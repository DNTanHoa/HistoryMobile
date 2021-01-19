using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryMobile.Backend.Module.Blazor.Editors
{
    [PropertyEditor(typeof(string), false)]
    public class HtmlEditorProperty : BlazorPropertyEditorBase
    {
        public HtmlEditorProperty(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }
        protected override IComponentAdapter CreateComponentAdapter() => new HtmlInputAdapter(new HtmlInputModel());
    }
}
