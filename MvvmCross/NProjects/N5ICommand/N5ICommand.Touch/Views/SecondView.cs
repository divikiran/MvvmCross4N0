using System.Drawing;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace N5ICommand.Touch.Views
{
	[Register("SecondView")]
    public class SecondView : MvxViewController
    {
        public override void ViewDidLoad()
        {
			this.EdgesForExtendedLayout = UIRectEdge.None;
			View = new UIView { BackgroundColor = UIColor.Red };
            base.ViewDidLoad();

			var Label = new UILabel(new RectangleF(10, 10, 300, 40)){
				Text = "Second View"
			};
			Add(Label);

        }
    }
}
