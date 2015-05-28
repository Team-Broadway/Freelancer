namespace Freelancer.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using Freelancer.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            var OOPExam = new Exam
            {
                Name = "OOP"
            };

            context.Exams.Add(OOPExam);

            var DOTNETExam = new Exam
            {
                Name = ".NET"
            };

            context.Exams.Add(DOTNETExam);

            var dbonevUser = context.Users.FirstOrDefault(x => x.UserName == "dbonev");
            var kiborkUser = context.Users.FirstOrDefault(x => x.UserName == "Kibork");

            OOPExam.Employees.Add(dbonevUser);
            DOTNETExam.Employees.Add(kiborkUser);

            var questionAboutDOTNET = new Question
            {
                QuestionTitle = "Date of .NET Exam?"
            };

            context.Questions.Add(questionAboutDOTNET);

            var dotNETSkill = new Skill
            {
                Exam = DOTNETExam,
                Name = ".NET",
                Users = { kiborkUser }
            };

            var OOPSkill = new Skill
            {
                Exam = OOPExam,
                Name = "OOP",
                Users = { dbonevUser }
            };

            context.Skills.Add(dotNETSkill);
            context.Skills.Add(OOPSkill);

            var admRole = new IdentityRole
            {
                Name = "Administrator"
            };

            context.Roles.Add(admRole);

            var modRole = new IdentityRole
            {
                Name = "Moderator"
            };

            context.Roles.Add(modRole);

            var userRole = new IdentityRole
            {
                Name = "User"
            };
            
            context.Roles.Add(userRole);

            context.SaveChanges();
        }
    }
}
