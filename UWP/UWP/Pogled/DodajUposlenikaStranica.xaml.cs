using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP.Enumeracija;
using UWP.Kontroler;
using UWP.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP.Pogled {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DodajUposlenikaStranica : Page {

        private Biblioteka biblioteka;

        public DodajUposlenikaStranica()
        {
            InitializeComponent();
            inicijalizirajKontrole();
        }

        private void inicijalizirajKontrole()
        {
            inicijalizirajKontroluDatumRodjenja();
            inicijalizirajKontroluSlika();
            inicijalizirajKontroluSpol();
            inicijalizirajKontroluTip();
        }

        private void inicijalizirajKontroluDatumRodjenja()
        {
            kontrolaDatumRodjenja.Date = DateTime.Now;
        }

        private void inicijalizirajKontroluSlika()
        {
            kontrolaSlika.Source = new BitmapImage(new Uri("ms-appx:///Assets/Square150x150Logo.scale-200.png"));
        }

        private void inicijalizirajKontroluSpol()
        {
            kontrolaSpol.Items.Add(Spol.Musko.ToString());
            kontrolaSpol.Items.Add(Spol.Zensko.ToString());
            kontrolaSpol.Items.Add(Spol.Ostali.ToString());
        }

        private void inicijalizirajKontroluTip()
        {
            kontrolaTip.Items.Add(TipUposlenika.Obicni.ToString());
            kontrolaTip.Items.Add(TipUposlenika.Cistac.ToString());
            kontrolaTip.Items.Add(TipUposlenika.Domar.ToString());
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

        private async void izaberiSlikuUposlenika(object sender, RoutedEventArgs e)
        {
            FileOpenPicker izbornikFajlaSlike = new FileOpenPicker();
            izbornikFajlaSlike.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            izbornikFajlaSlike.FileTypeFilter.Add(".bmp");
            izbornikFajlaSlike.FileTypeFilter.Add(".jpeg");
            izbornikFajlaSlike.FileTypeFilter.Add(".jpg");
            izbornikFajlaSlike.FileTypeFilter.Add(".png");
            StorageFile fajlSlike = await izbornikFajlaSlike.PickSingleFileAsync();
            if (fajlSlike != null)
            {
                using (IRandomAccessStream tokFajla = await fajlSlike.OpenAsync(FileAccessMode.Read))
                {
                    BitmapImage slika = new BitmapImage();
                    slika.SetSource(tokFajla);
                    kontrolaSlika.Source = slika;
                }
            }
        }

        private void ponistiUposlenika(object sender, RoutedEventArgs e)
        {
            kontrolaIme.Text = "";
            kontrolaPrezime.Text = "";
            kontrolaMaticniBroj.Text = "";
            inicijalizirajKontroluDatumRodjenja();
            inicijalizirajKontroluSlika();
            kontrolaSpol.SelectedValue = null;
            kontrolaTip.SelectedValue = null;
        }

        private void dodajUposlenika(object sender, RoutedEventArgs e)
        {
            try
            {
                Uposlenik u = new Uposlenik(kontrolaIme.Text, kontrolaPrezime.Text, kontrolaMaticniBroj.Text, 
                    kontrolaDatumRodjenja.Date.Value.Date, (Spol)kontrolaSpol.SelectedIndex, kontrolaSlika.Source, 
                    (TipUposlenika)kontrolaTip.SelectedIndex);
                biblioteka.RegistrujUposlenika(u);
                prikaziDijalogPoruke("Obavještenje", "Uposlenik je uspješno dodan.");
            } 
            catch(Exception exc)
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
