using Epam.TestAutomation.Core.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Epam.TestAutomation.Core.Browser;

public static class DriverFactory
{
    public static IWebDriver GetWebDriver(BrowserType browser)
    {
        IWebDriver createdWebDriver;
        switch (browser)
        {
            case BrowserType.Chrome:
                createdWebDriver = new ChromeBrowser().GetDriver();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(browser));
        }
        return createdWebDriver;
    }
}