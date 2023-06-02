using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlow.Internal.Json;
using TechTalk.SpecFlow;
using todoly_specflow.src.code.page.todoly;
using todoly_specflow.src.code.util.properties;

namespace todoly_specflow.src.code.test
{
    public class TestBase
    {
        protected MainPage mainPage = new MainPage();
        protected LoginSection loginSection = new LoginSection();
        protected MenuSection menuSection = new MenuSection();
        protected LeftSite leftSite = new LeftSite();

        [BeforeScenario("@Login")]
        public void OpenBrowser()
        {
            session.Session.Instance.GetBrowser().Navigate().GoToUrl(GetPropertiesTodoly.Instance.Host);
        }

        [AfterScenario("@DeleteProject")]
        public void CloseBrowser()
        {
            session.Session.Instance.CloseBrowser();
        }
    }
}
