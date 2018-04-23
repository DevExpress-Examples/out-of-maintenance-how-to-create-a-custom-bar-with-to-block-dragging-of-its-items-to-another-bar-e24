using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Utils;
using DevExpress.XtraBars.ViewInfo;

namespace BarsCustomization
{
	public class MyBarManager : BarManager
	{
		public MyBarManager(IContainer container)
			: base(container)
		{
		}
		public MyBarManager()
			: base()
		{
		}

		protected override BarManagerHelpers CreateHelpers()
		{
			return new MyBarManagerHelpers(this);
		}

		protected internal new BarSelectionInfo SelectionInfo
		{
			get
			{
				return base.SelectionInfo;
			}
		}

	}
}
