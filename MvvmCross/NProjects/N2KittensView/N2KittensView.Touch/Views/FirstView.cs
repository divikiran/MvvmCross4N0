using System;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using N2KittensView.Core.ViewModels;

namespace N2KittensView.Touch
{
	[Register("FirstView")]
	public class FirstView : MvxTableViewController
	{
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			//var source = new MvxStandardTableViewSource(TableView, "TitleText Name;ImageUrl ImageUrl;Text Price");
			var source = new MvxSimpleTableViewSource(TableView, KittenCell.Key, KittenCell.Key);
			TableView.RowHeight = 100;
			TableView.Source = source;

			var set = this.CreateBindingSet<FirstView, FirstViewModel>();
			set.Bind(source).To(v => v.Kittens);
			set.Apply();

			TableView.ReloadData();

		}
	}
}
