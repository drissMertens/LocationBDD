using System;
using TechTalk.SpecFlow;
using LocationBDD;

namespace LocationSpecFlow.Features
{
    [Binding]
    public class VehiculeTestSteps
    {
        Vehicule test = new Vehicule();

        [Given(@"my immatriculation is ""(.*)""")]
        public void GivenMyImmatriculationIs(string p0)
        {
            test.Immatriculation = p0;
        }
        
        [Given(@"my marque is ""(.*)""")]
        public void GivenMyMarqueIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"my model is ""(.*)""")]
        public void GivenMyModelIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"my color is ""(.*)""")]
        public void GivenMyColorIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"PriceReservation is ""(.*)"" €")]
        public void GivenPriceReservationIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"PriceKilometrique is ""(.*)""€")]
        public void GivenPriceKilometriqueIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"ChvFiscaux is ""(.*)""")]
        public void GivenChvFiscauxIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
