using HistoryMobile.Models;
using HistoryMobile.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoryMobile.ViewModels
{
    public class FamousPeoplePageViewModel : ViewModelBase
    {
        private readonly ICategoryService categoryService;

        public FamousPeoplePageViewModel(INavigationService navigationService,
            ICategoryService categoryService)
            : base(navigationService)
        {
            Title = "Nhân vật lịch sử";
            this.categoryService = categoryService;

            ItemTappedCommand = new DelegateCommand(async () => await ItemTappedCommandExecute());

            Categories = categoryService.GetCategoryFamousPeople();
        }

        private List<CategoryFamousPeople> categories;
        public List<CategoryFamousPeople> Categories
        {
            get => categories;
            set => SetProperty(ref categories, value);
        }

        private CategoryFamousPeople selectedCategory;
        public CategoryFamousPeople SelectedCategory
        {
            get => selectedCategory;
            set
            {
                SetProperty(ref selectedCategory, value);
                RaisePropertyChanged(nameof(SelectedCategory));
            }
        }

        #region command

        public DelegateCommand ItemTappedCommand { get; private set; }

        public async Task ItemTappedCommandExecute()
        {
            var parameters = new NavigationParameters();
            parameters.Add("CategoryOid", this.SelectedCategory.Name);
            await NavigationService.NavigateAsync("FamousPeopleListPage", parameters);
        }

        #endregion

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            
            base.OnNavigatedFrom(parameters);
        }
    }
}
