Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Utils
Imports DevExpress.XtraBars.ViewInfo

Namespace BarsCustomization
	Public Class MyBarManager
		Inherits BarManager
		Public Sub New(ByVal container As IContainer)
			MyBase.New(container)
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Function CreateHelpers() As BarManagerHelpers
			Return New MyBarManagerHelpers(Me)
		End Function

		Protected Friend Shadows ReadOnly Property SelectionInfo() As BarSelectionInfo
			Get
				Return MyBase.SelectionInfo
			End Get
		End Property

	End Class
End Namespace
