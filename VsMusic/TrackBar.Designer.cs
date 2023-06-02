namespace VsMusic
{
    partial class TrackBar
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
            components = new System.ComponentModel.Container();
            trackBarArea = new TableLayoutPanel();
            progres = new TableLayoutPanel();
            whiteLine = new Label();
            controlArea = new TableLayoutPanel();
            controlSelector = new TableLayoutPanel();
            next = new CustomButton();
            previos = new CustomButton();
            customButton2 = new CustomButton();
            playPause = new CustomButton();
            customButton1 = new CustomButton();
            audioTime = new System.Windows.Forms.Timer(components);
            trackBarArea.SuspendLayout();
            progres.SuspendLayout();
            controlArea.SuspendLayout();
            controlSelector.SuspendLayout();
            SuspendLayout();
            // 
            // trackBarArea
            // 
            trackBarArea.BackColor = Color.LightGray;
            trackBarArea.ColumnCount = 1;
            trackBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            trackBarArea.Controls.Add(progres, 0, 0);
            trackBarArea.Controls.Add(controlArea, 0, 1);
            trackBarArea.Dock = DockStyle.Fill;
            trackBarArea.Location = new Point(0, 0);
            trackBarArea.Name = "trackBarArea";
            trackBarArea.RowCount = 2;
            trackBarArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            trackBarArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            trackBarArea.Size = new Size(769, 72);
            trackBarArea.TabIndex = 0;
            // 
            // progres
            // 
            progres.BackColor = Color.Transparent;
            progres.ColumnCount = 2;
            progres.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0F));
            progres.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            progres.Controls.Add(whiteLine, 0, 0);
            progres.Dock = DockStyle.Fill;
            progres.Location = new Point(0, 0);
            progres.Margin = new Padding(0);
            progres.Name = "progres";
            progres.RowCount = 1;
            progres.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            progres.Size = new Size(769, 5);
            progres.TabIndex = 0;
            progres.MouseClick += progres_MouseClick;
            // 
            // whiteLine
            // 
            whiteLine.AutoSize = true;
            whiteLine.BackColor = Color.Black;
            whiteLine.Dock = DockStyle.Fill;
            whiteLine.Location = new Point(0, 0);
            whiteLine.Margin = new Padding(0);
            whiteLine.Name = "whiteLine";
            whiteLine.Size = new Size(1, 5);
            whiteLine.TabIndex = 0;
            whiteLine.TextAlign = ContentAlignment.TopCenter;
            whiteLine.MouseClick += progres_MouseClick;
            // 
            // controlArea
            // 
            controlArea.ColumnCount = 3;
            controlArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            controlArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            controlArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            controlArea.Controls.Add(controlSelector, 1, 0);
            controlArea.Dock = DockStyle.Fill;
            controlArea.Location = new Point(0, 5);
            controlArea.Margin = new Padding(0);
            controlArea.Name = "controlArea";
            controlArea.RowCount = 1;
            controlArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            controlArea.Size = new Size(769, 67);
            controlArea.TabIndex = 1;
            // 
            // controlSelector
            // 
            controlSelector.ColumnCount = 5;
            controlSelector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            controlSelector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            controlSelector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            controlSelector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            controlSelector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            controlSelector.Controls.Add(next, 3, 0);
            controlSelector.Controls.Add(previos, 1, 0);
            controlSelector.Controls.Add(customButton2, 0, 0);
            controlSelector.Controls.Add(playPause, 2, 0);
            controlSelector.Controls.Add(customButton1, 4, 0);
            controlSelector.Dock = DockStyle.Fill;
            controlSelector.Location = new Point(184, 0);
            controlSelector.Margin = new Padding(0);
            controlSelector.Name = "controlSelector";
            controlSelector.RowCount = 1;
            controlSelector.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            controlSelector.Size = new Size(400, 67);
            controlSelector.TabIndex = 0;
            // 
            // next
            // 
            next.ButtonImage = Properties.Resources.next;
            next.Dock = DockStyle.Fill;
            next.Location = new Point(243, 3);
            next.Name = "next";
            next.Size = new Size(74, 61);
            next.TabIndex = 4;
            next.CustomClick += next_CustomClick;
            // 
            // previos
            // 
            previos.ButtonImage = Properties.Resources.back;
            previos.Dock = DockStyle.Fill;
            previos.Location = new Point(83, 3);
            previos.Name = "previos";
            previos.Size = new Size(74, 61);
            previos.TabIndex = 3;
            previos.CustomClick += previos_CustomClick;
            // 
            // customButton2
            // 
            customButton2.ButtonImage = Properties.Resources.random;
            customButton2.Dock = DockStyle.Fill;
            customButton2.Location = new Point(3, 3);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(74, 61);
            customButton2.TabIndex = 2;
            // 
            // playPause
            // 
            playPause.ButtonImage = Properties.Resources.play1;
            playPause.Dock = DockStyle.Fill;
            playPause.Location = new Point(163, 3);
            playPause.Name = "playPause";
            playPause.Size = new Size(74, 61);
            playPause.TabIndex = 0;
            // 
            // customButton1
            // 
            customButton1.ButtonImage = Properties.Resources.reapet;
            customButton1.Dock = DockStyle.Fill;
            customButton1.Location = new Point(323, 3);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(74, 61);
            customButton1.TabIndex = 1;
            // 
            // audioTime
            // 
            audioTime.Interval = 1000;
            audioTime.Tick += audioTime_Tick;
            // 
            // TrackBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            Controls.Add(trackBarArea);
            Name = "TrackBar";
            Size = new Size(769, 72);
            trackBarArea.ResumeLayout(false);
            progres.ResumeLayout(false);
            progres.PerformLayout();
            controlArea.ResumeLayout(false);
            controlSelector.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel trackBarArea;
        private TableLayoutPanel progres;
        private Label whiteLine;
        private System.Windows.Forms.Timer audioTime;
        private TableLayoutPanel controlArea;
        private TableLayoutPanel controlSelector;
        private CustomButton playPause;
        private CustomButton next;
        private CustomButton previos;
        private CustomButton customButton2;
        private CustomButton customButton1;
    }
}
