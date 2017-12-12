using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Multimedia
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();
            mediaPlayer.Open(new Uri(@"Media/train.mp3", UriKind.Relative));
            mediaElement.Source = (new Uri(@"Media/bunny.mp4", UriKind.Relative));
            mediaElement.LoadedBehavior = MediaState.Manual;
            mediaElement.ScrubbingEnabled = false;

        }

        private void ButtonPlay_OnClick(object sender, RoutedEventArgs e)
        {
           
            mediaPlayer.Play();
        }

        private void ButtonStop_OnClick(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void ButtonSetAudio_OnClick(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Open(new Uri(@"Media/train.mp3", UriKind.Relative));
        }

        private void ButtonSetVideo_OnClick(object sender, RoutedEventArgs e)
        {
                mediaElement.Position = new TimeSpan(0, 0, 0);
                mediaElement.Play();
        }
    }
}
