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
using CefSharp.Wpf;

namespace Vocabulary
{
    public partial class MainWindow : Window
    {
        ReadExcel r = new ReadExcel();
        static Random rnd = new Random();
        ExcelRow currentWord = null;


        public MainWindow()
        {

            CefSettings settings = new CefSettings();
            settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF";
            CefSharp.Cef.Initialize(settings);


            InitializeComponent();
            r.readWholeFile();
            next_word_button_Click(null, null);

        }

        private void translation_button_Click(object sender, RoutedEventArgs e)
        {
            hideRectangles(false);
            string link = LinkBuilder.generateLinkGoogle(currentWord);
            browser_window.Load(link);
        }

        private void next_word_button_Click(object sender, RoutedEventArgs e)
        {
            int rand = rnd.Next(r.words.Count);
            currentWord = r.words[rand];
            current_word_label.Content = currentWord.word.ToString();
            hideRectangles(false);

            //dnry
            string link = LinkBuilder.generateLinkGoogle(currentWord);
            browser_window.Load(link);
        }

        private void lengusa_button_Click(object sender, RoutedEventArgs e)
        {
            hideRectangles(true);
            string link = LinkBuilder.generateLinkLengusa(currentWord);
            browser_window.Load(link);
        }

        private void definition_button_Click(object sender, RoutedEventArgs e)
        {
            
            string link = LinkBuilder.generateLinkDefenition(currentWord);
            browser_window.Load(link);
            hideRectangles(true);
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            hideRectangles(true);
        }

        private void hideRectangles(bool hide)
        {
            if (hide)
            {
                hide_word1.Visibility = Visibility.Hidden;
                hide_word2.Visibility = Visibility.Hidden;
            }
            else
            {
                hide_word1.Visibility=Visibility.Visible;
                hide_word2.Visibility = Visibility.Visible;
            }    
        }

        private void senstecestack_button_Click(object sender, RoutedEventArgs e)
        {
            string link = LinkBuilder.generateLinkSentenceStack(currentWord);
            browser_window.Load(link);
            hideRectangles(true);
        }

        private void yandex_button_Click(object sender, RoutedEventArgs e)
        {
            string link = LinkBuilder.generateLinkYandex(currentWord);
            browser_window.Load(link);
            hideRectangles(true);
        }

        private void reverso_button_Click(object sender, RoutedEventArgs e)
        {
            string link = LinkBuilder.generateLinkReverso(currentWord);
            browser_window.Load(link);
            hideRectangles(true);
        }

    }
}
