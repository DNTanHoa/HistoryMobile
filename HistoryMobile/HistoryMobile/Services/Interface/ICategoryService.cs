using HistoryMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HistoryMobile.Services
{
    public interface ICategoryService
    {
        List<CategoryEvent> GetCategoryEvents();

        List<CategoryFamousPeople> GetCategoryFamousPeople();

        List<CategoryVideo> GetCategoryVideo();
    }
}
