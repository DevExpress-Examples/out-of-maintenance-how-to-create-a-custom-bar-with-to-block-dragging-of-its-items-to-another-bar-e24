using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraBars.Utils;
using DevExpress.XtraBars.ViewInfo;

namespace BarsCustomization
{
	public class MyBarLinkDragManager : BarLinkDragManager
	{
		private Bar currentBar = null;

		public MyBarLinkDragManager(BarManager manager)
			: base(manager)
		{
		}

		protected virtual bool IsItemLinkIsFixed(BarItemLink link)
		{
			if ( currentBar == null )
				return false;

			bool fixedItem = false;
			if ( link.Bar is MyBar )
				fixedItem = ((MyBar)link.Bar).FixedItems.Contains(link.Item);

			return fixedItem && link.Bar != currentBar;
		}

		public override bool CanAcceptDragObject(IDataObject data)
		{
			if ( currentBar == null )
				return base.CanAcceptDragObject(data);

			bool acceptDragObject = base.CanAcceptDragObject(data);
			object obj = GetDraggingObject(data);

			if ( obj is BarItemLink && IsItemLinkIsFixed((BarItemLink)obj) )
				acceptDragObject = false;

			return acceptDragObject;
		}

		public override void DoDragging(Control control, MouseEventArgs e)
		{
			base.DoDragging(control, e);

			CustomBarControl barControl = control as CustomBarControl;
			if ( barControl == null )
				return;

			currentBar = barControl.Bar;
			if ( DragObject is BarItemLink && IsItemLinkIsFixed((BarItemLink)DragObject) )
			{
				Cursor.Current = (Cursor)Manager.GetController().DragCursors[2];
				Manager.SelectionInfo.DropSelectStyle = LinkDropTargetEnum.None;
			}
		}

		public new MyBarManager Manager
		{
			get
			{
				return base.Manager as MyBarManager;
			}
		}
	}
}
