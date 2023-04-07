using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace SampleProject.Pages
{
    [Binding]
    public class HomePage
    {

        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By username => By.XPath("//input[@placeholder='Username']");
        By password => By.XPath("//input[@placeholder='Password']");
        By logonButton => By.XPath("//input[@type='submit']");
        By homePageLogo => By.XPath("//div[text()='Swag Labs']");

        public void enterUsername(string userName)
        {
            driver.FindElement(username).SendKeys(userName);
        }

        public void enterPassword(string passWord)
        {
            driver.FindElement(password).SendKeys(passWord);
        }

        public void getLogOnButton()
        {
            driver.FindElement(logonButton).Click();
        }

        public bool isHomePageLogoDisplayed()
        {
            bool status = driver.FindElement(homePageLogo).Displayed;
            return status;
        }
    }
}
