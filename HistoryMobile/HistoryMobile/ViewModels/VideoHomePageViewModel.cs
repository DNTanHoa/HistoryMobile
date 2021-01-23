using HistoryMobile.Models;
using HistoryMobile.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoryMobile.ViewModels
{
    public class VideoHomePageViewModel : ViewModelBase
    {
        private readonly ICategoryService categoryService;

        public VideoHomePageViewModel(INavigationService navigationService,
            ICategoryService categoryService,
            IDialogService dialogService)
            : base(navigationService)
        {
            Title = "Video lịch sử";
            this.categoryService = categoryService;
            
            ItemTappedCommand = new DelegateCommand(async () => await ItemTappedCommandExecute());

            this.IsBusy = true;
            Task.Run(() =>
            {
                try
                {
                    this.Categories = categoryService.GetCategoryVideo();
                }
                catch(Exception ex)
                {
                    dialogService.ShowDialogAsync(ex.Message);
                }
                this.IsBusy = false;
            });
        }

        private List<CategoryVideo> categories;

        public List<CategoryVideo> Categories
        {
            get => categories;
            set
            {
                SetProperty(ref categories, value);
                RaisePropertyChanged(nameof(Categories));
            }
        }

        private CategoryVideo categoryVideo;
        public CategoryVideo CategoryVideo
        {
            get => categoryVideo;
            set
            {
                SetProperty(ref categoryVideo, value);
                RaisePropertyChanged(nameof(CategoryVideo));
            }
        }

        #region command

        public DelegateCommand ItemTappedCommand { get; private set; }

        public async Task ItemTappedCommandExecute()
        {
            var parameters = new NavigationParameters();
            parameters.Add("CategoryOid", CategoryVideo.Name);
            await NavigationService.NavigateAsync("VideoDetailPage", parameters);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }

        #endregion
    }
}
