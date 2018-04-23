Imports Microsoft.VisualBasic
Imports System
Namespace BarsCustomization
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.myBarManager1 = New BarsCustomization.MyBarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
			Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
			Me.barSubItem2 = New DevExpress.XtraBars.BarSubItem()
			Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
			Me.barCheckItem2 = New DevExpress.XtraBars.BarCheckItem()
			CType(Me.myBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myBarManager1
			' 
			Me.myBarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2, Me.bar3})
			Me.myBarManager1.DockControls.Add(Me.barDockControlTop)
			Me.myBarManager1.DockControls.Add(Me.barDockControlBottom)
			Me.myBarManager1.DockControls.Add(Me.barDockControlLeft)
			Me.myBarManager1.DockControls.Add(Me.barDockControlRight)
			Me.myBarManager1.Form = Me
			Me.myBarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barButtonItem2, Me.barCheckItem1, Me.barSubItem1, Me.barSubItem2, Me.barButtonItem3, Me.barCheckItem2})
			Me.myBarManager1.MaxItemId = 7
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(485, 74)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 286)
			Me.barDockControlBottom.Size = New System.Drawing.Size(485, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 74)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 212)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(485, 74)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 212)
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "barButtonItem1"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' bar1
			' 
			Me.bar1.BarName = "Custom 2"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1)})
			Me.bar1.Text = "Custom 2"
			' 
			' bar2
			' 
			Me.bar2.BarName = "Custom 3"
			Me.bar2.DockCol = 0
			Me.bar2.DockRow = 1
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3)})
			Me.bar2.Text = "Custom 3"
			' 
			' bar3
			' 
			Me.bar3.BarName = "Custom 4"
			Me.bar3.DockCol = 0
			Me.bar3.DockRow = 2
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItem2)})
			Me.bar3.Text = "Custom 4"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "barButtonItem2"
			Me.barButtonItem2.Id = 1
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' barCheckItem1
			' 
			Me.barCheckItem1.Caption = "barCheckItem1"
			Me.barCheckItem1.Id = 2
			Me.barCheckItem1.Name = "barCheckItem1"
			' 
			' barSubItem1
			' 
			Me.barSubItem1.Caption = "barSubItem1"
			Me.barSubItem1.Id = 3
			Me.barSubItem1.Name = "barSubItem1"
			' 
			' barSubItem2
			' 
			Me.barSubItem2.Caption = "barSubItem2"
			Me.barSubItem2.Id = 4
			Me.barSubItem2.Name = "barSubItem2"
			' 
			' barButtonItem3
			' 
			Me.barButtonItem3.Caption = "barButtonItem3"
			Me.barButtonItem3.Id = 5
			Me.barButtonItem3.Name = "barButtonItem3"
			' 
			' barCheckItem2
			' 
			Me.barCheckItem2.Caption = "barCheckItem2"
			Me.barCheckItem2.Id = 6
			Me.barCheckItem2.Name = "barCheckItem2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(485, 286)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.myBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myBarManager1 As MyBarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private bar1 As DevExpress.XtraBars.Bar
		Private bar2 As DevExpress.XtraBars.Bar
		Private bar3 As DevExpress.XtraBars.Bar
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barCheckItem1 As DevExpress.XtraBars.BarCheckItem
		Private barSubItem1 As DevExpress.XtraBars.BarSubItem
		Private barSubItem2 As DevExpress.XtraBars.BarSubItem
		Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
		Private barCheckItem2 As DevExpress.XtraBars.BarCheckItem




	End Class
End Namespace

