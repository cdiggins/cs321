using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvgDemoWinForms
{
    public static class Extensions
    {
        public static Color Convert(this System.Drawing.Color color)
            => new() { R = color.R, B = color.B, G = color.G };

    }
}
