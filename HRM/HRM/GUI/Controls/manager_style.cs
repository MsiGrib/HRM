using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.GUI.Controls
{
    public static class manager_style
    {
        public static bool is_darck = false;

        // One - back color,     two - textbox back color,     three - text color,     four - acthent color
        public static Color one_light = Color.White;
        public static Color two_light = Color.FromArgb(237, 237, 237);
        public static Color three_light = Color.Black;
        public static Color four_light = Color.FromArgb(52, 189, 180);
        public static Color additional_light = Color.FromArgb(163, 228, 224);

        public static Color one_darck = Color.FromArgb(52, 58, 61);
        public static Color two_darck = Color.FromArgb(68, 75, 79);
        public static Color three_darck = Color.White;
        public static Color four_darck = Color.FromArgb(52, 189, 180);
        public static Color additional_darck = Color.FromArgb(163, 228, 224);
    }
}
