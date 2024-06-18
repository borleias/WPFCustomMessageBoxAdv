// -----------------------------------------------------------------------
// <copyright file="Util.cs">
// Copyright (c) 2024
// </copyright>
// -----------------------------------------------------------------------

namespace WPFCustomMessageBoxAdv
{
    using System.Drawing;
    using System.Windows;
    using System.Windows.Interop;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    /// <summary>
    /// Provides utility methods for the WPFCustomMessageBoxAdv namespace.
    /// </summary>
    internal static class Util
    {
        /// <summary>
        /// Converts an Icon to an ImageSource.
        /// </summary>
        /// <param name="icon">The Icon to convert.</param>
        /// <returns>The converted ImageSource.</returns>
        internal static ImageSource ToImageSource(this Icon icon)
        {
            ImageSource imageSource = Imaging.CreateBitmapSourceFromHIcon(
                icon.Handle,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            return imageSource;
        }
    }
}
