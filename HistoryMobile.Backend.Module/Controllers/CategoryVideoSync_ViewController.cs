using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using HistoryMobile.Backend.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HistoryMobile.Backend.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class CategoryVideoSync_ViewController : ViewController
    {
        public CategoryVideoSync_ViewController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
            SimpleAction syncFirebaseAction = new SimpleAction(
                this, "SyncFirebase",
                PredefinedCategory.Unspecified)
            {
                TargetObjectType = typeof(CategoryVideo),
                TargetViewType = ViewType.Any
            };
            syncFirebaseAction.SelectionDependencyType = SelectionDependencyType.RequireMultipleObjects;
            syncFirebaseAction.Execute += SyncFirebaseAction_Execute;
        }

        private void SyncFirebaseAction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var categories = e.SelectedObjects;
            ProcessSyncToFirebaseLib.SyncCategoryVideo(
                this.ObjectSpace,
                (categories.Cast<CategoryVideo>().ToList()));
        }


        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
