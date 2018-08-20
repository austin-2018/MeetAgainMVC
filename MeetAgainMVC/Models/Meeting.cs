using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetAgainMVC.Models
{
    public class Meeting
    {
        public string Thename { get; set; }
        public string Description { get; set; }

        public Meeting(string thename, string description)//constructor
        {
            Thename = thename;
            Description = description;
        }

        public Meeting() { }//default constructor
    }
}
