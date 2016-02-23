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

namespace WindowsApp
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

        private void laskeButton_Click(object sender, RoutedEventArgs e)
        {
            // Haetaan käyttäjän syöttämät luvut korkeus, leveys, karminleveys
            string leveysString = leveysTextBox.Text;
            int leveys = int.Parse(leveysString);
            //KORKEUS
            string korkeusString = korkeusTextBox.Text;
            int korkeus = int.Parse(korkeusString);
            //KARMI
            string karmiString = karmiTextBox.Text;
            int karmi = int.Parse(karmiString);

            //LASKUTOIMITUS KARMIN PIIRI
            int karpiiri = 2 *(korkeus + leveys) / 10;

            //LASKUTOIMITUS IKKUNAN ALA
            int lasilaske = (leveys * korkeus) /10;

            //LASKUTOIMITUS LASIN ALA
            int laske = (leveys - (2*karmi)) * (korkeus - (2*karmi)) / 10;

            vastauskarmiTextBlock.Text = karpiiri.ToString() + " cm";
            vastausikkunaTextBlock.Text = lasilaske.ToString() + " cm^2";
            vastauslasiTextBlock.Text = laske.ToString() + " cm^2"; 


        }
    }
}
