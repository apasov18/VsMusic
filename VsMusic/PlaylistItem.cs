using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VsMusic
{
    public partial class playlistItem : UserControl
    {


        public playlistItem()
        {
            InitializeComponent();
            RecursiveHendlerHover(this);
            RecursiveHendlerDoubleClick(this);
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

            BackColor = Color.DarkGray;
        }
        private void Element_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.Silver;
        }

        public event EventHandler PlaylistChanged;
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
            PlaylistChanged.Invoke(this, e);
        }

        [Category("Свойства плейлиста ")]

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

        [Category("Свойства плейлиста")]

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

        public Image PlaylistImage
        {
            get
            {
                return picAlbum.Image;
            }
            set
            {
                picAlbum.Image = value;
            }

        }

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
    }
}
