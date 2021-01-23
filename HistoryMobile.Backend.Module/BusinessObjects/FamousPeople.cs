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
    public class FamousPeople : BaseObject
    {
        public FamousPeople(Session session) : base(session)
        {

        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            this.Code = DateTime.Now.ToString("yyyyMMddHHmmsstt");
        }

        string code;
        string image;
        string title;
        string summary;
        string detail;
        string source;
        bool firebaseSynced;

        public string Code
        {
            get => code;
            set => SetPropertyValue(nameof(Code), ref code, value);
        }

        [Size(500)]
        public string Image
        {
            get => image;
            set => SetPropertyValue(nameof(Image), ref image, value);
        }

        public string Title
        {
            get => title;
            set => SetPropertyValue(nameof(Title), ref title, value);
        }

        [Size(500)]
        public string Summary
        {
            get => summary;
            set => SetPropertyValue(nameof(Summary), ref summary, value);
        }

        public string Source
        {
            get => source;
            set => SetPropertyValue(nameof(Source), ref source, value);
        }

        public bool FirebaseSynced
        {
            get => firebaseSynced;
            set => SetPropertyValue(nameof(FirebaseSynced), ref firebaseSynced, value);
        }

        [Size(5000)]
        public string Detail
        {
            get => detail;
            set => SetPropertyValue(nameof(Detail), ref detail, value);
        }

        [Association]
        public XPCollection<CategoryFamousPeople> CategoryOids => GetCollection<CategoryFamousPeople>(nameof(CategoryOids));
    }
}
