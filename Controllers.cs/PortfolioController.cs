using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers 
{
    public class portfolio : Controller 
    {
        [HttpGet]
        [Route("Home")]
        public IActionResult Home()
        {
            return View("Home");
        }

        [HttpGet]
        [Route("Home/Projects")]
        public IActionResult Projects()
        {
            return View("Projects");
        }

        [HttpGet]
        [Route("Home/Projects/Contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }

    }
} 