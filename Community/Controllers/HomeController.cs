using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Community.DAL.User;
using Community.DAL;

namespace Community.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            using (CommunityContext ctx = new CommunityContext())
            {
                var result = from t in ctx.AccNamesPermissions select t;

                var test = ctx.AccNamesPermissions.ToList();


                foreach (var rec in test)
                {
                    Console.WriteLine("{0} {1}", rec.AccName, rec.PermissionName);
                }
                return null;
            }
            

        }
    }
}
