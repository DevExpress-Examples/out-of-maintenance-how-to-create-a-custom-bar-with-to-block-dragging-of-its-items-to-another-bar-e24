Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Utils

Namespace BarsCustomization
	Public Class MyBarManagerHelpers
		Inherits BarManagerHelpers
		Public Sub New(ByVal manager As BarManager)
			MyBase.New(manager)
		End Sub

		Protected Overrides Function CreateLinkDragManager() As BarLinkDragManager
			Return New MyBarLinkDragManager(Manager)
		End Function
	End Class
End Namespace
