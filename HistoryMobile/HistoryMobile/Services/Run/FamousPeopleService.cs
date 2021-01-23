using HistoryMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HistoryMobile.Services
{
    public class FamousPeopleService : IFamousPeopleService
    {
        public List<FamousPeople> GetByCategory(string CategoryOid)
        {
            var data = FirebaseService.Get<FamousPeople>("/FamousPeople");
            return data.Where(item => item.CategoryOids.Contains(CategoryOid)).ToList();
        }

        public List<FamousPeople> GetByCategoryPaging(string CategoryOid, int Page, int PageSize)
        {
            throw new NotImplementedException();
        }

        public FamousPeople GetByOid(string Oid)
        {
            throw new NotImplementedException();
        }
    }
}
