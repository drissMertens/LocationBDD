using System;
using TechTalk.SpecFlow;
using LocationBDD;

namespace LocationSpecFlow.Steps
{
    [Binding]
    public class ClientSteps
    {
        Client test;
        bool permis = false;
        [Given(@"the username (.*), the password (.*), the name (.*), the lastname (.*) and the birthdate (.*)")]
        public void GivenTheUsernameBobThePasswordAzertyTheNameBobTheLastnameLenonAndTheBirthdate(string username,string password, string name, string lastname, DateTime birthdate)
        {
            test = new Client(username, password, name, lastname, birthdate);
        }
        
        [Given(@"the licence date (.*)")]
        public void GivenTheLicenceDate(DateTime licenceDate)
        {
            test.LicenceDate = licenceDate;
        }
        
        [When(@"the client is major")]
        public void WhenTheClientIsMajor()
        {
            test.estMajeur();
        }
        
        [When(@"the client is not major")]
        public void WhenTheClientIsNotMajor()
        {
            test.estMajeur();
        }
        
        [When(@"the licence is less than (.*) mouth experience")]
        public void WhenTheLicenceIsLessThanMouthExperience(int limit)
        {
            permis = test.permisValide(limit);
        }
        
        [When(@"the licence is more than (.*) mouth experience")]
        public void WhenTheLicenceIsMoreThanMouthExperience(int limit)
        {
            permis = test.permisValide(limit);
        }
        
        [Then(@"the client is register")]
        public void ThenTheClientIsRegister()
        {
            if (test.estMajeur())
                Console.WriteLine("Tu es majeur");
        }
        
        [Then(@"the client is not register because he is to young")]
        public void ThenTheClientIsNotRegisterBecauseHeIsToYoung()
        {
            if (!test.estMajeur())
                Console.WriteLine("Tu n'es pas majeur");                
        }
        
        [Then(@"the licence is not valide you don't have enouth experience to make location")]
        public void ThenTheLicenceIsNotValideYouDonTHaveEnouthExperienceToMakeLocation()
        {
            if (!permis)
                Console.WriteLine("Tu ne peux pas louer");
        }
        
        [Then(@"the licence is valide you can make location")]
        public void ThenTheLicenceIsValideYouCanMakeLocation()
        {
            if (permis)
                Console.WriteLine("Tu peux louer");
        }
    }
}
