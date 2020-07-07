using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace FiltersDemonstration_2.UtilityClasses
{
    //public class BrowserCheckAttribute : FilterAttribute,IAuthorizationFilter
    //{
    //}

    public class BrowserCheckAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Request.UserAgent.Contains("Chrome"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

        //Custom  IAuthenticationFilter
    public class AuthnticationCheckAttribute : FilterAttribute, IAuthenticationFilter         
    {
        void IAuthenticationFilter.OnAuthentication(AuthenticationContext filterContext)
        {
            throw new NotImplementedException();
        }

        void IAuthenticationFilter.OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            throw new NotImplementedException();
        }
    }

        //Custom  IAuthorizationFilter
    internal class AuthorizationCheckAttribute : FilterAttribute, IAuthorizationFilter     
    {
        void IAuthorizationFilter.OnAuthorization(AuthorizationContext filterContext)
        {
            throw new NotImplementedException();
        }
    }
}