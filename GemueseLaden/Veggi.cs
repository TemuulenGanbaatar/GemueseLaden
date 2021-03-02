using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemueseLaden
{

    class Veggi
    {
        public string Name { get; set; }
        public int Menge { get; set; }
        public double Preis_pro_Einheit { get; set; }
        public string Kategorie { get; set; }

        private double price;

        public double Price
        {
            get
            {
                if (Kategorie == "A")
                {
                    return (Preis_pro_Einheit * Menge);
                }
                else if (Kategorie == "B")
                {
                    return Menge * (Preis_pro_Einheit * 0.95);
                }
                else if (Kategorie == "C")
                {
                    return Menge * (Preis_pro_Einheit * 0.9);
                }
                else
                    return 0;
            }
            set { price = value; }
        }

        //
        public override string ToString()
        {
            return $"Name: {Name}  Preis/Einheit: {Preis_pro_Einheit}  Menge: {Menge}  Kategorie: {Kategorie}";
        }



    }
}
