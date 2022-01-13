using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstateAgent.Web.Helpers
{
    public static class QueryStringHelper
    {
        public static int GetIntFromQueryString(HttpRequestBase request, string key, int fallbackValue = 0)
        {
            var stringValue = request.QueryString[key];
            if (stringValue != null && !string.IsNullOrWhiteSpace(stringValue) &&
                int.TryParse(stringValue, out var numericValue))
            {
                return numericValue;
            }

            return fallbackValue;
        }
    }
}