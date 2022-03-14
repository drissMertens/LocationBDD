using System;
using TechTalk.SpecFlow;
using LocationBDD;
namespace LocationSpecFlow.Features
{
    [Binding]
    public class VehiculeTestSteps
    {
         Vehicule test;
        [Given(@"je cree un newVehicule")]
        public void GivenJeCreeUnNewVehicule(string immatriculation, string marque, string model, string color, float priceReservation, float priceKilometrique, float chvFiscaux)
        {
            test = new Vehicule(immatriculation, marque, model, color, priceReservation, priceKilometrique, chvFiscaux);
        }

        [Given(@"my immatriculation is ""(.*)""")]
        public void GivenMyImmatriculationIs(string p0)
        {
            test.Immatriculation = p0;
        }
        
        [Given(@"my marque is ""(.*)""")]
        public void GivenMyMarqueIs(string p0)
        {
            test.Marque = p0;
        }
        
        [Given(@"my model is ""(.*)""")]
        public void GivenMyModelIs(string p0)
        {
            test.Model = p0;
        }
        
        [Given(@"my color is ""(.*)""")]
        public void GivenMyColorIs(string p0)
        {
            test.Color = p0;
        }

        [Given(@"PriceReservation is ""(.*)"" €")]
        public void GivenPriceReservationIs(int p0)
        {
            test.PriceReservation = p0;
        }

        [Given(@"PriceKilometrique is ""(.*)""€")]
        public void GivenPriceKilometriqueIs(int p0)
        {
            test.PriceKilometrique = p0;
        }

        [Given(@"ChvFiscaux is ""(.*)""")]
        public void GivenChvFiscauxIs(int p0)
        {
            test.ChvFiscaux = p0;
        }

    }
}
