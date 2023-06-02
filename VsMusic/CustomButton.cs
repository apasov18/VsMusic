using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VsMusic
{
    public partial class CustomButton : UserControl
    {
        public CustomButton()
        {
            InitializeComponent();
            RecursiveHendlerHover(tableLayoutPanel1);
            RecursiveHendlerClick(tableLayoutPanel1);

        }

        public event EventHandler CustomClick;



        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            int radius = 25;
            graphicsPath.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
            graphicsPath.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
            graphicsPath.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
            graphicsPath.CloseFigure();
            Region = new Region(graphicsPath);
            base.OnPaint(e);
        }
        public Image ButtonImage
        {
            get
            {
                return button.BackgroundImage;
            }
            set
            {
                button.BackgroundImage = value;
            }

        }

        private void Element_MouseClick(object? sender, MouseEventArgs e)
        {
            CustomClick.Invoke(this, e);
        }

        void RecursiveHendlerClick(Control element)
        {
            element.MouseClick += Element_MouseClick;
            foreach (Control innerElement in element.Controls)
            {
                RecursiveHendlerClick(innerElement);
            }
        }


        void RecursiveHendlerHover(Control element)
        {
            element.MouseEnter += Element_MouseEnter;
            element.MouseLeave += Element_MouseLeave;
            foreach (Control innerElement in element.Controls)
            {
                RecursiveHendlerHover(innerElement);
            }
        }

        private void Element_MouseEnter(object? sender, EventArgs e)
        {
            button.Margin = new Padding(5);
        }
        private void Element_MouseLeave(object? sender, EventArgs e)
        {
            button.Margin = new Padding(8);

        }

    }
}
