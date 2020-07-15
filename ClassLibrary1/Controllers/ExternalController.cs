using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Controllers
{
    public class ExternalController : Controller
    {
        [HttpGet("external")]
        public IActionResult Index() => Content("External Controller");
    }
}
