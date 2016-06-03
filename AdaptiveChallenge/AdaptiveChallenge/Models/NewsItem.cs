using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveChallenge.Models
{
    public enum NewsCategory
    {
        Financial,
        Food,
    }

    class NewsItem
    {
        public NewsCategory Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string Dateline { get; set; }
        public string Image { get; set; }
        public int Id { get; set; }
    }

    class NewManager
    {
        public static List<NewsItem> getNewsItems()
        {
            List<NewsItem> lsNews = new List<NewsItem>();
            lsNews.Add(new NewsItem() { Id = 1, Category = NewsCategory.Financial, Headline = "Lorem Ipsum", Subhead = "doro sit amet", Dateline = "Nunc tristique nec", Image = "Assets/Financial1.png" });
            lsNews.Add(new NewsItem() { Id = 2, Category = NewsCategory.Financial, Headline = "Etiam ac felis viverra", Subhead = "vulputate nisl ac, aliquet nisi", Dateline = "tortor porttitor, eu fermentum ante congue", Image = "Assets/Financial2.png" });
            lsNews.Add(new NewsItem() { Id = 3, Category = NewsCategory.Financial, Headline = "Integer sed turpis erat", Subhead = "Sed quis hendrerit lorem, quis interdum dolor", Dateline = "in viverra metus facilisis sed", Image = "Assets/Financial3.png" });
            lsNews.Add(new NewsItem() { Id = 4, Category = NewsCategory.Financial, Headline = "Proin sem neque", Subhead = "aliquet quis ipsum tincidunt", Dateline = "Integer eleifend", Image = "Assets/Financial4.png" });
            lsNews.Add(new NewsItem() { Id = 5, Category = NewsCategory.Financial, Headline = "Mauris bibendum non leo vitae tempor", Subhead = "In nisl tortor, eleifend sed ipsum eget", Dateline = "Curabitur dictum augue vitae elementum ultrices", Image = "Assets/Financial5.png" });

            lsNews.Add(new NewsItem() { Id = 6, Category = NewsCategory.Food, Headline = "Lorem ipsum", Subhead = "dolor sit amet", Dateline = "Nunc tristique nec", Image = "Assets/Food1.png" });
            lsNews.Add(new NewsItem() { Id = 7, Category = NewsCategory.Food, Headline = "Etiam ac felis viverra", Subhead = "vulputate nisl ac, aliquet nisi", Dateline = "tortor porttitor, eu fermentum ante congue", Image = "Assets/Food2.png" });
            lsNews.Add(new NewsItem() { Id = 8, Category = NewsCategory.Food, Headline = "Integer sed turpis erat", Subhead = "Sed quis hendrerit lorem, quis interdum dolor", Dateline = "in viverra metus facilisis sed", Image = "Assets/Food3.png" });
            lsNews.Add(new NewsItem() { Id = 9, Category = NewsCategory.Food, Headline = "Proin sem neque", Subhead = "aliquet quis ipsum tincidunt", Dateline = "Integer eleifend", Image = "Assets/Food4.png" });
            lsNews.Add(new NewsItem() { Id = 10, Category = NewsCategory.Food, Headline = "Mauris bibendum non leo vitae tempor", Subhead = "In nisl tortor, eleifend sed ipsum eget", Dateline = "Curabitur dictum augue vitae elementum ultrices", Image = "Assets/Food5.png" });

            return lsNews;
        }

        public static void GetNews(NewsCategory category, ObservableCollection<NewsItem> newsItems)
        {
            List<NewsItem> lsNewsItem = getNewsItems();

            List<NewsItem> filterdNewItem = lsNewsItem.Where(p => (p.Category == category)).ToList();

            newsItems.Clear();

            filterdNewItem.ForEach( p => newsItems.Add(p));
            //foreach (var p in filterdNewItem)
            //{
            //    newsItems.Add(p);
            //}
        }
    }
}
