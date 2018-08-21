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
        public int MeetingId { get; set; }
        private static int nextId = 1;


        public Meeting()
        {//still the default constructor ensures each Meeting object has a unique ID
            MeetingId = nextId;
            nextId++;
        }
    }
}
