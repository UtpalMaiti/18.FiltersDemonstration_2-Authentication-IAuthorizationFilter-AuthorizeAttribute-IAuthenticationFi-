using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersDemonstration_2.Controllers
{
    //[Authorize(Users ="Pragim")] //User based  Authorize access
    [Authorize(Roles = " Pragim")]  // Role based  Authorize access
    public class AdminController : Controller
    {
        public string Index()
        {
            return "Welcome to Admin HomePage...";
        }

        public string ApproveUsers()
        {
            return "Welcome to ApproveUsers Section...";
        }

        public string DisableUsers()
        {
            return "Welcome to Disable Users View";
        }

        [OverrideAuthorization]
        public string Contactpage()
        {
            return "Welcome to Contact page View";
        }
    }
}