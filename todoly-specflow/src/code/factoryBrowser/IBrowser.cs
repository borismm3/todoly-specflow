using OpenQA.Selenium;

namespace todoly_specflow.src.code.factoryBrowser
{
    public interface IBrowser
    {
        IWebDriver Create();
    }
}
