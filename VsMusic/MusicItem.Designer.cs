namespace VsMusic
{
    partial class MusicItem
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
            itemArea = new TableLayoutPanel();
            description = new Label();
            image = new PictureBox();
            title = new Label();
            playButton = new CustomButton();
            display = new System.Windows.Forms.Timer(components);
            itemArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            SuspendLayout();
            // 
            // itemArea
            // 
            itemArea.BackColor = Color.FromArgb(40, 40, 40);
            itemArea.ColumnCount = 1;
            itemArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            itemArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            itemArea.Controls.Add(description, 0, 2);
            itemArea.Controls.Add(image, 0, 0);
            itemArea.Controls.Add(title, 0, 1);
            itemArea.Dock = DockStyle.Fill;
            itemArea.Location = new Point(0, 0);
            itemArea.Name = "itemArea";
            itemArea.Padding = new Padding(20);
            itemArea.RowCount = 3;
            itemArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            itemArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            itemArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            itemArea.Size = new Size(264, 358);
            itemArea.TabIndex = 0;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Dock = DockStyle.Fill;
            description.Font = new Font("Gill Sans Nova Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            description.ForeColor = SystemColors.AppWorkspace;
            description.Location = new Point(23, 298);
            description.Name = "description";
            description.Size = new Size(218, 40);
            description.TabIndex = 2;
            description.Text = "discription";
            // 
            // image
            // 
            image.Dock = DockStyle.Fill;
            image.Image = Properties.Resources._1;
            image.Location = new Point(20, 20);
            image.Margin = new Padding(0);
            image.Name = "image";
            image.Size = new Size(224, 238);
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.TabIndex = 0;
            image.TabStop = false;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Dock = DockStyle.Fill;
            title.Font = new Font("Eras Medium ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            title.ForeColor = SystemColors.ScrollBar;
            title.Location = new Point(23, 258);
            title.Name = "title";
            title.Size = new Size(218, 40);
            title.TabIndex = 1;
            title.Text = "title";
            // 
            // playButton
            // 
            playButton.ButtonImage = Properties.Resources.play1;
            playButton.Location = new Point(182, 200);
            playButton.Name = "playButton";
            playButton.Size = new Size(60, 60);
            playButton.TabIndex = 1;
            playButton.Visible = false;
            // 
            // display
            // 
            display.Enabled = true;
            display.Interval = 10;
            display.Tick += display_Tick;
            // 
            // MusicItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(playButton);
            Controls.Add(itemArea);
            Name = "MusicItem";
            Size = new Size(264, 358);
            itemArea.ResumeLayout(false);
            itemArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel itemArea;
        private PictureBox image;
        private Label description;
        private Label title;
        private CustomButton playButton;
        private System.Windows.Forms.Timer display;
    }
}
