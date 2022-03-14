using System;
using TechTalk.SpecFlow;
using LocationBDD;
using LocationSpecFlow.Fake;

namespace LocationSpecFlow.Features
{
    [Binding]
    public class VehiculeTestSteps
    {
        private readonly ScenarioContext _scenarioContext;

        private string _immatriculation;
        private string _marque;
        private string _model;
        private string _color;
        private float _priceReservation;
        private float _priceKilometrique;
        private int _chvFiscaux;
        private string _lastErrorMessage;
        //private Location _target;
        private FakeDataLayer _fakeDataLayer;

        public VehiculeTestSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            this._fakeDataLayer = new FakeDataLayer();
            //  this._target = new Location(this._fakeDataLayer);
        }

        [Given(@"je cree un newVehicule avec pour immatriculation ""(.*)"", marque ""(.*)"", model ""(.*)"", color ""(.*)"", PriceReservation ""(.*)"" €, PriceKilometrique ""(.*)""€ ChvFiscaux is ""(.*)""")]
        public void GivenJeCreeUnNewVehiculeAvecPourImmatriculationMarqueModelColorPriceReservationPriceKilometriqueChvFiscauxIs(string immatriculation, string marque, string model, string color, float priceReservation, float priceKilometrique, float chvFiscaux)
        {
            Vehicule test = new Vehicule(immatriculation, marque, model, color, priceReservation, priceKilometrique, chvFiscaux);
        }

        [Given(@"the immatriculation (.*), the model (.*), the ChvFiscaux (.*)")]
        public void GivenTheImmatriculationPO_HGTheModelClio_RSTheChvFiscaux(string immatriculation, string model, int chevaux)
        {
            this._immatriculation = immatriculation;
            this._model = model;
            this._chvFiscaux = chevaux;
        }

        [When(@"the data match")]
        public void WhenTheDataMatch()
        {
        }

        [Then(@"the vehicule is the (.*)")]
        public void ThenTheVehiculeIsTheRenault(string marque)
        {
        }

    }
}
