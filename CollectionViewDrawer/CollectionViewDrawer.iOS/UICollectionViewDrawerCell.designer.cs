// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CollectionViewDrawer.iOS
{
	[Register ("UICollectionViewDrawerCell")]
	partial class UICollectionViewDrawerCell
	{
		[Outlet]
		UIKit.UIView circleView { get; set; }

		[Outlet]
		UIKit.UILabel label { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (label != null) {
				label.Dispose ();
				label = null;
			}

			if (circleView != null) {
				circleView.Dispose ();
				circleView = null;
			}
		}
	}
}
