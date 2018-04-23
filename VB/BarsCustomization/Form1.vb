Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraBars

Namespace BarsCustomization
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim bar As New MyBar()
			bar.DockRow = 3
			bar.DockStyle = BarDockStyle.Top

			Dim item As BarItem = New BarButtonItem(myBarManager1, "barButtonItem")
			bar.AddItem(item)
			bar.FixedItems.Add(item)
			item = New BarCheckItem()
			item.Caption = "barCheckItem"
			bar.AddItem(item)
			bar.FixedItems.Add(item)
			item = New BarStaticItem()
			item.Caption = "barStaticItem"
			bar.AddItem(item)

			myBarManager1.Bars.Add(bar)
		End Sub
	End Class
End Namespace