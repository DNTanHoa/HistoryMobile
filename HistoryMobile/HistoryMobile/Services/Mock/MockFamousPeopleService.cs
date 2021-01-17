using HistoryMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HistoryMobile.Services
{
    public class MockFamousPeopleService : IFamousPeopleService
    {
        public List<FamousPeople> GetByCategory(string CategoryOid)
        {
            return MockFamousPeople.Where(item => item.CategoryOid == CategoryOid).ToList();
        }

        public List<FamousPeople> GetByCategoryPaging(string CategoryOid, int Page, int PageSize)
        {
            return MockFamousPeople.Where(item => item.CategoryOid == CategoryOid)
                .Skip(Page*PageSize)
                .Take(PageSize)
                .ToList();
        }

        public FamousPeople GetByOid(string Oid)
        {
            return MockFamousPeople.First();
        }

        public List<FamousPeople> MockFamousPeople = new List<FamousPeople>()
        {
            new FamousPeople
            {
                Oid = Guid.NewGuid().ToString(),
                Title = "Hồ Chí Minh (1890 - 1969)",
                Summary = "Là một nhà cách mạng, người sáng lập Đảng Cộng Sản Việt Nam, " +
                "một trong những người đặt nền và lãnh đạo công cuộc đấu tranh giành độc lập, toàn vẹn lãnh thổ",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/Ho_Chi_Minh_1946.jpg/220px-Ho_Chi_Minh_1946.jpg",
                Detail = "",
                CategoryOid = "Nhân vật lịch sử Việt Nam",
            },
            new FamousPeople
            {
                Oid =Guid.NewGuid().ToString(),
                Title = "Nguyễn Trãi (1380 – 19 tháng 9 năm 1442)",
                Summary = "Nguyễn Trãi hiệu là Ức Trai (抑齋), là một nhà chính trị, nhà văn, người đã tham gia tích cực " +
                "khởi nghĩa Lam Sơn do Lê Lợi lãnh đạo chống lại sự xâm lược của nhà Minh (Trung Quốc) với Đại Việt.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c6/Nguyen_Trai.jpg/220px-Nguyen_Trai.jpg",
                Detail = "",
                CategoryOid = "Nhân vật lịch sử Việt Nam",
            },
        };
    }
}
