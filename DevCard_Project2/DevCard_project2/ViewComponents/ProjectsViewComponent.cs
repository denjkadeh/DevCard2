﻿using System.Collections.Generic;
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
              new  Project2 (id:1,name:"احمد",description:"استاد احمد رحیمی ",client:"شماره شناسایی 12"),
              new  Project2 (id:2,name:"رضا",description:"استاد رضا رحیمی ",client:"شماره شناسایی 13"),
              new  Project2 (id:3,name:"محسن",description:"استاد محسن رحیمی ",client:"شماره شناسایی 14"),
              new  Project2 (id:4,name:"علی",description:"استاد علی رحیمی ",client:"شماره شناسایی 15"),

            };
            return View("_Projects",projects);
        }

    }
}
