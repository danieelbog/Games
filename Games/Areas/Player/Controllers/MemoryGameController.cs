using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Games.Areas.Player.Controllers
{
    public class MemoryGameController : Controller
    {
        [Area("Player")]
        public IActionResult Index()
        {
            return View();
        }
    }
}