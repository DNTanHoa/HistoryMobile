using DevExpress.ExpressApp.Blazor.Components.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryMobile.Backend.Module.Blazor.Editors
{
    public class HtmlInputModel : ComponentModelBase
    {
        public string Value
        {
            get => GetPropertyValue<string>();
            set
            {
                SetPropertyValue(value);
                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public bool ReadOnly
        {
            get => GetPropertyValue<bool>();
            set => SetPropertyValue(value);
        }
        public void SetValueFromUI(string value)
        {
            SetPropertyValue(value, notify: false, nameof(Value));
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler ValueChanged;
    }
}
