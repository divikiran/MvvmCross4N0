using MvvmCross.Core.ViewModels;

namespace N4ValueConverter.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
		private string _foo;
		public string Foo
		{
			get { return _foo; }
			set { SetProperty(ref _foo, value); }
		}
	}
}
