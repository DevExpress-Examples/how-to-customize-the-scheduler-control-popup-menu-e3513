<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/SilverlightApplication1/MainPage.xaml) (VB: [MainPage.xaml](./VB/SilverlightApplication1/MainPage.xaml))
* [MainPage.xaml.cs](./CS/SilverlightApplication1/MainPage.xaml.cs) (VB: [MainPage.xaml](./VB/SilverlightApplication1/MainPage.xaml))
<!-- default file list end -->
# How to customize the Scheduler control popup menu


<p>The following example illustrates how to customize the Scheduler control popup menus. In particular, this sample demonstrates how to remove existing menu items and add new items to the <strong>Default Popup Menu</strong> and <strong>Appointment Popup Menu</strong>.</p>


<h3>Description</h3>

<p>Popup menu customization can be performed either at design time (via the XAML markup), or at runtime (via the code-behind file). To modify a popup menu at runtime, handle the <strong>SchedulerControl.PopupMenuShowing</strong> event. In this event handler, all modifications to the list of menu items can be made by changing the <strong>SchedulerMenuEventArgs.Customizations</strong> collection. To get access to a popup menu for which the event has been raised, use the <strong>SchedulerMenuEventArgs.Menu</strong> property. To customize the Scheduler control default and appointment popup menus at design time, you can also use the <strong>SchedulerControl.DefaultMenuCustomizations</strong> and <strong>SchedulerControl.AppointmentMenuCustomizations</strong> properties respectively. In both cases, to remove a specific menu item along with its link, use the <strong>RemoveBarItemAndLinkAction</strong> instance, and to add a custom menu item, add a new <strong>BarButtonItem</strong> or <strong>BarCheckItem</strong> object to the Customizations collection.</p>

<br/>


