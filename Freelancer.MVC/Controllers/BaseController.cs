using Freelancer.Data.UnitOfWork;
using Freelancer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Freelancer.MVC.Controllers
{
    public abstract class BaseController : Controller
    {
        protected BaseController(IFreelancerData data)
        {
            this.Data = data;
        }

        protected BaseController(IFreelancerData data, User userProfile)
            : this(data)
        {
            this.UserProfile = userProfile;
        }

        protected IFreelancerData Data { get; private set; }

        protected User UserProfile { get; private set; }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            if (requestContext.HttpContext.User.Identity.IsAuthenticated)
            {
                var user = this.Data.Users.All().FirstOrDefault(x => x.UserName == requestContext.HttpContext.User.Identity.Name);
                this.UserProfile = user;
            }
            return base.BeginExecute(requestContext, callback, state);
        }
    }
}