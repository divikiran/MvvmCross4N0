using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using N2KittensView.Core;
using UIKit;

namespace N2KittensView.Touch
{
	public partial class KittenCell : MvxTableViewCell
	{
		public static readonly NSString Key = new NSString("KittenCell");
		public static readonly UINib Nib;

		static KittenCell()
		{
			Nib = UINib.FromName("KittenCell", NSBundle.MainBundle);
		}

		protected KittenCell(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
			this.DelayBind(() =>
			{
				var set = this.CreateBindingSet<KittenCell, Kitten>();
				var imageLoader = new MvxImageViewLoader(() => this.MainImage);
				set.Bind(Name).To(v => v.Name);
				set.Bind(PriceLabel).To(v => v.Price);
				set.Bind(imageLoader).To(v => v.ImageUrl);
				set.Apply();
			});
		}
	}
}
