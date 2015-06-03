using Microsoft.AspNet.Identity;

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
            context.Exams.Add(new Exam { Name = "3DsMax" });
            context.Exams.Add(new Exam { Name = "Academic Writing" });
            context.Exams.Add(new Exam { Name = "Accounting Principles" });
            context.Exams.Add(new Exam { Name = "ActionScript 3.0" });
            context.Exams.Add(new Exam { Name = "ADO.NET" });
            context.Exams.Add(new Exam { Name = "Adobe Dreamweaver CS4" });
            context.Exams.Add(new Exam { Name = "Adobe Fireworks CS4 " });
            context.Exams.Add(new Exam { Name = "Adobe Flex" });
            context.Exams.Add(new Exam { Name = "Adobe Illustrator CS4" });
            context.Exams.Add(new Exam { Name = "Adobe Illustrator CS5" });
            context.Exams.Add(new Exam { Name = "Adobe Photoshop CS4" });
            context.Exams.Add(new Exam { Name = "Adobe Photoshop CS5" });
            context.Exams.Add(new Exam { Name = "Advanced Logical Reasoning" });
            context.Exams.Add(new Exam { Name = "AJAX Programming" });
            context.Exams.Add(new Exam { Name = "Algorithms" });
            context.Exams.Add(new Exam { Name = "Analog Electronics" });
            context.Exams.Add(new Exam { Name = "Android Development" });
            context.Exams.Add(new Exam { Name = "Ant" });
            context.Exams.Add(new Exam { Name = "AppleScript" });
            context.Exams.Add(new Exam { Name = "AI" });
            context.Exams.Add(new Exam { Name = "ASP.NET" });
            context.Exams.Add(new Exam { Name = "Atom Publishing Protocol" });
            context.Exams.Add(new Exam { Name = "AutoCAD 2010" });
            context.Exams.Add(new Exam { Name = "AWS" });
            context.Exams.Add(new Exam { Name = "Basic Numeracy" });
            context.Exams.Add(new Exam { Name = "Blackberry Programming" });
            context.Exams.Add(new Exam { Name = "Blogger API" });
            context.Exams.Add(new Exam { Name = "Blogging" });
            context.Exams.Add(new Exam { Name = "Brazilian Portuguese" });
            context.Exams.Add(new Exam { Name = "Brazilian Portuguese to English Translation" });
            context.Exams.Add(new Exam { Name = "C Programming" });
            context.Exams.Add(new Exam { Name = "C# Programming" });
            context.Exams.Add(new Exam { Name = "C++" });
            context.Exams.Add(new Exam { Name = "CGI Programming" });
            context.Exams.Add(new Exam { Name = "Cloud Computing" });
            context.Exams.Add(new Exam { Name = "COBOL" });
            context.Exams.Add(new Exam { Name = "Cocoa Programming" });
            context.Exams.Add(new Exam { Name = "ColdFusion Programming" });
            context.Exams.Add(new Exam { Name = "Compiler Design" });
            context.Exams.Add(new Exam { Name = "Computer Graphics" });
            context.Exams.Add(new Exam { Name = "Computer Security" });
            context.Exams.Add(new Exam { Name = "CUDA" });
            context.Exams.Add(new Exam { Name = "Danish" });
            context.Exams.Add(new Exam { Name = "Danish to English Translation" });
            context.Exams.Add(new Exam { Name = "Dart Programming" });
            context.Exams.Add(new Exam { Name = "Data Structures" });
            context.Exams.Add(new Exam { Name = "Delphi Programming" });
            context.Exams.Add(new Exam { Name = "Digital Electronics" });
            context.Exams.Add(new Exam { Name = "Digital Signal Processing (DSP)" });
            context.Exams.Add(new Exam { Name = "DNS &amp; BIND" });
            context.Exams.Add(new Exam { Name = "Domino Designer" });
            context.Exams.Add(new Exam { Name = "DotNetNuke" });
            context.Exams.Add(new Exam { Name = "Drupal" });
            context.Exams.Add(new Exam { Name = "Dutch to English Translation" });
            context.Exams.Add(new Exam { Name = "Dutch" });
            context.Exams.Add(new Exam { Name = "Embedded Systems" });
            context.Exams.Add(new Exam { Name = "Ethernet for Admins" });
            context.Exams.Add(new Exam { Name = "Facebook API" });
            context.Exams.Add(new Exam { Name = "Factor" });
            context.Exams.Add(new Exam { Name = "FastCGI" });
            context.Exams.Add(new Exam { Name = "Filipino" });
            context.Exams.Add(new Exam { Name = "Filipino to English Translation" });
            context.Exams.Add(new Exam { Name = "Flash" });
            context.Exams.Add(new Exam { Name = "Flash CS5" });
            context.Exams.Add(new Exam { Name = "Fortran" });
            context.Exams.Add(new Exam { Name = "French " });
            context.Exams.Add(new Exam { Name = "French to English Translation" });
            context.Exams.Add(new Exam { Name = "German" });
            context.Exams.Add(new Exam { Name = "German to English Translation" });
            context.Exams.Add(new Exam { Name = "Google AdSense" });
            context.Exams.Add(new Exam { Name = "AdWords" });
            context.Exams.Add(new Exam { Name = "Google AdWords API" });
            context.Exams.Add(new Exam { Name = "Google Apps Script" });
            context.Exams.Add(new Exam { Name = "Google Checkout" });
            context.Exams.Add(new Exam { Name = "Google Checkout API" });
            context.Exams.Add(new Exam { Name = "Google Cloud Storage" });
            context.Exams.Add(new Exam { Name = "Google Custom Search" });
            context.Exams.Add(new Exam { Name = "Google Drive" });
            context.Exams.Add(new Exam { Name = "Google Feed API" });
            context.Exams.Add(new Exam { Name = "Google Maps API" });
            context.Exams.Add(new Exam { Name = "Google Webmaster Central" });
            context.Exams.Add(new Exam { Name = "Google Webmaster Central" });
            context.Exams.Add(new Exam { Name = "Google Website Optimizer" });
            context.Exams.Add(new Exam { Name = "Haskell" });
            context.Exams.Add(new Exam { Name = "HTML" });
            context.Exams.Add(new Exam { Name = "HTML 4" });
            context.Exams.Add(new Exam { Name = "HTML5" });
            context.Exams.Add(new Exam { Name = "HTML5 Geolocation" });
            context.Exams.Add(new Exam { Name = "HTML5 Media" });
            context.Exams.Add(new Exam { Name = "HTML5 WebSockets" });
            context.Exams.Add(new Exam { Name = "HTTP" });
            context.Exams.Add(new Exam { Name = "Impact HTML5 Game Dev" });
            context.Exams.Add(new Exam { Name = "Impact HTML5 Game Dev" });
            context.Exams.Add(new Exam { Name = "Indonesian" });
            context.Exams.Add(new Exam { Name = "Indonesian to English Translation" });
            context.Exams.Add(new Exam { Name = "iPhone Development" });
            context.Exams.Add(new Exam { Name = "Italian" });
            context.Exams.Add(new Exam { Name = "Italian to English Translation" });
            context.Exams.Add(new Exam { Name = "Java" });
            context.Exams.Add(new Exam { Name = "Java EE 6" });
            context.Exams.Add(new Exam { Name = "JavaScript" });
            context.Exams.Add(new Exam { Name = "Joomla!" });
            context.Exams.Add(new Exam { Name = "JQuery" });
            context.Exams.Add(new Exam { Name = "Kerberos" });
            context.Exams.Add(new Exam { Name = "lex &amp; yacc" });
            context.Exams.Add(new Exam { Name = "LINQ" });
            context.Exams.Add(new Exam { Name = "Linux Kernel Programming" });
            context.Exams.Add(new Exam { Name = "Lisp" });
            context.Exams.Add(new Exam { Name = "Lotus Domino for Admins" });
            context.Exams.Add(new Exam { Name = "Lotus Notes for End Users" });
            context.Exams.Add(new Exam { Name = "Lotus Notes Formula Language" });
            context.Exams.Add(new Exam { Name = "LotusScript" });
            context.Exams.Add(new Exam { Name = "MacOS" });
            context.Exams.Add(new Exam { Name = "Maya" });
            context.Exams.Add(new Exam { Name = "MS Azure" });
            context.Exams.Add(new Exam { Name = "MS Project 2010" });
            context.Exams.Add(new Exam { Name = "MS Publisher 2010" });
            context.Exams.Add(new Exam { Name = "MySQL" });
            context.Exams.Add(new Exam { Name = "Network Programming" });
            context.Exams.Add(new Exam { Name = "Nginx" });
            context.Exams.Add(new Exam { Name = "Norwegian to English Translation" });
            context.Exams.Add(new Exam { Name = "Norwegian â€“ Level 1 " });
            context.Exams.Add(new Exam { Name = "OAuth" });
            context.Exams.Add(new Exam { Name = "OAuth 2.0" });
            context.Exams.Add(new Exam { Name = "Objective-C" });
            context.Exams.Add(new Exam { Name = "Open Data Protocol" });
            context.Exams.Add(new Exam { Name = "OpenSocial Programming" });
            context.Exams.Add(new Exam { Name = "OpenSSL" });
            context.Exams.Add(new Exam { Name = "OpenStack" });
            context.Exams.Add(new Exam { Name = "Oracle 10g" });
            context.Exams.Add(new Exam { Name = "OracleSQL" });
            context.Exams.Add(new Exam { Name = "Papervision3D" });
            context.Exams.Add(new Exam { Name = "Perl 5 programming" });
            context.Exams.Add(new Exam { Name = "PhoneGap" });
            context.Exams.Add(new Exam { Name = "PHP" });
            context.Exams.Add(new Exam { Name = "PHP5" });
            context.Exams.Add(new Exam { Name = "Physics for Game Developers" });
            context.Exams.Add(new Exam { Name = "PostgreSQL" });
            context.Exams.Add(new Exam { Name = "PostScript" });
            context.Exams.Add(new Exam { Name = "Prolog" });
            context.Exams.Add(new Exam { Name = "Prototype JS" });
            context.Exams.Add(new Exam { Name = "Python" });
            context.Exams.Add(new Exam { Name = "RDF Programming" });
            context.Exams.Add(new Exam { Name = "Redis" });
            context.Exams.Add(new Exam { Name = "Regular Expressions" });
            context.Exams.Add(new Exam { Name = "Requirements Engineering" });
            context.Exams.Add(new Exam { Name = "REST" });
            context.Exams.Add(new Exam { Name = "Ruby" });
            context.Exams.Add(new Exam { Name = "Ruby on Rails" });
            context.Exams.Add(new Exam { Name = "Scheme" });
            context.Exams.Add(new Exam { Name = "Sed &amp; Awk" });
            context.Exams.Add(new Exam { Name = "Semiconductors" });
            context.Exams.Add(new Exam { Name = "SEO" });
            context.Exams.Add(new Exam { Name = "SharePoint" });
            context.Exams.Add(new Exam { Name = "SharePoint 2010 Developers" });
            context.Exams.Add(new Exam { Name = "Shell Scripting" });
            context.Exams.Add(new Exam { Name = "Smalltalk" });
            context.Exams.Add(new Exam { Name = "Social Engine" });
            context.Exams.Add(new Exam { Name = "Spanish" });
            context.Exams.Add(new Exam { Name = "Spanish to English Translation" });
            context.Exams.Add(new Exam { Name = "SQL" });
            context.Exams.Add(new Exam { Name = "SQL Server" });
            context.Exams.Add(new Exam { Name = "SQLite" });
            context.Exams.Add(new Exam { Name = "Squid" });
            context.Exams.Add(new Exam { Name = "Statistics" });
            context.Exams.Add(new Exam { Name = "Subversion" });
            context.Exams.Add(new Exam { Name = "Swedish" });
            context.Exams.Add(new Exam { Name = "Swedish to English Translation" });
            context.Exams.Add(new Exam { Name = "TCP/IP" });
            context.Exams.Add(new Exam { Name = "Turkish" });
            context.Exams.Add(new Exam { Name = "Turkish to English Translation" });
            context.Exams.Add(new Exam { Name = "Twitter API" });
            context.Exams.Add(new Exam { Name = "Twitter Development" });
            context.Exams.Add(new Exam { Name = "UK English" });
            context.Exams.Add(new Exam { Name = "UML" });
            context.Exams.Add(new Exam { Name = "Unix" });
            context.Exams.Add(new Exam { Name = "US English" });
            context.Exams.Add(new Exam { Name = "USB Electronics" });
            context.Exams.Add(new Exam { Name = "VB.NET" });
            context.Exams.Add(new Exam { Name = "VB6 Programming" });
            context.Exams.Add(new Exam { Name = "Visual Basic" });
            context.Exams.Add(new Exam { Name = "VLSI Design" });
            context.Exams.Add(new Exam { Name = "Vorbis I" });
            context.Exams.Add(new Exam { Name = "VPN" });
            context.Exams.Add(new Exam { Name = "Windows Phone" });
            context.Exams.Add(new Exam { Name = "Windows Script Host" });
            context.Exams.Add(new Exam { Name = "Winsock 2" });
            context.Exams.Add(new Exam { Name = "WordPress" });
            context.Exams.Add(new Exam { Name = "Xcode3" });
            context.Exams.Add(new Exam { Name = "Xcode4" });
            context.Exams.Add(new Exam { Name = "XHTML" });
            context.Exams.Add(new Exam { Name = "XML" });
            context.Exams.Add(new Exam { Name = "XNA 4.0" });
            context.Exams.Add(new Exam { Name = "XQuery" });

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

            var userStore = new UserStore<User>(context);
            var userManager = new UserManager<User>(userStore);
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            RoleManager.Create(new IdentityRole("Administrator"));
            RoleManager.Create(new IdentityRole("Moderator"));
            RoleManager.Create(new IdentityRole("User"));
        
            var questionAboutDOTNET = new Question
            {
                QuestionTitle = "Date of .NET Exam?"
            };

            context.Questions.Add(questionAboutDOTNET);

            var dotNETSkill = new Skill
            {
                Exam = DOTNETExam,
                Name = ".NET"
            };

            var OOPSkill = new Skill
            {
                Exam = OOPExam,
                Name = "OOP"
            };

            if (!context.Users.Any(u => u.UserName == "dbonev"))
            {
                var dbonevUser = new User { UserName = "dbonev", Email = "dbonev@abv.bg" };
                userManager.Create(dbonevUser, "123321");
                userManager.AddToRole(dbonevUser.Id, "Administrator");

                OOPExam.Employees.Add(dbonevUser);
                dbonevUser.Skills.Add(OOPSkill);
                dbonevUser.Skills.Add(dotNETSkill);
            }

            if (!context.Users.Any(u => u.UserName == "dbonev"))
            {
                var kiborkUser = new User { UserName = "Kibork", Email = "kibork@abv.bg" };
                userManager.Create(kiborkUser, "123456");
                userManager.AddToRole(kiborkUser.Id, "User");

                DOTNETExam.Employees.Add(kiborkUser);
                kiborkUser.Skills.Add(dotNETSkill);
            }
          
            context.SaveChanges();
        }
    }
}
