using System;
using System.Globalization;
using System.IO;
using Xamarin.Forms;

namespace StorefrontAPISample_Xamarin
{
	public class UrlToImage : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			byte[] _appImageBytes = (byte[])value;

			return ImageSource.FromStream(() => new MemoryStream(_appImageBytes));

		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return null;
		}
	}
}
