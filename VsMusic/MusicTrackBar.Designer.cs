namespace VsMusic
{
    partial class MusicTrackBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicTrackBar));
            trackBarArea = new TableLayoutPanel();
            progres = new TableLayoutPanel();
            whiteLine = new Label();
            controlArea = new TableLayoutPanel();
            controlSelector = new TableLayoutPanel();
            next = new CustomButton();
            previos = new CustomButton();
            playPause = new CustomButton();
            VolumeControl = new CustomTrackBar();
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
            resources.ApplyResources(trackBarArea, "trackBarArea");
            trackBarArea.Controls.Add(progres, 0, 0);
            trackBarArea.Controls.Add(controlArea, 0, 1);
            trackBarArea.Name = "trackBarArea";
            // 
            // progres
            // 
            progres.BackColor = Color.Transparent;
            resources.ApplyResources(progres, "progres");
            progres.Controls.Add(whiteLine, 0, 0);
            progres.Name = "progres";
            progres.MouseClick += progres_MouseClick;
            // 
            // whiteLine
            // 
            resources.ApplyResources(whiteLine, "whiteLine");
            whiteLine.BackColor = Color.Black;
            whiteLine.Name = "whiteLine";
            whiteLine.MouseClick += progres_MouseClick;
            // 
            // controlArea
            // 
            resources.ApplyResources(controlArea, "controlArea");
            controlArea.Controls.Add(controlSelector, 1, 0);
            controlArea.Controls.Add(VolumeControl, 2, 0);
            controlArea.Name = "controlArea";
            // 
            // controlSelector
            // 
            resources.ApplyResources(controlSelector, "controlSelector");
            controlSelector.Controls.Add(next, 3, 0);
            controlSelector.Controls.Add(previos, 1, 0);
            controlSelector.Controls.Add(playPause, 2, 0);
            controlSelector.Name = "controlSelector";
            // 
            // next
            // 
            next.ButtonImage = Properties.Resources.next;
            resources.ApplyResources(next, "next");
            next.Name = "next";
            next.CustomClick += next_CustomClick;
            // 
            // previos
            // 
            previos.ButtonImage = Properties.Resources.back;
            resources.ApplyResources(previos, "previos");
            previos.Name = "previos";
            previos.CustomClick += previos_CustomClick;
            // 
            // playPause
            // 
            playPause.ButtonImage = Properties.Resources.play1;
            resources.ApplyResources(playPause, "playPause");
            playPause.Name = "playPause";
            // 
            // VolumeControl
            // 
            VolumeControl.BackColor = Color.LightGray;
            resources.ApplyResources(VolumeControl, "VolumeControl");
            VolumeControl.Name = "VolumeControl";
            VolumeControl.Value = 0F;
            // 
            // audioTime
            // 
            audioTime.Interval = 1000;
            audioTime.Tick += audioTime_Tick;
            // 
            // MusicTrackBar
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            Controls.Add(trackBarArea);
            Name = "MusicTrackBar";
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
        private CustomTrackBar VolumeControl;
    }
}
