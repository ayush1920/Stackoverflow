﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace StackOverflow
{
    public class HoverButton : Button
    {

        public static readonly DependencyProperty hoverColorProperty = DependencyProperty.Register
            (
                 "hoverColor",
                 typeof(SolidColorBrush),
                 typeof(HoverButton),
                 new PropertyMetadata(new BrushConverter().ConvertFrom("#5D5D5D"))
            );

        public SolidColorBrush hoverColor
        {
            get { return (SolidColorBrush)GetValue(hoverColorProperty); }
            set { SetValue(hoverColorProperty, value); }
        }

        public static readonly DependencyProperty bgColorProperty = DependencyProperty.Register
         (
              "bgColor",
              typeof(SolidColorBrush),
              typeof(HoverButton),
              new PropertyMetadata(new SolidColorBrush(Colors.Red))
         );

        public SolidColorBrush bgColor
        {
            get { return (SolidColorBrush)GetValue(bgColorProperty); }
            set { SetValue(bgColorProperty, value); }
        }
    }
}