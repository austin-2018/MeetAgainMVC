using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeetAgainMVC.Controllers
{
    public class MeetController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<string> meetings = new List<string>();

            meetings.Add("Maria");
            meetings.Add("Karla");
            meetings.Add("Sharon");

            ViewBag.meetings = meetings;

            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
