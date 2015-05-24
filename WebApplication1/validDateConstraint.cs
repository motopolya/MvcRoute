using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace WebApplication1
{
    class validDateConstraint : IRouteConstraint
    {

        public bool Match(System.Web.HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            DateTime dateValue;
            return DateTime.TryParse(values[parameterName].ToString(), out dateValue);
        }
    }
}