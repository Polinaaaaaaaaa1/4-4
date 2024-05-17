using System;
using System.Globalization;
using System.Reflection;
using Avalonia.Media.Imaging;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Avalonia.Platform;

namespace lasthw.Infrastructure;

public class BitmapValueConverter : IValueConverter
{
    public static BitmapValueConverter Instance = new BitmapValueConverter();

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string imagePath && targetType == typeof(IImage))
        {
            try
            {
                Console.WriteLine("Attempting to load image from path: " + imagePath);
                var prefix = $"avares://{Assembly.GetExecutingAssembly().GetName().Name}/Assets/";
                var uri = new Uri(prefix + imagePath, UriKind.RelativeOrAbsolute);
                Console.WriteLine("Image URI: " + uri);
                var bitmap = new Bitmap(AssetLoader.Open(uri));
                Console.WriteLine("Image loaded successfully");
                return bitmap;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading image: " + ex.Message);
            }
        }
        throw new NotSupportedException();
    }


    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}