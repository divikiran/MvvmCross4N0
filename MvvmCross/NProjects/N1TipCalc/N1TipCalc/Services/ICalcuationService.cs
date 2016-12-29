using System;
namespace N1TipCalc
{
	public interface ICalcuationService
	{
		double Tip(double subTotal, double generosity);
	}
}