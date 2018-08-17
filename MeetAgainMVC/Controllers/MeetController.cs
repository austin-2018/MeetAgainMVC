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

        static private List<string> Meetings = new List<string>();

        public IActionResult Index()
        {
            // List<string> meetings = new List<string>(); replaced with static List above

            //meetings.Add("Maria replaced with static List above
            // meetings.Add("Karla"); replaced with static List above
            //meetings.Add("Sharon"); replaced with static List above

            // ViewBag.meetings = meetings; with static list must change from small case to upper case as it is no longer a local variable
            ViewBag.meetings = Meetings;

            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult NewLastName(string lastname)
        {
            // Add new last name to existing last

            Meetings.Add(lastname);
            //return View();
            return Redirect("/Meet"); 
        }

    }
}
