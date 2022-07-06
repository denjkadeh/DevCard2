using DevCard_project2.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_project2.ViewComponents 
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"پروژه انبار"," دانشگاه مازندران","blog-post-thumb-card-1.jpg"),
                new Article(1,"پروژه حسابداری"," وروشه","blog-post-thumb-card-2.jpg"),
                new Article(1,"پروژه فروش"," آکووین","blog-post-thumb-card-3.jpg"),
                new Article(1,"پروژه بازاریابی"," آپاستیک","blog-post-thumb-card-4.jpg"),


            };
            return View("_LatestArticles", articles);
        }
    }
}
