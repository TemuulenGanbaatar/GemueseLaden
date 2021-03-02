using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemueseLaden
{
    class Basket
    {
        public ObservableCollection<Veggi> Veggies = new ObservableCollection<Veggi>();


        public void Add(Veggi veggi)
        {
            Veggies.Add(veggi);
            TotalPriceChanged();
        }

        private double totalprice;
        public double Totalprice
        {
            get {
                double Gesamtpreis = 0;

                foreach (var item in Veggies)
                {
                    Gesamtpreis += item.Price;
                }
                return Gesamtpreis;
            }
            set { totalprice = value; }
        }


        public TotalPriceChangedEventHandler TotalPriceChanged;
    }
}
