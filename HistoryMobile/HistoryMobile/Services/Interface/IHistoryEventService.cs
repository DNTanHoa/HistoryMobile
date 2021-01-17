using HistoryMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryMobile.Services
{
    public interface IHistoryEventService
    {
        List<HistoryEvent> GetListByEnventPaging(int Page, int PageZie);
    }
}
