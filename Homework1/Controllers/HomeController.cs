using Homework1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Homework1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(IndexViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }
        //    return View();
        //}


        [HttpPost]
        public IActionResult Index(IndexViewModel model)
        {
            var ResponseSucces = new ResponseViewModel
            {
                Data = "Giriş işlemi başarılı",
                Success = true,
                Error = "Null"

            };
            if (!ModelState.IsValid) //null değerler olması durumunda hata verecek 
            {
                var ResponseError = new ResponseViewModel
                {
                    Data = "Null",
                    Success = false,
                    Error = "Hatalı giriş"

                };

                ViewData["message"] = "Data :" + ResponseError.Data + ", Success: " + ResponseError.Success + ", Error: " + ResponseError.Error;



                return View();
            }
            ViewData["message"] = "Data :" + ResponseSucces.Data + ", Success: " + ResponseSucces.Success + ", Error: " + ResponseSucces.Error;
            return View(model);
        }

        public IActionResult LoginScreen()
        {
            return View();
        }


        [HttpPost]
        public IActionResult LoginScreen(IndexViewModel model)
        {
            var ResponseSucces = new ResponseViewModel
            {
                Data = "Giriş başarılı",
                Success = true,
                Error = "Null"

            };
            if (!ModelState.IsValid) //null değerler olması durumunda hata verecek 
            {
                var ResponseError = new ResponseViewModel
                {
                    Data = "Null",
                    Success = false,
                    Error = "Hatalı giriş"

                };

                ViewData["message"] = "Data :" + ResponseError.Data + ", Success: " + ResponseError.Success + ", Error: " + ResponseError.Error;



                return View();
            }
            ViewData["message"] = "Data :" + ResponseSucces.Data + ", Success: " + ResponseSucces.Success + ", Error: " + ResponseSucces.Error;
            return View(model);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}