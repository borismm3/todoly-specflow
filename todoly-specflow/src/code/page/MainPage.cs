using OpenQA.Selenium;
using todoly_specflow.src.code.control;

namespace todoly_specflow.src.code.page.todoly
{
    public class MainPage
    {
        public Button loginButton = new Button(By.XPath("//img[@src=\"/Images/design/pagelogin.png\"]"));
    }
}
