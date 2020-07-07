using FiltersDemonstration_2.Models;
using FiltersDemonstration_2.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FiltersDemonstration_2.Controllers
{
    [BrowserCheck]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginInfo loginInfo)
        {
            SqlConnection conn = new SqlConnection(@"server=DESKTOP-89HQ4RL\SQLEXPRESS;database=EmployeeDB;integrated security=true");
            string query = "select count(*) from LoginInfo where UserName=@uName and Password=@pwd";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter("@uName", loginInfo.UserName));
            cmd.Parameters.Add(new SqlParameter("@pwd", loginInfo.PassWord));
            conn.Open();
            int noOfUsers = (int)cmd.ExecuteScalar();
            conn.Close();
            if (noOfUsers > 0)
            {
                FormsAuthentication.SetAuthCookie(loginInfo.UserName, false);
                return RedirectToAction("Home");
            }
            return View();
        }

        [Authorize]
        public ActionResult Home()
        {
            //if (Request.IsAuthenticated)
            //{
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Index");
            //}
            return View();
        }

        [Authorize]
        public ActionResult EditProfile()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}