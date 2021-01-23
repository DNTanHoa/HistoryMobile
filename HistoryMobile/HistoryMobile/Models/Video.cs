using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HistoryMobile.Models
{
    public class Video
    {
        public Guid Oid { get; set; }

        public string Title { get; set; }

        public string Link { get; set; }

        public string CategoryOid { get; set; }

        public HtmlWebViewSource Source
        {
            get => new HtmlWebViewSource
            {
                Html = this.Link
            };
            set { }
        }
    }
}
