using System.Collections.Generic;
using DevExpress.XtraBars;

namespace BarsCustomization
{
	public class MyBar : Bar
	{
		private List<BarItem> _fixedItems;

		public MyBar(BarManager manager, string name)
			: base(manager, name)
		{
		}
		public MyBar(BarManager manager)
			: base(manager)
		{
		}
		public MyBar(BarManager manager, string name, BarDockStyle ADockStyle, BarOptionFlags AOptions, System.Drawing.Rectangle floatRect, LinksInfo linksInfo)
			: base(manager, name, ADockStyle, AOptions, floatRect, linksInfo)
		{
		}
		public MyBar(BarManager manager, string name, BarDockStyle ADockStyle, BarOptionFlags AOptions, System.Drawing.Rectangle floatRect, LinksInfo linksInfo, System.Drawing.Point dockPos, int offset)
			: base(manager, name, ADockStyle, AOptions, floatRect, linksInfo, dockPos, offset)
		{
		}
		public MyBar(BarManager manager, string name, BarDockStyle ADockStyle, BarOptionFlags AOptions, System.Drawing.Rectangle floatRect, LinksInfo linksInfo, System.Drawing.Point dockPos, int offset, BarCanDockStyle canDockStyle)
			: base(manager, name, ADockStyle, AOptions, floatRect, linksInfo, dockPos, offset, canDockStyle)
		{
		}
		public MyBar(BarManager manager, string name, BarDockStyle ADockStyle, BarOptionFlags AOptions, System.Drawing.Rectangle floatRect, LinksInfo linksInfo, System.Drawing.Point dockPos, int offset, BarCanDockStyle canDockStyle, System.Drawing.Color backColor)
			: base(manager, name, ADockStyle, AOptions, floatRect, linksInfo, dockPos, offset, canDockStyle, backColor)
		{
		}
		public MyBar(BarManager manager, string name, BarDockStyle ADockStyle, BarOptionFlags AOptions, System.Drawing.Rectangle floatRect, LinksInfo linksInfo, System.Drawing.Point dockPos, int offset, BarCanDockStyle canDockStyle, System.Drawing.Color backColor, System.Drawing.Image backImage)
			: base(manager, name, ADockStyle, AOptions, floatRect, linksInfo, dockPos, offset, canDockStyle, backColor, backImage)
		{
		}
		public MyBar(BarManager manager, string name, BarDockStyle ADockStyle, BarOptionFlags AOptions, System.Drawing.Rectangle floatRect, LinksInfo linksInfo, System.Drawing.Point dockPos, int offset, BarCanDockStyle canDockStyle, System.Drawing.Color backColor, int barItemHorzIndent, int barItemVertIndent)
			: base(manager, name, ADockStyle, AOptions, floatRect, linksInfo, dockPos, offset, canDockStyle, backColor, barItemHorzIndent, barItemVertIndent)
		{
		}
		public MyBar(BarManager manager, string name, BarDockStyle ADockStyle, BarOptionFlags AOptions, System.Drawing.Rectangle floatRect, LinksInfo linksInfo, System.Drawing.Point dockPos, int offset, BarCanDockStyle canDockStyle, System.Drawing.Color backColor, System.Drawing.Image backImage, int barItemHorzIndent, int barItemVertIndent)
			: base(manager, name, ADockStyle, AOptions, floatRect, linksInfo, dockPos, offset, canDockStyle, backColor, backImage, barItemHorzIndent, barItemVertIndent)
		{
		}
		public MyBar()
			: base()
		{
		}

		public List<BarItem> FixedItems
		{
			get
			{
				if ( _fixedItems == null )
					_fixedItems = new List<BarItem>();
				
				return _fixedItems;
			}
		}
	}
}
