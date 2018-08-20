using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeetAgainMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeetAgainMVC.Controllers
{
    public class MeetController : Controller
    {
        // GET: /<controller>/

        //static private List<string> Meetings = new List<string>();
        //static private Dictionary<string, string> Meetings = new Dictionary<string, string>();
        static private List<Meeting> Meetings = new List<Meeting>();
       //Dictionary where first string will be last name, second will be description

        public IActionResult Index()
        {

            ViewBag.meetings = Meetings;

            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Route("Meet/Add")]
        public IActionResult NewTheName(string thename, string description = "")
        {
            //Below uses default constructor in Meeting.cs

            Meeting newMeeting = new Meeting
            {
                Description = description,
                Thename = thename
            };

            Meetings.Add(newMeeting);

            //Meetings.Add(new Meeting(thename, description));
            //return View();
            return Redirect("/Meet"); 
        }

    }
}
