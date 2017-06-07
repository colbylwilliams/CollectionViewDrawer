using System;

using UIKit;

namespace CollectionViewDrawer.iOS
{
	public partial class UICollectionViewDrawerCell : UICollectionViewCell
	{
		bool circleLayerUpdated;


		public UICollectionViewDrawerCell (IntPtr handle) : base (handle) { }


		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();

			if (!circleLayerUpdated)
			{
				circleLayerUpdated = true;

				circleView.Layer.CornerRadius = circleView.Frame.Height / 2;
				circleView.Layer.MasksToBounds = true;
			}
		}


		public void SetData (string text) => label.Text = text;
	}
}
