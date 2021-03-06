﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Login
{
    public class LoginClaimsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "LoginClaim";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "LoginClaims_default",
                "LoginClaims/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}