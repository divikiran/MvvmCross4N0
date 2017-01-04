using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace N5ICommand.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }

		private MvxCommand _myCommand;
		public ICommand MyCommand
		{
			get
			{
				_myCommand = _myCommand ?? new MvxCommand(DoMyCommand);
				return _myCommand;
			}
		}

		private void DoMyCommand()
		{
			Hello = Hello + " World";
		}

		private MvxCommand _goSecondCommand;
		public ICommand GoSecondCommand
		{
			get
			{
				_goSecondCommand = _goSecondCommand ?? new MvxCommand(DoGoSecond);
				return _goSecondCommand;
			}
		}

		private void DoGoSecond()
		{
			ShowViewModel<SecondViewModel>();
		}
	}
}
