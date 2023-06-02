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
            Console.WriteLine("FIRST PAR OF PATH = " + path);
            Console.WriteLine("SECOND PAR OF PATH = /resources/driver/chromedriver.exe");

            string directoryPath = path;

            // Get all files in the directory
            string[] files = Directory.GetFiles(directoryPath);
            Console.WriteLine("Files:");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            // Get all subdirectories in the directory
            string[] directories = Directory.GetDirectories(directoryPath);
            Console.WriteLine("Directories:");
            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
            }


            IWebDriver driver = new ChromeDriver(path + "/resources/driver/", options);
            
            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}
