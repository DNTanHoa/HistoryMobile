using HistoryMobile.Services;
using HistoryMobile.ViewModels;
using HistoryMobile.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace HistoryMobile
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("AppShell");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<AboutPage, AboutPageViewModel>();
            containerRegistry.RegisterForNavigation<NewsListPage, NewListPageViewModel>();
            containerRegistry.RegisterForNavigation<VideoHomePage, VideoHomePageViewModel>();
            containerRegistry.RegisterForNavigation<FamousPeoplePage, FamousPeoplePageViewModel>();

            containerRegistry.RegisterForNavigation<AppShell, AppShellViewModel>();

            #region dependency register

            containerRegistry.RegisterSingleton<IHistoryEventService, MockHistoryEventService>();
            containerRegistry.RegisterSingleton<ICategoryService, CategoryService>();
            containerRegistry.RegisterSingleton<IFamousPeopleService, FamousPeopleService>();
            containerRegistry.RegisterSingleton<IVideoService, VideoService>();

            #endregion

            containerRegistry.RegisterForNavigation<FamousPeopleListPage, FamousPeopleListPageViewModel>();
            containerRegistry.RegisterForNavigation<FamousPeopleDetailPage, FamousPeopleDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<VideoDetailPage, VideoDetailPageViewModel>();
        }
    }
}
