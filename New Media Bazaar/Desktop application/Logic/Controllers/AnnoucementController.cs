using Logic.Classes;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Controllers
{
    public class AnnoucementController
    {
        private readonly IAnnoucementController accessAnnoucement;
        public AnnoucementController(IAnnoucementController accessAnnoucement) 
        {
            this.accessAnnoucement = accessAnnoucement;
        }

        public void AddAnnouncement(Announcement annoucement)
        {
            accessAnnoucement.AddAnnouncement(annoucement);
        }
        public void UpdateAnnouncement(Announcement annoucement)
        {
            accessAnnoucement.UpdateAnnouncement(annoucement);
        }

        public void RemoveAnnouncement(int  id)
        {
            accessAnnoucement.RemoveAnnouncement(id);
        }

        public Announcement GetAnnouncement(int id)
        {
            return accessAnnoucement.GetAnnouncement(id);
        }
        
        public Announcement[] GetAllAnnouncements()
        {
            return accessAnnoucement.GetAllAnnouncements();
        }
        public Announcement EditAnnouncement(Announcement announcement)
        {
            return accessAnnoucement.EditAnnouncement(announcement);
        }
    }
}
