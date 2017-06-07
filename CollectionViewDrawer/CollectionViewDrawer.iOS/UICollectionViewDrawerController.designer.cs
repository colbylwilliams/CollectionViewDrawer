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
	[Register ("UICollectionViewDrawerController")]
	partial class UICollectionViewDrawerController
	{
		[Outlet]
		UIKit.UIView drawerContainerView { get; set; }

		[Outlet]
		CollectionViewDrawer.iOS.UICollectionViewDrawerFlowLayout DrawerFlowLayout { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (DrawerFlowLayout != null) {
				DrawerFlowLayout.Dispose ();
				DrawerFlowLayout = null;
			}

			if (drawerContainerView != null) {
				drawerContainerView.Dispose ();
				drawerContainerView = null;
			}
		}
	}
}
