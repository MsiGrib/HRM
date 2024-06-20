using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM.GUI.Controls
{
    public partial class progress_bar : UserControl
    {
        private int kpd = 0;
        private Color color;

        public progress_bar()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
        }

        public void set_value(int value)
        {
            kpd = value;
            if (kpd < 30)
                color = Color.FromArgb(190, 230, 30);
            else if (kpd >= 30 && kpd < 80)
                color = Color.FromArgb(34, 230, 30);
            else if (kpd >= 80)
                color = Color.FromArgb(230, 117, 30);
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int full = (this.Width / 150) * kpd;
            if (full > this.Width)
                full = this.Width;
            if (full <= 0)
                full = 1;
            e.Graphics.FillRectangle(new SolidBrush(color), 0, 0, full, this.Height);
        }
    }
}
