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

using System.Collections.ObjectModel;
using App1.Models;
using SQLite.Net;
using Windows.Storage;

namespace App1
{
    public sealed partial class MainPage : Page
    {
        ObservableCollection<Article> Articles;
        string path;
        SQLiteConnection conn;

        public MainPage()
        {
            this.InitializeComponent();
            path = Path.Combine(ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<SavedNewsInstance>();
            Articles = new ObservableCollection<Article>();
            GetAR("Trump", "2021-03-17", "publishedAt", "20f0bc79a63947818867de418e5f4ab3");
        }

        private async void GetAR(string q, string from, string SortBy, string ApiKey)
        {
            //var url = string.Format("https://newsapi.org/v2/everything?q={0}&from={1}&sortBy={2}&apiKey={3}", q, from, SortBy, ApiKey);
            var url = string.Format("https://newsapi.org/v2/everything?language=en&q={0}&from={1}&sortBy={2}&apiKey={3}", q, from, SortBy, ApiKey);
            var news = await New.GetNew(url);
            Articles.Clear();
            news.articles.ForEach(n => {
                Articles.Add(n);
            });
        }

        private void View_ItemClick(object sender, ItemClickEventArgs e)
        {
            Article ar = e.ClickedItem as Article;
            
            Frame.Navigate(typeof(ArticleView), ar);
        }

        private void bookmarShowkBtn_Click(object sender, RoutedEventArgs e)
        {
            var bookmarks = conn.Table<SavedNewsInstance>().ToList() ;
            Articles.Clear();
            bookmarks.ForEach(news => {
                Article a = SavedInstanceToNomalNews.transform(news);
                Articles.Add(a);
            });
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            string phrase = searchText.Text;
            GetAR(phrase, "2021-03-17", "publishedAt", "20f0bc79a63947818867de418e5f4ab3");
        }
    }
}
