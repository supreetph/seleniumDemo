using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace SeleniumDemo
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://twitter.com/login");
            var txtUserName = webDriver.FindElement(By.Name("session[username_or_email]"));
            txtUserName.SendKeys("tom");
            Assert.True(txtUserName.Displayed);

        }
    }
}
