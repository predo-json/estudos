﻿using System.Web;
using System.Web.Mvc;

namespace Dapper_Project_CRUD_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
