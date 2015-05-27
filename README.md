# Freelancer
ASP.NET MVC Project

# TODO:
- roles
- bidding to project
- notification signalR 

- ajax projects ( paging, signalR)
- adding employees to project
- bookmarking 
- list of projectEmployees (view, check status, change status, add comments, notification - all employees finish project notification)
- user profiles ( if user is logged in - view projects, view skills, add skills, exams)
- seed method - add exams and questions / skills

#Updates:
27.05.2015:
-	added properties "data" and "userProfile" in BaseController.
-	updated getters "Data" and "UserProfile" in BaseController.
-	removed "CheckUsername" from "HomeController" because there is internal checker for allready exists username
-	migrations set in HomeController's constructor

IMPORTANT:
If you recive AspNetUsers allready exists. Just type:
	"update-database -Verbose"
in package manager console
