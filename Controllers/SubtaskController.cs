using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace TaskAway.Controllers
{
    public class SubtaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
