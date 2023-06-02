using OpenQA.Selenium;

namespace todoly_specflow.src.code.control
{
    public class TextBox : ControlSelenium
    {
        public TextBox(By locator) : base(locator)
        {
        }

        public void SetText(string value)
        {
            FindControl();
            control.Clear();
            control.SendKeys(value);
        }
    }
}
