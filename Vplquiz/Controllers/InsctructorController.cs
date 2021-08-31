using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vplquiz.DAL;
using Vplquiz.Models;

namespace Vplquiz.Controllers
{
    class InsctructorController
    {

        static InsctructorController _instance;
        public static InsctructorController Instance => _instance;

        public Instructor Insert(Instructor instructor)
        {
            var instructorEntry = AppDbContext.Instance.Instructors.Add(instructor);

            AppDbContext.Instance.SaveChanges();

            return instructorEntry;
        }

        public Instructor Update(int id, string name, string phoneNum,string specialization,string experience)
        {
            var instructor = AppDbContext.Instance.Instructors.Find(id);

            instructor.Name = name;
            instructor.PhoneNum = phoneNum;
            instructor.Specialization = specialization;
            instructor.Experience = experience;
            AppDbContext.Instance.SaveChanges();
            return instructor;

        }
    }
}
