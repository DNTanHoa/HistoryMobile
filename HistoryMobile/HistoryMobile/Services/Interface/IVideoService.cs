using HistoryMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryMobile.Services
{
    public interface IVideoService
    {
        List<Video> GetByCategory(string CategoryOid);
    }
}
