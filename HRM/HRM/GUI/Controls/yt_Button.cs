using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.ComponentModel;
using System.Data;

namespace HRM.GUI.Controls
{
    public class yt_Button : Control
    {
        Animation CurtainButtonAnim = new Animation();
        private StringFormat SF = new StringFormat();
        private Rectangle rect = new Rectangle();

        private bool MouseEntered = false;
        private bool MousePressed = false;

        private StringAlignment align;
        private int offset_text_x;
        private int offset_img_x;
        private int offset_img_y;
        private int width_img;
        private int height_img;
        private Image img;


        #region properties

        public int Width_img
        {
            get
            {
                return width_img;
            }
            set
            {
                width_img = value;
                this.Invalidate();
            }
        }

        public int Height_img
        {
            get
            {
                return height_img;
            }
            set
            {
                height_img = value;
                this.Invalidate();
            }
        }

        public Image Img
        {
            get 
            {
                return img;
            }
            set
            { 
                img = value;
                this.Invalidate();
            }
        }

        public StringAlignment Align
        {
            get 
            {
                return align;
            }

            set
            {
                SF.Alignment = align = value;
                this.Invalidate();
            } 
        }

        public int Offset_text_x
        {
            get
            {
                return offset_text_x;
            }
            set
            {
                offset_text_x = value;
                this.Invalidate();
            }
        }

        public int Offset_img_x
        {
            get
            {
                return offset_img_x;
            }
            set
            {
                offset_img_x = value;
                this.Invalidate();
            }
        }

        public int Offset_img_y
        {
            get
            {
                return offset_img_y;
            }
            set
            {
                offset_img_y = value;
                this.Invalidate();
            }
        }
        #endregion

        public yt_Button()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(165, 62);
            BackColor = Color.DodgerBlue;
            ForeColor = Color.White;

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;

            graph.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectCurtain = new Rectangle(0, 0, (int)CurtainButtonAnim.Value, Height - 1);

            graph.DrawRectangle(new Pen(BackColor), rect);
            graph.FillRectangle(new SolidBrush(BackColor), rect);

            graph.DrawRectangle(new Pen(Color.FromArgb(60, Color.Black)), rectCurtain);
            graph.FillRectangle(new SolidBrush(Color.FromArgb(60, Color.Black)), rectCurtain);

            if (MousePressed)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(30, Color.Black)), rect);
                graph.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), rect);
            }
            int tmp = (align == StringAlignment.Near ? offset_text_x : (align == StringAlignment.Far ? -offset_text_x : 0));
            rect = new Rectangle(rect.X + tmp, rect.Y, rect.Width - Math.Abs(tmp), rect.Height);
            if (img != null)
                graph.DrawImage(img, offset_img_x, offset_img_y, width_img, height_img);
            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);
            
        }

        private void ButtonCurtainAction()
        {
            if (MouseEntered)
            {
                CurtainButtonAnim = new Animation("ButtonCurtain_" + Handle, Invalidate, CurtainButtonAnim.Value, Width - 1);
            }
            else
            {
                CurtainButtonAnim = new Animation("ButtonCurtain_" + Handle, Invalidate, CurtainButtonAnim.Value, 0);
            }

            Animator.Request(CurtainButtonAnim, true);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            MouseEntered = true;

            ButtonCurtainAction();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            MouseEntered = false;

            ButtonCurtainAction();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            MousePressed = true;

            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            MousePressed = false;

            Invalidate();
        }
    }
}