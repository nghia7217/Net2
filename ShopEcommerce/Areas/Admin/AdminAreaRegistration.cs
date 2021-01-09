﻿using System.Web.Mvc;

namespace ShopEcommerce.Areas.Admin {
    public class AdminAreaRegistration : AreaRegistration {
        public override string AreaName {
            get {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                defaults: new { controller = "Dashboard", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "ShopEcommerce.Areas.Admin.Controllers" }
            );
        }
    }
}