using System;
using System.Drawing;
using Foundation;
using HelloMvx4.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using ObjCRuntime;
using UIKit;

namespace HelloMvx4.Touch
{
	[Register("MyView")]
	public class MyView : MvxViewController
	{
		public MyView()
		{
		}

		protected MyViewModel MyViewModel
		{
			get { return ViewModel as MyViewModel; }
		}

		public override void ViewDidLoad()
		{
			View = new UIView() { BackgroundColor = UIColor.Blue };
			base.ViewDidLoad();

			ViewModel = new MyViewModel()
			{
				FirstName = "Divikiran",
				LastName = "Ravela"
			};

			// ios7 layout
			if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
				EdgesForExtendedLayout = UIRectEdge.None;

			var textFieldName = new UITextField(new RectangleF(10, 10, 320, 40));
			Add(textFieldName);
			var textFieldLastName = new UITextField(new RectangleF(10, 50, 320, 40));
			Add(textFieldLastName);

			var textFieldFullName = new UITextField(new RectangleF(10, 150, 320, 40));
			Add(textFieldFullName);


			var set = this.CreateBindingSet<MyView, Core.ViewModels.MyViewModel>();
			set.Bind(textFieldName).To(vm => vm.FirstName);
			set.Bind(textFieldLastName).To(vm => vm.LastName);
			set.Bind(textFieldFullName).To(vm => vm.FullName);
			set.Apply();

		}
	}
}