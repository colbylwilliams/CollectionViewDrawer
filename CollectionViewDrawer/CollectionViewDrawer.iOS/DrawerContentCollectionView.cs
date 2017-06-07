using System;
using System.Collections.Generic;

using Foundation;
using UIKit;

namespace CollectionViewDrawer.iOS
{
	public partial class DrawerContentCollectionView : UICollectionViewController
	{

		List<string> items = new List<string> { "one", "two", "three", "four" };


		public DrawerContentCollectionView (IntPtr handle) : base (handle) { }


		public override nint NumberOfSections (UICollectionView collectionView) => 1;


		public override nint GetItemsCount (UICollectionView collectionView, nint section) => items.Count;


		public override UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = collectionView.Dequeue<DrawerContentCollectionViewCell> (indexPath);

			return cell;
		}


		public override UICollectionReusableView GetViewForSupplementaryElement (UICollectionView collectionView, NSString elementKind, NSIndexPath indexPath)
		{
			var header = collectionView.Dequeue<DrawerContentCollectionViewHeader> (elementKind, indexPath);

			return header;
		}


		partial void closeClicked (NSObject sender)
		{
			if (ParentViewController is UICollectionViewDrawerController parent)
			{
				parent.CloseDrawer ();
			}
		}
	}
}
