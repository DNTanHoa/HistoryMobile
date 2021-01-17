using HistoryMobile.Models;
using HistoryMobile.Services;
using MvvmHelpers;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace HistoryMobile.ViewModels
{
    public class NewListPageViewModel : ViewModelBase
    {
        private readonly IHistoryEventService historyEventService;
        private readonly ICategoryService categoryService;

        public NewListPageViewModel(INavigationService navigationService,
            IHistoryEventService historyEventService,
            ICategoryService categoryService)
            :base(navigationService)
        {
            Title = "Sự kiện lịch sử";
            this.historyEventService = historyEventService;
            this.categoryService = categoryService;
            Page = 0;
            PageSize = 10;

            this.Events = historyEventService.GetListByEnventPaging(this.Page, this.PageSize);
            
            this.Categories = new ObservableRangeCollection<CategoryEvent>(categoryService.GetCategoryEvents());

            CategoryTappedCommand = new DelegateCommand<object>(async (Oid) => await CategoryTappedCommandExecute(Oid));
        }

        private int page;
        public int Page
        {
            get => page;
            set => SetProperty(ref page, value);
        }

        private int pageSize;
        public int PageSize
        {
            get => pageSize;
            set => SetProperty(ref pageSize, value);
        }

        private List<HistoryEvent> events;
        public List<HistoryEvent> Events
        {
            get => events;
            set
            {
                SetProperty(ref events, value);
                RaisePropertyChanged();
            }
        }

        private ObservableRangeCollection<CategoryEvent> categories;
        public ObservableRangeCollection<CategoryEvent> Categories
        {
            get => categories;
            set
            {
                SetProperty(ref categories, value);
                RaisePropertyChanged(nameof(Categories));
            }
        }

        #region Command

        public DelegateCommand<object> CategoryTappedCommand { get; private set; }

        public async Task CategoryTappedCommandExecute(object CategoryOid)
        {
            var categories = this.Categories;
            foreach (var item in this.categories)
            {
                if (item.Oid == (Guid)CategoryOid)
                {
                    item.Name = "Test";
                    item.IsActive = true;
                }
                else
                {
                    item.IsActive = false;
                }
            }
            
            this.Categories = categories;
            RaisePropertyChanged(nameof(Categories));
        }

        #endregion
    }
}
