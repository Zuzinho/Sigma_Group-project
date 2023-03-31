using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sigma_Group_project.Models
{
    public class Link
    {
        public int Id { get; private set; }
        public string Provider { get; private set; }
        public string Url { get; private set; }
        public int UserId { get; private set; }
        public string ProviderAvatarUrl { get; private set; }

        public Link(int id, string provider, string url, int userId, string providerAvatarUrl)
        {
            Id = id;
            Provider = provider;
            Url = url;
            UserId = userId;
            ProviderAvatarUrl = providerAvatarUrl;
        }
    }
}