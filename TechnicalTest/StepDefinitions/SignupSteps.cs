using NUnit.Framework;
using TechnicalTest.Generators;
using TechnicalTest.Models;
using TechnicalTest.PageObjects;
using TechTalk.SpecFlow;

namespace TechnicalTest.StepDefinitions
{
    [Binding]
    public sealed class SignupSteps
    {
        private HomePage homePage;
        private SignUpPage signupPage;
        private UserHomePage userHomePage;        
        public SignupSteps(HomePage homePage, SignUpPage signupPage, UserHomePage userHomePage)                
        {
            this.homePage = homePage;
            this.signupPage = signupPage;
            this.userHomePage = userHomePage;            
        }

        [Given(@"I am not logged in")]
        public void GivenIAmNotLoggedIn()
        {
            homePage.GoTo();
            Assert.That(homePage.NotLoggedIn());
        }

        [When(@"I complete the sign up form")]
        public void WhenICompleteTheSignUpForm()
        {
            homePage.OpenSignUpPage();
            SignupDetailsGenerator signupDetailsGenerator = new SignupDetailsGenerator();
            SignupDetails signupDetails = signupDetailsGenerator.Generate();
            signupPage.CompleteSignUp(signupDetails);
            ScenarioContext.Current["SignupDetails"] = signupDetails;
        }

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {           
            Assert.IsTrue(userHomePage.IsLoggedIn());
        }

        [Then(@"my username is displayed")]
        public void ThenMyUsernameIsDisplayed()
        {
            var signupDetails = (SignupDetails)ScenarioContext.Current["SignupDetails"];
            Assert.AreEqual(signupDetails.UserName, userHomePage.GetUserName());
        }

    }
}
