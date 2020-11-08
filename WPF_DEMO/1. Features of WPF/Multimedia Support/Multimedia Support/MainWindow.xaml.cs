using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Multimedia_Support
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileBrowser = new OpenFileDialog();
            fileBrowser.ShowDialog();
            System.Uri url = new Uri(fileBrowser.FileName);
            VideoSection.Source = url;
            CheckVideoSectionStatus();
        }

        private void PlayBtn_Click(object sender, RoutedEventArgs e)
        {
            if (VideoSection.LoadedBehavior == MediaState.Play)
            {
                VideoSection.LoadedBehavior = MediaState.Pause;
                PlayBtn.Content = "Play";
            }
              
            else
            {
                VideoSection.LoadedBehavior = MediaState.Play;
                PlayBtn.Content = "Pause";
            }
               
        }

        private void MuteBtn_Click(object sender, RoutedEventArgs e)
        {
            if(MuteBtn.Content.ToString() == "Mute")
            {
                MuteBtn.Content = "Un Mute";
                VideoSection.Volume = 0;
            }
               
            else
            {
                MuteBtn.Content = "Mute";
                VideoSection.Volume = VolumeControl.Value;
            }
                
        }

        private void CheckVideoSectionStatus()
        {
            if (VideoSection.LoadedBehavior == MediaState.Play)
                PlayBtn.Content = "Pause";

            else
                PlayBtn.Content = "Play";
        }

        

        private void VolumeControl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoSection.Volume = VolumeControl.Value;
        }

        private void ttsbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Speech_Click(object sender, RoutedEventArgs e)
        {
            SpeechRecognizer speechRecognizer = new SpeechRecognizer();
            speechRecognizer.ShowDialog();

        }
    }
}
