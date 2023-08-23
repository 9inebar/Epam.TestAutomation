using Epam.TestAutomation.Core.BasePage;
using Epam.TestAutomation.Core.Elements;
using Epam.TestAutomation.Web.PageObjects.Panels;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Web.PageObjects.Pages;

public class MainPage :BasePage
{
    public Label Title => new Label(By.TagName("h2"));

    public FooterBlock FooterBlock => new FooterBlock(By.XPath("//*[@class='footer section']"));

    public HeaderBlock HeaderBlock => new HeaderBlock(By.XPath("//*[@class = 'header__content']"));
}