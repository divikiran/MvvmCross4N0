using MvvmCross.Core.ViewModels;

namespace N1TipCalc.ViewModels
{
	public class FirstViewModel
		: MvxViewModel
	{
		private string _hello = "Hello MvvmCross";
		public string Hello
		{
			get { return _hello; }
			set { SetProperty(ref _hello, value); }
		}

		private readonly ICalcuationService _calculationService;
		public FirstViewModel(ICalcuationService calculationService)
		{
			_calculationService = calculationService;
			_generosity = 20;
			_subTotal = 100;
			ReCalc();

		}

		private double _subTotal;
		public double SubTotal
		{
			get { return _subTotal; }
			set { SetProperty(ref _subTotal, value); ReCalc(); }
		}

		private double _generosity;
		public double Generosity
		{
			get { return _generosity; }
			set
			{
				SetProperty(ref _generosity, value);
				ReCalc();
			}
		}


		private double _tip;
		public double Tip
		{
			get { return _tip; }
			set { SetProperty(ref _tip, value); }
		}

		private double _total;
		public double Total
		{
			get { return _total; }
			set { SetProperty(ref _total, value); }
		}

		private void ReCalc()
		{
			Tip = _calculationService.Tip(SubTotal, Generosity);
			Total = SubTotal + Tip;
		}
	}
}