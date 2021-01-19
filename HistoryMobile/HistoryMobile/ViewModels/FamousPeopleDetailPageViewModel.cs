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
    public class FamousPeopleDetailPageViewModel : ViewModelBase
    {
        private readonly IFamousPeopleService famousPeopleService;

        public FamousPeopleDetailPageViewModel(INavigationService navigationService,
            IFamousPeopleService famousPeopleService)
            :base(navigationService)
        {
            this.famousPeopleService = famousPeopleService;
            BackCommand = new DelegateCommand(async () => await BackCommandExecute());
        }

        private FamousPeople people;
        public FamousPeople People
        {
            get => people;
            set
            {
                SetProperty(ref people, value);
                RaisePropertyChanged(nameof(People));
            }
        }

        public string CategoryOid { get; set; }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            var Oid = parameters["Oid"];
            this.CategoryOid = parameters["CategoryOid"]?.ToString();
            this.People = famousPeopleService.GetByOid((string)Oid);
            this.Title = this.People?.Title;
            base.OnNavigatedTo(parameters);
        }

        public new async Task BackCommandExecute()
        {
            var parameters = new NavigationParameters();
            parameters.Add("CategoryOid", this.CategoryOid);
            await NavigationService.GoBackAsync(parameters);
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            parameters.Add("CategoryOid", this.CategoryOid);
            base.OnNavigatedFrom(parameters);
        }
    }
}
