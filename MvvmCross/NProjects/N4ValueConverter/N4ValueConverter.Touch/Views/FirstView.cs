using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

namespace N4ValueConverter.Touch.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, ViewModels.FirstViewModel>();
			set.Bind(Label).To(vm => vm.Foo);
			set.Bind(TextField).To(vm => vm.Foo);
            set.Apply();
        }
    }
}
