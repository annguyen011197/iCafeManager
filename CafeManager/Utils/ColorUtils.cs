using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Utils
{
    public static class ColorUtils
    {
        public static  Color ToColor(this string values) {
            return System.Drawing.ColorTranslator.FromHtml(values);
        }
    }
}
