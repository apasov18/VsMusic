namespace VsMusic
{
    partial class CustomTrackBar
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            areaVolumeControl = new TableLayoutPanel();
            pictureVolume = new PictureBox();
            volumeControl = new TableLayoutPanel();
            whiteLine = new Label();
            blackLine = new Label();
            areaVolumeControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureVolume).BeginInit();
            volumeControl.SuspendLayout();
            SuspendLayout();
            // 
            // areaVolumeControl
            // 
            areaVolumeControl.ColumnCount = 2;
            areaVolumeControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            areaVolumeControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            areaVolumeControl.Controls.Add(pictureVolume, 0, 0);
            areaVolumeControl.Controls.Add(volumeControl, 1, 0);
            areaVolumeControl.Cursor = Cursors.Hand;
            areaVolumeControl.Dock = DockStyle.Fill;
            areaVolumeControl.Location = new Point(0, 0);
            areaVolumeControl.Margin = new Padding(0);
            areaVolumeControl.Name = "areaVolumeControl";
            areaVolumeControl.Padding = new Padding(8);
            areaVolumeControl.RowCount = 1;
            areaVolumeControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            areaVolumeControl.Size = new Size(282, 80);
            areaVolumeControl.TabIndex = 0;
            // 
            // pictureVolume
            // 
            pictureVolume.Anchor = AnchorStyles.None;
            pictureVolume.Image = Properties.Resources.volume;
            pictureVolume.Location = new Point(18, 21);
            pictureVolume.Name = "pictureVolume";
            pictureVolume.Size = new Size(50, 37);
            pictureVolume.SizeMode = PictureBoxSizeMode.Zoom;
            pictureVolume.TabIndex = 0;
            pictureVolume.TabStop = false;
            pictureVolume.Click += pictureVolume_Click;
            // 
            // volumeControl
            // 
            volumeControl.ColumnCount = 2;
            volumeControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            volumeControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            volumeControl.Controls.Add(whiteLine, 0, 0);
            volumeControl.Controls.Add(blackLine, 0, 0);
            volumeControl.Location = new Point(78, 8);
            volumeControl.Margin = new Padding(0);
            volumeControl.Name = "volumeControl";
            volumeControl.Padding = new Padding(0, 19, 0, 19);
            volumeControl.RowCount = 1;
            volumeControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            volumeControl.Size = new Size(196, 64);
            volumeControl.TabIndex = 1;
            volumeControl.MouseClick += volumeControl_MouseClick;
            // 
            // whiteLine
            // 
            whiteLine.AutoSize = true;
            whiteLine.BackColor = Color.White;
            whiteLine.Dock = DockStyle.Fill;
            whiteLine.Location = new Point(98, 19);
            whiteLine.Margin = new Padding(0);
            whiteLine.Name = "whiteLine";
            whiteLine.Padding = new Padding(0, 20, 0, 20);
            whiteLine.Size = new Size(98, 26);
            whiteLine.TabIndex = 1;
            whiteLine.MouseClick += whiteLine_MouseClick;
            // 
            // blackLine
            // 
            blackLine.AutoSize = true;
            blackLine.BackColor = Color.Gray;
            blackLine.Dock = DockStyle.Fill;
            blackLine.Location = new Point(0, 19);
            blackLine.Margin = new Padding(0);
            blackLine.Name = "blackLine";
            blackLine.Padding = new Padding(0, 20, 0, 20);
            blackLine.Size = new Size(98, 26);
            blackLine.TabIndex = 0;
            blackLine.MouseClick += volumeControl_MouseClick;
            // 
            // CustomTrackBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(areaVolumeControl);
            Name = "CustomTrackBar";
            Size = new Size(282, 80);
            areaVolumeControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureVolume).EndInit();
            volumeControl.ResumeLayout(false);
            volumeControl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel areaVolumeControl;
        private PictureBox pictureVolume;
        private TableLayoutPanel volumeControl;
        private Label blackLine;
        private Label whiteLine;
    }
}
