using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    public class SavedNewsInstance
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string urlToImage { get; set; }
        public string content { get; set; }
    }
    public class SavedInstanceToNomalNews
    {
        public static Article transform(SavedNewsInstance s)
        {
            return new Article()
            {
                author = s.author,
                title = s.title,
                description = s.description,
                urlToImage = s.urlToImage,
                content = s.content
            };
        }
    }
}
