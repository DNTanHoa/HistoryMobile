using FireSharp;
using FireSharp.Response;
using HistoryMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace HistoryMobile.Services
{
    public class VideoService : IVideoService
    {
        public List<Video> GetByCategory(string CategoryOid)
        {
            var videos = FirebaseService.Get<Video>("/Videos");
            if(videos != null)
            {
                return videos
                    .Where(item => item.CategoryOid == CategoryOid).ToList();
            }
            return new List<Video>();
        }
    }
}
