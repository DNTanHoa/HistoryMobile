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
    public partial class VideoFirebaseSync_Controller : ViewController
    {
        public VideoFirebaseSync_Controller()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
            SimpleAction syncFirebaseAction = new SimpleAction(
                this, "SyncVideoFirebase",
                PredefinedCategory.Unspecified)
            {
                TargetObjectType = typeof(Video),
                TargetViewType = ViewType.Any
            };
            syncFirebaseAction.SelectionDependencyType = SelectionDependencyType.RequireMultipleObjects;
            syncFirebaseAction.Execute += SyncFirebaseAction_Execute;
        }

        private void SyncFirebaseAction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var categories = e.SelectedObjects;
            ProcessSyncToFirebaseLib.SyncVideo(
                this.ObjectSpace,
                (categories.Cast<Video>().ToList()));
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
