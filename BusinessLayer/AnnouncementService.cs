using FindMeARoomate.DataLayer.Entities;
using FindMeARoomate.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoomate.BusinessLayer
{
    public class AnnouncementService
    {
        #region Business Layer
        //Announcement Business Logic
        //Get All announcements
        public List<Announcement> GetAnnouncements()
        {
            var announcementRepo = new AnnouncementRepository();
            var announcements = announcementRepo.GetAllAnnouncement();
            return announcements;
        }
        //Make an announcement
        public void MakeAnnouncement()
        {
            Console.WriteLine("Make an Announcement");
            var announcement = new Announcement();
            Console.WriteLine("Enter Title");
            announcement.Title = Console.ReadLine();
            Console.WriteLine("Enter Description");
            announcement.Title = Console.ReadLine();
            Console.WriteLine("Enter PublishedDate");
            announcement.PublishedDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter student ID");
            announcement.StudentID = int.Parse(Console.ReadLine());
            
            //Add Announcement
            var announcementRepository = new AnnouncementRepository();
            announcementRepository.AddAnnouncement(announcement);
        }
        //
        //Announcement Business Logic
        #endregion
    }
}
