using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Package.Utils
{
    class UtilsColor
    {
        public static Color colorConvertHexadecimal(string color)
        {
            Color result = ColorTranslator.FromHtml(color);
            return result;
        }
    }
}
