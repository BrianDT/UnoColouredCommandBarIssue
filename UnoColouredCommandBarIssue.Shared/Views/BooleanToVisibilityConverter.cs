// <copyright file="BooleanToVisibilityConverter.cs" company="Visual Software Systems Ltd.">Copyright (c) 2012, 2019 All rights reserved</copyright>

namespace Vssl.Samples.Views.Converters
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Graphics.Display;
    using Windows.UI.ViewManagement;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Data;

    /// <summary>
    /// Value converter that translates true to <see cref="Visibility.Visible"/> and false to
    /// <see cref="Visibility.Collapsed"/>.
    /// </summary>
    public class BooleanToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Converts boolean to Visibility
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="targetType">The target type of the conversion</param>
        /// <param name="parameter">Any optional parameter</param>
        /// <param name="language">The language</param>
        /// <returns>The converted value</returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (value is bool && (bool)value) ? Visibility.Visible : Visibility.Collapsed;
        }

        /// <summary>
        /// Converts Visibility to boolean
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="targetType">The target type of the conversion</param>
        /// <param name="parameter">Any optional parameter</param>
        /// <param name="language">The language</param>
        /// <returns>The converted value</returns>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return value is Visibility && (Visibility)value == Visibility.Visible;
        }
    }
}
