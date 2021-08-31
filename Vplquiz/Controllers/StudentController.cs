using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vplquiz.DAL;
using Vplquiz.Models;

namespace Vplquiz.Controllers
{
    public class StudentController
    {
        private static StudentController _instance;
        public static StudentController Instance => _instance ?? (_instance = new StudentController());

        public Student Insert(Student student)
        {
            var studentEntry = AppDbContext.Instance.Students.Add(student);
            
            AppDbContext.Instance.SaveChanges();

            return studentEntry;
        }

        public Student Update(int id,string name, string phoneNum, string eductation)
        {

            var entity = AppDbContext.Instance.Students.FirstOrDefault(x => x.Id == id);

            entity.Name = name;
            entity.PhoneNum = phoneNum;
            entity.Education = eductation;

            AppDbContext.Instance.SaveChanges();

            return entity;
        }
        


    }
}
