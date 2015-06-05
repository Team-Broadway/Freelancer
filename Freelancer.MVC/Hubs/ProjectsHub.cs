using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Freelancer.MVC.Controllers;
using Freelancer.MVC.Models;
using Freelancer.Models;

namespace Twitter.MVC.Hubs
{
    public class ProjectsHub : Hub
    {
        public void NewProjectsHubMessage(string title,string description,string date,int bids,int id)
        {
            Clients.All.addProjectsHubMessage(title,description,date,bids,id);
        }

    }
}
