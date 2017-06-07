using System;
using System.Collections.Generic;

using CoreGraphics;
using Foundation;
using UIKit;


namespace CollectionViewDrawer.iOS
{
	public partial class UICollectionViewDrawerController : UICollectionViewController
	{

		List<string> items = new List<string> { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen" };


		public UICollectionViewDrawerController (IntPtr handle) : base (handle) { }


		public override nint NumberOfSections (UICollectionView collectionView) => 1;


		public override nint GetItemsCount (UICollectionView collectionView, nint section) => items.Count;


		public override UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = collectionView.Dequeue<UICollectionViewDrawerCell> (indexPath);

			var item = items [(int)indexPath.Item];

			cell.SetData (item);

			return cell;
		}


		public override void ItemSelected (UICollectionView collectionView, NSIndexPath indexPath)
		{
			OpenDrawer (collectionView, indexPath);
		}


		public void OpenDrawer (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = collectionView.CellForItem (indexPath);

			var cellRect = View.ConvertRectFromView (cell.Frame, collectionView);

			var drawerRect = new CGRect (0, cellRect.Bottom, View.Bounds.Width, 8);

			drawerContainerView.Frame = drawerRect;

			View.AddSubview (drawerContainerView);

			drawerRect.Height += 132;

			UIView.Animate (1, () => drawerContainerView.Frame = drawerRect);

			// create screenshot

			//var imageRect = new CGRect (0, cellRect.Bottom + 8, View.Bounds.Width, View.Bounds.Height - cellRect.Bottom - 8);

			//UIGraphics.BeginImageContextWithOptions (imageRect.Size, false, 0);

			//View.DrawViewHierarchy (imageRect, false);

			//var image = UIGraphics.GetImageFromCurrentImageContext ();

			//UIGraphics.EndImageContext ();
		}


		public void CloseDrawer ()
		{
			var drawerRect = drawerContainerView.Frame;

			drawerRect.Height -= 132;

			UIView.AnimateNotify (1, () => drawerContainerView.Frame = drawerRect, (finished) => drawerContainerView.RemoveFromSuperview ());
		}
	}
}
