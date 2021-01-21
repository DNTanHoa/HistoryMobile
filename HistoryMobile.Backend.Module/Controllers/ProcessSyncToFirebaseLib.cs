using DevExpress.ExpressApp;
using HistoryMobile.Backend.Module.BusinessObjects;
using HistoryMobile.Backend.Module.DTO;
using HistoryMobile.Backend.Module.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryMobile.Backend.Module.Controllers
{
    public class ProcessSyncToFirebaseLib
    {
        public static void SyncCategoryVideo(
            IObjectSpace objectSpace,
            List<CategoryVideo> categoryVideos)
        {
            foreach(var categoryVideo in categoryVideos)
            {
                if(!categoryVideo.FirebaseSynced)
                {
                    var data = new CategoryVideoDTO()
                    {
                        Name = categoryVideo.Name,
                        Code = categoryVideo.Code,
                        Image = categoryVideo.Image
                    };
                    var syncResult = FirebaseService.Insert("CategoryVideos/", data);
                    categoryVideo.FirebaseSynced = syncResult;
                    objectSpace.CommitChanges();
                }    
            }
        }

        public static void SyncVideo(
            IObjectSpace objectSpace,
            List<Video> Videos)
        {
            foreach (var video in Videos)
            {
                if (!video.FirebaseSynced)
                {
                    var data = new VideoDTO()
                    {
                        Title = video.Title,
                        Link = video.Link,
                        CategoryOid = video.CategoryVideo?.Name,
                    };
                    var syncResult = FirebaseService.Insert("Videos/", data);
                    video.FirebaseSynced = syncResult;
                    objectSpace.CommitChanges();
                }
            }
        }
    }
}
