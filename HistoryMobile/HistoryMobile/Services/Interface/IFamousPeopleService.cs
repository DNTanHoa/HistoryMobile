using HistoryMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryMobile.Services
{
    public interface IFamousPeopleService
    {
        List<FamousPeople> GetByCategory(string CategoryOid);

        List<FamousPeople> GetByCategoryPaging(string CategoryOid, int Page, int PageSize);

        FamousPeople GetByOid(string Oid);
    }
}
