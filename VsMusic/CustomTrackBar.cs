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
    public partial class CustomTrackBar : UserControl
    {
        public CustomTrackBar()
        {
            InitializeComponent();
            RecursiveHendlerHover(areaVolumeControl);

            volumeControl.MouseWheel += VolumeControl_MouseWheel;
        }
        public event EventHandler ChangeVolume;
        #region Рекурсивное наведение

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
            blackLine.BackColor = Color.Black;
        }
        private void Element_MouseLeave(object? sender, EventArgs e)
        {
            blackLine.BackColor = Color.Gray;
        }
        #endregion


        float currentValue = 50;
        public float Value { get; set; }
        private void volumeControl_MouseClick(object sender, MouseEventArgs e)
        {
            float percent = (float)e.X / volumeControl.Width * 100.0f;
            currentValue = percent;
            UpdateVolumeControl();


        }
        private void whiteLine_MouseClick(object sender, MouseEventArgs e)
        {
            float percent = ((float)e.X + blackLine.Width) / volumeControl.Width * 100.0f;
            currentValue = percent;
            UpdateVolumeControl();
        }
        private void VolumeControl_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (currentValue < 100)
                    currentValue += 2;
            }

            else
            {
                if (currentValue > 0)
                {
                    currentValue -= 2;
                }
            }

            UpdateVolumeControl();
        }
        void UpdateVolumeControl()
        {
            float value = currentValue;
            if (value <= 0 || mute)
            {
                value = 0;
            }
            else if (value >= 100)
            {
                value = 100;
            }
            Value = value;
            ChangeVolume.Invoke(this, EventArgs.Empty);
            volumeControl.ColumnStyles[0].Width = value;

            volumeControl.ColumnStyles[1].Width = 100 - value;
        }
        bool mute = false;
        private void pictureVolume_Click(object sender, EventArgs e)
        {
            mute = !mute;
            if (mute)
            {
                pictureVolume.Image = Properties.Resources.volumeMute;
            }
            else
            {
                pictureVolume.Image = Properties.Resources.volume;

            }
            UpdateVolumeControl();
        }

    }
}
