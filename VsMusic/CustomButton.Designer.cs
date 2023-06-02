namespace VsMusic
{
    partial class CustomButton
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
            buttonArea = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button = new Button();
            buttonArea.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonArea
            // 
            buttonArea.Controls.Add(tableLayoutPanel1);
            buttonArea.Dock = DockStyle.Fill;
            buttonArea.Location = new Point(0, 0);
            buttonArea.Name = "buttonArea";
            buttonArea.Size = new Size(50, 50);
            buttonArea.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(50, 50);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button
            // 
            button.BackgroundImage = Properties.Resources.play1;
            button.BackgroundImageLayout = ImageLayout.Zoom;
            button.Dock = DockStyle.Fill;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.Location = new Point(8, 8);
            button.Margin = new Padding(8);
            button.Name = "button";
            button.Size = new Size(34, 34);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            // 
            // CustomButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonArea);
            Name = "CustomButton";
            Size = new Size(50, 50);
            buttonArea.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel buttonArea;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button;
    }
}
