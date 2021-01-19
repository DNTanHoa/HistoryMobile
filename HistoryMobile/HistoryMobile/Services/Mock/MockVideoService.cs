using HistoryMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HistoryMobile.Services
{
    public class MockVideoService : IVideoService
    {
        public List<Video> GetByCategory(string CategoryOid)
        {
            return MockVideos.Where(item => item.CategoryOid == CategoryOid).ToList();
        }

        public List<Video> MockVideos = new List<Video>()
        {
            new Video
            {
                Title = "Tóm tắt: Chiến tranh Thanh - Nhật (1894 - 1895) | Lịch sử thế giới",
                CategoryOid = "Sử lược - Tóm tắt lịch sử",
                Link = "https://www.youtube.com/embed/kYlTkL74RQE",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Tóm tắt: Chiến tranh Nga - Nhật (1904 - 1905) | Lịch sử thế giới",
                CategoryOid = "Sử lược - Tóm tắt lịch sử",
                Link = "https://www.youtube.com/embed/svHxQ0gjIZc",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "[FULL] Tóm Tắt: Nhà Trần (1225 - 1400) | Lịch sử phong kiến Việt Nam",
                CategoryOid = "Sử lược - Tóm tắt lịch sử",
                Link = "https://www.youtube.com/embed/Jr3bWJwnG98",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Tóm tắt: Thế Chiến Thứ 2 (1939 - 1945) | World War 2 | Lịch sử Thế Giới",
                CategoryOid = "Sử lược - Tóm tắt lịch sử",
                Link = "https://www.youtube.com/embed/nppZmchtVnE",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Tóm tắt: Thế Chiến Thứ 1 (1914 - 1918) | World War 1 | Lịch sử Thế Giới",
                CategoryOid = "Sử lược - Tóm tắt lịch sử",
                Link = "https://www.youtube.com/embed/M1zIOPrVuoM",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Khang Hy – Vị Hoàng Đế Trị Vì Lâu Nhất Trong Lịch Sử Phong Kiến Trung Hoa",
                CategoryOid = "Người nổi tiếng",
                Link = "https://www.youtube.com/embed/GL72lW9D5HQ",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Chu Nguyên Chương - Kẻ Ăn Mày Trở Thành Hoàng Đế Gây Tranh Cãi Trong Lịch Sử Trung Hoa",
                CategoryOid = "Người nổi tiếng",
                Link = "https://www.youtube.com/embed/_0AYQ8mylxc",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Nguyễn Trãi – Công Thần Thời Hậu Lê Và Án Oan Lệ Chi Viên",
                CategoryOid = "Người nổi tiếng",
                Link = "https://www.youtube.com/embed/tglfEFovtJM",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Ba Nhân Tài Việt Sản Xuất Vũ Khí Khiến Giặc Ngoại Xâm Khiếp Sợ",
                CategoryOid = "Người nổi tiếng",
                Link = "https://www.youtube.com/embed/FaVwRI-_ypw",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Những Cái Tên Đưa Hai Chữ Việt Nam Rạng Danh Thế Giới – Phần 1",
                CategoryOid = "Người nổi tiếng",
                Link = "https://www.youtube.com/embed/NgBbNd-rdm0",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Albert Einstein - Kẻ Lữ Hành Đơn Độc, Một Mình Thay Đổi Thế Giới Và Thâu Tóm Vũ Trụ",
                CategoryOid = "Người nổi tiếng",
                Link = "https://www.youtube.com/embed/VBvQzlqc9cA",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Tóm Tắt Lịch Sử - Chiến Tranh Lạnh",
                CategoryOid = "Lịch sử tóm tắt",
                Link = "https://www.youtube.com/embed/OuVu8gIuzzo",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Tóm Tắt Nhanh Lịch Sử Nhật Bản - Thời Kì Minh Trị",
                CategoryOid = "Lịch sử tóm tắt",
                Link = "https://www.youtube.com/embed/HVo0x2VvXEI",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Tóm Tắt Nhanh Lịch Sử Đế Quốc Mông Cổ Và Thành Cát Tư Hãn",
                CategoryOid = "Lịch sử tóm tắt",
                Link = "https://www.youtube.com/embed/eog3Erno6wY",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Tóm Tắt Nhanh Đế Quốc Nhật",
                CategoryOid = "Lịch sử tóm tắt",
                Link = "https://www.youtube.com/embed/ahosPWzs4_0",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Tóm Tắt Lịch Sử - Sự Trỗi Dậy Của Nhà Thanh",
                CategoryOid = "Lịch sử tóm tắt",
                Link = "https://www.youtube.com/embed/cCdH3CC2Y6I",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Nhà Lý – Vương Triều Mở Ra Kỷ Nguyên Đại Việt Trong Lịch Sử Việt Nam",
                CategoryOid = "Người nổi tiếng",
                Link = "https://www.youtube.com/embed/jABCmgUHKNA",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Hoàng Hoa Thám - “Hùm Thiêng Yên Thế” Và Cuộc Khởi Nghĩa Kéo Dài 30 Năm",
                CategoryOid = "Người nổi tiếng",
                Link = "https://www.youtube.com/embed/6tzccznxoxg",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Hoàng Diệu – Vị Tổng Đốc Tuẫn Tiết Cùng Thành Hà Nội",
                CategoryOid = "Người nổi tiếng",
                Link = "https://www.youtube.com/embed/M_lmJvOiUQY",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Hồ Quý Ly – Nhân Vật Gây Tranh Cãi Bậc Nhất Lịch Sử Phong Kiến VN",
                CategoryOid = "Người nổi tiếng",
                Link = "https://www.youtube.com/embed/uvtEnP9HMWk",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Lê Long Đĩnh - Vị Vua Cuối Cùng Của Nhà Tiền Lê Và Sự Thật Đằng Sau Sự Tàn Độc",
                CategoryOid = "Người nổi tiếng",
                Link = "https://www.youtube.com/embed/h1yvpJVBoxg",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Trạng Lường Lương Thế Vinh - Nhà Toán Học Hiếm Hoi Thời Phong Kiến VN",
                CategoryOid = "Người nổi tiếng",
                Link = "https://www.youtube.com/embed/5Dh_0EVLvVA",
                Oid = Guid.NewGuid()
            },
            new Video
            {
                Title = "Vua Duy Tân – Giấc Mộng Buồn Của Vị Vua Nhỏ Tuổi Nhất Triều Nguyễn",
                CategoryOid = "Người nổi tiếng",
                Link = "https://www.youtube.com/embed/4cByP6qZkAo",
                Oid = Guid.NewGuid()
            },
        };
    }
}
