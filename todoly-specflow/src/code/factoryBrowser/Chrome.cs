using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace todoly_specflow.src.code.factoryBrowser
{
    public class Chrome : IBrowser
    {
        public IWebDriver Create()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            ChromeOptions options = new ChromeOptions();
            /*options.AddArgument("--headless"); // Run Chrome in headless mode
            options.AddArgument("--no-sandbox"); // Add necessary arguments for headless mode to work properly
            options.AddArgument("--disable-gpu");
            options.AddArgument("--disable-dev-shm-usage");*/

            IWebDriver driver = new ChromeDriver(path + "/resources/driver/chromedriver.exe");
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
