using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Utils
{
    public static class StringUtils
    {
        public static string ToStringSQL(this int values)
        {
            if (values == -1)
            {
                return "null";
            }
            return "'" + values.ToString() + "'";
        }

        public static string ToStringSQL(this string values)
        {
            if (values == "")
            {
                return "null";
            }
            return "N'" + values + "'";
        }

        public static string ToStringSQL(this bool values)
        {
            return "'" + values.ToString() + "'";
        }
    }
}
