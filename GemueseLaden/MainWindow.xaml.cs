using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GemueseLaden
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Basket einkaufswagen;
        public MainWindow()
        {
            InitializeComponent();
            einkaufswagen = new Basket();
            einkaufswagen.TotalPriceChanged += TextBoxGesamtPreisAktualisieren;
        }

        private void TextBoxGesamtPreisAktualisieren()
        {
            TextBoxGesamtPreis.Text = Convert.ToString(einkaufswagen.Totalprice);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Veggi v = new Veggi() {
                Name = TextBoxVeggi.Text,
                Preis_pro_Einheit = (float)Convert.ToDouble(TextBoxUnitPrice.Text),
                Menge = Convert.ToInt32(TextBoxUnits.Text),
                Kategorie = TextBoxCategory.Text
            };
            einkaufswagen.Add(v);
            ListBoxBasket.ItemsSource = einkaufswagen.Veggies;

        }
    }
}
