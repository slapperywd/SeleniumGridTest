using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumGridTest
{
    [TestClass]
    public class SeleniumGridTest
    {
        [TestMethod]
        public void ChromeMethod()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            RemoteWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:5555/wd/hub"), options.ToCapabilities());
            driver.Navigate().GoToUrl("https://metanit.com/nosql/mongodb/1.2.php");  
            driver.Quit();
        }
        [TestMethod]
        public void FireFox()
        {
            FirefoxOptions options = new FirefoxOptions();
            // options.AddArgument("--start-maximized");
            //also works fine with http://localhost:4444/wd/hub"
            RemoteWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:5555/wd/hub"), options.ToCapabilities());
            driver.Navigate().GoToUrl("https://metanit.com/nosql/mongodb/1.2.php");


            driver.Quit();
        }
    }
}
