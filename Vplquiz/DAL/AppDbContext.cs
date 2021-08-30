using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vplquiz.Models;

namespace Vplquiz.DAL
{
    class AppDbContext : DbContext
    {

        private static AppDbContext _instance;

        public static AppDbContext Instance => _instance ?? (_instance = new AppDbContext());


        public AppDbContext() : base(ConfigurationSettings.AppSettings["ConnectionString"])
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
    }
}
