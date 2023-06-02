namespace VsMusic
{
    partial class playlistItem
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
            playListArea = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            titleArea = new TableLayoutPanel();
            description = new Label();
            title = new Label();
            playListArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            titleArea.SuspendLayout();
            SuspendLayout();
            // 
            // playListArea
            // 
            playListArea.BackColor = Color.Transparent;
            playListArea.ColumnCount = 2;
            playListArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            playListArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            playListArea.Controls.Add(pictureBox1, 0, 0);
            playListArea.Controls.Add(titleArea, 1, 0);
            playListArea.Dock = DockStyle.Fill;
            playListArea.Location = new Point(0, 0);
            playListArea.Margin = new Padding(0);
            playListArea.Name = "playListArea";
            playListArea.RowCount = 1;
            playListArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            playListArea.Size = new Size(266, 60);
            playListArea.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.thumb;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // titleArea
            // 
            titleArea.BackColor = Color.Transparent;
            titleArea.ColumnCount = 1;
            titleArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            titleArea.Controls.Add(description, 0, 1);
            titleArea.Controls.Add(title, 0, 0);
            titleArea.Dock = DockStyle.Fill;
            titleArea.Location = new Point(60, 2);
            titleArea.Margin = new Padding(0, 2, 0, 2);
            titleArea.Name = "titleArea";
            titleArea.RowCount = 2;
            titleArea.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            titleArea.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            titleArea.Size = new Size(206, 56);
            titleArea.TabIndex = 1;
            // 
            // description
            // 
            description.AutoSize = true;
            description.BackColor = Color.Transparent;
            description.Dock = DockStyle.Fill;
            description.Font = new Font("Eras Medium ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            description.Location = new Point(3, 28);
            description.Name = "description";
            description.Size = new Size(200, 28);
            description.TabIndex = 1;
            description.Text = "description";
            description.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Dock = DockStyle.Fill;
            title.Font = new Font("Eras Medium ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(3, 0);
            title.Name = "title";
            title.Size = new Size(200, 28);
            title.TabIndex = 0;
            title.Text = "title";
            title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // playlistItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(playListArea);
            Margin = new Padding(0);
            Name = "playlistItem";
            Size = new Size(266, 60);
            playListArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            titleArea.ResumeLayout(false);
            titleArea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel playListArea;
        private PictureBox pictureBox1;
        private TableLayoutPanel titleArea;
        private Label title;
        private Label description;
    }
}
