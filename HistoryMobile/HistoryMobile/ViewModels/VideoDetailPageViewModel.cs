using HistoryMobile.Models;
using HistoryMobile.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace HistoryMobile.ViewModels
{
    public class VideoDetailPageViewModel : ViewModelBase
    {
        private readonly IVideoService videoService;

        public VideoDetailPageViewModel(INavigationService navigationService,
            IVideoService videoService)
            :base(navigationService)
        {
            this.videoService = videoService;
        }

        private List<Video> videos;
        public List<Video> Videos
        {
            get => videos;
            set
            {
                SetProperty(ref videos, value);
                RaisePropertyChanged(nameof(Videos));
            }
        }

        private Video selectedVideo;
        public Video SelectedVideo
        {
            get => selectedVideo;
            set
            {
                SetProperty(ref selectedVideo, value);
                RaisePropertyChanged(nameof(SelectedVideo));
            }
        }

        public HtmlWebViewSource Test
        {
            get => new HtmlWebViewSource
            {
                Html = "<iframe width='100%' height='100%' src='https://www.youtube.com/embed/hmmIVysAxPM' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>",
            };
            set { }
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            var CategoryOid = parameters["CategoryOid"];
            this.Videos = videoService.GetByCategory((string)CategoryOid);

            this.Title = (string)CategoryOid;

            if(this.Videos.Count() > 0)
            {
                this.SelectedVideo = Videos.First();
            }
        }
    }
}
