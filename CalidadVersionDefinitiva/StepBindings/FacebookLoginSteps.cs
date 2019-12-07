using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using TechTalk.SpecFlow;


namespace CalidadVersionDefinitiva
{
    [Binding]
    public class FacebookLoginSteps
    {
        private ChromeDriver chromeDriver;
        public FacebookLoginSteps() => chromeDriver = new ChromeDriver();

        [Given(@"I have navigated to facebook")]
        public void GivenIHaveNavigatedToFacebook()
        {
            chromeDriver.Navigate().GoToUrl("https://www.facebook.com");
            Assert.IsTrue(chromeDriver.Title.ToLower().Contains("facebook"));
        }
        
        [Given(@"I have entered user into the username field")]
        public void GivenIHaveEnteredUserIntoTheUsernameField()
        {
            chromeDriver.FindElement(By.Id("email")).SendKeys("Selenium");
        }
        
        [Given(@"I have entered password into the password field")]
        public void GivenIHaveEnteredPasswordIntoThePasswordField()
        {
            chromeDriver.FindElement(By.Id("pass")).SendKeys("Testing");
        }
        
        [When(@"I press the submit button")]
        public void WhenIPressTheSubmitButton()
        {
            var submitButton = chromeDriver.FindElement(By.Id("u_0_2"));
            submitButton.Click();
        }
        
        [Then(@"I should see the login session")]
        public void ThenIShouldSeeTheLoginSession()
        {
            System.Threading.Thread.Sleep(2000);
        }
    }
}
