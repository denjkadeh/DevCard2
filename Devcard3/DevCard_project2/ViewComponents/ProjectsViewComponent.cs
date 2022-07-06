using System.Collections.Generic;
using DevCard_project2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace DevCard_project2.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           
            var projects = new List<Project2 >
            {
              new  Project2 (id:1,name:"علی",description:" برنامه نویس و عضو هیات مدیره علی  ","project-1.jpg",client:"برنامه نویس و عضو هیات مدیره1"),
              new  Project2 (id:2,name:"نیما",description:"نیما برنامه نویس و عضو هیات مدیره ","project-2.jpg",client:"برنامه نویس و عضو هیات مدیره2"),
              new  Project2 (id:3,name:"میلاد",description:"برنامه نویس و عضو هیات مدیره میلاد ","project-3.jpg",client:"برنامه نویس و عضو هیات مدیره3"),
              new  Project2 (id:4,name:"آصف",description:"آصف برنامه نویس و عضو هیات مدیره ","project-4.jpg", client:"برنامه نویس و عضو هیات مدیره4"),

            };
            return View("_Projects",projects);
        }

    }
}
