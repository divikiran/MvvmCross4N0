using System;
using MvvmCross.Core.ViewModels;

namespace N5ICommand
{
	public class SecondViewModel : MvxViewModel
	{
		private string _name = "Second";
		public string Name
		{
			get { return _name; }
			set { SetProperty(ref _name, value); }
		}
	}
}
