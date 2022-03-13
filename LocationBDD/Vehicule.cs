using System;
using System.Collections.Generic;

namespace LocationBDD
{
    public class Vehicule
    {
        private string Immatriculation { get; }
        private string Marque { get; }
        private string Model { get;}
        private string Color { get;}
        private float PriceReservation { get;}
        private float PriceKilometrique { get;}
        private float ChvFiscaux { get;}

        private List<List<DateTime>> ReservationDate { get; set; }


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
