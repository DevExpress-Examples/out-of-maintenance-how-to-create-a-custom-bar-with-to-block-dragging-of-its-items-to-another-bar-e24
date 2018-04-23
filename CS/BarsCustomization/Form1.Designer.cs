namespace BarsCustomization
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.myBarManager1 = new BarsCustomization.MyBarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
			this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
			this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
			this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
			this.barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
			((System.ComponentModel.ISupportInitialize)(this.myBarManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// myBarManager1
			// 
			this.myBarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
			this.myBarManager1.DockControls.Add(this.barDockControlTop);
			this.myBarManager1.DockControls.Add(this.barDockControlBottom);
			this.myBarManager1.DockControls.Add(this.barDockControlLeft);
			this.myBarManager1.DockControls.Add(this.barDockControlRight);
			this.myBarManager1.Form = this;
			this.myBarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barCheckItem1,
            this.barSubItem1,
            this.barSubItem2,
            this.barButtonItem3,
            this.barCheckItem2});
			this.myBarManager1.MaxItemId = 7;
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Size = new System.Drawing.Size(485, 74);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 286);
			this.barDockControlBottom.Size = new System.Drawing.Size(485, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 74);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 212);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(485, 74);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 212);
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "barButtonItem1";
			this.barButtonItem1.Id = 0;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// bar1
			// 
			this.bar1.BarName = "Custom 2";
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 0;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
			this.bar1.Text = "Custom 2";
			// 
			// bar2
			// 
			this.bar2.BarName = "Custom 3";
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 1;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
			this.bar2.Text = "Custom 3";
			// 
			// bar3
			// 
			this.bar3.BarName = "Custom 4";
			this.bar3.DockCol = 0;
			this.bar3.DockRow = 2;
			this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem2)});
			this.bar3.Text = "Custom 4";
			// 
			// barButtonItem2
			// 
			this.barButtonItem2.Caption = "barButtonItem2";
			this.barButtonItem2.Id = 1;
			this.barButtonItem2.Name = "barButtonItem2";
			// 
			// barCheckItem1
			// 
			this.barCheckItem1.Caption = "barCheckItem1";
			this.barCheckItem1.Id = 2;
			this.barCheckItem1.Name = "barCheckItem1";
			// 
			// barSubItem1
			// 
			this.barSubItem1.Caption = "barSubItem1";
			this.barSubItem1.Id = 3;
			this.barSubItem1.Name = "barSubItem1";
			// 
			// barSubItem2
			// 
			this.barSubItem2.Caption = "barSubItem2";
			this.barSubItem2.Id = 4;
			this.barSubItem2.Name = "barSubItem2";
			// 
			// barButtonItem3
			// 
			this.barButtonItem3.Caption = "barButtonItem3";
			this.barButtonItem3.Id = 5;
			this.barButtonItem3.Name = "barButtonItem3";
			// 
			// barCheckItem2
			// 
			this.barCheckItem2.Caption = "barCheckItem2";
			this.barCheckItem2.Id = 6;
			this.barCheckItem2.Name = "barCheckItem2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 286);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.myBarManager1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MyBarManager myBarManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private DevExpress.XtraBars.BarCheckItem barCheckItem1;
		private DevExpress.XtraBars.BarSubItem barSubItem1;
		private DevExpress.XtraBars.BarSubItem barSubItem2;
		private DevExpress.XtraBars.BarButtonItem barButtonItem3;
		private DevExpress.XtraBars.BarCheckItem barCheckItem2;




	}
}

