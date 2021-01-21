using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HistoryMobile.Backend.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Video : BaseObject
    {
        public Video(Session session) : base(session)
        {

        }

        string title;
        string link;
        CategoryVideo categoryVideo;
        bool firebaseSynced;

        [Size(500)]
        [VisibleInListView(true)]
        public string Title
        {
            get => title;
            set => SetPropertyValue(nameof(Title), ref title, value);
        }

        [Size(500)]
        public string Link
        {
            get => link;
            set => SetPropertyValue(nameof(Link), ref link, value);
        }

        public bool FirebaseSynced
        {
            get => firebaseSynced;
            set => SetPropertyValue(nameof(FirebaseSynced), ref firebaseSynced, value);
        }

        [Association]
        public CategoryVideo CategoryVideo
        {
            get => categoryVideo;
            set => SetPropertyValue(nameof(CategoryVideo), ref categoryVideo, value);
        }
    }
}
