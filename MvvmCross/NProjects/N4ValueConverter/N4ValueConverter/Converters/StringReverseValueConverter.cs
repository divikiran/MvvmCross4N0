using System;
using System.Text;
using MvvmCross.Platform.Converters;

namespace N4ValueConverter
{
	public class StringReverseValueConverter : MvxValueConverter<string, string>
	{
		protected override string Convert(string value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return Reverse(value);

		}

		//protected override string ConvertBack(string value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		//{
		//	return Reverse(value);
		//}

		static string Reverse(string value)
		{
			value = value ?? "";
			var stringBuilder = new StringBuilder(value.Length);

			for (var i = value.Length - 1; i >= 0; i--)
			{
				stringBuilder.Append(value[i]);
			}

			return stringBuilder.ToString();
		}
	}
}
