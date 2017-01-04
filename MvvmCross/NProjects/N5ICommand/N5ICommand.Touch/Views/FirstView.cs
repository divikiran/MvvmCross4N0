using System.Drawing;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace N5ICommand.Touch.Views
{
	[Register("FirstView")]
    public class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
			this.EdgesForExtendedLayout = UIRectEdge.None;
			View = new UIView { BackgroundColor = UIColor.White };
            base.ViewDidLoad();

			var Label = new UILabel(new RectangleF(10,10,300,40));
			Add(Label);
			var TextField = new UITextView(new RectangleF(10, 60, 300, 40));
			Add(TextField);

			var Button = new UIButton(UIButtonType.RoundedRect);
			Button.SetTitle("Click Me!!!", UIControlState.Normal);
			Button.Frame = new RectangleF(10, 120, 300, 40); 
			Add(Button);

            var set = this.CreateBindingSet<FirstView, ViewModels.FirstViewModel>();
            set.Bind(Label).To(vm => vm.Hello);
            set.Bind(TextField).To(vm => vm.Hello);
			set.Bind(Button).To(vm => vm.GoSecondCommand);
            set.Apply();
        }
    }
}
