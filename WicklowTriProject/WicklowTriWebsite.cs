
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WicklowTriProject
{
    [TestClass]
    public class WicklowTriWebsite
    {
        static IWebDriver driverFF;
       

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            driverFF = new FirefoxDriver();

        }

        [TestMethod]
        public void TestWicklowTri()
        {
            driverFF.Navigate().GoToUrl("http://www.wicklowtri.com");
        }

        [TestMethod]
        public void ForumPages()
        {
            driverFF.Navigate().GoToUrl("http://www.wicklowtri.com/index.php/forum");
        }

        [TestMethod]
        public void WrongPasswordForumPages()
        {
            driverFF.FindElement(By.Name("username")).SendKeys("Stevenpetersmi");
            driverFF.FindElement(By.Name("password")).SendKeys("password");
            driverFF.FindElement(By.ClassName("kbutton")).SendKeys(Keys.Enter);

        }

        [TestMethod]
        public void CorrectPasswordForumPages()
        {
            driverFF.Navigate().GoToUrl("http://www.wicklowtri.com/index.php/forum");
            driverFF.FindElement(By.Name("username")).SendKeys("StevenAuto");
            driverFF.FindElement(By.Name("password")).SendKeys("autotestpassword");
            driverFF.FindElement(By.ClassName("kbutton")).SendKeys(Keys.Enter);

        }

        [TestMethod]
        public void logoutForumPages()
        {
            
            driverFF.FindElement(By.ClassName("kbutton")).SendKeys(Keys.Enter);


        }

        [TestMethod]
        public void Pages()
        {
            driverFF.Navigate().GoToUrl("http://www.wicklowtri.com/index.php/2015-04-07-20-42-40/news");
        }

        [TestMethod]
         public void refresh()
         {
             driverFF.Navigate().Refresh();
         }


        // [AssemblyCleanup]
        //  public static void ClosedWebSite()
        //  {
        //    driverFF.Quit();
        //   }
    }
}
