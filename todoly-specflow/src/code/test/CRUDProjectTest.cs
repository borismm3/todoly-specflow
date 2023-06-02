using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace todoly_specflow.src.code.test
{
    /*[TestClass]
    public class CRUDProjectTest : TestBase
    {
        [TestMethod]
        public void VerifyCRUDProject()
        {
            string projectName = "Mojix" + DateTime.Now.Ticks.ToString();
            string projectNameUpdated = "Updated" + DateTime.Now.Ticks.ToString();
            string taskName = "Task" + DateTime.Now.Ticks.ToString();
            string taskNameUpdated = "Updated" + DateTime.Now.Ticks.ToString();

            // Login
            mainPage.loginButton.Click();
            loginSection.Login(user, pwd);
            Assert.IsTrue(menuSection.logoutButton.IsControlDisplayed(),
                "ERROR! The login was not successfully, review credentials please");

            // New project
            leftSite.addNewProjectButton.Click();
            leftSite.projectNameTxtBox.SetText(projectName);
            leftSite.addButton.Click();
            // add verification
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed(projectName), "ERROR! The project was not created");

            // Update project
            leftSite.ClickProjectName(projectName);
            leftSite.subMenuIcon.Click();
            leftSite.editButton.Click();
            leftSite.projectNameEditTxtBox.SetText(projectNameUpdated);
            leftSite.saveButton.Click();
            // add verification
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed(projectNameUpdated), "ERROR! The project was not updated");

            // Delete project
            leftSite.ClickProjectName(projectNameUpdated);
            leftSite.subMenuIcon.Click();
            leftSite.deleteButton.Click();
            session.Session.Instance.GetBrowser().SwitchTo().Alert().Accept();
            // add verification
            Assert.IsFalse(leftSite.ProjectNameIsDisplayed(projectNameUpdated), "ERROR! The project was not deleted");
        }
    }*/
}
