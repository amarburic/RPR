using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP.Kontroler;
using UWP.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP.Pogled {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DodajKnjiguStranica : Page {

        private Biblioteka biblioteka;

        public DodajKnjiguStranica()
        {
            InitializeComponent();
            inicijalizirajKontrole();
        }
        
        private void inicijalizirajKontrole()
        {
            inicijalizirajKontroluGodina();
        }

        private void inicijalizirajKontroluGodina()
        {
            kontrolaGodinaIzdanja.Date = DateTime.Now;
        }

        private void otvoriPodloguIzbornika(object sender, RoutedEventArgs e)
        {
            podlogaStranice.IsPaneOpen = !podlogaStranice.IsPaneOpen;
        }

        private void vratiIzbornikStranicu(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        private void ponistiKnjigu(object sender, RoutedEventArgs e)
        {
            kontrolaNaslov.Text = "";
            kontrolaAutori.Text = "";
            kontrolaISBN.Text = "";
            kontrolaIzdavac.Text = "";
            inicijalizirajKontroluGodina();
        }
        
        private void dodajKnjigu(object sender, RoutedEventArgs e)
        {
            try
            {
                Knjiga u = new Knjiga(kontrolaNaslov.Text, kontrolaAutori.Text.Split(',').ToList(), kontrolaISBN.Text,
                    kontrolaIzdavac.Text, kontrolaGodinaIzdanja.Date.Value.Year);
                prikaziDijalogPoruke("Obavještenje", "Knjiga je uspješno dodana.");
            }
            catch (Exception exc)
            {
                prikaziDijalogPoruke("Greška", exc.Message);
            }
        }
        

        private async void prikaziDijalogPoruke(string naslov, string poruka)
        {
            MessageDialog dijalogPoruke = new MessageDialog(poruka, naslov);
            dijalogPoruke.Commands.Clear();
            dijalogPoruke.Commands.Add(new UICommand { Label = "Ok", Id = 0 });
            await dijalogPoruke.ShowAsync();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            biblioteka = (Biblioteka)e.Parameter;
            base.OnNavigatedTo(e);
        }
    }
}
