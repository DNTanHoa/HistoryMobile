using HistoryMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryMobile.Services
{
    public class MockCategoryService : ICategoryService
    {
        public List<CategoryEvent> GetCategoryEvents()
        {
            return MockCateroyEventData;
        }

        public List<CategoryFamousPeople> GetCategoryFamousPeople()
        {
            return MockCategoryFamousPeople;
        }

        public List<CategoryVideo> GetCategoryVideo()
        {
            return MockCategoryVideo;
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

        public List<CategoryVideo> MockCategoryVideo = new List<CategoryVideo>()
        {
            new CategoryVideo
            {
                Name = "Sử lược - Tóm tắt lịch sử",
                Image = "https://yt3.ggpht.com/ytc/AAUvwnhjXtSx-nCmm6fHw9tKojfD6QceKeK6FrXH1M5EgA=s88-c-k-c0x00ffffff-no-rj"
            },
            new CategoryVideo
            {
                Name = "Người nổi tiếng",
                Image = "https://yt3.ggpht.com/ytc/AAUvwniUcFuLxvlSAMAU-ANghhsOX05AQZwk4gA65wW7sA=s88-c-k-c0x00ffffff-no-rj"
            },
            new CategoryVideo
            {
                Name = "Lịch sử tóm tắt",
                Image = "https://yt3.ggpht.com/ytc/AAUvwnh0B6LQaynfXPkx_uPNtQ_TrteROrji52Jd5j0u=s88-c-k-c0x00ffffff-no-rj"
            },
        };
    }
}
