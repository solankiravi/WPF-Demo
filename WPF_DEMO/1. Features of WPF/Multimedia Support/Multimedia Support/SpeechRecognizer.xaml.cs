using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Multimedia_Support
{
    /// <summary>
    /// Interaction logic for SpeechRecognizer.xaml
    /// </summary>
    public partial class SpeechRecognizer : Window
    {
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        //SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
        public SpeechRecognizer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            speechSynthesizer.Volume = 100;
            if (messageTextBox.Text == string.Empty || string.IsNullOrWhiteSpace(messageTextBox.Text) || messageTextBox.Text=="")
            {
                speechSynthesizer.Speak("Text box is empty");
                
            }
            else
            {
                speakbtn.IsEnabled = false;
                messageTextBox.IsEnabled = false;
                speechSynthesizer.Speak(messageTextBox.Text);
                speakbtn.IsEnabled = true;
                messageTextBox.IsEnabled = true;
            }
            
        }

        private void messageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(messageTextBox.Text.Trim() != "")
            {
                status_text.Text = "Value is set. Click on speak.";
            }
           
        }
    }
}
