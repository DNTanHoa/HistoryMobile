using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HistoryMobile.Backend.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class CategoryEvent : XPLiteObject
    {
        public CategoryEvent(Session session) : base(session)
        {

        }

        string code;
        string name;

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
    }
}
