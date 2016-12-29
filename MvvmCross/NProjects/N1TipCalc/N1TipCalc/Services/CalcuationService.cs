using System;
namespace N1TipCalc
{
	public class CalcuationService : ICalcuationService
	{
		public CalcuationService()
		{
		}

		public double Tip(double subTotal, double generosity)
		{
			return subTotal * generosity / 100.0;
		}
	}
}
