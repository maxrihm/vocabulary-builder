using System;
using System.Collections.Generic;
using System.Windows;
using CefSharp.Wpf;

namespace Vocabulary
{
    public partial class MainWindow : Window
    {
        private readonly ReadExcel reader = new ReadExcel();
        private readonly Random rnd = new Random();
        private ExcelRow currentWord;

        public MainWindow()
        {
            CefSettings settings = new CefSettings
            {
                CachePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\CEF"
            };
            CefSharp.Cef.Initialize(settings);

            InitializeComponent();
            reader.readWholeFile();
            ShowNextWord();
        }

        private void translation_button_Click(object sender, RoutedEventArgs e)
        {
            DisplayBrowserWindow(LinkBuilder.generateLinkGoogle(currentWord));
        }

        private void next_word_button_Click(object sender, RoutedEventArgs e)
        {
            ShowNextWord();
        }

        private void lengusa_button_Click(object sender, RoutedEventArgs e)
        {
            DisplayBrowserWindow(LinkBuilder.generateLinkLengusa(currentWord));
        }

        private void definition_button_Click(object sender, RoutedEventArgs e)
        {
            DisplayBrowserWindow(LinkBuilder.generateLinkDefenition(currentWord));
        }

        private void senstecestack_button_Click(object sender, RoutedEventArgs e)
        {
            DisplayBrowserWindow(LinkBuilder.generateLinkSentenceStack(currentWord));
        }

        private void yandex_button_Click(object sender, RoutedEventArgs e)
        {
            DisplayBrowserWindow(LinkBuilder.generateLinkYandex(currentWord));
        }

        private void reverso_button_Click(object sender, RoutedEventArgs e)
        {
            DisplayBrowserWindow(LinkBuilder.generateLinkReverso(currentWord));
        }

        private void Rectangle_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            HideRectangles();
        }

        private void HideRectangles()
        {
            hide_word1.Visibility = Visibility.Hidden;
            hide_word2.Visibility = Visibility.Hidden;
        }

        private void ShowNextWord()
        {
            int rand = rnd.Next(reader.words.Count);
            currentWord = reader.words[rand];
            current_word_label.Content = currentWord.word;
            HideRectangles();
            DisplayBrowserWindow(LinkBuilder.generateLinkGoogle(currentWord));
        }

        private void DisplayBrowserWindow(string link)
        {
            browser_window.Load(link);
            HideRectangles();
        }
    }
}
