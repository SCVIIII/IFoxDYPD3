using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace IFoxTestCode
{
    

    public class RowSpanToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int rowSpan)
            {
                switch (rowSpan)
                {
                    case 1:
                        return new SolidColorBrush(Color.FromRgb(255, 200, 200)); // 浅红色
                    case 2:
                        return new SolidColorBrush(Color.FromRgb(200, 255, 200)); // 浅绿色
                    case 3:
                        return new SolidColorBrush(Color.FromRgb(200, 200, 255)); // 浅蓝色
                    default:
                        return Brushes.White;
                }
            }
            return Brushes.White;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
