using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.Components
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(id:1, name:"تاکسی", description:"درخواست آنلاین تاکسی برای سفرهای درون شهری",image:"project-1.jpg", client:"Snapp"),
                new Project(id:2, name:"زودفود", description:"درخواست آنلاین غذا برای سراسر کشور", image:"project-2.jpg", client:"ZOODFOOD"),
                new Project(id:3, name:"مدارس", description:"سیستم مدیریت یکپارچه مدارس", image:"project-3.jpg", client:"MONOP"),
                new Project(id:4, name:"فضاپیما", description:"برنامه مدیریت فضاپیماهای ناسا", image:"project-4.jpg", client:"NASA"),
            };
            return View("_Projects", projects);
        }
    }
}
