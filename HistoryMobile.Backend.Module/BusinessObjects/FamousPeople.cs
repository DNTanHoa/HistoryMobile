using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HistoryMobile.Backend.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class FamousPeople : XPLiteObject
    {
        public FamousPeople(Session session) : base(session)
        {

        }

        int id;
        string code;
        string image;
        string title;
        string summary;
        string detail;

        [Key]
        [Browsable(true)]
        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value); 
        }

        public string Code
        {
            get => code;
            set => SetPropertyValue(nameof(Code), ref code, value);
        }

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

        public string Summary
        {
            get => summary;
            set => SetPropertyValue(nameof(Summary), ref summary, value);
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
