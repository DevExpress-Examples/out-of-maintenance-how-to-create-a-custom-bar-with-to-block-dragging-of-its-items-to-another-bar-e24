using DevExpress.XtraBars;
using DevExpress.XtraBars.Utils;

namespace BarsCustomization
{
	public class MyBarManagerHelpers : BarManagerHelpers
	{
		public MyBarManagerHelpers(BarManager manager)
			: base(manager)
		{
		}

		protected override BarLinkDragManager CreateLinkDragManager()
		{
			return new MyBarLinkDragManager(Manager);
		}
	}
}
