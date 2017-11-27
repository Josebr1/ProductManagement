using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagement.Package.Utils
{
    class MenuStripRenderer : ToolStripProfessionalRenderer
    {
        public MenuStripRenderer() : base(new ColorScheme()) { }
    }

    class ColorScheme : ProfessionalColorTable
    {
        public override Color MenuItemSelected => UtilsColor.colorConvertHexadecimal("#4CAF50");
        public override Color MenuItemSelectedGradientBegin => UtilsColor.colorConvertHexadecimal("#4CAF50");
        public override Color MenuItemSelectedGradientEnd => UtilsColor.colorConvertHexadecimal("#4CAF50");
        public override Color MenuItemBorder => UtilsColor.colorConvertHexadecimal("#4CAF50");
        public override Color MenuItemPressedGradientBegin => UtilsColor.colorConvertHexadecimal("#4CAF50");
        public override Color MenuItemPressedGradientMiddle => UtilsColor.colorConvertHexadecimal("#4CAF50");
        public override Color MenuItemPressedGradientEnd => UtilsColor.colorConvertHexadecimal("#4CAF50");
    }
}
