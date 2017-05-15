using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace SeleniumTests
{
    [TestFixture]
    public class WicklowTrIProject
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://www.wicklowtri.com/index.php";
            verificationErrors = new StringBuilder();
        }
        
        
        [Test]
        public void TheWicklowTrIProjectTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/index.php");
            driver.FindElement(By.XPath("(//a[contains(text(),'Home')])[2]")).Click();
            driver.FindElement(By.CssSelector("a..dropdown-toggle")).Click();
            driver.FindElement(By.CssSelector("ul.mega-nav.level1 > li > a")).Click();
            driver.FindElement(By.CssSelector("a..dropdown-toggle")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Committee & Coaches')])[2]")).Click();
            driver.FindElement(By.CssSelector("a..dropdown-toggle")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Club Training Sessions')])[2]")).Click();
            driver.FindElement(By.CssSelector("a..dropdown-toggle")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Contact')])[3]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Events')])[2]")).Click();
            driver.FindElement(By.CssSelector("div.ca-evp29.te")).Click();
            driver.FindElement(By.CssSelector("div.ca-evp43.te > span.te-s")).Click();
            driver.FindElement(By.CssSelector("div.ca-evp49.te > span.te-s")).Click();
            driver.FindElement(By.Id("bubbleClose:1")).Click();
            driver.FindElement(By.XPath("//header[@id='t3-mainnav']/div/nav[2]/div/ul/li[3]/a/em")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Base2Race Harbourman Triathlon')])[2]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Media')])[2]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'News')])[3]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Members')])[3]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Search')])[2]")).Click();
            driver.FindElement(By.Id("search-searchword")).Clear();
            driver.FindElement(By.Id("search-searchword")).SendKeys("Cork");
            driver.FindElement(By.Name("Search")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Training')])[14]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Members')])[3]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Forum')])[16]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Members')])[3]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'WTC Ironman')])[2]")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
