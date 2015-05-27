using System.Linq;
using Freelancer.Models;

namespace Freelancer.Data.Migrations
{
    using System.Data.Entity.Migrations;

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

            var dbonevUser = context.Users.Where(x => x.UserName == "dbonev").FirstOrDefault();
            var kiborkUser = context.Users.Where(x => x.UserName == "Kibork").FirstOrDefault();

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
                Users = {kiborkUser}
            };

            var OOPSkill = new Skill
            {
                Exam = OOPExam,
                Name = "OOP",
                Users = {dbonevUser}
            };

            context.Skills.Add(dotNETSkill);
            context.Skills.Add(OOPSkill);

            context.SaveChanges();
        }
    }
}
