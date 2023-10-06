using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes
{
    public class Announcement
    {
        public Announcement() { }
        public Announcement(int id, string title, string details, DateTime startDate, DateTime endDate) 
        { 
            Id = id;
            Title = title;
            Details = details;
            StartDate = startDate;
            EndDate = endDate;

        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
