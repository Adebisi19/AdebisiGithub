using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BlueeskyybisiTestFramework.StepDefinition
{
    [Binding]
    public sealed class Login
    {



        [Given(@"Inavigate to the website")]
        public void GivenInavigateToTheWebsite()
        {
           // ScenarioContext.Current.Pending();
        }

        [When(@"I click on login link")]
        public void WhenIClickOnLoginLink()
        {
           // ScenarioContext.Current.Pending();
        }

        [When(@"I enter username")]
        public void WhenIEnterUsername()
        {
//ScenarioContext.Current.Pending();
        }

        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            //.Current.Pending();
        }

        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
//ScenarioContext.Current.Pending();
        }

        [Then(@"I must be able to login")]
        public void ThenIMustBeAbleToLogin()
        {
            //ScenarioContext.Current.Pending();
        

    }
}
}
