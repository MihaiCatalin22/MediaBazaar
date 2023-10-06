using Logic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IAnnoucementController
    {
        void AddAnnouncement(Announcement announcement);
        void RemoveAnnouncement(int id);
        Announcement GetAnnouncement(int id);
        Announcement[] GetAllAnnouncements();
        Announcement EditAnnouncement(Announcement announcement);
    }
}
