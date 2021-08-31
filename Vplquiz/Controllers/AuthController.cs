using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vplquiz.DAL;
using Vplquiz.Models;
using Vplquiz.Resources;
using Vplquiz.Views;

namespace Vplquiz.Controllers
{
    public class AuthController
    {
        private static AuthController _instance;
        public static AuthController Instance => _instance ?? (_instance = new AuthController());

        private const string _emailRegex = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
        private const string _passwordRegex = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";

        string cookieFolderPath = Directory.GetCurrentDirectory() + "/Resources";
        string cookieFilePath = Directory.GetCurrentDirectory() + "/Resources" + "/cookie.txt";
        UnicodeEncoding encoding = new UnicodeEncoding();
        private AuthController()
        {

        }


        public void SignUpNewUser(string email, string password, bool isStudent)
        {

            try
            {
                if (isStudent)
                {
                    var student = new Student()
                    {
                        EmailAddress = email,
                        Password = Resources.Utils.GetHash(password)
                    };

                    AppDbContext.Instance.Students.Add(student);
                    AppDbContext.Instance.SaveChanges();
                    var userDashboard = new StudentDashboardView(student);
                    userDashboard.Show();
                }
                else
                {
                    var instructor = new Instructor()
                    {
                        EmailAddress = email,
                        Password = Resources.Utils.GetHash(password)
                    };

                    AppDbContext.Instance.Instructors.Add(instructor);
                    AppDbContext.Instance.SaveChanges();
                    var students = AppDbContext.Instance.Students.ToList();
                    var instructorDashboard = new InstructorDashboardView(instructor, students);
                    instructorDashboard.Show();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                EntryView.Instance?.Show();
            }
        }

        public (Student student,Instructor instructorEntity) SignIn(string email, string password, bool isStudent)
        {
            var hashPass = Utils.GetHash(password);
            if (isStudent)
            {
                var std = AppDbContext.Instance.Students.FirstOrDefault(x => x.EmailAddress.ToLower().Trim().Equals(email) && x.Password.Equals(hashPass));
                
                if(std != null)
                {
                    CreateCookie(std.EmailAddress, std.Password, true);
                }

                return (std, null);
            }
            else
            {
                
                var inst = AppDbContext.Instance.Instructors.FirstOrDefault(x => x.EmailAddress.ToLower().Trim().Equals(email) && x.Password.Equals(hashPass));

                if (inst != null)
                {
                    CreateCookie(inst.EmailAddress, inst.Password, false);
                }

                return (null, inst);
            }
        }

        public void CreateCookie(string email, string password, bool isStudent)
        {
            
            if (!Directory.Exists(cookieFolderPath))
            {
                Directory.CreateDirectory(cookieFolderPath);
            }

            if (!File.Exists(cookieFilePath))
            {
                File.Create(cookieFilePath);
            }

            var ch = isStudent ? '1' : '0';
            var cookie = email + "\n" + password + "\n" + ch;
            byte[] byt = System.Text.Encoding.UTF8.GetBytes(cookie);

            File.WriteAllText(cookieFilePath, Convert.ToBase64String(byt));
        }

        public Cookie ReadCookie()
        {
            if (Directory.Exists(cookieFolderPath))
            {
                if (File.Exists(cookieFilePath))
                {
                    try
                    {

                        var cookieEncoded = File.ReadAllText(cookieFilePath);

                        var byteArray = Convert.FromBase64String(cookieEncoded);

                        var str = System.Text.Encoding.UTF8.GetString(byteArray);

                        var arr = str.Split('\n');

                        var cookie = new Cookie();
                        cookie.Email = arr[0];
                        cookie.Password = arr[1];
                        cookie.IsStudent = arr[2] == "1";

                        return cookie;
                    }
                    catch (Exception e)
                    {
                        return null;
                    }

                }
            }

            return null;
        }

        public void RemoveCookie()
        {
            File.WriteAllText(cookieFilePath, "");
        }


        public static Regex GetEmailRegex() => new Regex(_emailRegex);
        public static Regex GetPasswordRegex() => new Regex(_passwordRegex);
    }
}
