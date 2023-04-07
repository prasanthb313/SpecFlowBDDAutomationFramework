using NUnit.Framework;
using OpenQA.Selenium;
using SampleProject.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class SwagLabsStepDefinitions
    {
        public IWebDriver driver;

        HomePage homepage;

        [Given(@"The user is logged into application using username '([^']*)' and password '([^']*)'")]
        public void GivenTheUserIsLoggedIntoApplicationUsingUsernameAndPassword(string username, string password)
        {
            homepage = new HomePage(driver);
            homepage.enterUsername(username);
            homepage.enterPassword(password);
        }

        [When(@"Click on Login Button")]
        public void WhenClickOnLoginButton()
        {
            homepage.getLogOnButton();
        }

        [Then(@"Verify cart Icon in home page '([^']*)'")]
        public void ThenVerifyCartIconInHomePage(string expectedStatus)
        {
            string actualStatus = homepage.isHomePageLogoDisplayed().ToString();
            if(actualStatus != expectedStatus)
            {
                Console.WriteLine("Home page Logo is not dispayed");
                Assert.Fail();
            }
        }
    }
}
