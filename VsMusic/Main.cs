using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace VsMusic
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            trackBar1.PlayPause += TrackBar1_PlayPause;
            trackBar1.PlayNext += TrackBar1_PlayNext;
            trackBar1.PlayPrevios += TrackBar1_PlayPrevios;
        }

        private void TrackBar1_PlayPrevios(object? sender, EventArgs e)
        {
            int index = musicArea.Controls.IndexOf(play);
            if (index == 0)
            {
                index = musicArea.Controls.Count;
            }

            Control nextTract = musicArea.Controls[index - 1];
            NewTrack_MusicPlay(nextTract, e);

        }

        private void TrackBar1_PlayNext(object? sender, EventArgs e)
        {
            int index = musicArea.Controls.IndexOf(play);
            if (index + 1 == musicArea.Controls.Count)
            {
                index = 1;
            }
            Control nextTract = musicArea.Controls[index + 1];
            NewTrack_MusicPlay(nextTract, e);

        }

        private void TrackBar1_PlayPause(object? sender, EventArgs e)
        {
            bool player = (bool)sender;
            if (player)
            {
                play.ButtonPlay = false;
            }
            else
            {
                play.ButtonPlay = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {


            string[] dirs = Directory.GetDirectories("./Music");
            foreach (string dir in dirs)
            {
                playlistItem playlist = new playlistItem();
                DirectoryInfo directory = new DirectoryInfo(dir);
                playlist.Title = directory.Name;
                playlist.Description = directory.CreationTime.ToString("MM/yyyy");
                playlist.FilePath = directory.FullName;
                playlist.PlaylistChanged += Playlist_PlaylistChanged;
                string image = Path.Combine(dir, "index.gif");
                if (File.Exists(image))
                {
                    Bitmap bitmap = new Bitmap(image);
                    playlist.PlaylistImage = bitmap;
                }
                playListArea.Controls.Add(playlist);

            }
            playlistItem? playlist1 = playListArea.Controls[0] as playlistItem;
            if (playlist1 != null)
            {
                ShowPlaylist(playlist1);
            }

        }

        private void Playlist_PlaylistChanged(object? sender, EventArgs e)
        {
            playlistItem? playlist1 = sender as playlistItem;
            if (playlist1 != null)
            {
                ShowPlaylist(playlist1);
            }
        }

        public void ShowPlaylist(playlistItem playlist)
        {
            musicArea.Controls.Clear();

            string[] files = Directory.GetFiles(playlist.FilePath, "*.mp3");
            foreach (var musicTrack in files)
            {
                FileInfo file = new FileInfo(musicTrack);
                MusicItem newTrack = new MusicItem();
                newTrack.Title = file.Name.Replace(".mp3", "");
                newTrack.Description = playlist.Title;
                newTrack.FilePath = file.FullName;
                newTrack.MusicPlay += NewTrack_MusicPlay;
                newTrack.MusicHover += NewTrack_MusicHover;
                newTrack.TrackImage = playlist.PlaylistImage;
                musicArea.Controls.Add(newTrack);
            }
        }

        MusicItem hover;
        private void NewTrack_MusicHover(object? sender, EventArgs e)
        {


            if (sender is MusicItem musicItem && hover != musicItem)
            {
                if (hover != null)
                {
                    hover.ButtonVisible = false;
                }
                hover = musicItem;
                hover.ButtonVisible = true;
            }
        }
        MusicItem play;
        private void NewTrack_MusicPlay(object sender, EventArgs e)
        {
            if (sender is MusicItem musicItem)
            {
                if (play == musicItem)
                {
                    trackBar1.PlayPauseClick(sender, e);
                }
                else
                {
                    if (play != null)
                    {
                        play.ButtonPlay = false;
                    }
                    play = musicItem;
                    play.ButtonPlay = true;
                    trackBar1.Play(play.FilePath);

                }

            }

        }


    }
}