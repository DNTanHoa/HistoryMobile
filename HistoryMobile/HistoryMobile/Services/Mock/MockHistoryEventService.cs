using HistoryMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HistoryMobile.Services
{
    public class MockHistoryEventService : IHistoryEventService
    {
        public List<HistoryEvent> GetListByEnventPaging(int Page, int PageZie)
        {
            return MockHistoryEventData.Skip(Page*PageZie).Take(PageZie).ToList();
        }

        public List<HistoryEvent> MockHistoryEventData = new List<HistoryEvent>
        {
            new HistoryEvent
            {
                Title = "Cuộc cách mạng công ghiệp thế giới",
                Summary = "Cuộc cách mạng công nghiệp đầu tiên trên thế giới được bắt đầu ở nước Anh vào cuối thế kỷ 18 đầu thế kỷ 19, mở đầu với sự cơ giới hóa ngành dệt may. Lúc bấy giờ, các nhà máy dệt đều phải đặt gần sông để lợi dụng sức nước chảy, điều đó gây bất tiện ở nhiều mặt",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9e/Maquina_vapor_Watt_ETSIIM.jpg/300px-Maquina_vapor_Watt_ETSIIM.jpg",
            },
            new HistoryEvent
            {
                Title = "Con người tìm ra lửa cách đây 1,4 triệu năm",
                Summary = "Phát minh đầu tiên đánh dấu bước tiến hoá vượt bậc của loài người so với tổ tiên hoang dã đó là việc tìm và tạo ra lửa.",
                Image = "https://genk.mediacdn.vn/k:2015/1-1451097196454-crop-1451102950663-1451125985568/14-su-kien-lam-thay-doi-lich-su-quan-su-the-gioi-mai-mai.jpg",
            },
            new HistoryEvent
            {
                Title = "Cung tên được phát minh cách đây 15.000 năm TCN",
                Summary = "Dù không biết chính xác thời điểm phát minh, nhưng những mũi tên và cung tên đầu tiên trên thế giới được cho là làm từ những nguyên liệu dễ bị hư hỏng. Những cây cung cổ nhất được tìm thấy tại đầm lầy Holmegaard ở Đan Mạch, có niên đại cách đây khoảng 9000 năm TCN. Con người đã biết dùng cung tên để săn bắn và chống lại kẻ thù.",
                Image = "https://genk.mediacdn.vn/k:2015/1-14-su-kien-lam-thay-doi-lich-su-quan-su-the-gioi-mai-mai-1451125996948/14-su-kien-lam-thay-doi-lich-su-quan-su-the-gioi-mai-mai.jpg",
            },
            new HistoryEvent
            {
                Title = "Cuộc cách mạng công ghiệp thế giới",
                Summary = "Cuộc cách mạng công nghiệp đầu tiên trên thế giới được bắt đầu ở nước Anh vào cuối thế kỷ 18 đầu thế kỷ 19, mở đầu với sự cơ giới hóa ngành dệt may. Lúc bấy giờ, các nhà máy dệt đều phải đặt gần sông để lợi dụng sức nước chảy, điều đó gây bất tiện ở nhiều mặt",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9e/Maquina_vapor_Watt_ETSIIM.jpg/300px-Maquina_vapor_Watt_ETSIIM.jpg",
            },
            new HistoryEvent
            {
                Title = "Cuộc cách mạng công ghiệp thế giới",
                Summary = "Cuộc cách mạng công nghiệp đầu tiên trên thế giới được bắt đầu ở nước Anh vào cuối thế kỷ 18 đầu thế kỷ 19, mở đầu với sự cơ giới hóa ngành dệt may. Lúc bấy giờ, các nhà máy dệt đều phải đặt gần sông để lợi dụng sức nước chảy, điều đó gây bất tiện ở nhiều mặt",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9e/Maquina_vapor_Watt_ETSIIM.jpg/300px-Maquina_vapor_Watt_ETSIIM.jpg",
            },
        };
    }
}
