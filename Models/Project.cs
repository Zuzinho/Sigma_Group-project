using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Sigma_Group_project.Models
{
    public class Project
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string PhotoUrl { get; private set; }
        public string Url { get; private set; }
        public string About { get; private set; }
        public int UserId { get; private set; }
        public string Technology { get; private set; }
        public bool Selected { get; private set; }

        public Project(int id, string title, string about, int userId, string technology, HttpPostedFileBase Avatar, string url = "")
        {

            Id = id;
            Title = title;
            Url = url;
            About = about;
            UserId = userId;
            Technology = technology;
            Selected = false;
            if (Avatar == null) return;
            string path = "C:\\Users\\user\\source\\repos\\Sigma\\Content\\img\\Projects_avatars";
            string ProjectAvatarName = "avatar" + id.ToString() + ".jpg";
            Avatar.SaveAs(Path.Combine(path, ProjectAvatarName));
            PhotoUrl = "/Content/img/Projects_avatars/" + ProjectAvatarName;
        }

        public Project(int id, string title, string about, int user_id, string technology, bool selected, string photoUrl, string url)
        {
            Id = id;
            Title = title;
            About = about;
            UserId = user_id;
            Technology = technology;
            Selected = selected;
            PhotoUrl = photoUrl;
            Url = url;
        }

        public void ChangeData(string title, string about, string technology, HttpPostedFileBase Avatar = null, string url = "")
        {
            Title = title;
            Url = url;
            About = about;
            Technology = technology;
            if (Avatar == null) return;
            string path = "C:\\Users\\user\\source\\repos\\Sigma\\Content\\img\\Projects_avatars";
            string ProjectAvatarName = "avatar" + Id.ToString() + ".jpg";
            Avatar.SaveAs(Path.Combine(path, ProjectAvatarName));
            PhotoUrl = "/Content/img/Projects_avatars/" + ProjectAvatarName;
        }
    }
}