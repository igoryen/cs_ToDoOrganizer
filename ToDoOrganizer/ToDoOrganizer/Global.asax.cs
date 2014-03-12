﻿//=============================================================
// 30. has definition of class Database
// 35. has definition of MyDbContext
//=============================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity; //30
using ToDoOrganizer.Models; // 35

namespace ToDoOrganizer
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer<MyDbContext>(new MyDbInitializer()); // 1
        }
    }
}
