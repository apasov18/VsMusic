using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VsMusic
{
    public partial class MusicItem : UserControl
    {

        public event EventHandler MusicPlay;
        public event EventHandler MusicHover;

        public MusicItem()
        {
            InitializeComponent();
            RecursiveHendlerHover(itemArea);
            RecursiveHendlerHover(playButton);
            RecursiveHendlerDoubleClick(itemArea);
            playButton.CustomClick += PlayPause_CustomCLick;

            Margin = new Padding(10);
        }
        private void PlayPause_CustomCLick(object? sender, EventArgs e)
        {
            MusicPlay.Invoke(this, e);
        }
        public bool ButtonVisible { get; set; }
        public bool ButtonPlay
        {
            set
            {
                if (value)
                {
                    playButton.ButtonImage = Properties.Resources.pause;
                }
                else
                {
                    playButton.ButtonImage = Properties.Resources.play1;
                }

            }
        }



        private void display_Tick(object sender, EventArgs e)
        {

            if (ButtonVisible)
            {
                if (!playButton.Visible)
                {
                    playButton.Visible = true;
                }
                else if (playButton.Top > 200)
                {
                    playButton.Top--;
                }
            }
            else
            {
                if (playButton.Top < 210)
                {
                    playButton.Top++;
                }
                else if (playButton.Visible)
                {
                    playButton.Visible = false;
                }
            }

        }

        #region  Рекурсивное навидение 

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
            if (MusicHover != null)
            {
                MusicHover.Invoke(this, e);
            }
            itemArea.BackColor = Color.FromArgb(50, 50, 50);
        }
        private void Element_MouseLeave(object? sender, EventArgs e)
        {
            itemArea.BackColor = Color.FromArgb(40, 40, 40);
        }
        #endregion

        #region Рекурсивное двойное нажатие 
        void RecursiveHendlerDoubleClick(Control element)
        {
            element.MouseDoubleClick += Element_MouseDoubleClick;
            foreach (Control innerElement in element.Controls)
            {
                RecursiveHendlerDoubleClick(innerElement);
            }
        }
        private void Element_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            MusicPlay.Invoke(this, e);
        }
        #endregion

        #region Отрисовка 
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            int radius = 45;
            graphicsPath.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
            graphicsPath.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
            graphicsPath.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
            graphicsPath.CloseFigure();
            Region = new Region(graphicsPath);
            base.OnPaint(e);
        }
        #endregion

        #region Кастомные свойства 
        [Category("Свойства трека")]

        public string Title
        {
            get
            {
                return title.Text;
            }
            set
            {
                title.Text = value;
            }
        }

        [Category("Свойства трека")]

        public string Description
        {
            get
            {
                return description.Text;
            }
            set
            {
                description.Text = value;
            }
        }

        string filePath;



        public string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
            }
        }
        [Category("Свойства трека")]
        public Image TrackImage
        {
            get
            {
                return image.Image;
            }
            set
            {
                image.Image = value;
            }

        }
        #endregion

    }
}
