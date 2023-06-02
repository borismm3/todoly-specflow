using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace todoly_specflow.src.code.factoryBrowser
{
    public class Chrome : IBrowser
    {
        public IWebDriver Create()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--disable-dev-shm-usage");

            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            IWebDriver driver = new ChromeDriver(path + "/src/resources/driver/", options);
            
            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}
