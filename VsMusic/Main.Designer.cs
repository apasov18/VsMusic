namespace VsMusic
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            musicArea = new FlowLayoutPanel();
            trackBar1 = new MusicTrackBar();
            playListArea = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // musicArea
            // 
            musicArea.AutoScroll = true;
            musicArea.BackColor = Color.FromArgb(30, 30, 30);
            musicArea.Dock = DockStyle.Right;
            musicArea.Location = new Point(262, 0);
            musicArea.Name = "musicArea";
            musicArea.Padding = new Padding(3, 0, 0, 0);
            musicArea.Size = new Size(1103, 630);
            musicArea.TabIndex = 0;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.DarkSlateBlue;
            trackBar1.Dock = DockStyle.Bottom;
            trackBar1.Location = new Point(0, 630);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(1365, 80);
            trackBar1.TabIndex = 0;
            // 
            // playListArea
            // 
            playListArea.AutoScroll = true;
            playListArea.Dock = DockStyle.Left;
            playListArea.Location = new Point(0, 0);
            playListArea.Margin = new Padding(0);
            playListArea.Name = "playListArea";
            playListArea.Size = new Size(272, 630);
            playListArea.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1365, 710);
            Controls.Add(playListArea);
            Controls.Add(musicArea);
            Controls.Add(trackBar1);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1383, 757);
            MinimumSize = new Size(1383, 757);
            Name = "Main";
            Text = "Black Music";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel musicArea;
        private MusicTrackBar trackBar1;
        private FlowLayoutPanel playListArea;
    }
}