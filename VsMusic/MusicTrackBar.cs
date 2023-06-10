
using NAudio.Wave;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace VsMusic
{
    public partial class MusicTrackBar : UserControl

    {
        IWavePlayer _wavePlayer;
        AudioFileReader _audioFileReader;
        public event EventHandler PlayPause;
        public event EventHandler PlayNext;
        public event EventHandler PlayPrevios;

        bool play;
        public MusicTrackBar()
        {
            InitializeComponent();
            playPause.CustomClick += PlayPauseClick;
            VolumeControl.ChangeVolume += VolumeControl_ChangeVolume;
        }

        private void next_CustomClick(object sender, EventArgs e)
        {
            PlayNext.Invoke(sender, e);
        }
        private void previos_CustomClick(object sender, EventArgs e)
        {
            PlayPrevios.Invoke(sender, e);
        }



        public void PlayPauseClick(object? sender, EventArgs e)
        {
            if (play)
            {
                _wavePlayer.Pause();
                playPause.ButtonImage = Properties.Resources.play1;


            }
            else
            {
                _wavePlayer.Play();
                playPause.ButtonImage = Properties.Resources.pause;

            }
            PlayPause.Invoke(play, EventArgs.Empty);
            play = !play;
        }

        public void Play(string path)
        {
            if (_wavePlayer != null)
            {
                _wavePlayer.Dispose();
                _audioFileReader.Dispose();
                audioTime.Stop();
                play = false;
            }
            _wavePlayer = new WaveOut();
            _audioFileReader = new AudioFileReader(path);
            _wavePlayer.Init(_audioFileReader);
            _wavePlayer.Play();
            audioTime.Start();
            _wavePlayer.Volume = (float)(VolumeControl.Value / 100.0);
            playPause.ButtonImage = Properties.Resources.pause;
            play = true;
        }



        private void audioTime_Tick(object sender, EventArgs e)
        {
            double timePercent = _audioFileReader.CurrentTime / _audioFileReader.TotalTime * 100;
            progres.ColumnStyles[0].Width = (int)timePercent;
            progres.ColumnStyles[1].Width = 100 - (int)timePercent;

        }

        private void progres_MouseClick(object sender, MouseEventArgs e)
        {
            double percent = (double)e.X / progres.Width;
            TimeSpan result = _audioFileReader.TotalTime * percent;
            _audioFileReader.CurrentTime = result;

        }


        private void VolumeControl_ChangeVolume(object? sender, EventArgs e)
        {
            if (_wavePlayer != null)
            {
                _wavePlayer.Volume = (float)(VolumeControl.Value / 100.0);

            }
        }

    }
}
