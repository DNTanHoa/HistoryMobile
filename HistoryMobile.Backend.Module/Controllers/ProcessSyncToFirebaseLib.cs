using DevExpress.ExpressApp;
using HistoryMobile.Backend.Module.BusinessObjects;
using HistoryMobile.Backend.Module.DTO;
using HistoryMobile.Backend.Module.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public static void SyncCategoryFamousPeopleVideo(
            IObjectSpace objectSpace,
            List<CategoryFamousPeople> Categories)
        {
            foreach (var category in Categories)
            {
                if (!category.FirebaseSynced)
                {
                    var data = new CategoryFamousPeopleDTO
                    {
                        Code = category.Code,
                        Name = category.Name,
                        Image = category.Image,
                        Summary = category.Summary
                    };
                    var syncResult = FirebaseService.Insert("CategoryFamousPeople/", data);
                    category.FirebaseSynced = syncResult;
                    objectSpace.CommitChanges();
                }
            }
        }

        public static void SyncFamousPeople(
            IObjectSpace objectSpace,
            List<FamousPeople> famousPeople)
        {
            foreach (var item in famousPeople)
            {
                if(!item.FirebaseSynced)
                {
                    var data = new FamousPeopleDTO
                    {
                        Code = item.Code,
                        Title = item.Title,
                        Image = item.Image,
                        Summary = item.Summary,
                        Detail = item.Detail,
                        CategoryOids = item.CategoryOids.Select(item => item.Name).ToList()
                    };
                    var syncResult = FirebaseService.Insert("FamousPeople/", data);
                    item.FirebaseSynced = syncResult;
                    objectSpace.CommitChanges();
                }
            }
        }
    }
}
