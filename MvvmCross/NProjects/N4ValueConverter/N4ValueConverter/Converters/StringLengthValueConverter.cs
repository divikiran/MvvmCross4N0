using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace N4ValueConverter
{
	public class StringLengthValueConverter : MvxValueConverter<string, int>
	{
		protected override int Convert(string value, Type targetType, object parameter, CultureInfo culture)
		{
			value = value ?? "";
			return value.Length;
		}
	}
}
