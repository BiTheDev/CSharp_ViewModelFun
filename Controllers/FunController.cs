using System;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers     //be sure to use your own project's namespace!
    {
        public class FunController : Controller
        {

        [HttpGet]
            [Route("")]

            public IActionResult Index(){
                User Message = new User()
                {
                message = "Building mr concerns servants in he outlived am breeding. He so lain good miss when sell some at if. Told hand so an rich gave next. How doubt yet again see son smart."
                };
                return View("index", Message);
                }
                

            [HttpGet]
            [Route("number")]
            public IActionResult Number(){
                User number = new User()
                {
                    numbers = new double[]{1,2,3,4.5,5,65,6,78,}
                };
                return View("number", number);
            }

            [HttpGet]
            [Route("user")]
            public IActionResult user(){
                User Single = new User()
                {
                    name = new string[]{"Chee", "Brian", "Pedro", "Eric", "Matt"}
                };
                return View("user", Single);
            }

            [HttpGet]
            [Route("users")]
            public IActionResult users(){
                User users = new User()
                {
                    name = new string[]{"Chee", "Brian", "Pedro", "Eric", "Matt"}
                };
                return View("users", users);
            }
        }
    }
