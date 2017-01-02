// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace N2KittensView.Touch
{
	[Register ("KittenCell")]
	partial class KittenCell
	{
		[Outlet]
		UIKit.UIImageView MainImage { get; set; }

		[Outlet]
		UIKit.UILabel Name { get; set; }

		[Outlet]
		UIKit.UILabel PriceLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (MainImage != null) {
				MainImage.Dispose ();
				MainImage = null;
			}

			if (Name != null) {
				Name.Dispose ();
				Name = null;
			}

			if (PriceLabel != null) {
				PriceLabel.Dispose ();
				PriceLabel = null;
			}
		}
	}
}
