using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vplquiz.DAL;
using Vplquiz.Views;

namespace Vplquiz.Controllers
{
    public class EntryController
    {
        private static EntryController _instance;
        public static EntryController Instance => _instance ?? (_instance = new EntryController());

        
        public void Startup()
        {
            var folderPath = Directory.GetCurrentDirectory() + "/Resources";
            var filepath = folderPath + "/cookie.txt";
            if (!Directory.Exists(folderPath) || !File.Exists(filepath))
            {
                FirstStartup(folderPath);
                return;
            }

            var txt = File.ReadAllText(filepath);
            if (string.IsNullOrWhiteSpace(txt))
            {
                new SignInView().Show();
                return;
            }

            var cookie = AuthController.Instance.ReadCookie();

            if (cookie is null)
            {
                new SignInView().Show();
                return;
            }

            if (cookie.IsStudent)
            {
                var student = AppDbContext.Instance.Students
                     .FirstOrDefault(x => x.EmailAddress.ToLower().Trim().Contains(cookie.Email));

                if(student is null)
                {
                    new SignInView().Show();
                    return;
                }
                new StudentDashboardView(student).Show();
            }
            else
            {
                var instructor = AppDbContext.Instance.Instructors
                    .FirstOrDefault(x => x.EmailAddress.ToLower().Trim().Contains(cookie.Email));

                if(instructor is null)
                {
                    new SignInView().Show();
                    return;
                }
                var stds = AppDbContext.Instance.Students.ToList();
                new InstructorDashboardView(instructor, stds).Show();
            }
        }

        private void FirstStartup(string folderPath)
        {
            Directory.CreateDirectory(folderPath);
            File.Create(folderPath + "/cookie.txt");
            var signup = new SignupView();
            signup.FirstTime();
        }
    }
}
