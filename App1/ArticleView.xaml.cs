using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using App1.Models;
using Windows.UI.Xaml.Media.Imaging;
using SQLite.Net;
using Windows.Storage;
using System.Diagnostics;

namespace App1
{
    public sealed partial class ArticleView : Page
    {
        private Article article;
        string path;
        SQLiteConnection conn;

        public ArticleView()
        {
            this.InitializeComponent();
            path = Path.Combine(ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<SavedNewsInstance>();
            Debug.WriteLine(path);


        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            article = e.Parameter as Article;

            Image.Source = new BitmapImage(new Uri(article.urlToImage, UriKind.Absolute));
            Author.Text = article.author;
            Title.Text = article.title;
            Description.Text = article.description;
            Content.Text = article.content;
            base.OnNavigatedTo(e);
        }

        private void BtnHomePage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void bookmarkBtn_Click(object sender, RoutedEventArgs e)
        {

            SavedNewsInstance s = new SavedNewsInstance()
            {
                author = article.author,
                title = article.title,
                description = article.description,
                content = article.content,
                urlToImage = article.urlToImage
            };

            conn.Insert(s);

            bookmarkBtn.Icon = new SymbolIcon(Symbol.Accept);
        }
    }
}
