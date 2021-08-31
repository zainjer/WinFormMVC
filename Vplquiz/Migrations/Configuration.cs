using Vplquiz.Models;

namespace Vplquiz.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Vplquiz.Resources;

    internal sealed class Configuration : DbMigrationsConfiguration<Vplquiz.DAL.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Vplquiz.DAL.AppDbContext context)
        {
            var students = new List<Student>()
            {
                new Student
                {
                    Id = 0,
                    Name = "Muhammad Areeb",
                    EmailAddress = "areeb@mail.com",
                    Password = Utils.GetHash("areeb#123"),
                    Education = "MS (CS)",
                    PhoneNum = "03331234567"
                },
                new Student
                {
                    Id = 1,
                    Name = "Muhammad Wasi",
                    EmailAddress = "wasi@mail.com",
                    Password = Utils.GetHash("wasi#123"),
                    Education = "MS (CS)",
                    PhoneNum = "03001234577"
                },
                new Student
                {
                    Id = 2,
                    Name = "Abdullah Memon",
                    EmailAddress = "Memon@mail.com",
                    Password = Utils.GetHash("Memon#123"),
                    Education = "MS (CS)",
                    PhoneNum = "03010010101"
                },
            };

            students.ForEach(x => context.Students.AddOrUpdate(x));
        }
    }
}
