Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Scheduler
Imports DevExpress.Xpf.Scheduler.UI

Namespace SilverlightApplication1
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		#Region "#PopupMenuShowing"
		Private Sub schedulerControl1_PopupMenuShowing(ByVal sender As Object, ByVal e As SchedulerMenuEventArgs)
			' Check whether this event was raised for a default popup menu of the Scheduler control.
			If e.Menu.Name = SchedulerMenuItemName.DefaultMenu Then

				' Remove the New Recurring Appointment menu item.
				e.Customizations.Add(New RemoveBarItemAndLinkAction() With {.ItemName = SchedulerMenuItemName.NewRecurringAppointment})

				' Create a custom menu item.
				Dim menuItem As New BarButtonItem()
				menuItem.Name = "customItem"
				menuItem.Content = "Custom Item"
				AddHandler menuItem.ItemClick, AddressOf customItem_ItemClick

				' Insert a new item into the Scheduler popup menu.
				e.Customizations.Add(menuItem)
			End If
		End Sub

		Private Sub customItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			' Implement the custom action.
			' ...
		End Sub
		#End Region ' #PopupMenuShowing

		#Region "#AppointmentPopupMenuCustomization"
		Private Sub customCheckItem_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			' Implement the custom action.
			' ...
		End Sub

		Private Sub customButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			' Implement the custom action.
			' ...
		End Sub
		#End Region ' #AppointmentPopupMenuCustomization
	End Class
End Namespace
