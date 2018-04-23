using System.Windows.Controls;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Scheduler;
using DevExpress.Xpf.Scheduler.UI;

namespace SilverlightApplication1 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }
        #region #PopupMenuShowing
        private void schedulerControl1_PopupMenuShowing(object sender, SchedulerMenuEventArgs e) {
            // Check whether this event was raised for a default popup menu of the Scheduler control.
            if (e.Menu.Name == SchedulerMenuItemName.DefaultMenu) {

                // Remove the New Recurring Appointment menu item.
                e.Customizations.Add(new RemoveBarItemAndLinkAction() {
                    ItemName = SchedulerMenuItemName.NewRecurringAppointment
                });

                // Create a custom menu item.
                BarButtonItem menuItem = new BarButtonItem();
                menuItem.Name = "customItem";
                menuItem.Content = "Custom Item";
                menuItem.ItemClick += new ItemClickEventHandler(customItem_ItemClick);

                // Insert a new item into the Scheduler popup menu.
                e.Customizations.Add(menuItem);
            }
        }

        private void customItem_ItemClick(object sender, ItemClickEventArgs e) {
            // Implement the custom action.
            // ...
        }
        #endregion #PopupMenuShowing

        #region #AppointmentPopupMenuCustomization
        private void customCheckItem_CheckedChanged(object sender, ItemClickEventArgs e) {
            // Implement the custom action.
            // ...
        }

        private void customButtonItem_ItemClick(object sender, ItemClickEventArgs e) {
            // Implement the custom action.
            // ...
        }
        #endregion #AppointmentPopupMenuCustomization
    }
}
