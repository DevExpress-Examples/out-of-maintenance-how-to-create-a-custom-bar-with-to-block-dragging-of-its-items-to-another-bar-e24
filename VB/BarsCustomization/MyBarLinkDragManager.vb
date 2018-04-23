Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Controls
Imports DevExpress.XtraBars.Utils
Imports DevExpress.XtraBars.ViewInfo

Namespace BarsCustomization
	Public Class MyBarLinkDragManager
		Inherits BarLinkDragManager
		Private currentBar As Bar = Nothing

		Public Sub New(ByVal manager As BarManager)
			MyBase.New(manager)
		End Sub

		Protected Overridable Function IsItemLinkIsFixed(ByVal link As BarItemLink) As Boolean
			If currentBar Is Nothing Then
				Return False
			End If

			Dim fixedItem As Boolean = False
			If TypeOf link.Bar Is MyBar Then
				fixedItem = (CType(link.Bar, MyBar)).FixedItems.Contains(link.Item)
			End If

			Return fixedItem AndAlso link.Bar IsNot currentBar
		End Function

		Public Overrides Function CanAcceptDragObject(ByVal data As IDataObject) As Boolean
			If currentBar Is Nothing Then
				Return MyBase.CanAcceptDragObject(data)
			End If

			Dim acceptDragObject As Boolean = MyBase.CanAcceptDragObject(data)
			Dim obj As Object = GetDraggingObject(data)

			If TypeOf obj Is BarItemLink AndAlso IsItemLinkIsFixed(CType(obj, BarItemLink)) Then
				acceptDragObject = False
			End If

			Return acceptDragObject
		End Function

		Public Overrides Sub DoDragging(ByVal control As Control, ByVal e As MouseEventArgs)
			MyBase.DoDragging(control, e)

			Dim barControl As CustomBarControl = TryCast(control, CustomBarControl)
			If barControl Is Nothing Then
				Return
			End If

			currentBar = barControl.Bar
			If TypeOf DragObject Is BarItemLink AndAlso IsItemLinkIsFixed(CType(DragObject, BarItemLink)) Then
				Cursor.Current = CType(Manager.GetController().DragCursors(2), Cursor)
				Manager.SelectionInfo.DropSelectStyle = LinkDropTargetEnum.None
			End If
		End Sub

		Public Shadows ReadOnly Property Manager() As MyBarManager
			Get
				Return TryCast(MyBase.Manager, MyBarManager)
			End Get
		End Property
	End Class
End Namespace
