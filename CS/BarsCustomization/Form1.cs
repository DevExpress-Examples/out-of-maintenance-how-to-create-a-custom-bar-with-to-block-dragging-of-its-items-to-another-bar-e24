using System;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace BarsCustomization
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			MyBar bar = new MyBar();
			bar.DockRow = 3;
			bar.DockStyle = BarDockStyle.Top;

			BarItem item = new BarButtonItem(myBarManager1, "barButtonItem");
			bar.AddItem(item);
			bar.FixedItems.Add(item);
			item = new BarCheckItem();
			item.Caption = "barCheckItem";
			bar.AddItem(item);
			bar.FixedItems.Add(item);
			item = new BarStaticItem();
			item.Caption = "barStaticItem";
			bar.AddItem(item);
			
			myBarManager1.Bars.Add(bar);
		}
	}
}