using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.Components
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(id:1, title:"آموزش Asp.net Core", description:"کامل ترین پکیج آموزشی", image: "blog-post-thumb-1.jpg"),
            new Article(id: 2, title: "آموزش Git & Github", description: "کامل ترین پکیج آموزشی", image: "blog-post-thumb-2.jpg"),
            new Article(id: 3, title: "آموزش Onion Architecture", description: "کامل ترین پکیج آموزشی", image: "blog-post-thumb-3.jpg"),
            new Article(id: 4, title: "آموزش c++ & c#", description: "کامل ترین پکیج آموزشی", image: "blog-post-thumb-4.jpg")
            };
            return View("_LatestArticles", articles);
        }
    }
}
