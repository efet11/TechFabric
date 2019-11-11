using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TechFabricSln.Test
{
    class SeleniumTest
    {
        [Test]
        [Category("UITests")]
        public void VisitMicrosoft_CheckWindowsMenu()
        {
            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            driver.Navigate().GoToUrl("https://www.microsoft.com/");

            Thread.Sleep(10000);

            string Windows_text = driver.FindElement(By.Id("shellmenu_1")).Text;
            Assert.AreEqual("Windows", Windows_text);
        }
    }
}
