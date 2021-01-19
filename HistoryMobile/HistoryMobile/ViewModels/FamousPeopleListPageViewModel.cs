using HistoryMobile.Models;
using HistoryMobile.Services;
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
    public class FamousPeopleListPageViewModel : ViewModelBase
    {
        private readonly IFamousPeopleService famousPeopleService;

        public FamousPeopleListPageViewModel(INavigationService navigationService,
            IFamousPeopleService famousPeopleService)
            : base(navigationService)
        {
            this.famousPeopleService = famousPeopleService;

            ItemTappedCommand = new DelegateCommand<object>(async (Oid) => await ItemTappedCommandExecute(Oid));
        }

        public string CategoryOid { get; set; }

        private ObservableCollection<FamousPeople> famousPeoples;
        public ObservableCollection<FamousPeople> FamousPeoples
        {
            get => famousPeoples;
            set
            {
                SetProperty(ref famousPeoples, value);
                RaisePropertyChanged(nameof(FamousPeoples));
            }
        }

        private CategoryFamousPeople category;
        public CategoryFamousPeople Category
        {
            get => category;
            set
            {
                SetProperty(ref category, value);
                RaisePropertyChanged(nameof(Category));
            }
        }

        private FamousPeople selectedFamousPeople;
        public FamousPeople SelectedFamousPeople
        {
            get => selectedFamousPeople;
            set
            {
                SetProperty(ref selectedFamousPeople, value);
                RaisePropertyChanged(nameof(SelectedFamousPeople));
            }
        }

        #region Command

        public DelegateCommand<object> ItemTappedCommand { get; private set; }

        public async Task ItemTappedCommandExecute(object Oid)
        {
            var parameters = new NavigationParameters();
            parameters.Add("Oid", SelectedFamousPeople.Oid);
            parameters.Add("CategoryOid", CategoryOid);
            await NavigationService.NavigateAsync("FamousPeopleDetailPage", parameters);
        }

        #endregion

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            string CategoryOid = parameters.GetValue<string>("CategoryOid");

            this.CategoryOid = CategoryOid;
            this.Title = CategoryOid;

            this.FamousPeoples = new ObservableCollection<FamousPeople>(
                famousPeopleService.GetByCategory(CategoryOid));
        }
    }
}
