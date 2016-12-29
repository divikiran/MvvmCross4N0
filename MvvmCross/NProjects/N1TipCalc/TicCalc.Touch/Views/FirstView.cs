using System.Drawing;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using ObjCRuntime;
using UIKit;

namespace TicCalc.Touch.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {

			View = new UIView() { BackgroundColor = UIColor.Red };
            base.ViewDidLoad();

			// ios7 layout
			if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
				EdgesForExtendedLayout = UIRectEdge.None;

			var label1 = new UILabel(new RectangleF(0, 0, 300, 40)) { Text = "Test", BackgroundColor = UIColor.Green };
			Add(label1);

            //var set = this.CreateBindingSet<FirstView, N1TipCalc.ViewModels.FirstViewModel>();
            //set.Bind(label1).To(vm => vm.Hello);
            ////set.Bind(TextField).To(vm => vm.Hello);
            //set.Apply();
        }
    }
}
