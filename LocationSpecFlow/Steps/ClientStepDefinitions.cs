using TechTalk.SpecFlow;
using FluentAssertions;
using System;
using LocationSpecFlow.Fake;
using LocationBDD;

namespace LocationSpecFlow.Steps
{
    [Binding]
    public sealed class ClientStepDefinitions
    {
        [Given(@"the username (.*), the password (.*), the name (.*), the lastname (.*) and the birthdate (.")]
        public void GivenTheUsernameBobThePasswordAzertyTheNameBobTheLastnameLenonAndTheBirthdate(string username, string password, string name, string lastname, DateTime birthdate)
        {
            Client test = new Client(username, password, name, lastname, birthdate);
        }

        [When(@"the client is major")]
        public void WhenTheClientIsMajor()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the client is register")]
        public void ThenTheClientIsRegister()
        {

        }

        [When(@"the client is not major")]
        public void WhenTheClientIsNotMajor()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the client is not register because he is to young")]
        public void ThenTheClientIsNotRegisterBecauseHeIsToYoung()
        {

        }

    }
}
