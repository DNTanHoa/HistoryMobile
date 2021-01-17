using HistoryMobile.Models;
using HistoryMobile.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            var Oid = parameters["Oid"];
            this.People = famousPeopleService.GetByOid((string)Oid);
            this.Title = this.People?.Title;
            base.OnNavigatedTo(parameters);
        }
    }
}
