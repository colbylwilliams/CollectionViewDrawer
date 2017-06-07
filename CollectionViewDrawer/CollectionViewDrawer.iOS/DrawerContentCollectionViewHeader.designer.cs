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
	[Register ("DrawerContentCollectionViewHeader")]
	partial class DrawerContentCollectionViewHeader
	{
		[Outlet]
		UIKit.UIButton closeButton { get; set; }

		[Outlet]
		UIKit.UIView triangleView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (triangleView != null) {
				triangleView.Dispose ();
				triangleView = null;
			}

			if (closeButton != null) {
				closeButton.Dispose ();
				closeButton = null;
			}
		}
	}
}
