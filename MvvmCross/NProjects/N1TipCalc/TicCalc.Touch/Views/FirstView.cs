using System.Drawing;
using CoreGraphics;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using N1TipCalc.ViewModels;
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
			//if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
			this.EdgesForExtendedLayout = UIRectEdge.None;

			var subTotalLabel = new UILabel(new RectangleF(10, 0, 300, 40)) { Text = "SubTotal" };
			Add(subTotalLabel);

			var subTotalText = new UITextField(new CGRect(10, 40, 300, 40));
			subTotalText.BorderStyle = UITextBorderStyle.RoundedRect;
			Add(subTotalText);


			var generosityLabel = new UILabel(new RectangleF(10, 100, 300, 40)) { Text = "Generosity" };
			Add(generosityLabel);

			//var generosityText = new UITextField(new CGRect(10, 150, 300, 40));
			//generosityText.BorderStyle = UITextBorderStyle.RoundedRect;
			//Add(generosityText);

			var slider = new UISlider(new CGRect(10, 159, 300, 40));
			slider.MinValue = 0;
			slider.MaxValue = 100;
			Add(slider);

			var labelTip = new UILabel(new RectangleF(10, 200, 300, 40)) { Text = "Tip" };
			Add(labelTip);

			var tipText = new UILabel(new RectangleF(10, 240, 300, 40));
			Add(tipText);

			var tipLabel = new UILabel(new RectangleF(10, 280, 300, 40)) { Text = "Total" };
			Add(tipLabel);


			var labelTotal = new UILabel(new RectangleF(10, 320, 300, 40));
			Add(labelTotal);

			var set = this.CreateBindingSet<FirstView, FirstViewModel>();
			set.Bind(subTotalText).To(vm => vm.SubTotal);
			set.Bind(slider).To(vm => vm.Generosity);
			set.Bind(tipText).To(vm => vm.Tip);
			set.Bind(labelTotal).To(vm => vm.Total);

			set.Apply();

        }
    }
}
