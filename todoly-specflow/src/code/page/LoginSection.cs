using OpenQA.Selenium;
using todoly_specflow.src.code.control;

namespace todoly_specflow.src.code.page.todoly
{
    public class LoginSection
    {
        public TextBox emailTxtBox = new TextBox(By.Id("ctl00_MainContent_LoginControl1_TextBoxEmail"));
        public TextBox pwdTxtBox = new TextBox(By.Id("ctl00_MainContent_LoginControl1_TextBoxPassword"));
        public Button loginButton = new Button(By.Id("ctl00_MainContent_LoginControl1_ButtonLogin"));

        public void Login(string user, string pwd)
        {
            emailTxtBox.SetText(user);
            pwdTxtBox.SetText(pwd);
            loginButton.Click();
        }
    }
}
