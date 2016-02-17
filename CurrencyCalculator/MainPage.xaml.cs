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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CurrencyCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void euroButton_Click(object sender, RoutedEventArgs e)
        {
            string eurosString = euroTextBlock.Text;
            double euros = double.Parse(eurosString);

            euros = euros * 5.94573;

            euroTextBlock.Text = euros.ToString();
        }

        private void markkaButton_Click(object sender, RoutedEventArgs e)
        {
            string markkasString = markkaTextBlock.Text;
            double markkas = double.Parse(markkasString);

            markkas = markkas / 5.94573;

            markkaTextBlock.Text = markkas.ToString();
        }
    }
}
