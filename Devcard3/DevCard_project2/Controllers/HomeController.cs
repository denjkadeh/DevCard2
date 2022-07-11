using DevCard_project2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevCard_project2.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}
        // مدل بایدینگ
        [HttpPost]
        public JsonResult Contact(Contact form)
        {
            Console.WriteLine(form.ToString());
            return Json(Ok());
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JavascriptResult Test2()
        {
            return new JavascriptResult("alert('سلام احمد رحیمی هستم') ");
        }

        public RedirectResult Index2()
        {
            return Redirect("http://www.baran-company.ir");

        }

        public RedirectToActionResult index3()
        {
            return RedirectToAction("Contact", "Home");
        }

        public IActionResult index4()
        {
            //return new OkResult();
            // return new NotFoundResult();
            //  return new BadRequestResult();
            return new NoContentResult();

        }
    }

    public class JavascriptResult : ContentResult
    {
        public JavascriptResult(string data)
        {
            Content = data;
            ContentType = "application/javascript";
        }
    }

}