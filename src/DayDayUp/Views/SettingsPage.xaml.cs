using DayDayUp.ViewModels;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace DayDayUp.Views
{
 
    public sealed partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            
            this.InitializeComponent();

            DataContext = Ioc.Default.GetRequiredService<SettingsPageViewModel>();

        }

        public SettingsPageViewModel ViewModel => (SettingsPageViewModel)DataContext;
    }
}
