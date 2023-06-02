using OpenQA.Selenium;
using todoly_specflow.src.code.control;

namespace todoly_specflow.src.code.page.todoly
{
    public class MenuSection
    {
        public Button logoutButton = new Button(By.Id("ctl00_HeaderTopControl1_LinkButtonLogout"));
    }
}
