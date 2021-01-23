using HistoryMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryMobile.Services
{
    public class CategoryService : ICategoryService
    {
        public List<CategoryEvent> GetCategoryEvents()
        {
            return MockCateroyEventData;
        }

        public List<CategoryFamousPeople> GetCategoryFamousPeople()
        {
            return FirebaseService.Get<CategoryFamousPeople>("/CategoryFamousPeople");
        }

        public List<CategoryVideo> GetCategoryVideo()
        {
            return FirebaseService.Get<CategoryVideo>("/CategoryVideos");
        }

        public List<CategoryEvent> MockCateroyEventData = new List<CategoryEvent>()
        {
            new CategoryEvent
            {
                Oid = Guid.NewGuid(),
                Name = "Việt Nam",
                IsActive = true,
            },
            new CategoryEvent
            {
                Oid = Guid.NewGuid(),
                Name = "Trung Quốc",
                IsActive = false,
            },
            new CategoryEvent
            {
                Oid = Guid.NewGuid(),
                Name = "Thế giới",
                IsActive = false,
            },
            new CategoryEvent
            {
                Oid = Guid.NewGuid(),
                Name = "Ngành công nghiệp",
                IsActive = false,
            },
        };

        public List<CategoryFamousPeople> MockCategoryFamousPeople = new List<CategoryFamousPeople>
        {
            new CategoryFamousPeople
            {
                Image = "https://img.dantocmiennui.vn/t620/uploaddtmn//2017/4/17/quocky-1.gif",
                Name = "Nhân vật lịch sử Việt Nam",
                Summary = "Tổng hợp nhân vật có tầm ảnh hưởng trong quá trình của lịch sử Việt Nam"
            },
            new CategoryFamousPeople
            {
                Image = "https://img.tinbaihay.net/ThumbImages/2015/02/23/10-phat-minh-khoa-hoc-quan-trong-nhat-trong-lich-su-nhan-loai-9fc2_450.jpg",
                Name = "Nhà khoa học",
                Summary = "Tổng hợp nhà nghiên cứu khoa học, nhà phát minh vĩ đại của nhân loại"
            },
            new CategoryFamousPeople
            {
                Image = "https://danviet.mediacdn.vn/upload/1-2019/images/2019-03-18/5-danh-tuong-tai-gioi-nhat-lich-su-Viet-Nam-652-1552894512-width500height500.jpg",
                Name = "Các vị tướng, nhà quân sự",
                Summary = "Thông tin các vị tướng, quân sư, chuyên gia quân sự nổi tiếng"
            }
        };
    }
}
