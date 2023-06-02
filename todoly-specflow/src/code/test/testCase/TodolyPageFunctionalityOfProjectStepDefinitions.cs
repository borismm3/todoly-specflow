using System;
using TechTalk.SpecFlow;
using Assert = NUnit.Framework.Assert;

namespace todoly_specflow.src.code.test.testCase
{
    [Binding]
    public class TodolyPageFunctionalityOfProjectStepDefinitions : TestBase
    {
        [Given(@"I am on the Todoly login section")]
        public void GivenIAmOnTheTodolyLoginSection()
        {
            mainPage.loginButton.Click();
        }

        [When(@"I enter my username ""([^""]*)"" and password ""([^""]*)"", both valid, and click login")]
        public void WhenIEnterMyUsernameAndPasswordBothValidAndClickLogin(string user, string pwd)
        {
            loginSection.Login(user, pwd);
        }

        [Then(@"I should be logged in and see the Todoly logout button")]
        public void ThenIShouldBeLoggedInAndSeeTheTodolyLogoutButton()
        {
            Assert.IsTrue(menuSection.logoutButton.IsControlDisplayed(),
                "ERROR! The login was not successfully, review credentials please");
        }

        [Given(@"I am on the left section to click the add new project button")]
        public void GivenIAmOnTheLeftSectionToClickTheAddNewProjectButton()
        {
            leftSite.addNewProjectButton.Click();
        }

        [When(@"I enter the new project name ""([^""]*)"" and click the add button")]
        public void WhenIEnterTheNewProjectNameAndClickTheAddButton(string projectName)
        {
            leftSite.projectNameTxtBox.SetText(projectName);
            leftSite.addButton.Click();
        }

        [Then(@"The project name ""([^""]*)"" should be displayed on the left site section")]
        public void ThenTheProjectNameShouldBeDisplayedOnTheLeftSiteSection(string projectName)
        {
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed(projectName), "ERROR! The project was not created");
        }

        [Given(@"I am on the left section to click the project name ""([^""]*)""")]
        public void GivenIAmOnTheLeftSectionToClickTheProjectName(string projectName)
        {
            leftSite.ClickProjectName(projectName);
        }

        [Given(@"I click on sub menu icon to click the edit button")]
        public void GivenIClickOnSubMenuIconToClickTheEditButton()
        {
            leftSite.subMenuIcon.Click();
            leftSite.editButton.Click();
        }

        [When(@"I enter the updated project name ""([^""]*)"" and click the save button")]
        public void WhenIEnterTheUpdatedProjectNameAndClickTheSaveButton(string projectNameUpdated)
        {
            leftSite.projectNameEditTxtBox.SetText(projectNameUpdated);
            leftSite.saveButton.Click();
        }

        [Then(@"The updated project name ""([^""]*)"" should be displayed on the left site section")]
        public void ThenTheUpdatedProjectNameShouldBeDisplayedOnTheLeftSiteSection(string projectNameUpdated)
        {
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed(projectNameUpdated), "ERROR! The project was not updated");
        }

        [Given(@"I am on the left section to click the updated project name ""([^""]*)""")]
        public void GivenIAmOnTheLeftSectionToClickTheUpdatedProjectName(string projectNameUpdated)
        {
            leftSite.ClickProjectName(projectNameUpdated);
        }

        [Given(@"I click on sub menu icon to click the delete button")]
        public void GivenIClickOnSubMenuIconToClickTheDeleteButton()
        {
            leftSite.subMenuIcon.Click();
            leftSite.deleteButton.Click();
        }

        [When(@"I accept the Alert message")]
        public void WhenIAcceptTheAlertMessage()
        {
            session.Session.Instance.GetBrowser().SwitchTo().Alert().Accept();
        }

        [Then(@"The project name ""([^""]*)"" should no longer be displayed")]
        public void ThenTheProjectNameShouldNoLongerBeDisplayed(string projectNameUpdated)
        {
            Assert.IsFalse(leftSite.ProjectNameIsDisplayed(projectNameUpdated), "ERROR! The project was not deleted");
        }
    }
}
