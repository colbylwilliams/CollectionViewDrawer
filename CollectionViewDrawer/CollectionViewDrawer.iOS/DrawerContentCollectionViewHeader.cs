using System;

using CoreGraphics;
using Foundation;
using UIKit;

namespace CollectionViewDrawer.iOS
{
	public partial class DrawerContentCollectionViewHeader : UICollectionReusableView
	{

		public DrawerContentCollectionViewHeader (IntPtr handle) : base (handle) { }


		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();

			var radians = 45 * NMath.PI / 180;

			// rotate the system + button to make it an x
			closeButton.Transform = CGAffineTransform.MakeRotation (radians);

			// rotate a square view to make it appear as a triangle
			triangleView.Transform = CGAffineTransform.MakeRotation (radians);
		}
	}
}
