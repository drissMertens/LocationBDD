using System;
using System.Collections.Generic;

namespace LocationBDD
{
    public class Vehicule
    {
        public string Immatriculation { get; set; }
        public string Marque { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public float PriceReservation { get; set; }
        public float PriceKilometrique { get; set; }
        public float ChvFiscaux { get; set; }

        public Vehicule(string immatriculation, string marque, string model, string color, 
                        float priceReservation, float priceKilometrique, float chvFiscaux)
        {
            this.Immatriculation = immatriculation;
            this.Marque = marque;
            this.Model = model;
            this.Color = color;
            this.PriceReservation = priceReservation;
            this.PriceKilometrique = priceKilometrique;
            this.ChvFiscaux = chvFiscaux;
        
        }

     
    }
}
