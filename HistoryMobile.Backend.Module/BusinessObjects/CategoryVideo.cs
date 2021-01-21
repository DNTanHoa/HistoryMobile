using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HistoryMobile.Backend.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class CategoryVideo : XPLiteObject
    {
        public CategoryVideo(Session session) : base(session)
        {

        }

        string code;
        string name;
        string image;
        bool firebaseSynced;

        [Key]
        [Browsable(true)]
        public string Code
        {
            get => code;
            set => SetPropertyValue(nameof(Code), ref code, value);
        }

        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }

        public string Image
        {
            get => image;
            set => SetPropertyValue(nameof(Image), ref image, value);
        }

        public bool FirebaseSynced
        {
            get => firebaseSynced;
            set => SetPropertyValue(nameof(FirebaseSynced), ref firebaseSynced, value);
        }

        [Association]
        public XPCollection<Video> Videos => GetCollection<Video>(nameof(Videos));

    }
}
