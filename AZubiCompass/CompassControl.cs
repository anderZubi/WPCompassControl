using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace AZubiCompass
{
    public class CompassControl : Control
    {
        public static readonly DependencyProperty HeadingProperty = DependencyProperty.Register("Heading", typeof(double), typeof(CompassControl), null);

        public CompassControl()
        {
            DefaultStyleKey = typeof(CompassControl);
        }

        public double Heading
        {
            get { return (double)base.GetValue(HeadingProperty); }
            set { base.SetValue(HeadingProperty, value); }
        }
    }
}
