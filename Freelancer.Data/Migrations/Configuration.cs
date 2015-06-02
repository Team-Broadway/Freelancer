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

            var NETSkill = new Skill { Name = ".NET" };
            context.Skills.Add(NETSkill);
            var currentExam = context.Exams.FirstOrDefault(x => x.Name == ".NET");
            if (currentExam != null)
            {
                NETSkill.Exam = currentExam;
            }

            var degreevideoSkill = new Skill { Name = "360-degree video" };
            context.Skills.Add(degreevideoSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "360-degree video");
            if (currentExam != null)
            {
                degreevideoSkill.Exam = currentExam;
            }

            var DAnimationSkill = new Skill { Name = "3D Animation" };
            context.Skills.Add(DAnimationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "3D Animation");
            if (currentExam != null)
            {
                DAnimationSkill.Exam = currentExam;
            }

            var DDesignSkill = new Skill { Name = "3D Design" };
            context.Skills.Add(DDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "3D Design");
            if (currentExam != null)
            {
                DDesignSkill.Exam = currentExam;
            }

            var DModellingSkill = new Skill { Name = "3D Modelling" };
            context.Skills.Add(DModellingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "3D Modelling");
            if (currentExam != null)
            {
                DModellingSkill.Exam = currentExam;
            }

            var DPrintingSkill = new Skill { Name = "3D Printing" };
            context.Skills.Add(DPrintingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "3D Printing");
            if (currentExam != null)
            {
                DPrintingSkill.Exam = currentExam;
            }

            var DRenderingSkill = new Skill { Name = "3D Rendering" };
            context.Skills.Add(DRenderingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "3D Rendering");
            if (currentExam != null)
            {
                DRenderingSkill.Exam = currentExam;
            }

            var dsMaxSkill = new Skill { Name = "3ds Max" };
            context.Skills.Add(dsMaxSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "3ds Max");
            if (currentExam != null)
            {
                dsMaxSkill.Exam = currentExam;
            }

            var DSkill = new Skill { Name = "4D" };
            context.Skills.Add(DSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "4D");
            if (currentExam != null)
            {
                DSkill.Exam = currentExam;
            }

            var AcademicWritingSkill = new Skill { Name = "Academic Writing" };
            context.Skills.Add(AcademicWritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Academic Writing");
            if (currentExam != null)
            {
                AcademicWritingSkill.Exam = currentExam;
            }

            var AccountingSkill = new Skill { Name = "Accounting" };
            context.Skills.Add(AccountingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Accounting");
            if (currentExam != null)
            {
                AccountingSkill.Exam = currentExam;
            }

            var ActionScriptSkill = new Skill { Name = "ActionScript" };
            context.Skills.Add(ActionScriptSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "ActionScript");
            if (currentExam != null)
            {
                ActionScriptSkill.Exam = currentExam;
            }

            var ActiveDirectorySkill = new Skill { Name = "Active Directory" };
            context.Skills.Add(ActiveDirectorySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Active Directory");
            if (currentExam != null)
            {
                ActiveDirectorySkill.Exam = currentExam;
            }

            var AdPlanningampBuyingSkill = new Skill { Name = "Ad Planning &amp; Buying" };
            context.Skills.Add(AdPlanningampBuyingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Ad Planning &amp; Buying");
            if (currentExam != null)
            {
                AdPlanningampBuyingSkill.Exam = currentExam;
            }

            var AdobeAirSkill = new Skill { Name = "Adobe Air" };
            context.Skills.Add(AdobeAirSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Adobe Air");
            if (currentExam != null)
            {
                AdobeAirSkill.Exam = currentExam;
            }

            var AdobeDreamweaverSkill = new Skill { Name = "Adobe Dreamweaver" };
            context.Skills.Add(AdobeDreamweaverSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Adobe Dreamweaver");
            if (currentExam != null)
            {
                AdobeDreamweaverSkill.Exam = currentExam;
            }

            var AdobeFlashSkill = new Skill { Name = "Adobe Flash" };
            context.Skills.Add(AdobeFlashSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Adobe Flash");
            if (currentExam != null)
            {
                AdobeFlashSkill.Exam = currentExam;
            }

            var AdobeInDesignSkill = new Skill { Name = "Adobe InDesign" };
            context.Skills.Add(AdobeInDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Adobe InDesign");
            if (currentExam != null)
            {
                AdobeInDesignSkill.Exam = currentExam;
            }

            var AdobeLightroomSkill = new Skill { Name = "Adobe Lightroom" };
            context.Skills.Add(AdobeLightroomSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Adobe Lightroom");
            if (currentExam != null)
            {
                AdobeLightroomSkill.Exam = currentExam;
            }

            var AdobeLiveCycleDesignerSkill = new Skill { Name = "Adobe LiveCycle Designer" };
            context.Skills.Add(AdobeLiveCycleDesignerSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Adobe LiveCycle Designer");
            if (currentExam != null)
            {
                AdobeLiveCycleDesignerSkill.Exam = currentExam;
            }

            var AdvertisementDesignSkill = new Skill { Name = "Advertisement Design" };
            context.Skills.Add(AdvertisementDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Advertisement Design");
            if (currentExam != null)
            {
                AdvertisementDesignSkill.Exam = currentExam;
            }

            var AdvertisingSkill = new Skill { Name = "Advertising" };
            context.Skills.Add(AdvertisingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Advertising");
            if (currentExam != null)
            {
                AdvertisingSkill.Exam = currentExam;
            }

            var AeronauticalEngineeringSkill = new Skill { Name = "Aeronautical Engineering" };
            context.Skills.Add(AeronauticalEngineeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Aeronautical Engineering");
            if (currentExam != null)
            {
                AeronauticalEngineeringSkill.Exam = currentExam;
            }

            var AerospaceEngineeringSkill = new Skill { Name = "Aerospace Engineering" };
            context.Skills.Add(AerospaceEngineeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Aerospace Engineering");
            if (currentExam != null)
            {
                AerospaceEngineeringSkill.Exam = currentExam;
            }

            var AffiliateMarketingSkill = new Skill { Name = "Affiliate Marketing" };
            context.Skills.Add(AffiliateMarketingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Affiliate Marketing");
            if (currentExam != null)
            {
                AffiliateMarketingSkill.Exam = currentExam;
            }

            var AfrikaansSkill = new Skill { Name = "Afrikaans" };
            context.Skills.Add(AfrikaansSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Afrikaans");
            if (currentExam != null)
            {
                AfrikaansSkill.Exam = currentExam;
            }

            var AfterEffectsSkill = new Skill { Name = "After Effects" };
            context.Skills.Add(AfterEffectsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "After Effects");
            if (currentExam != null)
            {
                AfterEffectsSkill.Exam = currentExam;
            }

            var AgileDevelopmentSkill = new Skill { Name = "Agile Development" };
            context.Skills.Add(AgileDevelopmentSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Agile Development");
            if (currentExam != null)
            {
                AgileDevelopmentSkill.Exam = currentExam;
            }

            var AirConditioningSkill = new Skill { Name = "Air Conditioning" };
            context.Skills.Add(AirConditioningSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Air Conditioning");
            if (currentExam != null)
            {
                AirConditioningSkill.Exam = currentExam;
            }

            var AirbnbSkill = new Skill { Name = "Airbnb" };
            context.Skills.Add(AirbnbSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Airbnb");
            if (currentExam != null)
            {
                AirbnbSkill.Exam = currentExam;
            }

            var AJAXSkill = new Skill { Name = "AJAX" };
            context.Skills.Add(AJAXSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "AJAX");
            if (currentExam != null)
            {
                AJAXSkill.Exam = currentExam;
            }

            var AlbanianSkill = new Skill { Name = "Albanian" };
            context.Skills.Add(AlbanianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Albanian");
            if (currentExam != null)
            {
                AlbanianSkill.Exam = currentExam;
            }

            var AlgorithmSkill = new Skill { Name = "Algorithm" };
            context.Skills.Add(AlgorithmSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Algorithm");
            if (currentExam != null)
            {
                AlgorithmSkill.Exam = currentExam;
            }

            var AlibabaSkill = new Skill { Name = "Alibaba" };
            context.Skills.Add(AlibabaSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Alibaba");
            if (currentExam != null)
            {
                AlibabaSkill.Exam = currentExam;
            }

            var AmazonFireSkill = new Skill { Name = "Amazon Fire" };
            context.Skills.Add(AmazonFireSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Amazon Fire");
            if (currentExam != null)
            {
                AmazonFireSkill.Exam = currentExam;
            }

            var AmazonKindleSkill = new Skill { Name = "Amazon Kindle" };
            context.Skills.Add(AmazonKindleSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Amazon Kindle");
            if (currentExam != null)
            {
                AmazonKindleSkill.Exam = currentExam;
            }

            var AmazonWebServicesSkill = new Skill { Name = "Amazon Web Services" };
            context.Skills.Add(AmazonWebServicesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Amazon Web Services");
            if (currentExam != null)
            {
                AmazonWebServicesSkill.Exam = currentExam;
            }

            var AMQPSkill = new Skill { Name = "AMQP" };
            context.Skills.Add(AMQPSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "AMQP");
            if (currentExam != null)
            {
                AMQPSkill.Exam = currentExam;
            }

            var AnalyticsSkill = new Skill { Name = "Analytics" };
            context.Skills.Add(AnalyticsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Analytics");
            if (currentExam != null)
            {
                AnalyticsSkill.Exam = currentExam;
            }

            var AndroidSkill = new Skill { Name = "Android" };
            context.Skills.Add(AndroidSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Android");
            if (currentExam != null)
            {
                AndroidSkill.Exam = currentExam;
            }

            var AndroidHoneycombSkill = new Skill { Name = "Android Honeycomb" };
            context.Skills.Add(AndroidHoneycombSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Android Honeycomb");
            if (currentExam != null)
            {
                AndroidHoneycombSkill.Exam = currentExam;
            }

            var AndroidWearSDKSkill = new Skill { Name = "Android Wear SDK" };
            context.Skills.Add(AndroidWearSDKSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Android Wear SDK");
            if (currentExam != null)
            {
                AndroidWearSDKSkill.Exam = currentExam;
            }

            var AngularjsSkill = new Skill { Name = "Angular.js" };
            context.Skills.Add(AngularjsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Angular.js");
            if (currentExam != null)
            {
                AngularjsSkill.Exam = currentExam;
            }

            var AnimationSkill = new Skill { Name = "Animation" };
            context.Skills.Add(AnimationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Animation");
            if (currentExam != null)
            {
                AnimationSkill.Exam = currentExam;
            }

            var AntennaServicesSkill = new Skill { Name = "Antenna Services" };
            context.Skills.Add(AntennaServicesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Antenna Services");
            if (currentExam != null)
            {
                AntennaServicesSkill.Exam = currentExam;
            }

            var AnythingGoesSkill = new Skill { Name = "Anything Goes" };
            context.Skills.Add(AnythingGoesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Anything Goes");
            if (currentExam != null)
            {
                AnythingGoesSkill.Exam = currentExam;
            }

            var ApacheSkill = new Skill { Name = "Apache" };
            context.Skills.Add(ApacheSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Apache");
            if (currentExam != null)
            {
                ApacheSkill.Exam = currentExam;
            }

            var ApacheSolrSkill = new Skill { Name = "Apache Solr" };
            context.Skills.Add(ApacheSolrSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Apache Solr");
            if (currentExam != null)
            {
                ApacheSolrSkill.Exam = currentExam;
            }

            var AppceleratorTitaniumSkill = new Skill { Name = "Appcelerator Titanium" };
            context.Skills.Add(AppceleratorTitaniumSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Appcelerator Titanium");
            if (currentExam != null)
            {
                AppceleratorTitaniumSkill.Exam = currentExam;
            }

            var AppleCompressorSkill = new Skill { Name = "Apple Compressor" };
            context.Skills.Add(AppleCompressorSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Apple Compressor");
            if (currentExam != null)
            {
                AppleCompressorSkill.Exam = currentExam;
            }

            var AppleLogicProSkill = new Skill { Name = "Apple Logic Pro" };
            context.Skills.Add(AppleLogicProSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Apple Logic Pro");
            if (currentExam != null)
            {
                AppleLogicProSkill.Exam = currentExam;
            }

            var AppleMotionSkill = new Skill { Name = "Apple Motion" };
            context.Skills.Add(AppleMotionSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Apple Motion");
            if (currentExam != null)
            {
                AppleMotionSkill.Exam = currentExam;
            }

            var AppleSafariSkill = new Skill { Name = "Apple Safari" };
            context.Skills.Add(AppleSafariSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Apple Safari");
            if (currentExam != null)
            {
                AppleSafariSkill.Exam = currentExam;
            }

            var AppleWatchSkill = new Skill { Name = "Apple Watch" };
            context.Skills.Add(AppleWatchSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Apple Watch");
            if (currentExam != null)
            {
                AppleWatchSkill.Exam = currentExam;
            }

            var ApplianceInstallationSkill = new Skill { Name = "Appliance Installation" };
            context.Skills.Add(ApplianceInstallationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Appliance Installation");
            if (currentExam != null)
            {
                ApplianceInstallationSkill.Exam = currentExam;
            }

            var ApplianceRepairSkill = new Skill { Name = "Appliance Repair" };
            context.Skills.Add(ApplianceRepairSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Appliance Repair");
            if (currentExam != null)
            {
                ApplianceRepairSkill.Exam = currentExam;
            }

            var ArabicSkill = new Skill { Name = "Arabic" };
            context.Skills.Add(ArabicSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Arabic");
            if (currentExam != null)
            {
                ArabicSkill.Exam = currentExam;
            }

            var ArduinoSkill = new Skill { Name = "Arduino" };
            context.Skills.Add(ArduinoSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Arduino");
            if (currentExam != null)
            {
                ArduinoSkill.Exam = currentExam;
            }

            var ArgusMonitoringSoftwareSkill = new Skill { Name = "Argus Monitoring Software" };
            context.Skills.Add(ArgusMonitoringSoftwareSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Argus Monitoring Software");
            if (currentExam != null)
            {
                ArgusMonitoringSoftwareSkill.Exam = currentExam;
            }

            var ArticleRewritingSkill = new Skill { Name = "Article Rewriting" };
            context.Skills.Add(ArticleRewritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Article Rewriting");
            if (currentExam != null)
            {
                ArticleRewritingSkill.Exam = currentExam;
            }

            var ArticleSubmissionSkill = new Skill { Name = "Article Submission" };
            context.Skills.Add(ArticleSubmissionSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Article Submission");
            if (currentExam != null)
            {
                ArticleSubmissionSkill.Exam = currentExam;
            }

            var ArticlesSkill = new Skill { Name = "Articles" };
            context.Skills.Add(ArticlesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Articles");
            if (currentExam != null)
            {
                ArticlesSkill.Exam = currentExam;
            }

            var ArtsampCraftsSkill = new Skill { Name = "Arts &amp; Crafts" };
            context.Skills.Add(ArtsampCraftsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Arts &amp; Crafts");
            if (currentExam != null)
            {
                ArtsampCraftsSkill.Exam = currentExam;
            }

            var ASampiSeriesSkill = new Skill { Name = "AS400 &amp; iSeries" };
            context.Skills.Add(ASampiSeriesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "AS400 &amp; iSeries");
            if (currentExam != null)
            {
                ASampiSeriesSkill.Exam = currentExam;
            }

            var AsbestosRemovalSkill = new Skill { Name = "Asbestos Removal" };
            context.Skills.Add(AsbestosRemovalSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Asbestos Removal");
            if (currentExam != null)
            {
                AsbestosRemovalSkill.Exam = currentExam;
            }

            var ASPSkill = new Skill { Name = "ASP" };
            context.Skills.Add(ASPSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "ASP");
            if (currentExam != null)
            {
                ASPSkill.Exam = currentExam;
            }

            var ASPNETSkill = new Skill { Name = "ASP.NET" };
            context.Skills.Add(ASPNETSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "ASP.NET");
            if (currentExam != null)
            {
                ASPNETSkill.Exam = currentExam;
            }

            var AsphaltSkill = new Skill { Name = "Asphalt" };
            context.Skills.Add(AsphaltSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Asphalt");
            if (currentExam != null)
            {
                AsphaltSkill.Exam = currentExam;
            }

            var AssemblySkill = new Skill { Name = "Assembly" };
            context.Skills.Add(AssemblySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Assembly");
            if (currentExam != null)
            {
                AssemblySkill.Exam = currentExam;
            }

            var AsteriskPBXSkill = new Skill { Name = "Asterisk PBX" };
            context.Skills.Add(AsteriskPBXSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Asterisk PBX");
            if (currentExam != null)
            {
                AsteriskPBXSkill.Exam = currentExam;
            }

            var AstrophysicsSkill = new Skill { Name = "Astrophysics" };
            context.Skills.Add(AstrophysicsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Astrophysics");
            if (currentExam != null)
            {
                AstrophysicsSkill.Exam = currentExam;
            }

            var AtticAccessLaddersSkill = new Skill { Name = "Attic Access Ladders" };
            context.Skills.Add(AtticAccessLaddersSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Attic Access Ladders");
            if (currentExam != null)
            {
                AtticAccessLaddersSkill.Exam = currentExam;
            }

            var AudioProductionSkill = new Skill { Name = "Audio Production" };
            context.Skills.Add(AudioProductionSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Audio Production");
            if (currentExam != null)
            {
                AudioProductionSkill.Exam = currentExam;
            }

            var AudioServicesSkill = new Skill { Name = "Audio Services" };
            context.Skills.Add(AudioServicesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Audio Services");
            if (currentExam != null)
            {
                AudioServicesSkill.Exam = currentExam;
            }

            var AuditSkill = new Skill { Name = "Audit" };
            context.Skills.Add(AuditSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Audit");
            if (currentExam != null)
            {
                AuditSkill.Exam = currentExam;
            }

            var AugmentedRealitySkill = new Skill { Name = "Augmented Reality" };
            context.Skills.Add(AugmentedRealitySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Augmented Reality");
            if (currentExam != null)
            {
                AugmentedRealitySkill.Exam = currentExam;
            }

            var AutoCADSkill = new Skill { Name = "AutoCAD" };
            context.Skills.Add(AutoCADSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "AutoCAD");
            if (currentExam != null)
            {
                AutoCADSkill.Exam = currentExam;
            }

            var AutodeskInventorSkill = new Skill { Name = "Autodesk Inventor" };
            context.Skills.Add(AutodeskInventorSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Autodesk Inventor");
            if (currentExam != null)
            {
                AutodeskInventorSkill.Exam = currentExam;
            }

            var AutodeskRevitSkill = new Skill { Name = "Autodesk Revit" };
            context.Skills.Add(AutodeskRevitSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Autodesk Revit");
            if (currentExam != null)
            {
                AutodeskRevitSkill.Exam = currentExam;
            }

            var AutoHotkeySkill = new Skill { Name = "AutoHotkey" };
            context.Skills.Add(AutoHotkeySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "AutoHotkey");
            if (currentExam != null)
            {
                AutoHotkeySkill.Exam = currentExam;
            }

            var AutomotiveSkill = new Skill { Name = "Automotive" };
            context.Skills.Add(AutomotiveSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Automotive");
            if (currentExam != null)
            {
                AutomotiveSkill.Exam = currentExam;
            }

            var AwningsSkill = new Skill { Name = "Awnings" };
            context.Skills.Add(AwningsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Awnings");
            if (currentExam != null)
            {
                AwningsSkill.Exam = currentExam;
            }

            var AzureSkill = new Skill { Name = "Azure" };
            context.Skills.Add(AzureSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Azure");
            if (currentExam != null)
            {
                AzureSkill.Exam = currentExam;
            }

            var backbonejsSkill = new Skill { Name = "backbone.js" };
            context.Skills.Add(backbonejsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "backbone.js");
            if (currentExam != null)
            {
                backbonejsSkill.Exam = currentExam;
            }

            var BalsamiqSkill = new Skill { Name = "Balsamiq" };
            context.Skills.Add(BalsamiqSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Balsamiq");
            if (currentExam != null)
            {
                BalsamiqSkill.Exam = currentExam;
            }

            var BalustradingSkill = new Skill { Name = "Balustrading" };
            context.Skills.Add(BalustradingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Balustrading");
            if (currentExam != null)
            {
                BalustradingSkill.Exam = currentExam;
            }

            var BambooFlooringSkill = new Skill { Name = "Bamboo Flooring" };
            context.Skills.Add(BambooFlooringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Bamboo Flooring");
            if (currentExam != null)
            {
                BambooFlooringSkill.Exam = currentExam;
            }

            var BannerDesignSkill = new Skill { Name = "Banner Design" };
            context.Skills.Add(BannerDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Banner Design");
            if (currentExam != null)
            {
                BannerDesignSkill.Exam = currentExam;
            }

            var BasqueSkill = new Skill { Name = "Basque" };
            context.Skills.Add(BasqueSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Basque");
            if (currentExam != null)
            {
                BasqueSkill.Exam = currentExam;
            }

            var BathroomSkill = new Skill { Name = "Bathroom" };
            context.Skills.Add(BathroomSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Bathroom");
            if (currentExam != null)
            {
                BathroomSkill.Exam = currentExam;
            }

            var BengaliSkill = new Skill { Name = "Bengali" };
            context.Skills.Add(BengaliSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Bengali");
            if (currentExam != null)
            {
                BengaliSkill.Exam = currentExam;
            }

            var BigDataSkill = new Skill { Name = "Big Data" };
            context.Skills.Add(BigDataSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Big Data");
            if (currentExam != null)
            {
                BigDataSkill.Exam = currentExam;
            }

            var BigCommerceSkill = new Skill { Name = "BigCommerce" };
            context.Skills.Add(BigCommerceSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "BigCommerce");
            if (currentExam != null)
            {
                BigCommerceSkill.Exam = currentExam;
            }

            var BinaryAnalysisSkill = new Skill { Name = "Binary Analysis" };
            context.Skills.Add(BinaryAnalysisSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Binary Analysis");
            if (currentExam != null)
            {
                BinaryAnalysisSkill.Exam = currentExam;
            }

            var BiologySkill = new Skill { Name = "Biology" };
            context.Skills.Add(BiologySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Biology");
            if (currentExam != null)
            {
                BiologySkill.Exam = currentExam;
            }

            var BiotechnologySkill = new Skill { Name = "Biotechnology" };
            context.Skills.Add(BiotechnologySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Biotechnology");
            if (currentExam != null)
            {
                BiotechnologySkill.Exam = currentExam;
            }

            var BitcoinSkill = new Skill { Name = "Bitcoin" };
            context.Skills.Add(BitcoinSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Bitcoin");
            if (currentExam != null)
            {
                BitcoinSkill.Exam = currentExam;
            }

            var BiztalkSkill = new Skill { Name = "Biztalk" };
            context.Skills.Add(BiztalkSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Biztalk");
            if (currentExam != null)
            {
                BiztalkSkill.Exam = currentExam;
            }

            var BlackberrySkill = new Skill { Name = "Blackberry" };
            context.Skills.Add(BlackberrySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Blackberry");
            if (currentExam != null)
            {
                BlackberrySkill.Exam = currentExam;
            }

            var BlogSkill = new Skill { Name = "Blog" };
            context.Skills.Add(BlogSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Blog");
            if (currentExam != null)
            {
                BlogSkill.Exam = currentExam;
            }

            var BlogDesignSkill = new Skill { Name = "Blog Design" };
            context.Skills.Add(BlogDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Blog Design");
            if (currentExam != null)
            {
                BlogDesignSkill.Exam = currentExam;
            }

            var BlogInstallSkill = new Skill { Name = "Blog Install" };
            context.Skills.Add(BlogInstallSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Blog Install");
            if (currentExam != null)
            {
                BlogInstallSkill.Exam = currentExam;
            }

            var BluetoothLowEnergyBLESkill = new Skill { Name = "Bluetooth Low Energy (BLE)" };
            context.Skills.Add(BluetoothLowEnergyBLESkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Bluetooth Low Energy (BLE)");
            if (currentExam != null)
            {
                BluetoothLowEnergyBLESkill.Exam = currentExam;
            }

            var BMCRemedySkill = new Skill { Name = "BMC Remedy" };
            context.Skills.Add(BMCRemedySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "BMC Remedy");
            if (currentExam != null)
            {
                BMCRemedySkill.Exam = currentExam;
            }

            var BookWritingSkill = new Skill { Name = "Book Writing" };
            context.Skills.Add(BookWritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Book Writing");
            if (currentExam != null)
            {
                BookWritingSkill.Exam = currentExam;
            }

            var BookkeepingSkill = new Skill { Name = "Bookkeeping" };
            context.Skills.Add(BookkeepingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Bookkeeping");
            if (currentExam != null)
            {
                BookkeepingSkill.Exam = currentExam;
            }

            var BoonexDolphinSkill = new Skill { Name = "Boonex Dolphin" };
            context.Skills.Add(BoonexDolphinSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Boonex Dolphin");
            if (currentExam != null)
            {
                BoonexDolphinSkill.Exam = currentExam;
            }

            var BootstrapSkill = new Skill { Name = "Bootstrap" };
            context.Skills.Add(BootstrapSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Bootstrap");
            if (currentExam != null)
            {
                BootstrapSkill.Exam = currentExam;
            }

            var BosnianSkill = new Skill { Name = "Bosnian" };
            context.Skills.Add(BosnianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Bosnian");
            if (currentExam != null)
            {
                BosnianSkill.Exam = currentExam;
            }

            var BowerSkill = new Skill { Name = "Bower" };
            context.Skills.Add(BowerSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Bower");
            if (currentExam != null)
            {
                BowerSkill.Exam = currentExam;
            }

            var BPOSkill = new Skill { Name = "BPO" };
            context.Skills.Add(BPOSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "BPO");
            if (currentExam != null)
            {
                BPOSkill.Exam = currentExam;
            }

            var BracketsSkill = new Skill { Name = "Brackets" };
            context.Skills.Add(BracketsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Brackets");
            if (currentExam != null)
            {
                BracketsSkill.Exam = currentExam;
            }

            var BrainStormingSkill = new Skill { Name = "Brain Storming" };
            context.Skills.Add(BrainStormingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Brain Storming");
            if (currentExam != null)
            {
                BrainStormingSkill.Exam = currentExam;
            }

            var BrandingSkill = new Skill { Name = "Branding" };
            context.Skills.Add(BrandingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Branding");
            if (currentExam != null)
            {
                BrandingSkill.Exam = currentExam;
            }

            var BricklayingSkill = new Skill { Name = "Bricklaying" };
            context.Skills.Add(BricklayingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Bricklaying");
            if (currentExam != null)
            {
                BricklayingSkill.Exam = currentExam;
            }

            var BroadcastEngineeringSkill = new Skill { Name = "Broadcast Engineering" };
            context.Skills.Add(BroadcastEngineeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Broadcast Engineering");
            if (currentExam != null)
            {
                BroadcastEngineeringSkill.Exam = currentExam;
            }

            var BrochureDesignSkill = new Skill { Name = "Brochure Design" };
            context.Skills.Add(BrochureDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Brochure Design");
            if (currentExam != null)
            {
                BrochureDesignSkill.Exam = currentExam;
            }

            var BSDSkill = new Skill { Name = "BSD" };
            context.Skills.Add(BSDSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "BSD");
            if (currentExam != null)
            {
                BSDSkill.Exam = currentExam;
            }

            var BuildingSkill = new Skill { Name = "Building" };
            context.Skills.Add(BuildingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Building");
            if (currentExam != null)
            {
                BuildingSkill.Exam = currentExam;
            }

            var BuildingArchitectureSkill = new Skill { Name = "Building Architecture" };
            context.Skills.Add(BuildingArchitectureSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Building Architecture");
            if (currentExam != null)
            {
                BuildingArchitectureSkill.Exam = currentExam;
            }

            var BuildingCertifiersSkill = new Skill { Name = "Building Certifiers" };
            context.Skills.Add(BuildingCertifiersSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Building Certifiers");
            if (currentExam != null)
            {
                BuildingCertifiersSkill.Exam = currentExam;
            }

            var BuildingConsultantsSkill = new Skill { Name = "Building Consultants" };
            context.Skills.Add(BuildingConsultantsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Building Consultants");
            if (currentExam != null)
            {
                BuildingConsultantsSkill.Exam = currentExam;
            }

            var BuildingDesignerSkill = new Skill { Name = "Building Designer" };
            context.Skills.Add(BuildingDesignerSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Building Designer");
            if (currentExam != null)
            {
                BuildingDesignerSkill.Exam = currentExam;
            }

            var BuildingSurveyorsSkill = new Skill { Name = "Building Surveyors" };
            context.Skills.Add(BuildingSurveyorsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Building Surveyors");
            if (currentExam != null)
            {
                BuildingSurveyorsSkill.Exam = currentExam;
            }

            var BulgarianSkill = new Skill { Name = "Bulgarian" };
            context.Skills.Add(BulgarianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Bulgarian");
            if (currentExam != null)
            {
                BulgarianSkill.Exam = currentExam;
            }

            var BulkMarketingSkill = new Skill { Name = "Bulk Marketing" };
            context.Skills.Add(BulkMarketingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Bulk Marketing");
            if (currentExam != null)
            {
                BulkMarketingSkill.Exam = currentExam;
            }

            var BusinessAnalysisSkill = new Skill { Name = "Business Analysis" };
            context.Skills.Add(BusinessAnalysisSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Business Analysis");
            if (currentExam != null)
            {
                BusinessAnalysisSkill.Exam = currentExam;
            }

            var BusinessCardsSkill = new Skill { Name = "Business Cards" };
            context.Skills.Add(BusinessCardsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Business Cards");
            if (currentExam != null)
            {
                BusinessCardsSkill.Exam = currentExam;
            }

            var BusinessCatalystSkill = new Skill { Name = "Business Catalyst" };
            context.Skills.Add(BusinessCatalystSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Business Catalyst");
            if (currentExam != null)
            {
                BusinessCatalystSkill.Exam = currentExam;
            }

            var BusinessCoachingSkill = new Skill { Name = "Business Coaching" };
            context.Skills.Add(BusinessCoachingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Business Coaching");
            if (currentExam != null)
            {
                BusinessCoachingSkill.Exam = currentExam;
            }

            var BusinessPlansSkill = new Skill { Name = "Business Plans" };
            context.Skills.Add(BusinessPlansSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Business Plans");
            if (currentExam != null)
            {
                BusinessPlansSkill.Exam = currentExam;
            }

            var BusinessWritingSkill = new Skill { Name = "Business Writing" };
            context.Skills.Add(BusinessWritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Business Writing");
            if (currentExam != null)
            {
                BusinessWritingSkill.Exam = currentExam;
            }

            var BuyerSourcingSkill = new Skill { Name = "Buyer Sourcing" };
            context.Skills.Add(BuyerSourcingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Buyer Sourcing");
            if (currentExam != null)
            {
                BuyerSourcingSkill.Exam = currentExam;
            }

            var CProgrammingSkill = new Skill { Name = "C Programming" };
            context.Skills.Add(CProgrammingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "C Programming");
            if (currentExam != null)
            {
                CProgrammingSkill.Exam = currentExam;
            }

            var CSharpProgrammingSkill = new Skill { Name = "C# Programming" };
            context.Skills.Add(CSharpProgrammingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "C# Programming");
            if (currentExam != null)
            {
                CSharpProgrammingSkill.Exam = currentExam;
            }

            var CPlusPlusProgrammingSkill = new Skill { Name = "C++ Programming" };
            context.Skills.Add(CPlusPlusProgrammingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "C++ Programming");
            if (currentExam != null)
            {
                CPlusPlusProgrammingSkill.Exam = currentExam;
            }

            var CADCAMSkill = new Skill { Name = "CAD/CAM" };
            context.Skills.Add(CADCAMSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "CAD/CAM");
            if (currentExam != null)
            {
                CADCAMSkill.Exam = currentExam;
            }

            var CakePHPSkill = new Skill { Name = "CakePHP" };
            context.Skills.Add(CakePHPSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "CakePHP");
            if (currentExam != null)
            {
                CakePHPSkill.Exam = currentExam;
            }

            var CallCenterSkill = new Skill { Name = "Call Center" };
            context.Skills.Add(CallCenterSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Call Center");
            if (currentExam != null)
            {
                CallCenterSkill.Exam = currentExam;
            }

            var CallControlXMLSkill = new Skill { Name = "Call Control XML" };
            context.Skills.Add(CallControlXMLSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Call Control XML");
            if (currentExam != null)
            {
                CallControlXMLSkill.Exam = currentExam;
            }

            var CaptureNXSkill = new Skill { Name = "Capture NX2" };
            context.Skills.Add(CaptureNXSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Capture NX2");
            if (currentExam != null)
            {
                CaptureNXSkill.Exam = currentExam;
            }

            var CaricatureampCartoonsSkill = new Skill { Name = "Caricature &amp; Cartoons" };
            context.Skills.Add(CaricatureampCartoonsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Caricature &amp; Cartoons");
            if (currentExam != null)
            {
                CaricatureampCartoonsSkill.Exam = currentExam;
            }

            var CarpentrySkill = new Skill { Name = "Carpentry" };
            context.Skills.Add(CarpentrySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Carpentry");
            if (currentExam != null)
            {
                CarpentrySkill.Exam = currentExam;
            }

            var CarpetRepairampLayingSkill = new Skill { Name = "Carpet Repair &amp; Laying" };
            context.Skills.Add(CarpetRepairampLayingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Carpet Repair &amp; Laying");
            if (currentExam != null)
            {
                CarpetRepairampLayingSkill.Exam = currentExam;
            }

            var CarportsSkill = new Skill { Name = "Carports" };
            context.Skills.Add(CarportsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Carports");
            if (currentExam != null)
            {
                CarportsSkill.Exam = currentExam;
            }

            var CartographyampMapsSkill = new Skill { Name = "Cartography &amp; Maps" };
            context.Skills.Add(CartographyampMapsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Cartography &amp; Maps");
            if (currentExam != null)
            {
                CartographyampMapsSkill.Exam = currentExam;
            }

            var CarwashingSkill = new Skill { Name = "Carwashing" };
            context.Skills.Add(CarwashingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Carwashing");
            if (currentExam != null)
            {
                CarwashingSkill.Exam = currentExam;
            }

            var CasperJSSkill = new Skill { Name = "CasperJS" };
            context.Skills.Add(CasperJSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "CasperJS");
            if (currentExam != null)
            {
                CasperJSSkill.Exam = currentExam;
            }

            var CassandraSkill = new Skill { Name = "Cassandra" };
            context.Skills.Add(CassandraSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Cassandra");
            if (currentExam != null)
            {
                CassandraSkill.Exam = currentExam;
            }

            var CatalanSkill = new Skill { Name = "Catalan" };
            context.Skills.Add(CatalanSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Catalan");
            if (currentExam != null)
            {
                CatalanSkill.Exam = currentExam;
            }

            var CatchPhrasesSkill = new Skill { Name = "Catch Phrases" };
            context.Skills.Add(CatchPhrasesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Catch Phrases");
            if (currentExam != null)
            {
                CatchPhrasesSkill.Exam = currentExam;
            }

            var CeilingsSkill = new Skill { Name = "Ceilings" };
            context.Skills.Add(CeilingsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Ceilings");
            if (currentExam != null)
            {
                CeilingsSkill.Exam = currentExam;
            }

            var CementBondingAgentsSkill = new Skill { Name = "Cement Bonding Agents" };
            context.Skills.Add(CementBondingAgentsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Cement Bonding Agents");
            if (currentExam != null)
            {
                CementBondingAgentsSkill.Exam = currentExam;
            }

            var CGISkill = new Skill { Name = "CGI" };
            context.Skills.Add(CGISkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "CGI");
            if (currentExam != null)
            {
                CGISkill.Exam = currentExam;
            }

            var ChefConfigurationManagementSkill = new Skill { Name = "Chef Configuration Management" };
            context.Skills.Add(ChefConfigurationManagementSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Chef Configuration Management");
            if (currentExam != null)
            {
                ChefConfigurationManagementSkill.Exam = currentExam;
            }

            var ChemicalEngineeringSkill = new Skill { Name = "Chemical Engineering" };
            context.Skills.Add(ChemicalEngineeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Chemical Engineering");
            if (currentExam != null)
            {
                ChemicalEngineeringSkill.Exam = currentExam;
            }

            var ChordiantSkill = new Skill { Name = "Chordiant" };
            context.Skills.Add(ChordiantSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Chordiant");
            if (currentExam != null)
            {
                ChordiantSkill.Exam = currentExam;
            }

            var ChristmasSkill = new Skill { Name = "Christmas" };
            context.Skills.Add(ChristmasSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Christmas");
            if (currentExam != null)
            {
                ChristmasSkill.Exam = currentExam;
            }

            var ChromeOSSkill = new Skill { Name = "Chrome OS" };
            context.Skills.Add(ChromeOSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Chrome OS");
            if (currentExam != null)
            {
                ChromeOSSkill.Exam = currentExam;
            }

            var CinemaDSkill = new Skill { Name = "Cinema 4D" };
            context.Skills.Add(CinemaDSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Cinema 4D");
            if (currentExam != null)
            {
                CinemaDSkill.Exam = currentExam;
            }

            var CircuitDesignSkill = new Skill { Name = "Circuit Design" };
            context.Skills.Add(CircuitDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Circuit Design");
            if (currentExam != null)
            {
                CircuitDesignSkill.Exam = currentExam;
            }

            var CiscoSkill = new Skill { Name = "Cisco" };
            context.Skills.Add(CiscoSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Cisco");
            if (currentExam != null)
            {
                CiscoSkill.Exam = currentExam;
            }

            var CivilEngineeringSkill = new Skill { Name = "Civil Engineering" };
            context.Skills.Add(CivilEngineeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Civil Engineering");
            if (currentExam != null)
            {
                CivilEngineeringSkill.Exam = currentExam;
            }

            var ClassifiedsPostingSkill = new Skill { Name = "Classifieds Posting" };
            context.Skills.Add(ClassifiedsPostingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Classifieds Posting");
            if (currentExam != null)
            {
                ClassifiedsPostingSkill.Exam = currentExam;
            }

            var CleanTechnologySkill = new Skill { Name = "Clean Technology" };
            context.Skills.Add(CleanTechnologySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Clean Technology");
            if (currentExam != null)
            {
                CleanTechnologySkill.Exam = currentExam;
            }

            var CleaningCarpetSkill = new Skill { Name = "Cleaning Carpet" };
            context.Skills.Add(CleaningCarpetSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Cleaning Carpet");
            if (currentExam != null)
            {
                CleaningCarpetSkill.Exam = currentExam;
            }

            var CleaningDomesticSkill = new Skill { Name = "Cleaning Domestic" };
            context.Skills.Add(CleaningDomesticSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Cleaning Domestic");
            if (currentExam != null)
            {
                CleaningDomesticSkill.Exam = currentExam;
            }

            var CleaningUpholsterySkill = new Skill { Name = "Cleaning Upholstery" };
            context.Skills.Add(CleaningUpholsterySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Cleaning Upholstery");
            if (currentExam != null)
            {
                CleaningUpholsterySkill.Exam = currentExam;
            }

            var ClimateSciencesSkill = new Skill { Name = "Climate Sciences" };
            context.Skills.Add(ClimateSciencesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Climate Sciences");
            if (currentExam != null)
            {
                ClimateSciencesSkill.Exam = currentExam;
            }

            var ClotheslineSkill = new Skill { Name = "Clothesline" };
            context.Skills.Add(ClotheslineSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Clothesline");
            if (currentExam != null)
            {
                ClotheslineSkill.Exam = currentExam;
            }

            var CloudComputingSkill = new Skill { Name = "Cloud Computing" };
            context.Skills.Add(CloudComputingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Cloud Computing");
            if (currentExam != null)
            {
                CloudComputingSkill.Exam = currentExam;
            }

            var CMSSkill = new Skill { Name = "CMS" };
            context.Skills.Add(CMSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "CMS");
            if (currentExam != null)
            {
                CMSSkill.Exam = currentExam;
            }

            var CoatingMaterialsSkill = new Skill { Name = "Coating Materials" };
            context.Skills.Add(CoatingMaterialsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Coating Materials");
            if (currentExam != null)
            {
                CoatingMaterialsSkill.Exam = currentExam;
            }

            var COBOLSkill = new Skill { Name = "COBOL" };
            context.Skills.Add(COBOLSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "COBOL");
            if (currentExam != null)
            {
                COBOLSkill.Exam = currentExam;
            }

            var CocoaSkill = new Skill { Name = "Cocoa" };
            context.Skills.Add(CocoaSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Cocoa");
            if (currentExam != null)
            {
                CocoaSkill.Exam = currentExam;
            }

            var CodeigniterSkill = new Skill { Name = "Codeigniter" };
            context.Skills.Add(CodeigniterSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Codeigniter");
            if (currentExam != null)
            {
                CodeigniterSkill.Exam = currentExam;
            }

            var ColdFusionSkill = new Skill { Name = "Cold Fusion" };
            context.Skills.Add(ColdFusionSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Cold Fusion");
            if (currentExam != null)
            {
                ColdFusionSkill.Exam = currentExam;
            }

            var ColumnsSkill = new Skill { Name = "Columns" };
            context.Skills.Add(ColumnsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Columns");
            if (currentExam != null)
            {
                ColumnsSkill.Exam = currentExam;
            }

            var CommercialCleaningSkill = new Skill { Name = "Commercial Cleaning" };
            context.Skills.Add(CommercialCleaningSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Commercial Cleaning");
            if (currentExam != null)
            {
                CommercialCleaningSkill.Exam = currentExam;
            }

            var CommercialsSkill = new Skill { Name = "Commercials" };
            context.Skills.Add(CommercialsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Commercials");
            if (currentExam != null)
            {
                CommercialsSkill.Exam = currentExam;
            }

            var CommunicationsSkill = new Skill { Name = "Communications" };
            context.Skills.Add(CommunicationsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Communications");
            if (currentExam != null)
            {
                CommunicationsSkill.Exam = currentExam;
            }

            var ComplianceSkill = new Skill { Name = "Compliance" };
            context.Skills.Add(ComplianceSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Compliance");
            if (currentExam != null)
            {
                ComplianceSkill.Exam = currentExam;
            }

            var ComputerGraphicsSkill = new Skill { Name = "Computer Graphics" };
            context.Skills.Add(ComputerGraphicsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Computer Graphics");
            if (currentExam != null)
            {
                ComputerGraphicsSkill.Exam = currentExam;
            }

            var ComputerHelpSkill = new Skill { Name = "Computer Help" };
            context.Skills.Add(ComputerHelpSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Computer Help");
            if (currentExam != null)
            {
                ComputerHelpSkill.Exam = currentExam;
            }

            var ComputerSecuritySkill = new Skill { Name = "Computer Security" };
            context.Skills.Add(ComputerSecuritySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Computer Security");
            if (currentExam != null)
            {
                ComputerSecuritySkill.Exam = currentExam;
            }

            var ConceptDesignSkill = new Skill { Name = "Concept Design" };
            context.Skills.Add(ConceptDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Concept Design");
            if (currentExam != null)
            {
                ConceptDesignSkill.Exam = currentExam;
            }

            var ConcretingSkill = new Skill { Name = "Concreting" };
            context.Skills.Add(ConcretingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Concreting");
            if (currentExam != null)
            {
                ConcretingSkill.Exam = currentExam;
            }

            var ConstructionMonitoringSkill = new Skill { Name = "Construction Monitoring" };
            context.Skills.Add(ConstructionMonitoringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Construction Monitoring");
            if (currentExam != null)
            {
                ConstructionMonitoringSkill.Exam = currentExam;
            }

            var ContentWritingSkill = new Skill { Name = "Content Writing" };
            context.Skills.Add(ContentWritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Content Writing");
            if (currentExam != null)
            {
                ContentWritingSkill.Exam = currentExam;
            }

            var ContractsSkill = new Skill { Name = "Contracts" };
            context.Skills.Add(ContractsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Contracts");
            if (currentExam != null)
            {
                ContractsSkill.Exam = currentExam;
            }

            var ConversionRateOptimisationSkill = new Skill { Name = "Conversion Rate Optimisation" };
            context.Skills.Add(ConversionRateOptimisationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Conversion Rate Optimisation");
            if (currentExam != null)
            {
                ConversionRateOptimisationSkill.Exam = currentExam;
            }

            var CookingampRecipesSkill = new Skill { Name = "Cooking &amp; Recipes" };
            context.Skills.Add(CookingampRecipesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Cooking &amp; Recipes");
            if (currentExam != null)
            {
                CookingampRecipesSkill.Exam = currentExam;
            }

            var CookingBakingSkill = new Skill { Name = "Cooking / Baking" };
            context.Skills.Add(CookingBakingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Cooking / Baking");
            if (currentExam != null)
            {
                CookingBakingSkill.Exam = currentExam;
            }

            var CopyTypingSkill = new Skill { Name = "Copy Typing" };
            context.Skills.Add(CopyTypingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Copy Typing");
            if (currentExam != null)
            {
                CopyTypingSkill.Exam = currentExam;
            }

            var CopywritingSkill = new Skill { Name = "Copywriting" };
            context.Skills.Add(CopywritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Copywriting");
            if (currentExam != null)
            {
                CopywritingSkill.Exam = currentExam;
            }

            var CorporateIdentitySkill = new Skill { Name = "Corporate Identity" };
            context.Skills.Add(CorporateIdentitySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Corporate Identity");
            if (currentExam != null)
            {
                CorporateIdentitySkill.Exam = currentExam;
            }

            var CoursesSkill = new Skill { Name = "Courses" };
            context.Skills.Add(CoursesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Courses");
            if (currentExam != null)
            {
                CoursesSkill.Exam = currentExam;
            }

            var CoversampPackagingSkill = new Skill { Name = "Covers &amp; Packaging" };
            context.Skills.Add(CoversampPackagingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Covers &amp; Packaging");
            if (currentExam != null)
            {
                CoversampPackagingSkill.Exam = currentExam;
            }

            var CRELoadedSkill = new Skill { Name = "CRE Loaded" };
            context.Skills.Add(CRELoadedSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "CRE Loaded");
            if (currentExam != null)
            {
                CRELoadedSkill.Exam = currentExam;
            }

            var CreativeDesignSkill = new Skill { Name = "Creative Design" };
            context.Skills.Add(CreativeDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Creative Design");
            if (currentExam != null)
            {
                CreativeDesignSkill.Exam = currentExam;
            }

            var CreativeWritingSkill = new Skill { Name = "Creative Writing" };
            context.Skills.Add(CreativeWritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Creative Writing");
            if (currentExam != null)
            {
                CreativeWritingSkill.Exam = currentExam;
            }

            var CRMSkill = new Skill { Name = "CRM" };
            context.Skills.Add(CRMSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "CRM");
            if (currentExam != null)
            {
                CRMSkill.Exam = currentExam;
            }

            var CroatianSkill = new Skill { Name = "Croatian" };
            context.Skills.Add(CroatianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Croatian");
            if (currentExam != null)
            {
                CroatianSkill.Exam = currentExam;
            }

            var CryptographySkill = new Skill { Name = "Cryptography" };
            context.Skills.Add(CryptographySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Cryptography");
            if (currentExam != null)
            {
                CryptographySkill.Exam = currentExam;
            }

            var CSCartSkill = new Skill { Name = "CS-Cart" };
            context.Skills.Add(CSCartSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "CS-Cart");
            if (currentExam != null)
            {
                CSCartSkill.Exam = currentExam;
            }

            var CSSSkill = new Skill { Name = "CSS" };
            context.Skills.Add(CSSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "CSS");
            if (currentExam != null)
            {
                CSSSkill.Exam = currentExam;
            }

            var CubeCartSkill = new Skill { Name = "CubeCart" };
            context.Skills.Add(CubeCartSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "CubeCart");
            if (currentExam != null)
            {
                CubeCartSkill.Exam = currentExam;
            }

            var CUDASkill = new Skill { Name = "CUDA" };
            context.Skills.Add(CUDASkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "CUDA");
            if (currentExam != null)
            {
                CUDASkill.Exam = currentExam;
            }

            var CustomerServiceSkill = new Skill { Name = "Customer Service" };
            context.Skills.Add(CustomerServiceSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Customer Service");
            if (currentExam != null)
            {
                CustomerServiceSkill.Exam = currentExam;
            }

            var CustomerSupportSkill = new Skill { Name = "Customer Support" };
            context.Skills.Add(CustomerSupportSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Customer Support");
            if (currentExam != null)
            {
                CustomerSupportSkill.Exam = currentExam;
            }

            var CzechSkill = new Skill { Name = "Czech" };
            context.Skills.Add(CzechSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Czech");
            if (currentExam != null)
            {
                CzechSkill.Exam = currentExam;
            }

            var DjsSkill = new Skill { Name = "D3.js" };
            context.Skills.Add(DjsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "D3.js");
            if (currentExam != null)
            {
                DjsSkill.Exam = currentExam;
            }

            var DampProofingSkill = new Skill { Name = "Damp Proofing" };
            context.Skills.Add(DampProofingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Damp Proofing");
            if (currentExam != null)
            {
                DampProofingSkill.Exam = currentExam;
            }

            var DanishSkill = new Skill { Name = "Danish" };
            context.Skills.Add(DanishSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Danish");
            if (currentExam != null)
            {
                DanishSkill.Exam = currentExam;
            }

            var DariSkill = new Skill { Name = "Dari" };
            context.Skills.Add(DariSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Dari");
            if (currentExam != null)
            {
                DariSkill.Exam = currentExam;
            }

            var DartSkill = new Skill { Name = "Dart" };
            context.Skills.Add(DartSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Dart");
            if (currentExam != null)
            {
                DartSkill.Exam = currentExam;
            }

            var DataEntrySkill = new Skill { Name = "Data Entry" };
            context.Skills.Add(DataEntrySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Data Entry");
            if (currentExam != null)
            {
                DataEntrySkill.Exam = currentExam;
            }

            var DataMiningSkill = new Skill { Name = "Data Mining" };
            context.Skills.Add(DataMiningSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Data Mining");
            if (currentExam != null)
            {
                DataMiningSkill.Exam = currentExam;
            }

            var DataProcessingSkill = new Skill { Name = "Data Processing" };
            context.Skills.Add(DataProcessingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Data Processing");
            if (currentExam != null)
            {
                DataProcessingSkill.Exam = currentExam;
            }

            var DataScienceSkill = new Skill { Name = "Data Science" };
            context.Skills.Add(DataScienceSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Data Science");
            if (currentExam != null)
            {
                DataScienceSkill.Exam = currentExam;
            }

            var DataWarehousingSkill = new Skill { Name = "Data Warehousing" };
            context.Skills.Add(DataWarehousingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Data Warehousing");
            if (currentExam != null)
            {
                DataWarehousingSkill.Exam = currentExam;
            }

            var DatabaseAdministrationSkill = new Skill { Name = "Database Administration" };
            context.Skills.Add(DatabaseAdministrationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Database Administration");
            if (currentExam != null)
            {
                DatabaseAdministrationSkill.Exam = currentExam;
            }

            var DatabaseDevelopmentSkill = new Skill { Name = "Database Development" };
            context.Skills.Add(DatabaseDevelopmentSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Database Development");
            if (currentExam != null)
            {
                DatabaseDevelopmentSkill.Exam = currentExam;
            }

            var DatabaseProgrammingSkill = new Skill { Name = "Database Programming" };
            context.Skills.Add(DatabaseProgrammingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Database Programming");
            if (currentExam != null)
            {
                DatabaseProgrammingSkill.Exam = currentExam;
            }

            var DatingSkill = new Skill { Name = "Dating" };
            context.Skills.Add(DatingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Dating");
            if (currentExam != null)
            {
                DatingSkill.Exam = currentExam;
            }

            var DDSSkill = new Skill { Name = "DDS" };
            context.Skills.Add(DDSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "DDS");
            if (currentExam != null)
            {
                DDSSkill.Exam = currentExam;
            }

            var DebianSkill = new Skill { Name = "Debian" };
            context.Skills.Add(DebianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Debian");
            if (currentExam != null)
            {
                DebianSkill.Exam = currentExam;
            }

            var DebuggingSkill = new Skill { Name = "Debugging" };
            context.Skills.Add(DebuggingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Debugging");
            if (currentExam != null)
            {
                DebuggingSkill.Exam = currentExam;
            }

            var DeckingSkill = new Skill { Name = "Decking" };
            context.Skills.Add(DeckingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Decking");
            if (currentExam != null)
            {
                DeckingSkill.Exam = currentExam;
            }

            var DecorationSkill = new Skill { Name = "Decoration" };
            context.Skills.Add(DecorationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Decoration");
            if (currentExam != null)
            {
                DecorationSkill.Exam = currentExam;
            }

            var DeliverySkill = new Skill { Name = "Delivery" };
            context.Skills.Add(DeliverySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Delivery");
            if (currentExam != null)
            {
                DeliverySkill.Exam = currentExam;
            }

            var DelphiSkill = new Skill { Name = "Delphi" };
            context.Skills.Add(DelphiSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Delphi");
            if (currentExam != null)
            {
                DelphiSkill.Exam = currentExam;
            }

            var DemolitionSkill = new Skill { Name = "Demolition" };
            context.Skills.Add(DemolitionSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Demolition");
            if (currentExam != null)
            {
                DemolitionSkill.Exam = currentExam;
            }

            var DesktopSupportSkill = new Skill { Name = "Desktop Support" };
            context.Skills.Add(DesktopSupportSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Desktop Support");
            if (currentExam != null)
            {
                DesktopSupportSkill.Exam = currentExam;
            }

            var DigitalDesignSkill = new Skill { Name = "Digital Design" };
            context.Skills.Add(DigitalDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Digital Design");
            if (currentExam != null)
            {
                DigitalDesignSkill.Exam = currentExam;
            }

            var DisposalsSkill = new Skill { Name = "Disposals" };
            context.Skills.Add(DisposalsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Disposals");
            if (currentExam != null)
            {
                DisposalsSkill.Exam = currentExam;
            }

            var DjangoSkill = new Skill { Name = "Django" };
            context.Skills.Add(DjangoSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Django");
            if (currentExam != null)
            {
                DjangoSkill.Exam = currentExam;
            }

            var DNSSkill = new Skill { Name = "DNS" };
            context.Skills.Add(DNSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "DNS");
            if (currentExam != null)
            {
                DNSSkill.Exam = currentExam;
            }

            var DOSSkill = new Skill { Name = "DOS" };
            context.Skills.Add(DOSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "DOS");
            if (currentExam != null)
            {
                DOSSkill.Exam = currentExam;
            }

            var DotNetNukeSkill = new Skill { Name = "DotNetNuke" };
            context.Skills.Add(DotNetNukeSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "DotNetNuke");
            if (currentExam != null)
            {
                DotNetNukeSkill.Exam = currentExam;
            }

            var DraftingSkill = new Skill { Name = "Drafting" };
            context.Skills.Add(DraftingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Drafting");
            if (currentExam != null)
            {
                DraftingSkill.Exam = currentExam;
            }

            var DrainsSkill = new Skill { Name = "Drains" };
            context.Skills.Add(DrainsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Drains");
            if (currentExam != null)
            {
                DrainsSkill.Exam = currentExam;
            }

            var DronesSkill = new Skill { Name = "Drones" };
            context.Skills.Add(DronesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Drones");
            if (currentExam != null)
            {
                DronesSkill.Exam = currentExam;
            }

            var DrupalSkill = new Skill { Name = "Drupal" };
            context.Skills.Add(DrupalSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Drupal");
            if (currentExam != null)
            {
                DrupalSkill.Exam = currentExam;
            }

            var DutchSkill = new Skill { Name = "Dutch" };
            context.Skills.Add(DutchSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Dutch");
            if (currentExam != null)
            {
                DutchSkill.Exam = currentExam;
            }

            var DynamicsSkill = new Skill { Name = "Dynamics" };
            context.Skills.Add(DynamicsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Dynamics");
            if (currentExam != null)
            {
                DynamicsSkill.Exam = currentExam;
            }

            var eBaySkill = new Skill { Name = "eBay" };
            context.Skills.Add(eBaySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "eBay");
            if (currentExam != null)
            {
                eBaySkill.Exam = currentExam;
            }

            var eBooksSkill = new Skill { Name = "eBooks" };
            context.Skills.Add(eBooksSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "eBooks");
            if (currentExam != null)
            {
                eBooksSkill.Exam = currentExam;
            }

            var eCommerceSkill = new Skill { Name = "eCommerce" };
            context.Skills.Add(eCommerceSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "eCommerce");
            if (currentExam != null)
            {
                eCommerceSkill.Exam = currentExam;
            }

            var EditingSkill = new Skill { Name = "Editing" };
            context.Skills.Add(EditingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Editing");
            if (currentExam != null)
            {
                EditingSkill.Exam = currentExam;
            }

            var EducationampTutoringSkill = new Skill { Name = "Education &amp; Tutoring" };
            context.Skills.Add(EducationampTutoringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Education &amp; Tutoring");
            if (currentExam != null)
            {
                EducationampTutoringSkill.Exam = currentExam;
            }

            var edXSkill = new Skill { Name = "edX" };
            context.Skills.Add(edXSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "edX");
            if (currentExam != null)
            {
                edXSkill.Exam = currentExam;
            }

            var ElasticsearchSkill = new Skill { Name = "Elasticsearch" };
            context.Skills.Add(ElasticsearchSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Elasticsearch");
            if (currentExam != null)
            {
                ElasticsearchSkill.Exam = currentExam;
            }

            var eLearningSkill = new Skill { Name = "eLearning" };
            context.Skills.Add(eLearningSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "eLearning");
            if (currentExam != null)
            {
                eLearningSkill.Exam = currentExam;
            }

            var ElectricalEngineeringSkill = new Skill { Name = "Electrical Engineering" };
            context.Skills.Add(ElectricalEngineeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Electrical Engineering");
            if (currentExam != null)
            {
                ElectricalEngineeringSkill.Exam = currentExam;
            }

            var ElectriciansSkill = new Skill { Name = "Electricians" };
            context.Skills.Add(ElectriciansSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Electricians");
            if (currentExam != null)
            {
                ElectriciansSkill.Exam = currentExam;
            }

            var ElectronicFormsSkill = new Skill { Name = "Electronic Forms" };
            context.Skills.Add(ElectronicFormsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Electronic Forms");
            if (currentExam != null)
            {
                ElectronicFormsSkill.Exam = currentExam;
            }

            var ElectronicsSkill = new Skill { Name = "Electronics" };
            context.Skills.Add(ElectronicsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Electronics");
            if (currentExam != null)
            {
                ElectronicsSkill.Exam = currentExam;
            }

            var EmailHandlingSkill = new Skill { Name = "Email Handling" };
            context.Skills.Add(EmailHandlingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Email Handling");
            if (currentExam != null)
            {
                EmailHandlingSkill.Exam = currentExam;
            }

            var EmailMarketingSkill = new Skill { Name = "Email Marketing" };
            context.Skills.Add(EmailMarketingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Email Marketing");
            if (currentExam != null)
            {
                EmailMarketingSkill.Exam = currentExam;
            }

            var EmbeddedSoftwareSkill = new Skill { Name = "Embedded Software" };
            context.Skills.Add(EmbeddedSoftwareSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Embedded Software");
            if (currentExam != null)
            {
                EmbeddedSoftwareSkill.Exam = currentExam;
            }

            var EmberjsSkill = new Skill { Name = "Ember.js" };
            context.Skills.Add(EmberjsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Ember.js");
            if (currentExam != null)
            {
                EmberjsSkill.Exam = currentExam;
            }

            var EmploymentLawSkill = new Skill { Name = "Employment Law" };
            context.Skills.Add(EmploymentLawSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Employment Law");
            if (currentExam != null)
            {
                EmploymentLawSkill.Exam = currentExam;
            }

            var EnergySkill = new Skill { Name = "Energy" };
            context.Skills.Add(EnergySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Energy");
            if (currentExam != null)
            {
                EnergySkill.Exam = currentExam;
            }

            var EngineeringSkill = new Skill { Name = "Engineering" };
            context.Skills.Add(EngineeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Engineering");
            if (currentExam != null)
            {
                EngineeringSkill.Exam = currentExam;
            }

            var EngineeringDrawingSkill = new Skill { Name = "Engineering Drawing" };
            context.Skills.Add(EngineeringDrawingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Engineering Drawing");
            if (currentExam != null)
            {
                EngineeringDrawingSkill.Exam = currentExam;
            }

            var EnglishUKSkill = new Skill { Name = "English (UK)" };
            context.Skills.Add(EnglishUKSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "English (UK)");
            if (currentExam != null)
            {
                EnglishUKSkill.Exam = currentExam;
            }

            var EnglishUSSkill = new Skill { Name = "English (US)" };
            context.Skills.Add(EnglishUSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "English (US)");
            if (currentExam != null)
            {
                EnglishUSSkill.Exam = currentExam;
            }

            var EnglishGrammarSkill = new Skill { Name = "English Grammar" };
            context.Skills.Add(EnglishGrammarSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "English Grammar");
            if (currentExam != null)
            {
                EnglishGrammarSkill.Exam = currentExam;
            }

            var EnglishSpellingSkill = new Skill { Name = "English Spelling" };
            context.Skills.Add(EnglishSpellingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "English Spelling");
            if (currentExam != null)
            {
                EnglishSpellingSkill.Exam = currentExam;
            }

            var EntrepreneurshipSkill = new Skill { Name = "Entrepreneurship" };
            context.Skills.Add(EntrepreneurshipSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Entrepreneurship");
            if (currentExam != null)
            {
                EntrepreneurshipSkill.Exam = currentExam;
            }

            var EquipmentHireSkill = new Skill { Name = "Equipment Hire" };
            context.Skills.Add(EquipmentHireSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Equipment Hire");
            if (currentExam != null)
            {
                EquipmentHireSkill.Exam = currentExam;
            }

            var ErlangSkill = new Skill { Name = "Erlang" };
            context.Skills.Add(ErlangSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Erlang");
            if (currentExam != null)
            {
                ErlangSkill.Exam = currentExam;
            }

            var ERPSkill = new Skill { Name = "ERP" };
            context.Skills.Add(ERPSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "ERP");
            if (currentExam != null)
            {
                ERPSkill.Exam = currentExam;
            }

            var EstonianSkill = new Skill { Name = "Estonian" };
            context.Skills.Add(EstonianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Estonian");
            if (currentExam != null)
            {
                EstonianSkill.Exam = currentExam;
            }

            var EtsySkill = new Skill { Name = "Etsy" };
            context.Skills.Add(EtsySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Etsy");
            if (currentExam != null)
            {
                EtsySkill.Exam = currentExam;
            }

            var EventPlanningSkill = new Skill { Name = "Event Planning" };
            context.Skills.Add(EventPlanningSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Event Planning");
            if (currentExam != null)
            {
                EventPlanningSkill.Exam = currentExam;
            }

            var EventStaffingSkill = new Skill { Name = "Event Staffing" };
            context.Skills.Add(EventStaffingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Event Staffing");
            if (currentExam != null)
            {
                EventStaffingSkill.Exam = currentExam;
            }

            var ExcavationSkill = new Skill { Name = "Excavation" };
            context.Skills.Add(ExcavationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Excavation");
            if (currentExam != null)
            {
                ExcavationSkill.Exam = currentExam;
            }

            var ExcelSkill = new Skill { Name = "Excel" };
            context.Skills.Add(ExcelSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Excel");
            if (currentExam != null)
            {
                ExcelSkill.Exam = currentExam;
            }

            var ExpressJSSkill = new Skill { Name = "Express JS" };
            context.Skills.Add(ExpressJSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Express JS");
            if (currentExam != null)
            {
                ExpressJSSkill.Exam = currentExam;
            }

            var ExpressionEngineSkill = new Skill { Name = "Expression Engine" };
            context.Skills.Add(ExpressionEngineSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Expression Engine");
            if (currentExam != null)
            {
                ExpressionEngineSkill.Exam = currentExam;
            }

            var ExtensionsampAdditionsSkill = new Skill { Name = "Extensions &amp; Additions" };
            context.Skills.Add(ExtensionsampAdditionsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Extensions &amp; Additions");
            if (currentExam != null)
            {
                ExtensionsampAdditionsSkill.Exam = currentExam;
            }

            var FaceRecognitionSkill = new Skill { Name = "Face Recognition" };
            context.Skills.Add(FaceRecognitionSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Face Recognition");
            if (currentExam != null)
            {
                FaceRecognitionSkill.Exam = currentExam;
            }

            var FacebookMarketingSkill = new Skill { Name = "Facebook Marketing" };
            context.Skills.Add(FacebookMarketingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Facebook Marketing");
            if (currentExam != null)
            {
                FacebookMarketingSkill.Exam = currentExam;
            }

            var FashionDesignSkill = new Skill { Name = "Fashion Design" };
            context.Skills.Add(FashionDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Fashion Design");
            if (currentExam != null)
            {
                FashionDesignSkill.Exam = currentExam;
            }

            var FashionModelingSkill = new Skill { Name = "Fashion Modeling" };
            context.Skills.Add(FashionModelingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Fashion Modeling");
            if (currentExam != null)
            {
                FashionModelingSkill.Exam = currentExam;
            }

            var FencingSkill = new Skill { Name = "Fencing" };
            context.Skills.Add(FencingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Fencing");
            if (currentExam != null)
            {
                FencingSkill.Exam = currentExam;
            }

            var FengShuiSkill = new Skill { Name = "Feng Shui" };
            context.Skills.Add(FengShuiSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Feng Shui");
            if (currentExam != null)
            {
                FengShuiSkill.Exam = currentExam;
            }

            var FictionSkill = new Skill { Name = "Fiction" };
            context.Skills.Add(FictionSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Fiction");
            if (currentExam != null)
            {
                FictionSkill.Exam = currentExam;
            }

            var FileMakerSkill = new Skill { Name = "FileMaker" };
            context.Skills.Add(FileMakerSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "FileMaker");
            if (currentExam != null)
            {
                FileMakerSkill.Exam = currentExam;
            }

            var FilipinoSkill = new Skill { Name = "Filipino" };
            context.Skills.Add(FilipinoSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Filipino");
            if (currentExam != null)
            {
                FilipinoSkill.Exam = currentExam;
            }

            var FinalCutProSkill = new Skill { Name = "Final Cut Pro" };
            context.Skills.Add(FinalCutProSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Final Cut Pro");
            if (currentExam != null)
            {
                FinalCutProSkill.Exam = currentExam;
            }

            var FinaleSibeliusSkill = new Skill { Name = "Finale / Sibelius" };
            context.Skills.Add(FinaleSibeliusSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Finale / Sibelius");
            if (currentExam != null)
            {
                FinaleSibeliusSkill.Exam = currentExam;
            }

            var FinanceSkill = new Skill { Name = "Finance" };
            context.Skills.Add(FinanceSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Finance");
            if (currentExam != null)
            {
                FinanceSkill.Exam = currentExam;
            }

            var FinancialAnalysisSkill = new Skill { Name = "Financial Analysis" };
            context.Skills.Add(FinancialAnalysisSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Financial Analysis");
            if (currentExam != null)
            {
                FinancialAnalysisSkill.Exam = currentExam;
            }

            var FinancialMarketsSkill = new Skill { Name = "Financial Markets" };
            context.Skills.Add(FinancialMarketsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Financial Markets");
            if (currentExam != null)
            {
                FinancialMarketsSkill.Exam = currentExam;
            }

            var FinancialPlanningSkill = new Skill { Name = "Financial Planning" };
            context.Skills.Add(FinancialPlanningSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Financial Planning");
            if (currentExam != null)
            {
                FinancialPlanningSkill.Exam = currentExam;
            }

            var FinancialResearchSkill = new Skill { Name = "Financial Research" };
            context.Skills.Add(FinancialResearchSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Financial Research");
            if (currentExam != null)
            {
                FinancialResearchSkill.Exam = currentExam;
            }

            var FiniteElementAnalysisSkill = new Skill { Name = "Finite Element Analysis" };
            context.Skills.Add(FiniteElementAnalysisSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Finite Element Analysis");
            if (currentExam != null)
            {
                FiniteElementAnalysisSkill.Exam = currentExam;
            }

            var FinnishSkill = new Skill { Name = "Finnish" };
            context.Skills.Add(FinnishSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Finnish");
            if (currentExam != null)
            {
                FinnishSkill.Exam = currentExam;
            }

            var FirefoxSkill = new Skill { Name = "Firefox" };
            context.Skills.Add(FirefoxSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Firefox");
            if (currentExam != null)
            {
                FirefoxSkill.Exam = currentExam;
            }

            var FlashDSkill = new Skill { Name = "Flash 3D" };
            context.Skills.Add(FlashDSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Flash 3D");
            if (currentExam != null)
            {
                FlashDSkill.Exam = currentExam;
            }

            var FlashmobSkill = new Skill { Name = "Flashmob" };
            context.Skills.Add(FlashmobSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Flashmob");
            if (currentExam != null)
            {
                FlashmobSkill.Exam = currentExam;
            }

            var FlexSkill = new Skill { Name = "Flex" };
            context.Skills.Add(FlexSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Flex");
            if (currentExam != null)
            {
                FlexSkill.Exam = currentExam;
            }

            var FloorCoatingsSkill = new Skill { Name = "Floor Coatings" };
            context.Skills.Add(FloorCoatingsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Floor Coatings");
            if (currentExam != null)
            {
                FloorCoatingsSkill.Exam = currentExam;
            }

            var FlooringSkill = new Skill { Name = "Flooring" };
            context.Skills.Add(FlooringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Flooring");
            if (currentExam != null)
            {
                FlooringSkill.Exam = currentExam;
            }

            var FlyerDesignSkill = new Skill { Name = "Flyer Design" };
            context.Skills.Add(FlyerDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Flyer Design");
            if (currentExam != null)
            {
                FlyerDesignSkill.Exam = currentExam;
            }

            var FlyscreensSkill = new Skill { Name = "Flyscreens" };
            context.Skills.Add(FlyscreensSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Flyscreens");
            if (currentExam != null)
            {
                FlyscreensSkill.Exam = currentExam;
            }

            var FoodTakeawaySkill = new Skill { Name = "Food Takeaway" };
            context.Skills.Add(FoodTakeawaySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Food Takeaway");
            if (currentExam != null)
            {
                FoodTakeawaySkill.Exam = currentExam;
            }

            var FormatampLayoutSkill = new Skill { Name = "Format &amp; Layout" };
            context.Skills.Add(FormatampLayoutSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Format &amp; Layout");
            if (currentExam != null)
            {
                FormatampLayoutSkill.Exam = currentExam;
            }

            var FortranSkill = new Skill { Name = "Fortran" };
            context.Skills.Add(FortranSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Fortran");
            if (currentExam != null)
            {
                FortranSkill.Exam = currentExam;
            }

            var ForumPostingSkill = new Skill { Name = "Forum Posting" };
            context.Skills.Add(ForumPostingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Forum Posting");
            if (currentExam != null)
            {
                ForumPostingSkill.Exam = currentExam;
            }

            var ForumSoftwareSkill = new Skill { Name = "Forum Software" };
            context.Skills.Add(ForumSoftwareSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Forum Software");
            if (currentExam != null)
            {
                ForumSoftwareSkill.Exam = currentExam;
            }

            var FPGASkill = new Skill { Name = "FPGA" };
            context.Skills.Add(FPGASkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "FPGA");
            if (currentExam != null)
            {
                FPGASkill.Exam = currentExam;
            }

            var FramesampTrussesSkill = new Skill { Name = "Frames &amp; Trusses" };
            context.Skills.Add(FramesampTrussesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Frames &amp; Trusses");
            if (currentExam != null)
            {
                FramesampTrussesSkill.Exam = currentExam;
            }

            var FreelanceSkill = new Skill { Name = "Freelance" };
            context.Skills.Add(FreelanceSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Freelance");
            if (currentExam != null)
            {
                FreelanceSkill.Exam = currentExam;
            }

            var FreelancerAPISkill = new Skill { Name = "FreelancerAPI" };
            context.Skills.Add(FreelancerAPISkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "FreelancerAPI");
            if (currentExam != null)
            {
                FreelancerAPISkill.Exam = currentExam;
            }

            var FrenchSkill = new Skill { Name = "French" };
            context.Skills.Add(FrenchSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "French");
            if (currentExam != null)
            {
                FrenchSkill.Exam = currentExam;
            }

            var FrenchCanadianSkill = new Skill { Name = "French (Canadian)" };
            context.Skills.Add(FrenchCanadianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "French (Canadian)");
            if (currentExam != null)
            {
                FrenchCanadianSkill.Exam = currentExam;
            }

            var FundraisingSkill = new Skill { Name = "Fundraising" };
            context.Skills.Add(FundraisingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Fundraising");
            if (currentExam != null)
            {
                FundraisingSkill.Exam = currentExam;
            }

            var FurnitureAssemblySkill = new Skill { Name = "Furniture Assembly" };
            context.Skills.Add(FurnitureAssemblySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Furniture Assembly");
            if (currentExam != null)
            {
                FurnitureAssemblySkill.Exam = currentExam;
            }

            var FurnitureDesignSkill = new Skill { Name = "Furniture Design" };
            context.Skills.Add(FurnitureDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Furniture Design");
            if (currentExam != null)
            {
                FurnitureDesignSkill.Exam = currentExam;
            }

            var GameConsolesSkill = new Skill { Name = "Game Consoles" };
            context.Skills.Add(GameConsolesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Game Consoles");
            if (currentExam != null)
            {
                GameConsolesSkill.Exam = currentExam;
            }

            var GameDesignSkill = new Skill { Name = "Game Design" };
            context.Skills.Add(GameDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Game Design");
            if (currentExam != null)
            {
                GameDesignSkill.Exam = currentExam;
            }

            var GameDevelopmentSkill = new Skill { Name = "Game Development" };
            context.Skills.Add(GameDevelopmentSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Game Development");
            if (currentExam != null)
            {
                GameDevelopmentSkill.Exam = currentExam;
            }

            var GameSaladSkill = new Skill { Name = "GameSalad" };
            context.Skills.Add(GameSaladSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "GameSalad");
            if (currentExam != null)
            {
                GameSaladSkill.Exam = currentExam;
            }

            var GamificationSkill = new Skill { Name = "Gamification" };
            context.Skills.Add(GamificationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Gamification");
            if (currentExam != null)
            {
                GamificationSkill.Exam = currentExam;
            }

            var GarageBandSkill = new Skill { Name = "GarageBand" };
            context.Skills.Add(GarageBandSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "GarageBand");
            if (currentExam != null)
            {
                GarageBandSkill.Exam = currentExam;
            }

            var GardeningSkill = new Skill { Name = "Gardening" };
            context.Skills.Add(GardeningSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Gardening");
            if (currentExam != null)
            {
                GardeningSkill.Exam = currentExam;
            }

            var GasFittingSkill = new Skill { Name = "Gas Fitting" };
            context.Skills.Add(GasFittingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Gas Fitting");
            if (currentExam != null)
            {
                GasFittingSkill.Exam = currentExam;
            }

            var GenealogySkill = new Skill { Name = "Genealogy" };
            context.Skills.Add(GenealogySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Genealogy");
            if (currentExam != null)
            {
                GenealogySkill.Exam = currentExam;
            }

            var GeneralOfficeSkill = new Skill { Name = "General Office" };
            context.Skills.Add(GeneralOfficeSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "General Office");
            if (currentExam != null)
            {
                GeneralOfficeSkill.Exam = currentExam;
            }

            var GeneticEngineeringSkill = new Skill { Name = "Genetic Engineering" };
            context.Skills.Add(GeneticEngineeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Genetic Engineering");
            if (currentExam != null)
            {
                GeneticEngineeringSkill.Exam = currentExam;
            }

            var GeolocationSkill = new Skill { Name = "Geolocation" };
            context.Skills.Add(GeolocationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Geolocation");
            if (currentExam != null)
            {
                GeolocationSkill.Exam = currentExam;
            }

            var GeologySkill = new Skill { Name = "Geology" };
            context.Skills.Add(GeologySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Geology");
            if (currentExam != null)
            {
                GeologySkill.Exam = currentExam;
            }

            var GeospatialSkill = new Skill { Name = "Geospatial" };
            context.Skills.Add(GeospatialSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Geospatial");
            if (currentExam != null)
            {
                GeospatialSkill.Exam = currentExam;
            }

            var GermanSkill = new Skill { Name = "German" };
            context.Skills.Add(GermanSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "German");
            if (currentExam != null)
            {
                GermanSkill.Exam = currentExam;
            }

            var GhostwritingSkill = new Skill { Name = "Ghostwriting" };
            context.Skills.Add(GhostwritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Ghostwriting");
            if (currentExam != null)
            {
                GhostwritingSkill.Exam = currentExam;
            }

            var GitSkill = new Skill { Name = "Git" };
            context.Skills.Add(GitSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Git");
            if (currentExam != null)
            {
                GitSkill.Exam = currentExam;
            }

            var GlassMirrorampGlazingSkill = new Skill { Name = "Glass / Mirror &amp; Glazing" };
            context.Skills.Add(GlassMirrorampGlazingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Glass / Mirror &amp; Glazing");
            if (currentExam != null)
            {
                GlassMirrorampGlazingSkill.Exam = currentExam;
            }

            var GolangSkill = new Skill { Name = "Golang" };
            context.Skills.Add(GolangSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Golang");
            if (currentExam != null)
            {
                GolangSkill.Exam = currentExam;
            }

            var GoogleAdsenseSkill = new Skill { Name = "Google Adsense" };
            context.Skills.Add(GoogleAdsenseSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Google Adsense");
            if (currentExam != null)
            {
                GoogleAdsenseSkill.Exam = currentExam;
            }

            var GoogleAdwordsSkill = new Skill { Name = "Google Adwords" };
            context.Skills.Add(GoogleAdwordsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Google Adwords");
            if (currentExam != null)
            {
                GoogleAdwordsSkill.Exam = currentExam;
            }

            var GoogleAnalyticsSkill = new Skill { Name = "Google Analytics" };
            context.Skills.Add(GoogleAnalyticsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Google Analytics");
            if (currentExam != null)
            {
                GoogleAnalyticsSkill.Exam = currentExam;
            }

            var GoogleAppEngineSkill = new Skill { Name = "Google App Engine" };
            context.Skills.Add(GoogleAppEngineSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Google App Engine");
            if (currentExam != null)
            {
                GoogleAppEngineSkill.Exam = currentExam;
            }

            var GoogleCardboardSkill = new Skill { Name = "Google Cardboard" };
            context.Skills.Add(GoogleCardboardSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Google Cardboard");
            if (currentExam != null)
            {
                GoogleCardboardSkill.Exam = currentExam;
            }

            var GoogleChromeSkill = new Skill { Name = "Google Chrome" };
            context.Skills.Add(GoogleChromeSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Google Chrome");
            if (currentExam != null)
            {
                GoogleChromeSkill.Exam = currentExam;
            }

            var GoogleEarthSkill = new Skill { Name = "Google Earth" };
            context.Skills.Add(GoogleEarthSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Google Earth");
            if (currentExam != null)
            {
                GoogleEarthSkill.Exam = currentExam;
            }

            var GoogleMapsAPISkill = new Skill { Name = "Google Maps API" };
            context.Skills.Add(GoogleMapsAPISkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Google Maps API");
            if (currentExam != null)
            {
                GoogleMapsAPISkill.Exam = currentExam;
            }

            var GooglePlusSkill = new Skill { Name = "Google Plus" };
            context.Skills.Add(GooglePlusSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Google Plus");
            if (currentExam != null)
            {
                GooglePlusSkill.Exam = currentExam;
            }

            var GoogleSketchUpSkill = new Skill { Name = "Google SketchUp" };
            context.Skills.Add(GoogleSketchUpSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Google SketchUp");
            if (currentExam != null)
            {
                GoogleSketchUpSkill.Exam = currentExam;
            }

            var GoogleWebToolkitSkill = new Skill { Name = "Google Web Toolkit" };
            context.Skills.Add(GoogleWebToolkitSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Google Web Toolkit");
            if (currentExam != null)
            {
                GoogleWebToolkitSkill.Exam = currentExam;
            }

            var GoogleWebmasterToolsSkill = new Skill { Name = "Google Webmaster Tools" };
            context.Skills.Add(GoogleWebmasterToolsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Google Webmaster Tools");
            if (currentExam != null)
            {
                GoogleWebmasterToolsSkill.Exam = currentExam;
            }

            var GoogleWebsiteOptimizerSkill = new Skill { Name = "Google Website Optimizer" };
            context.Skills.Add(GoogleWebsiteOptimizerSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Google Website Optimizer");
            if (currentExam != null)
            {
                GoogleWebsiteOptimizerSkill.Exam = currentExam;
            }

            var GoProSkill = new Skill { Name = "GoPro" };
            context.Skills.Add(GoProSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "GoPro");
            if (currentExam != null)
            {
                GoProSkill.Exam = currentExam;
            }

            var GPGPUSkill = new Skill { Name = "GPGPU" };
            context.Skills.Add(GPGPUSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "GPGPU");
            if (currentExam != null)
            {
                GPGPUSkill.Exam = currentExam;
            }

            var GPSSkill = new Skill { Name = "GPS" };
            context.Skills.Add(GPSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "GPS");
            if (currentExam != null)
            {
                GPSSkill.Exam = currentExam;
            }

            var GrantWritingSkill = new Skill { Name = "Grant Writing" };
            context.Skills.Add(GrantWritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Grant Writing");
            if (currentExam != null)
            {
                GrantWritingSkill.Exam = currentExam;
            }

            var GraphicDesignSkill = new Skill { Name = "Graphic Design" };
            context.Skills.Add(GraphicDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Graphic Design");
            if (currentExam != null)
            {
                GraphicDesignSkill.Exam = currentExam;
            }

            var GreaseMonkeySkill = new Skill { Name = "Grease Monkey" };
            context.Skills.Add(GreaseMonkeySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Grease Monkey");
            if (currentExam != null)
            {
                GreaseMonkeySkill.Exam = currentExam;
            }

            var GreekSkill = new Skill { Name = "Greek" };
            context.Skills.Add(GreekSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Greek");
            if (currentExam != null)
            {
                GreekSkill.Exam = currentExam;
            }

            var GrowthHackingSkill = new Skill { Name = "Growth Hacking" };
            context.Skills.Add(GrowthHackingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Growth Hacking");
            if (currentExam != null)
            {
                GrowthHackingSkill.Exam = currentExam;
            }

            var GruntSkill = new Skill { Name = "Grunt" };
            context.Skills.Add(GruntSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Grunt");
            if (currentExam != null)
            {
                GruntSkill.Exam = currentExam;
            }

            var GutteringSkill = new Skill { Name = "Guttering" };
            context.Skills.Add(GutteringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Guttering");
            if (currentExam != null)
            {
                GutteringSkill.Exam = currentExam;
            }

            var HadoopSkill = new Skill { Name = "Hadoop" };
            context.Skills.Add(HadoopSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Hadoop");
            if (currentExam != null)
            {
                HadoopSkill.Exam = currentExam;
            }

            var HandymanSkill = new Skill { Name = "Handyman" };
            context.Skills.Add(HandymanSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Handyman");
            if (currentExam != null)
            {
                HandymanSkill.Exam = currentExam;
            }

            var HaskellSkill = new Skill { Name = "Haskell" };
            context.Skills.Add(HaskellSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Haskell");
            if (currentExam != null)
            {
                HaskellSkill.Exam = currentExam;
            }

            var HBaseSkill = new Skill { Name = "HBase" };
            context.Skills.Add(HBaseSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "HBase");
            if (currentExam != null)
            {
                HBaseSkill.Exam = currentExam;
            }

            var HealthSkill = new Skill { Name = "Health" };
            context.Skills.Add(HealthSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Health");
            if (currentExam != null)
            {
                HealthSkill.Exam = currentExam;
            }

            var HeatingSystemsSkill = new Skill { Name = "Heating Systems" };
            context.Skills.Add(HeatingSystemsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Heating Systems");
            if (currentExam != null)
            {
                HeatingSystemsSkill.Exam = currentExam;
            }

            var HebrewSkill = new Skill { Name = "Hebrew" };
            context.Skills.Add(HebrewSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Hebrew");
            if (currentExam != null)
            {
                HebrewSkill.Exam = currentExam;
            }

            var HelpdeskSkill = new Skill { Name = "Helpdesk" };
            context.Skills.Add(HelpdeskSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Helpdesk");
            if (currentExam != null)
            {
                HelpdeskSkill.Exam = currentExam;
            }

            var HerokuSkill = new Skill { Name = "Heroku" };
            context.Skills.Add(HerokuSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Heroku");
            if (currentExam != null)
            {
                HerokuSkill.Exam = currentExam;
            }

            var HindiSkill = new Skill { Name = "Hindi" };
            context.Skills.Add(HindiSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Hindi");
            if (currentExam != null)
            {
                HindiSkill.Exam = currentExam;
            }

            var HiremeSkill = new Skill { Name = "Hire me" };
            context.Skills.Add(HiremeSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Hire me");
            if (currentExam != null)
            {
                HiremeSkill.Exam = currentExam;
            }

            var HistorySkill = new Skill { Name = "History" };
            context.Skills.Add(HistorySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "History");
            if (currentExam != null)
            {
                HistorySkill.Exam = currentExam;
            }

            var HiveSkill = new Skill { Name = "Hive" };
            context.Skills.Add(HiveSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Hive");
            if (currentExam != null)
            {
                HiveSkill.Exam = currentExam;
            }

            var HomeAutomationSkill = new Skill { Name = "Home Automation" };
            context.Skills.Add(HomeAutomationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Home Automation");
            if (currentExam != null)
            {
                HomeAutomationSkill.Exam = currentExam;
            }

            var HomeDesignSkill = new Skill { Name = "Home Design" };
            context.Skills.Add(HomeDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Home Design");
            if (currentExam != null)
            {
                HomeDesignSkill.Exam = currentExam;
            }

            var HomeOrganizationSkill = new Skill { Name = "Home Organization" };
            context.Skills.Add(HomeOrganizationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Home Organization");
            if (currentExam != null)
            {
                HomeOrganizationSkill.Exam = currentExam;
            }

            var HomeKitSkill = new Skill { Name = "HomeKit" };
            context.Skills.Add(HomeKitSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "HomeKit");
            if (currentExam != null)
            {
                HomeKitSkill.Exam = currentExam;
            }

            var HotWaterSkill = new Skill { Name = "Hot Water" };
            context.Skills.Add(HotWaterSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Hot Water");
            if (currentExam != null)
            {
                HotWaterSkill.Exam = currentExam;
            }

            var HouseCleaningSkill = new Skill { Name = "House Cleaning" };
            context.Skills.Add(HouseCleaningSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "House Cleaning");
            if (currentExam != null)
            {
                HouseCleaningSkill.Exam = currentExam;
            }

            var HouseworkSkill = new Skill { Name = "Housework" };
            context.Skills.Add(HouseworkSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Housework");
            if (currentExam != null)
            {
                HouseworkSkill.Exam = currentExam;
            }

            var HPOpenviewSkill = new Skill { Name = "HP Openview" };
            context.Skills.Add(HPOpenviewSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "HP Openview");
            if (currentExam != null)
            {
                HPOpenviewSkill.Exam = currentExam;
            }

            var HTMLSkill = new Skill { Name = "HTML" };
            context.Skills.Add(HTMLSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "HTML");
            if (currentExam != null)
            {
                HTMLSkill.Exam = currentExam;
            }

            var HTML5Skill = new Skill { Name = "HTML5" };
            context.Skills.Add(HTML5Skill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "HTML5");
            if (currentExam != null)
            {
                HTML5Skill.Exam = currentExam;
            }

            var HumanResourcesSkill = new Skill { Name = "Human Resources" };
            context.Skills.Add(HumanResourcesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Human Resources");
            if (currentExam != null)
            {
                HumanResourcesSkill.Exam = currentExam;
            }

            var HumanSciencesSkill = new Skill { Name = "Human Sciences" };
            context.Skills.Add(HumanSciencesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Human Sciences");
            if (currentExam != null)
            {
                HumanSciencesSkill.Exam = currentExam;
            }

            var HungarianSkill = new Skill { Name = "Hungarian" };
            context.Skills.Add(HungarianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Hungarian");
            if (currentExam != null)
            {
                HungarianSkill.Exam = currentExam;
            }

            var iBeaconSkill = new Skill { Name = "iBeacon" };
            context.Skills.Add(iBeaconSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "iBeacon");
            if (currentExam != null)
            {
                iBeaconSkill.Exam = currentExam;
            }

            var IBMTivoliSkill = new Skill { Name = "IBM Tivoli" };
            context.Skills.Add(IBMTivoliSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "IBM Tivoli");
            if (currentExam != null)
            {
                IBMTivoliSkill.Exam = currentExam;
            }

            var IBMWebsphereTransformationToolSkill = new Skill { Name = "IBM Websphere Transformation Tool" };
            context.Skills.Add(IBMWebsphereTransformationToolSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "IBM Websphere Transformation Tool");
            if (currentExam != null)
            {
                IBMWebsphereTransformationToolSkill.Exam = currentExam;
            }

            var IconDesignSkill = new Skill { Name = "Icon Design" };
            context.Skills.Add(IconDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Icon Design");
            if (currentExam != null)
            {
                IconDesignSkill.Exam = currentExam;
            }

            var IISSkill = new Skill { Name = "IIS" };
            context.Skills.Add(IISSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "IIS");
            if (currentExam != null)
            {
                IISSkill.Exam = currentExam;
            }

            var IKEAInstallationSkill = new Skill { Name = "IKEA Installation" };
            context.Skills.Add(IKEAInstallationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "IKEA Installation");
            if (currentExam != null)
            {
                IKEAInstallationSkill.Exam = currentExam;
            }

            var IllustrationSkill = new Skill { Name = "Illustration" };
            context.Skills.Add(IllustrationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Illustration");
            if (currentExam != null)
            {
                IllustrationSkill.Exam = currentExam;
            }

            var IllustratorSkill = new Skill { Name = "Illustrator" };
            context.Skills.Add(IllustratorSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Illustrator");
            if (currentExam != null)
            {
                IllustratorSkill.Exam = currentExam;
            }

            var ImagingSkill = new Skill { Name = "Imaging" };
            context.Skills.Add(ImagingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Imaging");
            if (currentExam != null)
            {
                ImagingSkill.Exam = currentExam;
            }

            var iMovieSkill = new Skill { Name = "iMovie" };
            context.Skills.Add(iMovieSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "iMovie");
            if (currentExam != null)
            {
                iMovieSkill.Exam = currentExam;
            }

            var IndonesianSkill = new Skill { Name = "Indonesian" };
            context.Skills.Add(IndonesianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Indonesian");
            if (currentExam != null)
            {
                IndonesianSkill.Exam = currentExam;
            }

            var IndustrialDesignSkill = new Skill { Name = "Industrial Design" };
            context.Skills.Add(IndustrialDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Industrial Design");
            if (currentExam != null)
            {
                IndustrialDesignSkill.Exam = currentExam;
            }

            var IndustrialEngineeringSkill = new Skill { Name = "Industrial Engineering" };
            context.Skills.Add(IndustrialEngineeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Industrial Engineering");
            if (currentExam != null)
            {
                IndustrialEngineeringSkill.Exam = currentExam;
            }

            var InfographicsSkill = new Skill { Name = "Infographics" };
            context.Skills.Add(InfographicsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Infographics");
            if (currentExam != null)
            {
                InfographicsSkill.Exam = currentExam;
            }

            var InspectionsSkill = new Skill { Name = "Inspections" };
            context.Skills.Add(InspectionsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Inspections");
            if (currentExam != null)
            {
                InspectionsSkill.Exam = currentExam;
            }

            var InstagramSkill = new Skill { Name = "Instagram" };
            context.Skills.Add(InstagramSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Instagram");
            if (currentExam != null)
            {
                InstagramSkill.Exam = currentExam;
            }

            var InstallationSkill = new Skill { Name = "Installation" };
            context.Skills.Add(InstallationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Installation");
            if (currentExam != null)
            {
                InstallationSkill.Exam = currentExam;
            }

            var InstrumentationSkill = new Skill { Name = "Instrumentation" };
            context.Skills.Add(InstrumentationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Instrumentation");
            if (currentExam != null)
            {
                InstrumentationSkill.Exam = currentExam;
            }

            var InsuranceSkill = new Skill { Name = "Insurance" };
            context.Skills.Add(InsuranceSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Insurance");
            if (currentExam != null)
            {
                InsuranceSkill.Exam = currentExam;
            }

            var InteriorDesignSkill = new Skill { Name = "Interior Design" };
            context.Skills.Add(InteriorDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Interior Design");
            if (currentExam != null)
            {
                InteriorDesignSkill.Exam = currentExam;
            }

            var InteriorsSkill = new Skill { Name = "Interiors" };
            context.Skills.Add(InteriorsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Interiors");
            if (currentExam != null)
            {
                InteriorsSkill.Exam = currentExam;
            }

            var InternetMarketingSkill = new Skill { Name = "Internet Marketing" };
            context.Skills.Add(InternetMarketingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Internet Marketing");
            if (currentExam != null)
            {
                InternetMarketingSkill.Exam = currentExam;
            }

            var InternetResearchSkill = new Skill { Name = "Internet Research" };
            context.Skills.Add(InternetResearchSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Internet Research");
            if (currentExam != null)
            {
                InternetResearchSkill.Exam = currentExam;
            }

            var InternetSecuritySkill = new Skill { Name = "Internet Security" };
            context.Skills.Add(InternetSecuritySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Internet Security");
            if (currentExam != null)
            {
                InternetSecuritySkill.Exam = currentExam;
            }

            var InterspireSkill = new Skill { Name = "Interspire" };
            context.Skills.Add(InterspireSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Interspire");
            if (currentExam != null)
            {
                InterspireSkill.Exam = currentExam;
            }

            var InventoryManagementSkill = new Skill { Name = "Inventory Management" };
            context.Skills.Add(InventoryManagementSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Inventory Management");
            if (currentExam != null)
            {
                InventoryManagementSkill.Exam = currentExam;
            }

            var InvestmentResearchSkill = new Skill { Name = "Investment Research" };
            context.Skills.Add(InvestmentResearchSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Investment Research");
            if (currentExam != null)
            {
                InvestmentResearchSkill.Exam = currentExam;
            }

            var InvitationDesignSkill = new Skill { Name = "Invitation Design" };
            context.Skills.Add(InvitationDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Invitation Design");
            if (currentExam != null)
            {
                InvitationDesignSkill.Exam = currentExam;
            }

            var iPadSkill = new Skill { Name = "iPad" };
            context.Skills.Add(iPadSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "iPad");
            if (currentExam != null)
            {
                iPadSkill.Exam = currentExam;
            }

            var iPhoneSkill = new Skill { Name = "iPhone" };
            context.Skills.Add(iPhoneSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "iPhone");
            if (currentExam != null)
            {
                iPhoneSkill.Exam = currentExam;
            }

            var ISOSkill = new Skill { Name = "ISO9001" };
            context.Skills.Add(ISOSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "ISO9001");
            if (currentExam != null)
            {
                ISOSkill.Exam = currentExam;
            }

            var ItalianSkill = new Skill { Name = "Italian" };
            context.Skills.Add(ItalianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Italian");
            if (currentExam != null)
            {
                ItalianSkill.Exam = currentExam;
            }

            var ITILSkill = new Skill { Name = "ITIL" };
            context.Skills.Add(ITILSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "ITIL");
            if (currentExam != null)
            {
                ITILSkill.Exam = currentExam;
            }

            var JEESkill = new Skill { Name = "J2EE" };
            context.Skills.Add(JEESkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "J2EE");
            if (currentExam != null)
            {
                JEESkill.Exam = currentExam;
            }

            var JMESkill = new Skill { Name = "J2ME" };
            context.Skills.Add(JMESkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "J2ME");
            if (currentExam != null)
            {
                JMESkill.Exam = currentExam;
            }

            var JabberSkill = new Skill { Name = "Jabber" };
            context.Skills.Add(JabberSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Jabber");
            if (currentExam != null)
            {
                JabberSkill.Exam = currentExam;
            }

            var JapaneseSkill = new Skill { Name = "Japanese" };
            context.Skills.Add(JapaneseSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Japanese");
            if (currentExam != null)
            {
                JapaneseSkill.Exam = currentExam;
            }

            var JavaSkill = new Skill { Name = "Java" };
            context.Skills.Add(JavaSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Java");
            if (currentExam != null)
            {
                JavaSkill.Exam = currentExam;
            }

            var JavaFXSkill = new Skill { Name = "JavaFX" };
            context.Skills.Add(JavaFXSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "JavaFX");
            if (currentExam != null)
            {
                JavaFXSkill.Exam = currentExam;
            }

            var JavascriptSkill = new Skill { Name = "Javascript" };
            context.Skills.Add(JavascriptSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Javascript");
            if (currentExam != null)
            {
                JavascriptSkill.Exam = currentExam;
            }

            var JDFSkill = new Skill { Name = "JDF" };
            context.Skills.Add(JDFSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "JDF");
            if (currentExam != null)
            {
                JDFSkill.Exam = currentExam;
            }

            var JewellerySkill = new Skill { Name = "Jewellery" };
            context.Skills.Add(JewellerySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Jewellery");
            if (currentExam != null)
            {
                JewellerySkill.Exam = currentExam;
            }

            var JoomlaSkill = new Skill { Name = "Joomla" };
            context.Skills.Add(JoomlaSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Joomla");
            if (currentExam != null)
            {
                JoomlaSkill.Exam = currentExam;
            }

            var jQueryPrototypeSkill = new Skill { Name = "jQuery / Prototype" };
            context.Skills.Add(jQueryPrototypeSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "jQuery / Prototype");
            if (currentExam != null)
            {
                jQueryPrototypeSkill.Exam = currentExam;
            }

            var JSPSkill = new Skill { Name = "JSP" };
            context.Skills.Add(JSPSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "JSP");
            if (currentExam != null)
            {
                JSPSkill.Exam = currentExam;
            }

            var KannadaSkill = new Skill { Name = "Kannada" };
            context.Skills.Add(KannadaSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Kannada");
            if (currentExam != null)
            {
                KannadaSkill.Exam = currentExam;
            }

            var KinectSkill = new Skill { Name = "Kinect" };
            context.Skills.Add(KinectSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Kinect");
            if (currentExam != null)
            {
                KinectSkill.Exam = currentExam;
            }

            var KitchenSkill = new Skill { Name = "Kitchen" };
            context.Skills.Add(KitchenSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Kitchen");
            if (currentExam != null)
            {
                KitchenSkill.Exam = currentExam;
            }

            var KnockoutjsSkill = new Skill { Name = "Knockout.js" };
            context.Skills.Add(KnockoutjsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Knockout.js");
            if (currentExam != null)
            {
                KnockoutjsSkill.Exam = currentExam;
            }

            var KoreanSkill = new Skill { Name = "Korean" };
            context.Skills.Add(KoreanSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Korean");
            if (currentExam != null)
            {
                KoreanSkill.Exam = currentExam;
            }

            var LabelDesignSkill = new Skill { Name = "Label Design" };
            context.Skills.Add(LabelDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Label Design");
            if (currentExam != null)
            {
                LabelDesignSkill.Exam = currentExam;
            }

            var LabVIEWSkill = new Skill { Name = "LabVIEW" };
            context.Skills.Add(LabVIEWSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "LabVIEW");
            if (currentExam != null)
            {
                LabVIEWSkill.Exam = currentExam;
            }

            var LandingPagesSkill = new Skill { Name = "Landing Pages" };
            context.Skills.Add(LandingPagesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Landing Pages");
            if (currentExam != null)
            {
                LandingPagesSkill.Exam = currentExam;
            }

            var LandscapingSkill = new Skill { Name = "Landscaping" };
            context.Skills.Add(LandscapingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Landscaping");
            if (currentExam != null)
            {
                LandscapingSkill.Exam = currentExam;
            }

            var LandscapingampGardeningSkill = new Skill { Name = "Landscaping &amp; Gardening" };
            context.Skills.Add(LandscapingampGardeningSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Landscaping &amp; Gardening");
            if (currentExam != null)
            {
                LandscapingampGardeningSkill.Exam = currentExam;
            }

            var LaravelSkill = new Skill { Name = "Laravel" };
            context.Skills.Add(LaravelSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Laravel");
            if (currentExam != null)
            {
                LaravelSkill.Exam = currentExam;
            }

            var LaTeXSkill = new Skill { Name = "LaTeX" };
            context.Skills.Add(LaTeXSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "LaTeX");
            if (currentExam != null)
            {
                LaTeXSkill.Exam = currentExam;
            }

            var LatvianSkill = new Skill { Name = "Latvian" };
            context.Skills.Add(LatvianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Latvian");
            if (currentExam != null)
            {
                LatvianSkill.Exam = currentExam;
            }

            var LaundryandIroningSkill = new Skill { Name = "Laundry and Ironing" };
            context.Skills.Add(LaundryandIroningSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Laundry and Ironing");
            if (currentExam != null)
            {
                LaundryandIroningSkill.Exam = currentExam;
            }

            var LawnMowingSkill = new Skill { Name = "Lawn Mowing" };
            context.Skills.Add(LawnMowingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Lawn Mowing");
            if (currentExam != null)
            {
                LawnMowingSkill.Exam = currentExam;
            }

            var LeadsSkill = new Skill { Name = "Leads" };
            context.Skills.Add(LeadsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Leads");
            if (currentExam != null)
            {
                LeadsSkill.Exam = currentExam;
            }

            var LeapMotionSDKSkill = new Skill { Name = "Leap Motion SDK" };
            context.Skills.Add(LeapMotionSDKSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Leap Motion SDK");
            if (currentExam != null)
            {
                LeapMotionSDKSkill.Exam = currentExam;
            }

            var LegalSkill = new Skill { Name = "Legal" };
            context.Skills.Add(LegalSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Legal");
            if (currentExam != null)
            {
                LegalSkill.Exam = currentExam;
            }

            var LegalResearchSkill = new Skill { Name = "Legal Research" };
            context.Skills.Add(LegalResearchSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Legal Research");
            if (currentExam != null)
            {
                LegalResearchSkill.Exam = currentExam;
            }

            var LegalWritingSkill = new Skill { Name = "Legal Writing" };
            context.Skills.Add(LegalWritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Legal Writing");
            if (currentExam != null)
            {
                LegalWritingSkill.Exam = currentExam;
            }

            var LESSSassSCSSSkill = new Skill { Name = "LESS/Sass/SCSS" };
            context.Skills.Add(LESSSassSCSSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "LESS/Sass/SCSS");
            if (currentExam != null)
            {
                LESSSassSCSSSkill.Exam = currentExam;
            }

            var LifeCoachingSkill = new Skill { Name = "Life Coaching" };
            context.Skills.Add(LifeCoachingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Life Coaching");
            if (currentExam != null)
            {
                LifeCoachingSkill.Exam = currentExam;
            }

            var LightingSkill = new Skill { Name = "Lighting" };
            context.Skills.Add(LightingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Lighting");
            if (currentExam != null)
            {
                LightingSkill.Exam = currentExam;
            }

            var LinearProgrammingSkill = new Skill { Name = "Linear Programming" };
            context.Skills.Add(LinearProgrammingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Linear Programming");
            if (currentExam != null)
            {
                LinearProgrammingSkill.Exam = currentExam;
            }

            var LinkBuildingSkill = new Skill { Name = "Link Building" };
            context.Skills.Add(LinkBuildingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Link Building");
            if (currentExam != null)
            {
                LinkBuildingSkill.Exam = currentExam;
            }

            var LinkedinSkill = new Skill { Name = "Linkedin" };
            context.Skills.Add(LinkedinSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Linkedin");
            if (currentExam != null)
            {
                LinkedinSkill.Exam = currentExam;
            }

            var LinuxSkill = new Skill { Name = "Linux" };
            context.Skills.Add(LinuxSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Linux");
            if (currentExam != null)
            {
                LinuxSkill.Exam = currentExam;
            }

            var LispSkill = new Skill { Name = "Lisp" };
            context.Skills.Add(LispSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Lisp");
            if (currentExam != null)
            {
                LispSkill.Exam = currentExam;
            }

            var LithuanianSkill = new Skill { Name = "Lithuanian" };
            context.Skills.Add(LithuanianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Lithuanian");
            if (currentExam != null)
            {
                LithuanianSkill.Exam = currentExam;
            }

            var LocksmithSkill = new Skill { Name = "Locksmith" };
            context.Skills.Add(LocksmithSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Locksmith");
            if (currentExam != null)
            {
                LocksmithSkill.Exam = currentExam;
            }

            var LogisticsampShippingSkill = new Skill { Name = "Logistics &amp; Shipping" };
            context.Skills.Add(LogisticsampShippingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Logistics &amp; Shipping");
            if (currentExam != null)
            {
                LogisticsampShippingSkill.Exam = currentExam;
            }

            var LogoDesignSkill = new Skill { Name = "Logo Design" };
            context.Skills.Add(LogoDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Logo Design");
            if (currentExam != null)
            {
                LogoDesignSkill.Exam = currentExam;
            }

            var LotusNotesSkill = new Skill { Name = "Lotus Notes" };
            context.Skills.Add(LotusNotesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Lotus Notes");
            if (currentExam != null)
            {
                LotusNotesSkill.Exam = currentExam;
            }

            var MacOSSkill = new Skill { Name = "Mac OS" };
            context.Skills.Add(MacOSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Mac OS");
            if (currentExam != null)
            {
                MacOSSkill.Exam = currentExam;
            }

            var MacedonianSkill = new Skill { Name = "Macedonian" };
            context.Skills.Add(MacedonianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Macedonian");
            if (currentExam != null)
            {
                MacedonianSkill.Exam = currentExam;
            }

            var MachineLearningSkill = new Skill { Name = "Machine Learning" };
            context.Skills.Add(MachineLearningSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Machine Learning");
            if (currentExam != null)
            {
                MachineLearningSkill.Exam = currentExam;
            }

            var MagentoSkill = new Skill { Name = "Magento" };
            context.Skills.Add(MagentoSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Magento");
            if (currentExam != null)
            {
                MagentoSkill.Exam = currentExam;
            }

            var MagicLeapSkill = new Skill { Name = "Magic Leap" };
            context.Skills.Add(MagicLeapSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Magic Leap");
            if (currentExam != null)
            {
                MagicLeapSkill.Exam = currentExam;
            }

            var MailchimpSkill = new Skill { Name = "Mailchimp" };
            context.Skills.Add(MailchimpSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Mailchimp");
            if (currentExam != null)
            {
                MailchimpSkill.Exam = currentExam;
            }

            var MakerbotSkill = new Skill { Name = "Makerbot" };
            context.Skills.Add(MakerbotSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Makerbot");
            if (currentExam != null)
            {
                MakerbotSkill.Exam = currentExam;
            }

            var MalaySkill = new Skill { Name = "Malay" };
            context.Skills.Add(MalaySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Malay");
            if (currentExam != null)
            {
                MalaySkill.Exam = currentExam;
            }

            var MalayalamSkill = new Skill { Name = "Malayalam" };
            context.Skills.Add(MalayalamSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Malayalam");
            if (currentExam != null)
            {
                MalayalamSkill.Exam = currentExam;
            }

            var MalteseSkill = new Skill { Name = "Maltese" };
            context.Skills.Add(MalteseSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Maltese");
            if (currentExam != null)
            {
                MalteseSkill.Exam = currentExam;
            }

            var ManagementSkill = new Skill { Name = "Management" };
            context.Skills.Add(ManagementSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Management");
            if (currentExam != null)
            {
                ManagementSkill.Exam = currentExam;
            }

            var ManufacturingSkill = new Skill { Name = "Manufacturing" };
            context.Skills.Add(ManufacturingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Manufacturing");
            if (currentExam != null)
            {
                ManufacturingSkill.Exam = currentExam;
            }

            var ManufacturingDesignSkill = new Skill { Name = "Manufacturing Design" };
            context.Skills.Add(ManufacturingDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Manufacturing Design");
            if (currentExam != null)
            {
                ManufacturingDesignSkill.Exam = currentExam;
            }

            var MapReduceSkill = new Skill { Name = "Map Reduce" };
            context.Skills.Add(MapReduceSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Map Reduce");
            if (currentExam != null)
            {
                MapReduceSkill.Exam = currentExam;
            }

            var MariaDBSkill = new Skill { Name = "MariaDB" };
            context.Skills.Add(MariaDBSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "MariaDB");
            if (currentExam != null)
            {
                MariaDBSkill.Exam = currentExam;
            }

            var MarketResearchSkill = new Skill { Name = "Market Research" };
            context.Skills.Add(MarketResearchSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Market Research");
            if (currentExam != null)
            {
                MarketResearchSkill.Exam = currentExam;
            }

            var MarketingSkill = new Skill { Name = "Marketing" };
            context.Skills.Add(MarketingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Marketing");
            if (currentExam != null)
            {
                MarketingSkill.Exam = currentExam;
            }

            var MarketplaceServiceSkill = new Skill { Name = "Marketplace Service" };
            context.Skills.Add(MarketplaceServiceSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Marketplace Service");
            if (currentExam != null)
            {
                MarketplaceServiceSkill.Exam = currentExam;
            }

            var MaterialsEngineeringSkill = new Skill { Name = "Materials Engineering" };
            context.Skills.Add(MaterialsEngineeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Materials Engineering");
            if (currentExam != null)
            {
                MaterialsEngineeringSkill.Exam = currentExam;
            }

            var MathematicsSkill = new Skill { Name = "Mathematics" };
            context.Skills.Add(MathematicsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Mathematics");
            if (currentExam != null)
            {
                MathematicsSkill.Exam = currentExam;
            }

            var MatlabampMathematicaSkill = new Skill { Name = "Matlab &amp; Mathematica" };
            context.Skills.Add(MatlabampMathematicaSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Matlab &amp; Mathematica");
            if (currentExam != null)
            {
                MatlabampMathematicaSkill.Exam = currentExam;
            }

            var MayaSkill = new Skill { Name = "Maya" };
            context.Skills.Add(MayaSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Maya");
            if (currentExam != null)
            {
                MayaSkill.Exam = currentExam;
            }

            var MechanicalEngineeringSkill = new Skill { Name = "Mechanical Engineering" };
            context.Skills.Add(MechanicalEngineeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Mechanical Engineering");
            if (currentExam != null)
            {
                MechanicalEngineeringSkill.Exam = currentExam;
            }

            var MechatronicsSkill = new Skill { Name = "Mechatronics" };
            context.Skills.Add(MechatronicsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Mechatronics");
            if (currentExam != null)
            {
                MechatronicsSkill.Exam = currentExam;
            }

            var MedicalSkill = new Skill { Name = "Medical" };
            context.Skills.Add(MedicalSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Medical");
            if (currentExam != null)
            {
                MedicalSkill.Exam = currentExam;
            }

            var MedicalWritingSkill = new Skill { Name = "Medical Writing" };
            context.Skills.Add(MedicalWritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Medical Writing");
            if (currentExam != null)
            {
                MedicalWritingSkill.Exam = currentExam;
            }

            var MetatraderSkill = new Skill { Name = "Metatrader" };
            context.Skills.Add(MetatraderSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Metatrader");
            if (currentExam != null)
            {
                MetatraderSkill.Exam = currentExam;
            }

            var MetroSkill = new Skill { Name = "Metro" };
            context.Skills.Add(MetroSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Metro");
            if (currentExam != null)
            {
                MetroSkill.Exam = currentExam;
            }

            var MicrobiologySkill = new Skill { Name = "Microbiology" };
            context.Skills.Add(MicrobiologySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Microbiology");
            if (currentExam != null)
            {
                MicrobiologySkill.Exam = currentExam;
            }

            var MicrocontrollerSkill = new Skill { Name = "Microcontroller" };
            context.Skills.Add(MicrocontrollerSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Microcontroller");
            if (currentExam != null)
            {
                MicrocontrollerSkill.Exam = currentExam;
            }

            var MicrosoftSkill = new Skill { Name = "Microsoft" };
            context.Skills.Add(MicrosoftSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Microsoft");
            if (currentExam != null)
            {
                MicrosoftSkill.Exam = currentExam;
            }

            var MicrosoftAccessSkill = new Skill { Name = "Microsoft Access" };
            context.Skills.Add(MicrosoftAccessSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Microsoft Access");
            if (currentExam != null)
            {
                MicrosoftAccessSkill.Exam = currentExam;
            }

            var MicrosoftExchangeSkill = new Skill { Name = "Microsoft Exchange" };
            context.Skills.Add(MicrosoftExchangeSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Microsoft Exchange");
            if (currentExam != null)
            {
                MicrosoftExchangeSkill.Exam = currentExam;
            }

            var MicrosoftExpressionSkill = new Skill { Name = "Microsoft Expression" };
            context.Skills.Add(MicrosoftExpressionSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Microsoft Expression");
            if (currentExam != null)
            {
                MicrosoftExpressionSkill.Exam = currentExam;
            }

            var MicrosoftHololensSkill = new Skill { Name = "Microsoft Hololens" };
            context.Skills.Add(MicrosoftHololensSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Microsoft Hololens");
            if (currentExam != null)
            {
                MicrosoftHololensSkill.Exam = currentExam;
            }

            var MicrosoftOfficeSkill = new Skill { Name = "Microsoft Office" };
            context.Skills.Add(MicrosoftOfficeSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Microsoft Office");
            if (currentExam != null)
            {
                MicrosoftOfficeSkill.Exam = currentExam;
            }

            var MicrosoftOutlookSkill = new Skill { Name = "Microsoft Outlook" };
            context.Skills.Add(MicrosoftOutlookSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Microsoft Outlook");
            if (currentExam != null)
            {
                MicrosoftOutlookSkill.Exam = currentExam;
            }

            var MicrosoftSQLServerSkill = new Skill { Name = "Microsoft SQL Server" };
            context.Skills.Add(MicrosoftSQLServerSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Microsoft SQL Server");
            if (currentExam != null)
            {
                MicrosoftSQLServerSkill.Exam = currentExam;
            }

            var MicrostationSkill = new Skill { Name = "Microstation" };
            context.Skills.Add(MicrostationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Microstation");
            if (currentExam != null)
            {
                MicrostationSkill.Exam = currentExam;
            }

            var MillworkSkill = new Skill { Name = "Millwork" };
            context.Skills.Add(MillworkSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Millwork");
            if (currentExam != null)
            {
                MillworkSkill.Exam = currentExam;
            }

            var MiningEngineeringSkill = new Skill { Name = "Mining Engineering" };
            context.Skills.Add(MiningEngineeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Mining Engineering");
            if (currentExam != null)
            {
                MiningEngineeringSkill.Exam = currentExam;
            }

            var MLMSkill = new Skill { Name = "MLM" };
            context.Skills.Add(MLMSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "MLM");
            if (currentExam != null)
            {
                MLMSkill.Exam = currentExam;
            }

            var MMORPGSkill = new Skill { Name = "MMORPG" };
            context.Skills.Add(MMORPGSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "MMORPG");
            if (currentExam != null)
            {
                MMORPGSkill.Exam = currentExam;
            }

            var MobileAppTestingSkill = new Skill { Name = "Mobile App Testing" };
            context.Skills.Add(MobileAppTestingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Mobile App Testing");
            if (currentExam != null)
            {
                MobileAppTestingSkill.Exam = currentExam;
            }

            var MobilePhoneSkill = new Skill { Name = "Mobile Phone" };
            context.Skills.Add(MobilePhoneSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Mobile Phone");
            if (currentExam != null)
            {
                MobilePhoneSkill.Exam = currentExam;
            }

            var MODxSkill = new Skill { Name = "MODx" };
            context.Skills.Add(MODxSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "MODx");
            if (currentExam != null)
            {
                MODxSkill.Exam = currentExam;
            }

            var MonetDBSkill = new Skill { Name = "MonetDB" };
            context.Skills.Add(MonetDBSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "MonetDB");
            if (currentExam != null)
            {
                MonetDBSkill.Exam = currentExam;
            }

            var MoodleSkill = new Skill { Name = "Moodle" };
            context.Skills.Add(MoodleSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Moodle");
            if (currentExam != null)
            {
                MoodleSkill.Exam = currentExam;
            }

            var MortgageBrokeringSkill = new Skill { Name = "Mortgage Brokering" };
            context.Skills.Add(MortgageBrokeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Mortgage Brokering");
            if (currentExam != null)
            {
                MortgageBrokeringSkill.Exam = currentExam;
            }

            var MotionGraphicsSkill = new Skill { Name = "Motion Graphics" };
            context.Skills.Add(MotionGraphicsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Motion Graphics");
            if (currentExam != null)
            {
                MotionGraphicsSkill.Exam = currentExam;
            }

            var MovingSkill = new Skill { Name = "Moving" };
            context.Skills.Add(MovingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Moving");
            if (currentExam != null)
            {
                MovingSkill.Exam = currentExam;
            }

            var MQTTSkill = new Skill { Name = "MQTT" };
            context.Skills.Add(MQTTSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "MQTT");
            if (currentExam != null)
            {
                MQTTSkill.Exam = currentExam;
            }

            var MusicSkill = new Skill { Name = "Music" };
            context.Skills.Add(MusicSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Music");
            if (currentExam != null)
            {
                MusicSkill.Exam = currentExam;
            }

            var MVCSkill = new Skill { Name = "MVC" };
            context.Skills.Add(MVCSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "MVC");
            if (currentExam != null)
            {
                MVCSkill.Exam = currentExam;
            }

            var MYOBSkill = new Skill { Name = "MYOB" };
            context.Skills.Add(MYOBSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "MYOB");
            if (currentExam != null)
            {
                MYOBSkill.Exam = currentExam;
            }

            var MySpaceSkill = new Skill { Name = "MySpace" };
            context.Skills.Add(MySpaceSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "MySpace");
            if (currentExam != null)
            {
                MySpaceSkill.Exam = currentExam;
            }

            var MySQLSkill = new Skill { Name = "MySQL" };
            context.Skills.Add(MySQLSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "MySQL");
            if (currentExam != null)
            {
                MySQLSkill.Exam = currentExam;
            }

            var NanotechnologySkill = new Skill { Name = "Nanotechnology" };
            context.Skills.Add(NanotechnologySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Nanotechnology");
            if (currentExam != null)
            {
                NanotechnologySkill.Exam = currentExam;
            }

            var NaturalLanguageSkill = new Skill { Name = "Natural Language" };
            context.Skills.Add(NaturalLanguageSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Natural Language");
            if (currentExam != null)
            {
                NaturalLanguageSkill.Exam = currentExam;
            }

            var NetworkAdministrationSkill = new Skill { Name = "Network Administration" };
            context.Skills.Add(NetworkAdministrationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Network Administration");
            if (currentExam != null)
            {
                NetworkAdministrationSkill.Exam = currentExam;
            }

            var NewslettersSkill = new Skill { Name = "Newsletters" };
            context.Skills.Add(NewslettersSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Newsletters");
            if (currentExam != null)
            {
                NewslettersSkill.Exam = currentExam;
            }

            var NginxSkill = new Skill { Name = "Nginx" };
            context.Skills.Add(NginxSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Nginx");
            if (currentExam != null)
            {
                NginxSkill.Exam = currentExam;
            }

            var NingSkill = new Skill { Name = "Ning" };
            context.Skills.Add(NingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Ning");
            if (currentExam != null)
            {
                NingSkill.Exam = currentExam;
            }

            var nodejsSkill = new Skill { Name = "node.js" };
            context.Skills.Add(nodejsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "node.js");
            if (currentExam != null)
            {
                nodejsSkill.Exam = currentExam;
            }

            var NokiaSkill = new Skill { Name = "Nokia" };
            context.Skills.Add(NokiaSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Nokia");
            if (currentExam != null)
            {
                NokiaSkill.Exam = currentExam;
            }

            var NorwegianSkill = new Skill { Name = "Norwegian" };
            context.Skills.Add(NorwegianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Norwegian");
            if (currentExam != null)
            {
                NorwegianSkill.Exam = currentExam;
            }

            var NoSQLCouchampMongoSkill = new Skill { Name = "NoSQL Couch &amp; Mongo" };
            context.Skills.Add(NoSQLCouchampMongoSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "NoSQL Couch &amp; Mongo");
            if (currentExam != null)
            {
                NoSQLCouchampMongoSkill.Exam = currentExam;
            }

            var NutritionSkill = new Skill { Name = "Nutrition" };
            context.Skills.Add(NutritionSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Nutrition");
            if (currentExam != null)
            {
                NutritionSkill.Exam = currentExam;
            }

            var ObjectiveCSkill = new Skill { Name = "Objective C" };
            context.Skills.Add(ObjectiveCSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Objective C");
            if (currentExam != null)
            {
                ObjectiveCSkill.Exam = currentExam;
            }

            var OCRSkill = new Skill { Name = "OCR" };
            context.Skills.Add(OCRSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "OCR");
            if (currentExam != null)
            {
                OCRSkill.Exam = currentExam;
            }

            var OculusMobileSDKSkill = new Skill { Name = "Oculus Mobile SDK" };
            context.Skills.Add(OculusMobileSDKSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Oculus Mobile SDK");
            if (currentExam != null)
            {
                OculusMobileSDKSkill.Exam = currentExam;
            }

            var OnlineWritingSkill = new Skill { Name = "Online Writing" };
            context.Skills.Add(OnlineWritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Online Writing");
            if (currentExam != null)
            {
                OnlineWritingSkill.Exam = currentExam;
            }

            var OpenCartSkill = new Skill { Name = "Open Cart" };
            context.Skills.Add(OpenCartSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Open Cart");
            if (currentExam != null)
            {
                OpenCartSkill.Exam = currentExam;
            }

            var OpenBravoSkill = new Skill { Name = "OpenBravo" };
            context.Skills.Add(OpenBravoSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "OpenBravo");
            if (currentExam != null)
            {
                OpenBravoSkill.Exam = currentExam;
            }

            var OpenCLSkill = new Skill { Name = "OpenCL" };
            context.Skills.Add(OpenCLSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "OpenCL");
            if (currentExam != null)
            {
                OpenCLSkill.Exam = currentExam;
            }

            var OpenGLSkill = new Skill { Name = "OpenGL" };
            context.Skills.Add(OpenGLSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "OpenGL");
            if (currentExam != null)
            {
                OpenGLSkill.Exam = currentExam;
            }

            var OpenVMSSkill = new Skill { Name = "OpenVMS" };
            context.Skills.Add(OpenVMSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "OpenVMS");
            if (currentExam != null)
            {
                OpenVMSSkill.Exam = currentExam;
            }

            var OracleSkill = new Skill { Name = "Oracle" };
            context.Skills.Add(OracleSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Oracle");
            if (currentExam != null)
            {
                OracleSkill.Exam = currentExam;
            }

            var OrderProcessingSkill = new Skill { Name = "Order Processing" };
            context.Skills.Add(OrderProcessingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Order Processing");
            if (currentExam != null)
            {
                OrderProcessingSkill.Exam = currentExam;
            }

            var OSCommerceSkill = new Skill { Name = "OSCommerce" };
            context.Skills.Add(OSCommerceSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "OSCommerce");
            if (currentExam != null)
            {
                OSCommerceSkill.Exam = currentExam;
            }

            var PackageDesignSkill = new Skill { Name = "Package Design" };
            context.Skills.Add(PackageDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Package Design");
            if (currentExam != null)
            {
                PackageDesignSkill.Exam = currentExam;
            }

            var PackingampShippingSkill = new Skill { Name = "Packing &amp; Shipping" };
            context.Skills.Add(PackingampShippingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Packing &amp; Shipping");
            if (currentExam != null)
            {
                PackingampShippingSkill.Exam = currentExam;
            }

            var PaintingSkill = new Skill { Name = "Painting" };
            context.Skills.Add(PaintingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Painting");
            if (currentExam != null)
            {
                PaintingSkill.Exam = currentExam;
            }

            var PalmSkill = new Skill { Name = "Palm" };
            context.Skills.Add(PalmSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Palm");
            if (currentExam != null)
            {
                PalmSkill.Exam = currentExam;
            }

            var PapiamentoSkill = new Skill { Name = "Papiamento" };
            context.Skills.Add(PapiamentoSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Papiamento");
            if (currentExam != null)
            {
                PapiamentoSkill.Exam = currentExam;
            }

            var ParallaxScrollingSkill = new Skill { Name = "Parallax Scrolling" };
            context.Skills.Add(ParallaxScrollingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Parallax Scrolling");
            if (currentExam != null)
            {
                ParallaxScrollingSkill.Exam = currentExam;
            }

            var ParallelsAutomationSkill = new Skill { Name = "Parallels Automation" };
            context.Skills.Add(ParallelsAutomationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Parallels Automation");
            if (currentExam != null)
            {
                ParallelsAutomationSkill.Exam = currentExam;
            }

            var ParallelsDesktopSkill = new Skill { Name = "Parallels Desktop" };
            context.Skills.Add(ParallelsDesktopSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Parallels Desktop");
            if (currentExam != null)
            {
                ParallelsDesktopSkill.Exam = currentExam;
            }

            var PatentsSkill = new Skill { Name = "Patents" };
            context.Skills.Add(PatentsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Patents");
            if (currentExam != null)
            {
                PatentsSkill.Exam = currentExam;
            }

            var PatternMakingSkill = new Skill { Name = "Pattern Making" };
            context.Skills.Add(PatternMakingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Pattern Making");
            if (currentExam != null)
            {
                PatternMakingSkill.Exam = currentExam;
            }

            var PatternMatchingSkill = new Skill { Name = "Pattern Matching" };
            context.Skills.Add(PatternMatchingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Pattern Matching");
            if (currentExam != null)
            {
                PatternMatchingSkill.Exam = currentExam;
            }

            var PavementSkill = new Skill { Name = "Pavement" };
            context.Skills.Add(PavementSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Pavement");
            if (currentExam != null)
            {
                PavementSkill.Exam = currentExam;
            }

            var PaypalAPISkill = new Skill { Name = "Paypal API" };
            context.Skills.Add(PaypalAPISkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Paypal API");
            if (currentExam != null)
            {
                PaypalAPISkill.Exam = currentExam;
            }

            var PayrollSkill = new Skill { Name = "Payroll" };
            context.Skills.Add(PayrollSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Payroll");
            if (currentExam != null)
            {
                PayrollSkill.Exam = currentExam;
            }

            var PCBLayoutSkill = new Skill { Name = "PCB Layout" };
            context.Skills.Add(PCBLayoutSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "PCB Layout");
            if (currentExam != null)
            {
                PCBLayoutSkill.Exam = currentExam;
            }

            var PDFSkill = new Skill { Name = "PDF" };
            context.Skills.Add(PDFSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "PDF");
            if (currentExam != null)
            {
                PDFSkill.Exam = currentExam;
            }

            var PencilBlueCMSSkill = new Skill { Name = "PencilBlue CMS" };
            context.Skills.Add(PencilBlueCMSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "PencilBlue CMS");
            if (currentExam != null)
            {
                PencilBlueCMSSkill.Exam = currentExam;
            }

            var PentahoSkill = new Skill { Name = "Pentaho" };
            context.Skills.Add(PentahoSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Pentaho");
            if (currentExam != null)
            {
                PentahoSkill.Exam = currentExam;
            }

            var PeopleSoftSkill = new Skill { Name = "PeopleSoft" };
            context.Skills.Add(PeopleSoftSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "PeopleSoft");
            if (currentExam != null)
            {
                PeopleSoftSkill.Exam = currentExam;
            }

            var PeriscopeSkill = new Skill { Name = "Periscope" };
            context.Skills.Add(PeriscopeSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Periscope");
            if (currentExam != null)
            {
                PeriscopeSkill.Exam = currentExam;
            }

            var PerlSkill = new Skill { Name = "Perl" };
            context.Skills.Add(PerlSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Perl");
            if (currentExam != null)
            {
                PerlSkill.Exam = currentExam;
            }

            var PersonalDevelopmentSkill = new Skill { Name = "Personal Development" };
            context.Skills.Add(PersonalDevelopmentSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Personal Development");
            if (currentExam != null)
            {
                PersonalDevelopmentSkill.Exam = currentExam;
            }

            var PestControlSkill = new Skill { Name = "Pest Control" };
            context.Skills.Add(PestControlSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Pest Control");
            if (currentExam != null)
            {
                PestControlSkill.Exam = currentExam;
            }

            var PetSittingSkill = new Skill { Name = "Pet Sitting" };
            context.Skills.Add(PetSittingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Pet Sitting");
            if (currentExam != null)
            {
                PetSittingSkill.Exam = currentExam;
            }

            var PetroleumEngineeringSkill = new Skill { Name = "Petroleum Engineering" };
            context.Skills.Add(PetroleumEngineeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Petroleum Engineering");
            if (currentExam != null)
            {
                PetroleumEngineeringSkill.Exam = currentExam;
            }

            var PhoneSupportSkill = new Skill { Name = "Phone Support" };
            context.Skills.Add(PhoneSupportSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Phone Support");
            if (currentExam != null)
            {
                PhoneSupportSkill.Exam = currentExam;
            }

            var PhoneGapSkill = new Skill { Name = "PhoneGap" };
            context.Skills.Add(PhoneGapSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "PhoneGap");
            if (currentExam != null)
            {
                PhoneGapSkill.Exam = currentExam;
            }

            var PhotoEditingSkill = new Skill { Name = "Photo Editing" };
            context.Skills.Add(PhotoEditingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Photo Editing");
            if (currentExam != null)
            {
                PhotoEditingSkill.Exam = currentExam;
            }

            var PhotographySkill = new Skill { Name = "Photography" };
            context.Skills.Add(PhotographySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Photography");
            if (currentExam != null)
            {
                PhotographySkill.Exam = currentExam;
            }

            var PhotoshopSkill = new Skill { Name = "Photoshop" };
            context.Skills.Add(PhotoshopSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Photoshop");
            if (currentExam != null)
            {
                PhotoshopSkill.Exam = currentExam;
            }

            var PhotoshopCodingSkill = new Skill { Name = "Photoshop Coding" };
            context.Skills.Add(PhotoshopCodingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Photoshop Coding");
            if (currentExam != null)
            {
                PhotoshopCodingSkill.Exam = currentExam;
            }

            var PhotoshopDesignSkill = new Skill { Name = "Photoshop Design" };
            context.Skills.Add(PhotoshopDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Photoshop Design");
            if (currentExam != null)
            {
                PhotoshopDesignSkill.Exam = currentExam;
            }

            var PHPSkill = new Skill { Name = "PHP" };
            context.Skills.Add(PHPSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "PHP");
            if (currentExam != null)
            {
                PHPSkill.Exam = currentExam;
            }

            var PhysicsSkill = new Skill { Name = "Physics" };
            context.Skills.Add(PhysicsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Physics");
            if (currentExam != null)
            {
                PhysicsSkill.Exam = currentExam;
            }

            var PICKMultivalueDBSkill = new Skill { Name = "PICK Multivalue DB" };
            context.Skills.Add(PICKMultivalueDBSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "PICK Multivalue DB");
            if (currentExam != null)
            {
                PICKMultivalueDBSkill.Exam = currentExam;
            }

            var PickupSkill = new Skill { Name = "Pickup" };
            context.Skills.Add(PickupSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Pickup");
            if (currentExam != null)
            {
                PickupSkill.Exam = currentExam;
            }

            var PinterestSkill = new Skill { Name = "Pinterest" };
            context.Skills.Add(PinterestSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Pinterest");
            if (currentExam != null)
            {
                PinterestSkill.Exam = currentExam;
            }

            var PipingSkill = new Skill { Name = "Piping" };
            context.Skills.Add(PipingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Piping");
            if (currentExam != null)
            {
                PipingSkill.Exam = currentExam;
            }

            var PLCampSCADASkill = new Skill { Name = "PLC &amp; SCADA" };
            context.Skills.Add(PLCampSCADASkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "PLC &amp; SCADA");
            if (currentExam != null)
            {
                PLCampSCADASkill.Exam = currentExam;
            }

            var PleskSkill = new Skill { Name = "Plesk" };
            context.Skills.Add(PleskSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Plesk");
            if (currentExam != null)
            {
                PleskSkill.Exam = currentExam;
            }

            var PluginSkill = new Skill { Name = "Plugin" };
            context.Skills.Add(PluginSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Plugin");
            if (currentExam != null)
            {
                PluginSkill.Exam = currentExam;
            }

            var PlumbingSkill = new Skill { Name = "Plumbing" };
            context.Skills.Add(PlumbingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Plumbing");
            if (currentExam != null)
            {
                PlumbingSkill.Exam = currentExam;
            }

            var PoetrySkill = new Skill { Name = "Poetry" };
            context.Skills.Add(PoetrySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Poetry");
            if (currentExam != null)
            {
                PoetrySkill.Exam = currentExam;
            }

            var PolishSkill = new Skill { Name = "Polish" };
            context.Skills.Add(PolishSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Polish");
            if (currentExam != null)
            {
                PolishSkill.Exam = currentExam;
            }

            var PortugueseSkill = new Skill { Name = "Portuguese" };
            context.Skills.Add(PortugueseSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Portuguese");
            if (currentExam != null)
            {
                PortugueseSkill.Exam = currentExam;
            }

            var PortugueseBrazilSkill = new Skill { Name = "Portuguese (Brazil)" };
            context.Skills.Add(PortugueseBrazilSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Portuguese (Brazil)");
            if (currentExam != null)
            {
                PortugueseBrazilSkill.Exam = currentExam;
            }

            var PostProductionSkill = new Skill { Name = "Post-Production" };
            context.Skills.Add(PostProductionSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Post-Production");
            if (currentExam != null)
            {
                PostProductionSkill.Exam = currentExam;
            }

            var PosterDesignSkill = new Skill { Name = "Poster Design" };
            context.Skills.Add(PosterDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Poster Design");
            if (currentExam != null)
            {
                PosterDesignSkill.Exam = currentExam;
            }

            var PostgreSQLSkill = new Skill { Name = "PostgreSQL" };
            context.Skills.Add(PostgreSQLSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "PostgreSQL");
            if (currentExam != null)
            {
                PostgreSQLSkill.Exam = currentExam;
            }

            var PowerpointSkill = new Skill { Name = "Powerpoint" };
            context.Skills.Add(PowerpointSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Powerpoint");
            if (currentExam != null)
            {
                PowerpointSkill.Exam = currentExam;
            }

            var PreproductionSkill = new Skill { Name = "Pre-production" };
            context.Skills.Add(PreproductionSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Pre-production");
            if (currentExam != null)
            {
                PreproductionSkill.Exam = currentExam;
            }

            var PresentationsSkill = new Skill { Name = "Presentations" };
            context.Skills.Add(PresentationsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Presentations");
            if (currentExam != null)
            {
                PresentationsSkill.Exam = currentExam;
            }

            var PressReleasesSkill = new Skill { Name = "Press Releases" };
            context.Skills.Add(PressReleasesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Press Releases");
            if (currentExam != null)
            {
                PressReleasesSkill.Exam = currentExam;
            }

            var PrestashopSkill = new Skill { Name = "Prestashop" };
            context.Skills.Add(PrestashopSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Prestashop");
            if (currentExam != null)
            {
                PrestashopSkill.Exam = currentExam;
            }

            var PreziSkill = new Skill { Name = "Prezi" };
            context.Skills.Add(PreziSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Prezi");
            if (currentExam != null)
            {
                PreziSkill.Exam = currentExam;
            }

            var PrintSkill = new Skill { Name = "Print" };
            context.Skills.Add(PrintSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Print");
            if (currentExam != null)
            {
                PrintSkill.Exam = currentExam;
            }

            var ProcurementSkill = new Skill { Name = "Procurement" };
            context.Skills.Add(ProcurementSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Procurement");
            if (currentExam != null)
            {
                ProcurementSkill.Exam = currentExam;
            }

            var ProductDescriptionsSkill = new Skill { Name = "Product Descriptions" };
            context.Skills.Add(ProductDescriptionsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Product Descriptions");
            if (currentExam != null)
            {
                ProductDescriptionsSkill.Exam = currentExam;
            }

            var ProductDesignSkill = new Skill { Name = "Product Design" };
            context.Skills.Add(ProductDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Product Design");
            if (currentExam != null)
            {
                ProductDesignSkill.Exam = currentExam;
            }

            var ProductManagementSkill = new Skill { Name = "Product Management" };
            context.Skills.Add(ProductManagementSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Product Management");
            if (currentExam != null)
            {
                ProductManagementSkill.Exam = currentExam;
            }

            var ProductSourcingSkill = new Skill { Name = "Product Sourcing" };
            context.Skills.Add(ProductSourcingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Product Sourcing");
            if (currentExam != null)
            {
                ProductSourcingSkill.Exam = currentExam;
            }

            var ProjectManagementSkill = new Skill { Name = "Project Management" };
            context.Skills.Add(ProjectManagementSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Project Management");
            if (currentExam != null)
            {
                ProjectManagementSkill.Exam = currentExam;
            }

            var ProjectSchedulingSkill = new Skill { Name = "Project Scheduling" };
            context.Skills.Add(ProjectSchedulingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Project Scheduling");
            if (currentExam != null)
            {
                ProjectSchedulingSkill.Exam = currentExam;
            }

            var PrologSkill = new Skill { Name = "Prolog" };
            context.Skills.Add(PrologSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Prolog");
            if (currentExam != null)
            {
                PrologSkill.Exam = currentExam;
            }

            var ProofreadingSkill = new Skill { Name = "Proofreading" };
            context.Skills.Add(ProofreadingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Proofreading");
            if (currentExam != null)
            {
                ProofreadingSkill.Exam = currentExam;
            }

            var PropertyDevelopmentSkill = new Skill { Name = "Property Development" };
            context.Skills.Add(PropertyDevelopmentSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Property Development");
            if (currentExam != null)
            {
                PropertyDevelopmentSkill.Exam = currentExam;
            }

            var PropertyLawSkill = new Skill { Name = "Property Law" };
            context.Skills.Add(PropertyLawSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Property Law");
            if (currentExam != null)
            {
                PropertyLawSkill.Exam = currentExam;
            }

            var PropertyManagementSkill = new Skill { Name = "Property Management" };
            context.Skills.Add(PropertyManagementSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Property Management");
            if (currentExam != null)
            {
                PropertyManagementSkill.Exam = currentExam;
            }

            var ProposalBidWritingSkill = new Skill { Name = "Proposal/Bid Writing" };
            context.Skills.Add(ProposalBidWritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Proposal/Bid Writing");
            if (currentExam != null)
            {
                ProposalBidWritingSkill.Exam = currentExam;
            }

            var ProtoshareSkill = new Skill { Name = "Protoshare" };
            context.Skills.Add(ProtoshareSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Protoshare");
            if (currentExam != null)
            {
                ProtoshareSkill.Exam = currentExam;
            }

            var PSDtoHTMLSkill = new Skill { Name = "PSD to HTML" };
            context.Skills.Add(PSDtoHTMLSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "PSD to HTML");
            if (currentExam != null)
            {
                PSDtoHTMLSkill.Exam = currentExam;
            }

            var PSDCMSSkill = new Skill { Name = "PSD2CMS" };
            context.Skills.Add(PSDCMSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "PSD2CMS");
            if (currentExam != null)
            {
                PSDCMSSkill.Exam = currentExam;
            }

            var PsychologySkill = new Skill { Name = "Psychology" };
            context.Skills.Add(PsychologySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Psychology");
            if (currentExam != null)
            {
                PsychologySkill.Exam = currentExam;
            }

            var PublicRelationsSkill = new Skill { Name = "Public Relations" };
            context.Skills.Add(PublicRelationsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Public Relations");
            if (currentExam != null)
            {
                PublicRelationsSkill.Exam = currentExam;
            }

            var PublishingSkill = new Skill { Name = "Publishing" };
            context.Skills.Add(PublishingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Publishing");
            if (currentExam != null)
            {
                PublishingSkill.Exam = currentExam;
            }

            var PunjabiSkill = new Skill { Name = "Punjabi" };
            context.Skills.Add(PunjabiSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Punjabi");
            if (currentExam != null)
            {
                PunjabiSkill.Exam = currentExam;
            }

            var PuppetSkill = new Skill { Name = "Puppet" };
            context.Skills.Add(PuppetSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Puppet");
            if (currentExam != null)
            {
                PuppetSkill.Exam = currentExam;
            }

            var PythonSkill = new Skill { Name = "Python" };
            context.Skills.Add(PythonSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Python");
            if (currentExam != null)
            {
                PythonSkill.Exam = currentExam;
            }

            var QlikViewSkill = new Skill { Name = "QlikView" };
            context.Skills.Add(QlikViewSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "QlikView");
            if (currentExam != null)
            {
                QlikViewSkill.Exam = currentExam;
            }

            var QualtricsSurveyPlatformSkill = new Skill { Name = "Qualtrics Survey Platform" };
            context.Skills.Add(QualtricsSurveyPlatformSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Qualtrics Survey Platform");
            if (currentExam != null)
            {
                QualtricsSurveyPlatformSkill.Exam = currentExam;
            }

            var QuantumSkill = new Skill { Name = "Quantum" };
            context.Skills.Add(QuantumSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Quantum");
            if (currentExam != null)
            {
                QuantumSkill.Exam = currentExam;
            }

            var QuarkXPressSkill = new Skill { Name = "QuarkXPress" };
            context.Skills.Add(QuarkXPressSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "QuarkXPress");
            if (currentExam != null)
            {
                QuarkXPressSkill.Exam = currentExam;
            }

            var QuickBaseSkill = new Skill { Name = "QuickBase" };
            context.Skills.Add(QuickBaseSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "QuickBase");
            if (currentExam != null)
            {
                QuickBaseSkill.Exam = currentExam;
            }

            var QuickbooksampQuickenSkill = new Skill { Name = "Quickbooks &amp; Quicken" };
            context.Skills.Add(QuickbooksampQuickenSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Quickbooks &amp; Quicken");
            if (currentExam != null)
            {
                QuickbooksampQuickenSkill.Exam = currentExam;
            }

            var RProgrammingLanguageSkill = new Skill { Name = "R Programming Language" };
            context.Skills.Add(RProgrammingLanguageSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "R Programming Language");
            if (currentExam != null)
            {
                RProgrammingLanguageSkill.Exam = currentExam;
            }

            var ReactjsSkill = new Skill { Name = "React.js" };
            context.Skills.Add(ReactjsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "React.js");
            if (currentExam != null)
            {
                ReactjsSkill.Exam = currentExam;
            }

            var RealEstateSkill = new Skill { Name = "Real Estate" };
            context.Skills.Add(RealEstateSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Real Estate");
            if (currentExam != null)
            {
                RealEstateSkill.Exam = currentExam;
            }

            var REALbasicSkill = new Skill { Name = "REALbasic" };
            context.Skills.Add(REALbasicSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "REALbasic");
            if (currentExam != null)
            {
                REALbasicSkill.Exam = currentExam;
            }

            var RecruitmentSkill = new Skill { Name = "Recruitment" };
            context.Skills.Add(RecruitmentSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Recruitment");
            if (currentExam != null)
            {
                RecruitmentSkill.Exam = currentExam;
            }

            var RedHatSkill = new Skill { Name = "Red Hat" };
            context.Skills.Add(RedHatSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Red Hat");
            if (currentExam != null)
            {
                RedHatSkill.Exam = currentExam;
            }

            var RedisSkill = new Skill { Name = "Redis" };
            context.Skills.Add(RedisSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Redis");
            if (currentExam != null)
            {
                RedisSkill.Exam = currentExam;
            }

            var RemoteSensingSkill = new Skill { Name = "Remote Sensing" };
            context.Skills.Add(RemoteSensingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Remote Sensing");
            if (currentExam != null)
            {
                RemoteSensingSkill.Exam = currentExam;
            }

            var RemovalistSkill = new Skill { Name = "Removalist" };
            context.Skills.Add(RemovalistSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Removalist");
            if (currentExam != null)
            {
                RemovalistSkill.Exam = currentExam;
            }

            var RenewableEnergyDesignSkill = new Skill { Name = "Renewable Energy Design" };
            context.Skills.Add(RenewableEnergyDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Renewable Energy Design");
            if (currentExam != null)
            {
                RenewableEnergyDesignSkill.Exam = currentExam;
            }

            var ReportWritingSkill = new Skill { Name = "Report Writing" };
            context.Skills.Add(ReportWritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Report Writing");
            if (currentExam != null)
            {
                ReportWritingSkill.Exam = currentExam;
            }

            var ResearchSkill = new Skill { Name = "Research" };
            context.Skills.Add(ResearchSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Research");
            if (currentExam != null)
            {
                ResearchSkill.Exam = currentExam;
            }

            var RESTfulSkill = new Skill { Name = "RESTful" };
            context.Skills.Add(RESTfulSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "RESTful");
            if (currentExam != null)
            {
                RESTfulSkill.Exam = currentExam;
            }

            var ResumesSkill = new Skill { Name = "Resumes" };
            context.Skills.Add(ResumesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Resumes");
            if (currentExam != null)
            {
                ResumesSkill.Exam = currentExam;
            }

            var ReviewsSkill = new Skill { Name = "Reviews" };
            context.Skills.Add(ReviewsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Reviews");
            if (currentExam != null)
            {
                ReviewsSkill.Exam = currentExam;
            }

            var RiskManagementSkill = new Skill { Name = "Risk Management" };
            context.Skills.Add(RiskManagementSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Risk Management");
            if (currentExam != null)
            {
                RiskManagementSkill.Exam = currentExam;
            }

            var RoboticsSkill = new Skill { Name = "Robotics" };
            context.Skills.Add(RoboticsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Robotics");
            if (currentExam != null)
            {
                RoboticsSkill.Exam = currentExam;
            }

            var RocketEngineSkill = new Skill { Name = "Rocket Engine" };
            context.Skills.Add(RocketEngineSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Rocket Engine");
            if (currentExam != null)
            {
                RocketEngineSkill.Exam = currentExam;
            }

            var RomanianSkill = new Skill { Name = "Romanian" };
            context.Skills.Add(RomanianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Romanian");
            if (currentExam != null)
            {
                RomanianSkill.Exam = currentExam;
            }

            var RoofingSkill = new Skill { Name = "Roofing" };
            context.Skills.Add(RoofingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Roofing");
            if (currentExam != null)
            {
                RoofingSkill.Exam = currentExam;
            }

            var RTOSSkill = new Skill { Name = "RTOS" };
            context.Skills.Add(RTOSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "RTOS");
            if (currentExam != null)
            {
                RTOSSkill.Exam = currentExam;
            }

            var RubySkill = new Skill { Name = "Ruby" };
            context.Skills.Add(RubySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Ruby");
            if (currentExam != null)
            {
                RubySkill.Exam = currentExam;
            }

            var RubyonRailsSkill = new Skill { Name = "Ruby on Rails" };
            context.Skills.Add(RubyonRailsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Ruby on Rails");
            if (currentExam != null)
            {
                RubyonRailsSkill.Exam = currentExam;
            }

            var RussianSkill = new Skill { Name = "Russian" };
            context.Skills.Add(RussianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Russian");
            if (currentExam != null)
            {
                RussianSkill.Exam = currentExam;
            }

            var RWDSkill = new Skill { Name = "RWD" };
            context.Skills.Add(RWDSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "RWD");
            if (currentExam != null)
            {
                RWDSkill.Exam = currentExam;
            }

            var SalesSkill = new Skill { Name = "Sales" };
            context.Skills.Add(SalesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Sales");
            if (currentExam != null)
            {
                SalesSkill.Exam = currentExam;
            }

            var SalesforceAppDevelopmentSkill = new Skill { Name = "Salesforce App Development" };
            context.Skills.Add(SalesforceAppDevelopmentSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Salesforce App Development");
            if (currentExam != null)
            {
                SalesforceAppDevelopmentSkill.Exam = currentExam;
            }

            var SalesforcecomSkill = new Skill { Name = "Salesforce.com" };
            context.Skills.Add(SalesforcecomSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Salesforce.com");
            if (currentExam != null)
            {
                SalesforcecomSkill.Exam = currentExam;
            }

            var SamsungSkill = new Skill { Name = "Samsung" };
            context.Skills.Add(SamsungSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Samsung");
            if (currentExam != null)
            {
                SamsungSkill.Exam = currentExam;
            }

            var SamsungAccessorySDKSkill = new Skill { Name = "Samsung Accessory SDK" };
            context.Skills.Add(SamsungAccessorySDKSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Samsung Accessory SDK");
            if (currentExam != null)
            {
                SamsungAccessorySDKSkill.Exam = currentExam;
            }

            var SAPSkill = new Skill { Name = "SAP" };
            context.Skills.Add(SAPSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "SAP");
            if (currentExam != null)
            {
                SAPSkill.Exam = currentExam;
            }

            var SASSkill = new Skill { Name = "SAS" };
            context.Skills.Add(SASSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "SAS");
            if (currentExam != null)
            {
                SASSkill.Exam = currentExam;
            }

            var ScalaSkill = new Skill { Name = "Scala" };
            context.Skills.Add(ScalaSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Scala");
            if (currentExam != null)
            {
                ScalaSkill.Exam = currentExam;
            }

            var SchemeSkill = new Skill { Name = "Scheme" };
            context.Skills.Add(SchemeSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Scheme");
            if (currentExam != null)
            {
                SchemeSkill.Exam = currentExam;
            }

            var ScientificResearchSkill = new Skill { Name = "Scientific Research" };
            context.Skills.Add(ScientificResearchSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Scientific Research");
            if (currentExam != null)
            {
                ScientificResearchSkill.Exam = currentExam;
            }

            var ScreenwritingSkill = new Skill { Name = "Screenwriting" };
            context.Skills.Add(ScreenwritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Screenwriting");
            if (currentExam != null)
            {
                ScreenwritingSkill.Exam = currentExam;
            }

            var ScriptInstallSkill = new Skill { Name = "Script Install" };
            context.Skills.Add(ScriptInstallSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Script Install");
            if (currentExam != null)
            {
                ScriptInstallSkill.Exam = currentExam;
            }

            var ScrumSkill = new Skill { Name = "Scrum" };
            context.Skills.Add(ScrumSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Scrum");
            if (currentExam != null)
            {
                ScrumSkill.Exam = currentExam;
            }

            var ScrumDevelopmentSkill = new Skill { Name = "Scrum Development" };
            context.Skills.Add(ScrumDevelopmentSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Scrum Development");
            if (currentExam != null)
            {
                ScrumDevelopmentSkill.Exam = currentExam;
            }

            var SculpturingSkill = new Skill { Name = "Sculpturing" };
            context.Skills.Add(SculpturingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Sculpturing");
            if (currentExam != null)
            {
                SculpturingSkill.Exam = currentExam;
            }

            var SearchEngineMarketingSkill = new Skill { Name = "Search Engine Marketing" };
            context.Skills.Add(SearchEngineMarketingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Search Engine Marketing");
            if (currentExam != null)
            {
                SearchEngineMarketingSkill.Exam = currentExam;
            }

            var SenchaYahooUISkill = new Skill { Name = "Sencha / YahooUI" };
            context.Skills.Add(SenchaYahooUISkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Sencha / YahooUI");
            if (currentExam != null)
            {
                SenchaYahooUISkill.Exam = currentExam;
            }

            var SEOSkill = new Skill { Name = "SEO" };
            context.Skills.Add(SEOSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "SEO");
            if (currentExam != null)
            {
                SEOSkill.Exam = currentExam;
            }

            var SerbianSkill = new Skill { Name = "Serbian" };
            context.Skills.Add(SerbianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Serbian");
            if (currentExam != null)
            {
                SerbianSkill.Exam = currentExam;
            }

            var SewingSkill = new Skill { Name = "Sewing" };
            context.Skills.Add(SewingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Sewing");
            if (currentExam != null)
            {
                SewingSkill.Exam = currentExam;
            }

            var SharepointSkill = new Skill { Name = "Sharepoint" };
            context.Skills.Add(SharepointSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Sharepoint");
            if (currentExam != null)
            {
                SharepointSkill.Exam = currentExam;
            }

            var ShellScriptSkill = new Skill { Name = "Shell Script" };
            context.Skills.Add(ShellScriptSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Shell Script");
            if (currentExam != null)
            {
                ShellScriptSkill.Exam = currentExam;
            }

            var ShopifySkill = new Skill { Name = "Shopify" };
            context.Skills.Add(ShopifySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Shopify");
            if (currentExam != null)
            {
                ShopifySkill.Exam = currentExam;
            }

            var ShopifyTemplatesSkill = new Skill { Name = "Shopify Templates" };
            context.Skills.Add(ShopifyTemplatesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Shopify Templates");
            if (currentExam != null)
            {
                ShopifyTemplatesSkill.Exam = currentExam;
            }

            var ShoppingSkill = new Skill { Name = "Shopping" };
            context.Skills.Add(ShoppingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Shopping");
            if (currentExam != null)
            {
                ShoppingSkill.Exam = currentExam;
            }

            var ShoppingCartsSkill = new Skill { Name = "Shopping Carts" };
            context.Skills.Add(ShoppingCartsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Shopping Carts");
            if (currentExam != null)
            {
                ShoppingCartsSkill.Exam = currentExam;
            }

            var ShortStoriesSkill = new Skill { Name = "Short Stories" };
            context.Skills.Add(ShortStoriesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Short Stories");
            if (currentExam != null)
            {
                ShortStoriesSkill.Exam = currentExam;
            }

            var SiebelSkill = new Skill { Name = "Siebel" };
            context.Skills.Add(SiebelSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Siebel");
            if (currentExam != null)
            {
                SiebelSkill.Exam = currentExam;
            }

            var SilverlightSkill = new Skill { Name = "Silverlight" };
            context.Skills.Add(SilverlightSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Silverlight");
            if (currentExam != null)
            {
                SilverlightSkill.Exam = currentExam;
            }

            var SimplifiedChineseChinaSkill = new Skill { Name = "Simplified Chinese (China)" };
            context.Skills.Add(SimplifiedChineseChinaSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Simplified Chinese (China)");
            if (currentExam != null)
            {
                SimplifiedChineseChinaSkill.Exam = currentExam;
            }

            var SlogansSkill = new Skill { Name = "Slogans" };
            context.Skills.Add(SlogansSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Slogans");
            if (currentExam != null)
            {
                SlogansSkill.Exam = currentExam;
            }

            var SlovakianSkill = new Skill { Name = "Slovakian" };
            context.Skills.Add(SlovakianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Slovakian");
            if (currentExam != null)
            {
                SlovakianSkill.Exam = currentExam;
            }

            var SlovenianSkill = new Skill { Name = "Slovenian" };
            context.Skills.Add(SlovenianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Slovenian");
            if (currentExam != null)
            {
                SlovenianSkill.Exam = currentExam;
            }

            var SmartyPHPSkill = new Skill { Name = "Smarty PHP" };
            context.Skills.Add(SmartyPHPSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Smarty PHP");
            if (currentExam != null)
            {
                SmartyPHPSkill.Exam = currentExam;
            }

            var SnapchatSkill = new Skill { Name = "Snapchat" };
            context.Skills.Add(SnapchatSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Snapchat");
            if (currentExam != null)
            {
                SnapchatSkill.Exam = currentExam;
            }

            var SocialEngineSkill = new Skill { Name = "Social Engine" };
            context.Skills.Add(SocialEngineSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Social Engine");
            if (currentExam != null)
            {
                SocialEngineSkill.Exam = currentExam;
            }

            var SocialMediaMarketingSkill = new Skill { Name = "Social Media Marketing" };
            context.Skills.Add(SocialMediaMarketingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Social Media Marketing");
            if (currentExam != null)
            {
                SocialMediaMarketingSkill.Exam = currentExam;
            }

            var SocialNetworkingSkill = new Skill { Name = "Social Networking" };
            context.Skills.Add(SocialNetworkingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Social Networking");
            if (currentExam != null)
            {
                SocialNetworkingSkill.Exam = currentExam;
            }

            var SocketIOSkill = new Skill { Name = "Socket IO" };
            context.Skills.Add(SocketIOSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Socket IO");
            if (currentExam != null)
            {
                SocketIOSkill.Exam = currentExam;
            }

            var SoftwareArchitectureSkill = new Skill { Name = "Software Architecture" };
            context.Skills.Add(SoftwareArchitectureSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Software Architecture");
            if (currentExam != null)
            {
                SoftwareArchitectureSkill.Exam = currentExam;
            }

            var SoftwareDevelopmentSkill = new Skill { Name = "Software Development" };
            context.Skills.Add(SoftwareDevelopmentSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Software Development");
            if (currentExam != null)
            {
                SoftwareDevelopmentSkill.Exam = currentExam;
            }

            var SoftwareTestingSkill = new Skill { Name = "Software Testing" };
            context.Skills.Add(SoftwareTestingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Software Testing");
            if (currentExam != null)
            {
                SoftwareTestingSkill.Exam = currentExam;
            }

            var SolarisSkill = new Skill { Name = "Solaris" };
            context.Skills.Add(SolarisSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Solaris");
            if (currentExam != null)
            {
                SolarisSkill.Exam = currentExam;
            }

            var SolidworksSkill = new Skill { Name = "Solidworks" };
            context.Skills.Add(SolidworksSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Solidworks");
            if (currentExam != null)
            {
                SolidworksSkill.Exam = currentExam;
            }

            var SoundDesignSkill = new Skill { Name = "Sound Design" };
            context.Skills.Add(SoundDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Sound Design");
            if (currentExam != null)
            {
                SoundDesignSkill.Exam = currentExam;
            }

            var SpanishSkill = new Skill { Name = "Spanish" };
            context.Skills.Add(SpanishSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Spanish");
            if (currentExam != null)
            {
                SpanishSkill.Exam = currentExam;
            }

            var SpanishSpainSkill = new Skill { Name = "Spanish (Spain)" };
            context.Skills.Add(SpanishSpainSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Spanish (Spain)");
            if (currentExam != null)
            {
                SpanishSpainSkill.Exam = currentExam;
            }

            var SparkSkill = new Skill { Name = "Spark" };
            context.Skills.Add(SparkSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Spark");
            if (currentExam != null)
            {
                SparkSkill.Exam = currentExam;
            }

            var SpeechWritingSkill = new Skill { Name = "Speech Writing" };
            context.Skills.Add(SpeechWritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Speech Writing");
            if (currentExam != null)
            {
                SpeechWritingSkill.Exam = currentExam;
            }

            var SphinxSkill = new Skill { Name = "Sphinx" };
            context.Skills.Add(SphinxSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Sphinx");
            if (currentExam != null)
            {
                SphinxSkill.Exam = currentExam;
            }

            var SportsSkill = new Skill { Name = "Sports" };
            context.Skills.Add(SportsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Sports");
            if (currentExam != null)
            {
                SportsSkill.Exam = currentExam;
            }

            var SPSSStatisticsSkill = new Skill { Name = "SPSS Statistics" };
            context.Skills.Add(SPSSStatisticsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "SPSS Statistics");
            if (currentExam != null)
            {
                SPSSStatisticsSkill.Exam = currentExam;
            }

            var SQLSkill = new Skill { Name = "SQL" };
            context.Skills.Add(SQLSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "SQL");
            if (currentExam != null)
            {
                SQLSkill.Exam = currentExam;
            }

            var SQLiteSkill = new Skill { Name = "SQLite" };
            context.Skills.Add(SQLiteSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "SQLite");
            if (currentExam != null)
            {
                SQLiteSkill.Exam = currentExam;
            }

            var SquarespaceSkill = new Skill { Name = "Squarespace" };
            context.Skills.Add(SquarespaceSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Squarespace");
            if (currentExam != null)
            {
                SquarespaceSkill.Exam = currentExam;
            }

            var StartupsSkill = new Skill { Name = "Startups" };
            context.Skills.Add(StartupsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Startups");
            if (currentExam != null)
            {
                StartupsSkill.Exam = currentExam;
            }

            var StationeryDesignSkill = new Skill { Name = "Stationery Design" };
            context.Skills.Add(StationeryDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Stationery Design");
            if (currentExam != null)
            {
                StationeryDesignSkill.Exam = currentExam;
            }

            var StatisticalAnalysisSkill = new Skill { Name = "Statistical Analysis" };
            context.Skills.Add(StatisticalAnalysisSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Statistical Analysis");
            if (currentExam != null)
            {
                StatisticalAnalysisSkill.Exam = currentExam;
            }

            var StatisticsSkill = new Skill { Name = "Statistics" };
            context.Skills.Add(StatisticsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Statistics");
            if (currentExam != null)
            {
                StatisticsSkill.Exam = currentExam;
            }

            var SteamAPISkill = new Skill { Name = "Steam API" };
            context.Skills.Add(SteamAPISkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Steam API");
            if (currentExam != null)
            {
                SteamAPISkill.Exam = currentExam;
            }

            var StickerDesignSkill = new Skill { Name = "Sticker Design" };
            context.Skills.Add(StickerDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Sticker Design");
            if (currentExam != null)
            {
                StickerDesignSkill.Exam = currentExam;
            }

            var StripeSkill = new Skill { Name = "Stripe" };
            context.Skills.Add(StripeSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Stripe");
            if (currentExam != null)
            {
                StripeSkill.Exam = currentExam;
            }

            var StructuralEngineeringSkill = new Skill { Name = "Structural Engineering" };
            context.Skills.Add(StructuralEngineeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Structural Engineering");
            if (currentExam != null)
            {
                StructuralEngineeringSkill.Exam = currentExam;
            }

            var SugarCRMSkill = new Skill { Name = "SugarCRM" };
            context.Skills.Add(SugarCRMSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "SugarCRM");
            if (currentExam != null)
            {
                SugarCRMSkill.Exam = currentExam;
            }

            var SupplierSourcingSkill = new Skill { Name = "Supplier Sourcing" };
            context.Skills.Add(SupplierSourcingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Supplier Sourcing");
            if (currentExam != null)
            {
                SupplierSourcingSkill.Exam = currentExam;
            }

            var SurfboardDesignSkill = new Skill { Name = "Surfboard Design" };
            context.Skills.Add(SurfboardDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Surfboard Design");
            if (currentExam != null)
            {
                SurfboardDesignSkill.Exam = currentExam;
            }

            var SwedishSkill = new Skill { Name = "Swedish" };
            context.Skills.Add(SwedishSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Swedish");
            if (currentExam != null)
            {
                SwedishSkill.Exam = currentExam;
            }

            var SwiftSkill = new Skill { Name = "Swift" };
            context.Skills.Add(SwiftSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Swift");
            if (currentExam != null)
            {
                SwiftSkill.Exam = currentExam;
            }

            var SymbianSkill = new Skill { Name = "Symbian" };
            context.Skills.Add(SymbianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Symbian");
            if (currentExam != null)
            {
                SymbianSkill.Exam = currentExam;
            }

            var SymfonyPHPSkill = new Skill { Name = "Symfony PHP" };
            context.Skills.Add(SymfonyPHPSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Symfony PHP");
            if (currentExam != null)
            {
                SymfonyPHPSkill.Exam = currentExam;
            }

            var SystemAdminSkill = new Skill { Name = "System Admin" };
            context.Skills.Add(SystemAdminSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "System Admin");
            if (currentExam != null)
            {
                SystemAdminSkill.Exam = currentExam;
            }

            var TShirtsSkill = new Skill { Name = "T-Shirts" };
            context.Skills.Add(TShirtsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "T-Shirts");
            if (currentExam != null)
            {
                TShirtsSkill.Exam = currentExam;
            }

            var TamilSkill = new Skill { Name = "Tamil" };
            context.Skills.Add(TamilSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Tamil");
            if (currentExam != null)
            {
                TamilSkill.Exam = currentExam;
            }

            var TaoBaoAPISkill = new Skill { Name = "TaoBao API" };
            context.Skills.Add(TaoBaoAPISkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "TaoBao API");
            if (currentExam != null)
            {
                TaoBaoAPISkill.Exam = currentExam;
            }

            var TattooDesignSkill = new Skill { Name = "Tattoo Design" };
            context.Skills.Add(TattooDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Tattoo Design");
            if (currentExam != null)
            {
                TattooDesignSkill.Exam = currentExam;
            }

            var TaxSkill = new Skill { Name = "Tax" };
            context.Skills.Add(TaxSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Tax");
            if (currentExam != null)
            {
                TaxSkill.Exam = currentExam;
            }

            var TaxLawSkill = new Skill { Name = "Tax Law" };
            context.Skills.Add(TaxLawSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Tax Law");
            if (currentExam != null)
            {
                TaxLawSkill.Exam = currentExam;
            }

            var TechnicalSupportSkill = new Skill { Name = "Technical Support" };
            context.Skills.Add(TechnicalSupportSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Technical Support");
            if (currentExam != null)
            {
                TechnicalSupportSkill.Exam = currentExam;
            }

            var TechnicalWritingSkill = new Skill { Name = "Technical Writing" };
            context.Skills.Add(TechnicalWritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Technical Writing");
            if (currentExam != null)
            {
                TechnicalWritingSkill.Exam = currentExam;
            }

            var TelecommunicationsEngineeringSkill = new Skill { Name = "Telecommunications Engineering" };
            context.Skills.Add(TelecommunicationsEngineeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Telecommunications Engineering");
            if (currentExam != null)
            {
                TelecommunicationsEngineeringSkill.Exam = currentExam;
            }

            var TelemarketingSkill = new Skill { Name = "Telemarketing" };
            context.Skills.Add(TelemarketingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Telemarketing");
            if (currentExam != null)
            {
                TelemarketingSkill.Exam = currentExam;
            }

            var TelephoneHandlingSkill = new Skill { Name = "Telephone Handling" };
            context.Skills.Add(TelephoneHandlingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Telephone Handling");
            if (currentExam != null)
            {
                TelephoneHandlingSkill.Exam = currentExam;
            }

            var TeluguSkill = new Skill { Name = "Telugu" };
            context.Skills.Add(TeluguSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Telugu");
            if (currentExam != null)
            {
                TeluguSkill.Exam = currentExam;
            }

            var TemplatesSkill = new Skill { Name = "Templates" };
            context.Skills.Add(TemplatesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Templates");
            if (currentExam != null)
            {
                TemplatesSkill.Exam = currentExam;
            }

            var TestAutomationSkill = new Skill { Name = "Test Automation" };
            context.Skills.Add(TestAutomationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Test Automation");
            if (currentExam != null)
            {
                TestAutomationSkill.Exam = currentExam;
            }

            var TestingQASkill = new Skill { Name = "Testing / QA" };
            context.Skills.Add(TestingQASkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Testing / QA");
            if (currentExam != null)
            {
                TestingQASkill.Exam = currentExam;
            }

            var TestStandSkill = new Skill { Name = "TestStand" };
            context.Skills.Add(TestStandSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "TestStand");
            if (currentExam != null)
            {
                TestStandSkill.Exam = currentExam;
            }

            var TextileEngineeringSkill = new Skill { Name = "Textile Engineering" };
            context.Skills.Add(TextileEngineeringSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Textile Engineering");
            if (currentExam != null)
            {
                TextileEngineeringSkill.Exam = currentExam;
            }

            var ThaiSkill = new Skill { Name = "Thai" };
            context.Skills.Add(ThaiSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Thai");
            if (currentExam != null)
            {
                ThaiSkill.Exam = currentExam;
            }

            var TilingSkill = new Skill { Name = "Tiling" };
            context.Skills.Add(TilingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Tiling");
            if (currentExam != null)
            {
                TilingSkill.Exam = currentExam;
            }

            var TimeManagementSkill = new Skill { Name = "Time Management" };
            context.Skills.Add(TimeManagementSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Time Management");
            if (currentExam != null)
            {
                TimeManagementSkill.Exam = currentExam;
            }

            var TizenSDKforWearablesSkill = new Skill { Name = "Tizen SDK for Wearables" };
            context.Skills.Add(TizenSDKforWearablesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Tizen SDK for Wearables");
            if (currentExam != null)
            {
                TizenSDKforWearablesSkill.Exam = currentExam;
            }

            var TraditionalChineseHongKongSkill = new Skill { Name = "Traditional Chinese (Hong Kong)" };
            context.Skills.Add(TraditionalChineseHongKongSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Traditional Chinese (Hong Kong)");
            if (currentExam != null)
            {
                TraditionalChineseHongKongSkill.Exam = currentExam;
            }

            var TraditionalChineseTaiwanSkill = new Skill { Name = "Traditional Chinese (Taiwan)" };
            context.Skills.Add(TraditionalChineseTaiwanSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Traditional Chinese (Taiwan)");
            if (currentExam != null)
            {
                TraditionalChineseTaiwanSkill.Exam = currentExam;
            }

            var TrainingSkill = new Skill { Name = "Training" };
            context.Skills.Add(TrainingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Training");
            if (currentExam != null)
            {
                TrainingSkill.Exam = currentExam;
            }

            var TranscriptionSkill = new Skill { Name = "Transcription" };
            context.Skills.Add(TranscriptionSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Transcription");
            if (currentExam != null)
            {
                TranscriptionSkill.Exam = currentExam;
            }

            var TranslationSkill = new Skill { Name = "Translation" };
            context.Skills.Add(TranslationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Translation");
            if (currentExam != null)
            {
                TranslationSkill.Exam = currentExam;
            }

            var TravelWritingSkill = new Skill { Name = "Travel Writing" };
            context.Skills.Add(TravelWritingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Travel Writing");
            if (currentExam != null)
            {
                TravelWritingSkill.Exam = currentExam;
            }

            var TroubleshootingSkill = new Skill { Name = "Troubleshooting" };
            context.Skills.Add(TroubleshootingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Troubleshooting");
            if (currentExam != null)
            {
                TroubleshootingSkill.Exam = currentExam;
            }

            var TumblrSkill = new Skill { Name = "Tumblr" };
            context.Skills.Add(TumblrSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Tumblr");
            if (currentExam != null)
            {
                TumblrSkill.Exam = currentExam;
            }

            var TurkishSkill = new Skill { Name = "Turkish" };
            context.Skills.Add(TurkishSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Turkish");
            if (currentExam != null)
            {
                TurkishSkill.Exam = currentExam;
            }

            var TwitterSkill = new Skill { Name = "Twitter" };
            context.Skills.Add(TwitterSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Twitter");
            if (currentExam != null)
            {
                TwitterSkill.Exam = currentExam;
            }

            var TYPOSkill = new Skill { Name = "TYPO3" };
            context.Skills.Add(TYPOSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "TYPO3");
            if (currentExam != null)
            {
                TYPOSkill.Exam = currentExam;
            }

            var TypographySkill = new Skill { Name = "Typography" };
            context.Skills.Add(TypographySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Typography");
            if (currentExam != null)
            {
                TypographySkill.Exam = currentExam;
            }

            var UbuntuSkill = new Skill { Name = "Ubuntu" };
            context.Skills.Add(UbuntuSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Ubuntu");
            if (currentExam != null)
            {
                UbuntuSkill.Exam = currentExam;
            }

            var UkranianSkill = new Skill { Name = "Ukranian" };
            context.Skills.Add(UkranianSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Ukranian");
            if (currentExam != null)
            {
                UkranianSkill.Exam = currentExam;
            }

            var UmbracoSkill = new Skill { Name = "Umbraco" };
            context.Skills.Add(UmbracoSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Umbraco");
            if (currentExam != null)
            {
                UmbracoSkill.Exam = currentExam;
            }

            var UMLDesignSkill = new Skill { Name = "UML Design" };
            context.Skills.Add(UMLDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "UML Design");
            if (currentExam != null)
            {
                UMLDesignSkill.Exam = currentExam;
            }

            var UnityDSkill = new Skill { Name = "Unity 3D" };
            context.Skills.Add(UnityDSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Unity 3D");
            if (currentExam != null)
            {
                UnityDSkill.Exam = currentExam;
            }

            var UNIXSkill = new Skill { Name = "UNIX" };
            context.Skills.Add(UNIXSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "UNIX");
            if (currentExam != null)
            {
                UNIXSkill.Exam = currentExam;
            }

            var UrduSkill = new Skill { Name = "Urdu" };
            context.Skills.Add(UrduSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Urdu");
            if (currentExam != null)
            {
                UrduSkill.Exam = currentExam;
            }

            var UsabilityTestingSkill = new Skill { Name = "Usability Testing" };
            context.Skills.Add(UsabilityTestingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Usability Testing");
            if (currentExam != null)
            {
                UsabilityTestingSkill.Exam = currentExam;
            }

            var UserExperienceDesignSkill = new Skill { Name = "User Experience Design" };
            context.Skills.Add(UserExperienceDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "User Experience Design");
            if (currentExam != null)
            {
                UserExperienceDesignSkill.Exam = currentExam;
            }

            var UserInterfaceIASkill = new Skill { Name = "User Interface / IA" };
            context.Skills.Add(UserInterfaceIASkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "User Interface / IA");
            if (currentExam != null)
            {
                UserInterfaceIASkill.Exam = currentExam;
            }

            var ValuationampAppraisalSkill = new Skill { Name = "Valuation &amp; Appraisal" };
            context.Skills.Add(ValuationampAppraisalSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Valuation &amp; Appraisal");
            if (currentExam != null)
            {
                ValuationampAppraisalSkill.Exam = currentExam;
            }

            var VBNETSkill = new Skill { Name = "VB.NET" };
            context.Skills.Add(VBNETSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "VB.NET");
            if (currentExam != null)
            {
                VBNETSkill.Exam = currentExam;
            }

            var vBulletinSkill = new Skill { Name = "vBulletin" };
            context.Skills.Add(vBulletinSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "vBulletin");
            if (currentExam != null)
            {
                vBulletinSkill.Exam = currentExam;
            }

            var VerilogVHDLSkill = new Skill { Name = "Verilog / VHDL" };
            context.Skills.Add(VerilogVHDLSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Verilog / VHDL");
            if (currentExam != null)
            {
                VerilogVHDLSkill.Exam = currentExam;
            }

            var VertexFXSkill = new Skill { Name = "VertexFX" };
            context.Skills.Add(VertexFXSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "VertexFX");
            if (currentExam != null)
            {
                VertexFXSkill.Exam = currentExam;
            }

            var VideoBroadcastingSkill = new Skill { Name = "Video Broadcasting" };
            context.Skills.Add(VideoBroadcastingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Video Broadcasting");
            if (currentExam != null)
            {
                VideoBroadcastingSkill.Exam = currentExam;
            }

            var VideoEditingSkill = new Skill { Name = "Video Editing" };
            context.Skills.Add(VideoEditingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Video Editing");
            if (currentExam != null)
            {
                VideoEditingSkill.Exam = currentExam;
            }

            var VideoProductionSkill = new Skill { Name = "Video Production" };
            context.Skills.Add(VideoProductionSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Video Production");
            if (currentExam != null)
            {
                VideoProductionSkill.Exam = currentExam;
            }

            var VideoServicesSkill = new Skill { Name = "Video Services" };
            context.Skills.Add(VideoServicesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Video Services");
            if (currentExam != null)
            {
                VideoServicesSkill.Exam = currentExam;
            }

            var VideoUploadSkill = new Skill { Name = "Video Upload" };
            context.Skills.Add(VideoUploadSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Video Upload");
            if (currentExam != null)
            {
                VideoUploadSkill.Exam = currentExam;
            }

            var VideographySkill = new Skill { Name = "Videography" };
            context.Skills.Add(VideographySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Videography");
            if (currentExam != null)
            {
                VideographySkill.Exam = currentExam;
            }

            var VietnameseSkill = new Skill { Name = "Vietnamese" };
            context.Skills.Add(VietnameseSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Vietnamese");
            if (currentExam != null)
            {
                VietnameseSkill.Exam = currentExam;
            }

            var ViralMarketingSkill = new Skill { Name = "Viral Marketing" };
            context.Skills.Add(ViralMarketingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Viral Marketing");
            if (currentExam != null)
            {
                ViralMarketingSkill.Exam = currentExam;
            }

            var VirtualAssistantSkill = new Skill { Name = "Virtual Assistant" };
            context.Skills.Add(VirtualAssistantSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Virtual Assistant");
            if (currentExam != null)
            {
                VirtualAssistantSkill.Exam = currentExam;
            }

            var VirtualWorldsSkill = new Skill { Name = "Virtual Worlds" };
            context.Skills.Add(VirtualWorldsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Virtual Worlds");
            if (currentExam != null)
            {
                VirtualWorldsSkill.Exam = currentExam;
            }

            var VirtuemartSkill = new Skill { Name = "Virtuemart" };
            context.Skills.Add(VirtuemartSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Virtuemart");
            if (currentExam != null)
            {
                VirtuemartSkill.Exam = currentExam;
            }

            var VirtuozzoSkill = new Skill { Name = "Virtuozzo" };
            context.Skills.Add(VirtuozzoSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Virtuozzo");
            if (currentExam != null)
            {
                VirtuozzoSkill.Exam = currentExam;
            }

            var VisaImmigrationSkill = new Skill { Name = "Visa / Immigration" };
            context.Skills.Add(VisaImmigrationSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Visa / Immigration");
            if (currentExam != null)
            {
                VisaImmigrationSkill.Exam = currentExam;
            }

            var VisualArtsSkill = new Skill { Name = "Visual Arts" };
            context.Skills.Add(VisualArtsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Visual Arts");
            if (currentExam != null)
            {
                VisualArtsSkill.Exam = currentExam;
            }

            var VisualBasicSkill = new Skill { Name = "Visual Basic" };
            context.Skills.Add(VisualBasicSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Visual Basic");
            if (currentExam != null)
            {
                VisualBasicSkill.Exam = currentExam;
            }

            var VisualBasicforAppsSkill = new Skill { Name = "Visual Basic for Apps" };
            context.Skills.Add(VisualBasicforAppsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Visual Basic for Apps");
            if (currentExam != null)
            {
                VisualBasicforAppsSkill.Exam = currentExam;
            }

            var VisualFoxproSkill = new Skill { Name = "Visual Foxpro" };
            context.Skills.Add(VisualFoxproSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Visual Foxpro");
            if (currentExam != null)
            {
                VisualFoxproSkill.Exam = currentExam;
            }

            var VMwareSkill = new Skill { Name = "VMware" };
            context.Skills.Add(VMwareSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "VMware");
            if (currentExam != null)
            {
                VMwareSkill.Exam = currentExam;
            }

            var VoiceTalentSkill = new Skill { Name = "Voice Talent" };
            context.Skills.Add(VoiceTalentSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Voice Talent");
            if (currentExam != null)
            {
                VoiceTalentSkill.Exam = currentExam;
            }

            var VoiceXMLSkill = new Skill { Name = "VoiceXML" };
            context.Skills.Add(VoiceXMLSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "VoiceXML");
            if (currentExam != null)
            {
                VoiceXMLSkill.Exam = currentExam;
            }

            var VoIPSkill = new Skill { Name = "VoIP" };
            context.Skills.Add(VoIPSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "VoIP");
            if (currentExam != null)
            {
                VoIPSkill.Exam = currentExam;
            }

            var VolusionSkill = new Skill { Name = "Volusion" };
            context.Skills.Add(VolusionSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Volusion");
            if (currentExam != null)
            {
                VolusionSkill.Exam = currentExam;
            }

            var VPSSkill = new Skill { Name = "VPS" };
            context.Skills.Add(VPSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "VPS");
            if (currentExam != null)
            {
                VPSSkill.Exam = currentExam;
            }

            var vTigerSkill = new Skill { Name = "vTiger" };
            context.Skills.Add(vTigerSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "vTiger");
            if (currentExam != null)
            {
                vTigerSkill.Exam = currentExam;
            }

            var VuforiaSkill = new Skill { Name = "Vuforia" };
            context.Skills.Add(VuforiaSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Vuforia");
            if (currentExam != null)
            {
                VuforiaSkill.Exam = currentExam;
            }

            var WatchKitSkill = new Skill { Name = "WatchKit" };
            context.Skills.Add(WatchKitSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "WatchKit");
            if (currentExam != null)
            {
                WatchKitSkill.Exam = currentExam;
            }

            var WebHostingSkill = new Skill { Name = "Web Hosting" };
            context.Skills.Add(WebHostingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Web Hosting");
            if (currentExam != null)
            {
                WebHostingSkill.Exam = currentExam;
            }

            var WebScrapingSkill = new Skill { Name = "Web Scraping" };
            context.Skills.Add(WebScrapingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Web Scraping");
            if (currentExam != null)
            {
                WebScrapingSkill.Exam = currentExam;
            }

            var WebSearchSkill = new Skill { Name = "Web Search" };
            context.Skills.Add(WebSearchSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Web Search");
            if (currentExam != null)
            {
                WebSearchSkill.Exam = currentExam;
            }

            var WebSecuritySkill = new Skill { Name = "Web Security" };
            context.Skills.Add(WebSecuritySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Web Security");
            if (currentExam != null)
            {
                WebSecuritySkill.Exam = currentExam;
            }

            var WebServicesSkill = new Skill { Name = "Web Services" };
            context.Skills.Add(WebServicesSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Web Services");
            if (currentExam != null)
            {
                WebServicesSkill.Exam = currentExam;
            }

            var webMethodsSkill = new Skill { Name = "webMethods" };
            context.Skills.Add(webMethodsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "webMethods");
            if (currentExam != null)
            {
                webMethodsSkill.Exam = currentExam;
            }

            var WebOSSkill = new Skill { Name = "WebOS" };
            context.Skills.Add(WebOSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "WebOS");
            if (currentExam != null)
            {
                WebOSSkill.Exam = currentExam;
            }

            var WebsiteDesignSkill = new Skill { Name = "Website Design" };
            context.Skills.Add(WebsiteDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Website Design");
            if (currentExam != null)
            {
                WebsiteDesignSkill.Exam = currentExam;
            }

            var WebsiteManagementSkill = new Skill { Name = "Website Management" };
            context.Skills.Add(WebsiteManagementSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Website Management");
            if (currentExam != null)
            {
                WebsiteManagementSkill.Exam = currentExam;
            }

            var WebsiteTestingSkill = new Skill { Name = "Website Testing" };
            context.Skills.Add(WebsiteTestingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Website Testing");
            if (currentExam != null)
            {
                WebsiteTestingSkill.Exam = currentExam;
            }

            var WeddingsSkill = new Skill { Name = "Weddings" };
            context.Skills.Add(WeddingsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Weddings");
            if (currentExam != null)
            {
                WeddingsSkill.Exam = currentExam;
            }

            var WeeblySkill = new Skill { Name = "Weebly" };
            context.Skills.Add(WeeblySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Weebly");
            if (currentExam != null)
            {
                WeeblySkill.Exam = currentExam;
            }

            var WelshSkill = new Skill { Name = "Welsh" };
            context.Skills.Add(WelshSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Welsh");
            if (currentExam != null)
            {
                WelshSkill.Exam = currentExam;
            }

            var WHMCSSkill = new Skill { Name = "WHMCS" };
            context.Skills.Add(WHMCSSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "WHMCS");
            if (currentExam != null)
            {
                WHMCSSkill.Exam = currentExam;
            }

            var WIKISkill = new Skill { Name = "WIKI" };
            context.Skills.Add(WIKISkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "WIKI");
            if (currentExam != null)
            {
                WIKISkill.Exam = currentExam;
            }

            var WikipediaSkill = new Skill { Name = "Wikipedia" };
            context.Skills.Add(WikipediaSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Wikipedia");
            if (currentExam != null)
            {
                WikipediaSkill.Exam = currentExam;
            }

            var WindowsSkill = new Skill { Name = "Windows 8" };
            context.Skills.Add(WindowsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Windows 8");
            if (currentExam != null)
            {
                WindowsSkill.Exam = currentExam;
            }

            var WindowsAPISkill = new Skill { Name = "Windows API" };
            context.Skills.Add(WindowsAPISkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Windows API");
            if (currentExam != null)
            {
                WindowsAPISkill.Exam = currentExam;
            }

            var WindowsCESkill = new Skill { Name = "Windows CE" };
            context.Skills.Add(WindowsCESkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Windows CE");
            if (currentExam != null)
            {
                WindowsCESkill.Exam = currentExam;
            }

            var WindowsDesktopSkill = new Skill { Name = "Windows Desktop" };
            context.Skills.Add(WindowsDesktopSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Windows Desktop");
            if (currentExam != null)
            {
                WindowsDesktopSkill.Exam = currentExam;
            }

            var WindowsMobileSkill = new Skill { Name = "Windows Mobile" };
            context.Skills.Add(WindowsMobileSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Windows Mobile");
            if (currentExam != null)
            {
                WindowsMobileSkill.Exam = currentExam;
            }

            var WindowsPhoneSkill = new Skill { Name = "Windows Phone" };
            context.Skills.Add(WindowsPhoneSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Windows Phone");
            if (currentExam != null)
            {
                WindowsPhoneSkill.Exam = currentExam;
            }

            var WindowsServerSkill = new Skill { Name = "Windows Server" };
            context.Skills.Add(WindowsServerSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Windows Server");
            if (currentExam != null)
            {
                WindowsServerSkill.Exam = currentExam;
            }

            var WirelessSkill = new Skill { Name = "Wireless" };
            context.Skills.Add(WirelessSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Wireless");
            if (currentExam != null)
            {
                WirelessSkill.Exam = currentExam;
            }

            var WixSkill = new Skill { Name = "Wix" };
            context.Skills.Add(WixSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Wix");
            if (currentExam != null)
            {
                WixSkill.Exam = currentExam;
            }

            var WolframSkill = new Skill { Name = "Wolfram" };
            context.Skills.Add(WolframSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Wolfram");
            if (currentExam != null)
            {
                WolframSkill.Exam = currentExam;
            }

            var WooCommerceSkill = new Skill { Name = "WooCommerce" };
            context.Skills.Add(WooCommerceSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "WooCommerce");
            if (currentExam != null)
            {
                WooCommerceSkill.Exam = currentExam;
            }

            var WordSkill = new Skill { Name = "Word" };
            context.Skills.Add(WordSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Word");
            if (currentExam != null)
            {
                WordSkill.Exam = currentExam;
            }

            var WordProcessingSkill = new Skill { Name = "Word Processing" };
            context.Skills.Add(WordProcessingSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Word Processing");
            if (currentExam != null)
            {
                WordProcessingSkill.Exam = currentExam;
            }

            var WordpressSkill = new Skill { Name = "Wordpress" };
            context.Skills.Add(WordpressSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Wordpress");
            if (currentExam != null)
            {
                WordpressSkill.Exam = currentExam;
            }

            var WorkshopsSkill = new Skill { Name = "Workshops" };
            context.Skills.Add(WorkshopsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Workshops");
            if (currentExam != null)
            {
                WorkshopsSkill.Exam = currentExam;
            }

            var WPFSkill = new Skill { Name = "WPF" };
            context.Skills.Add(WPFSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "WPF");
            if (currentExam != null)
            {
                WPFSkill.Exam = currentExam;
            }

            var WufooSkill = new Skill { Name = "Wufoo" };
            context.Skills.Add(WufooSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Wufoo");
            if (currentExam != null)
            {
                WufooSkill.Exam = currentExam;
            }

            var xxAssemblerSkill = new Skill { Name = "x86/x64 Assembler" };
            context.Skills.Add(xxAssemblerSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "x86/x64 Assembler");
            if (currentExam != null)
            {
                xxAssemblerSkill.Exam = currentExam;
            }

            var XeroSkill = new Skill { Name = "Xero" };
            context.Skills.Add(XeroSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Xero");
            if (currentExam != null)
            {
                XeroSkill.Exam = currentExam;
            }

            var XMLSkill = new Skill { Name = "XML" };
            context.Skills.Add(XMLSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "XML");
            if (currentExam != null)
            {
                XMLSkill.Exam = currentExam;
            }

            var XMPPSkill = new Skill { Name = "XMPP" };
            context.Skills.Add(XMPPSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "XMPP");
            if (currentExam != null)
            {
                XMPPSkill.Exam = currentExam;
            }

            var XoopsSkill = new Skill { Name = "Xoops" };
            context.Skills.Add(XoopsSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Xoops");
            if (currentExam != null)
            {
                XoopsSkill.Exam = currentExam;
            }

            var XQuerySkill = new Skill { Name = "XQuery" };
            context.Skills.Add(XQuerySkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "XQuery");
            if (currentExam != null)
            {
                XQuerySkill.Exam = currentExam;
            }

            var XSLTSkill = new Skill { Name = "XSLT" };
            context.Skills.Add(XSLTSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "XSLT");
            if (currentExam != null)
            {
                XSLTSkill.Exam = currentExam;
            }

            var XXXSkill = new Skill { Name = "XXX" };
            context.Skills.Add(XXXSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "XXX");
            if (currentExam != null)
            {
                XXXSkill.Exam = currentExam;
            }

            var YahooStoreDesignSkill = new Skill { Name = "Yahoo! Store Design" };
            context.Skills.Add(YahooStoreDesignSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Yahoo! Store Design");
            if (currentExam != null)
            {
                YahooStoreDesignSkill.Exam = currentExam;
            }

            var YardWorkampRemovalSkill = new Skill { Name = "Yard Work &amp; Removal" };
            context.Skills.Add(YardWorkampRemovalSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Yard Work &amp; Removal");
            if (currentExam != null)
            {
                YardWorkampRemovalSkill.Exam = currentExam;
            }

            var YarnSkill = new Skill { Name = "Yarn" };
            context.Skills.Add(YarnSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Yarn");
            if (currentExam != null)
            {
                YarnSkill.Exam = currentExam;
            }

            var YiiSkill = new Skill { Name = "Yii" };
            context.Skills.Add(YiiSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Yii");
            if (currentExam != null)
            {
                YiiSkill.Exam = currentExam;
            }

            var YouTubeSkill = new Skill { Name = "YouTube" };
            context.Skills.Add(YouTubeSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "YouTube");
            if (currentExam != null)
            {
                YouTubeSkill.Exam = currentExam;
            }

            var ZenCartSkill = new Skill { Name = "Zen Cart" };
            context.Skills.Add(ZenCartSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Zen Cart");
            if (currentExam != null)
            {
                ZenCartSkill.Exam = currentExam;
            }

            var ZendSkill = new Skill { Name = "Zend" };
            context.Skills.Add(ZendSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Zend");
            if (currentExam != null)
            {
                ZendSkill.Exam = currentExam;
            }

            var ZendeskSkill = new Skill { Name = "Zendesk" };
            context.Skills.Add(ZendeskSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Zendesk");
            if (currentExam != null)
            {
                ZendeskSkill.Exam = currentExam;
            }

            var ZohoSkill = new Skill { Name = "Zoho" };
            context.Skills.Add(ZohoSkill);
            currentExam = context.Exams.FirstOrDefault(x => x.Name == "Zoho");
            if (currentExam != null)
            {
                ZohoSkill.Exam = currentExam;
            }

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

                // DOTNETExam.Employees.Add(kiborkUser);
                // kiborkUser.Skills.Add(dotNETSkill);
            }
          
            context.SaveChanges();
        }
    }
}
