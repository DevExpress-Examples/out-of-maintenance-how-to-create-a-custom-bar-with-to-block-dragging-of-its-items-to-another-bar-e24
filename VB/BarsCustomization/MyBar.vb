Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports DevExpress.XtraBars

Namespace BarsCustomization
	Public Class MyBar
		Inherits Bar
		Private _fixedItems As List(Of BarItem)

		Public Sub New(ByVal manager As BarManager, ByVal name As String)
			MyBase.New(manager, name)
		End Sub
		Public Sub New(ByVal manager As BarManager)
			MyBase.New(manager)
		End Sub
		Public Sub New(ByVal manager As BarManager, ByVal name As String, ByVal ADockStyle As BarDockStyle, ByVal AOptions As BarOptionFlags, ByVal floatRect As System.Drawing.Rectangle, ByVal linksInfo As LinksInfo)
			MyBase.New(manager, name, ADockStyle, AOptions, floatRect, linksInfo)
		End Sub
		Public Sub New(ByVal manager As BarManager, ByVal name As String, ByVal ADockStyle As BarDockStyle, ByVal AOptions As BarOptionFlags, ByVal floatRect As System.Drawing.Rectangle, ByVal linksInfo As LinksInfo, ByVal dockPos As System.Drawing.Point, ByVal offset As Integer)
			MyBase.New(manager, name, ADockStyle, AOptions, floatRect, linksInfo, dockPos, offset)
		End Sub
		Public Sub New(ByVal manager As BarManager, ByVal name As String, ByVal ADockStyle As BarDockStyle, ByVal AOptions As BarOptionFlags, ByVal floatRect As System.Drawing.Rectangle, ByVal linksInfo As LinksInfo, ByVal dockPos As System.Drawing.Point, ByVal offset As Integer, ByVal canDockStyle As BarCanDockStyle)
			MyBase.New(manager, name, ADockStyle, AOptions, floatRect, linksInfo, dockPos, offset, canDockStyle)
		End Sub
		Public Sub New(ByVal manager As BarManager, ByVal name As String, ByVal ADockStyle As BarDockStyle, ByVal AOptions As BarOptionFlags, ByVal floatRect As System.Drawing.Rectangle, ByVal linksInfo As LinksInfo, ByVal dockPos As System.Drawing.Point, ByVal offset As Integer, ByVal canDockStyle As BarCanDockStyle, ByVal backColor As System.Drawing.Color)
			MyBase.New(manager, name, ADockStyle, AOptions, floatRect, linksInfo, dockPos, offset, canDockStyle, backColor)
		End Sub
		Public Sub New(ByVal manager As BarManager, ByVal name As String, ByVal ADockStyle As BarDockStyle, ByVal AOptions As BarOptionFlags, ByVal floatRect As System.Drawing.Rectangle, ByVal linksInfo As LinksInfo, ByVal dockPos As System.Drawing.Point, ByVal offset As Integer, ByVal canDockStyle As BarCanDockStyle, ByVal backColor As System.Drawing.Color, ByVal backImage As System.Drawing.Image)
			MyBase.New(manager, name, ADockStyle, AOptions, floatRect, linksInfo, dockPos, offset, canDockStyle, backColor, backImage)
		End Sub
		Public Sub New(ByVal manager As BarManager, ByVal name As String, ByVal ADockStyle As BarDockStyle, ByVal AOptions As BarOptionFlags, ByVal floatRect As System.Drawing.Rectangle, ByVal linksInfo As LinksInfo, ByVal dockPos As System.Drawing.Point, ByVal offset As Integer, ByVal canDockStyle As BarCanDockStyle, ByVal backColor As System.Drawing.Color, ByVal barItemHorzIndent As Integer, ByVal barItemVertIndent As Integer)
			MyBase.New(manager, name, ADockStyle, AOptions, floatRect, linksInfo, dockPos, offset, canDockStyle, backColor, barItemHorzIndent, barItemVertIndent)
		End Sub
		Public Sub New(ByVal manager As BarManager, ByVal name As String, ByVal ADockStyle As BarDockStyle, ByVal AOptions As BarOptionFlags, ByVal floatRect As System.Drawing.Rectangle, ByVal linksInfo As LinksInfo, ByVal dockPos As System.Drawing.Point, ByVal offset As Integer, ByVal canDockStyle As BarCanDockStyle, ByVal backColor As System.Drawing.Color, ByVal backImage As System.Drawing.Image, ByVal barItemHorzIndent As Integer, ByVal barItemVertIndent As Integer)
			MyBase.New(manager, name, ADockStyle, AOptions, floatRect, linksInfo, dockPos, offset, canDockStyle, backColor, backImage, barItemHorzIndent, barItemVertIndent)
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub

		Public ReadOnly Property FixedItems() As List(Of BarItem)
			Get
				If _fixedItems Is Nothing Then
					_fixedItems = New List(Of BarItem)()
				End If

				Return _fixedItems
			End Get
		End Property
	End Class
End Namespace
