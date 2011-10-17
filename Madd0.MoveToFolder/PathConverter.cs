//-----------------------------------------------------------------------
// <copyright file="PathConverter.cs" company="">
//     Copyright (c) madd0, . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Madd0.MoveToFolder
{
    using System;
    using System.Linq;
    using System.Windows.Data;

    /// <summary>
    /// TODO: Provide summary section in the documentation header.
    /// </summary>
    public class PathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string path = (string)value;

            int indexOfFirstFolder = path.IndexOf('\\', 3);

            if (parameter != null && parameter.Equals("root"))
            {
                if (indexOfFirstFolder < 0)
                {
                    return path.Substring(2);
                }
                else
                {
                return path.Substring(2, path.IndexOf('\\', 3) - 2);
                }
            }

            if (indexOfFirstFolder < 0)
            {
                return "\\";
            }
            else
            {
                return path.Substring(path.IndexOf('\\', 3) + 1);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
