using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Feniks_SeleniumTest
{
    [TestClass]
    public class ChromeDriverTest
    {
        // In order to run the below test(s), 
        // please follow the instructions from http://go.microsoft.com/fwlink/?LinkId=619687
        // to install Microsoft WebDriver.

        private ChromeDriver Driver;
        private string URL = "https://localhost:44313/";

        [TestInitialize]
        public void ChromeDriverInitialize()
        {
            var binaryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Driver = new ChromeDriver(binaryPath);
        }

        [TestMethod]
        public void VerifyPageTitle()
        {
            // Replace with your own test logic
            Driver.Url = "https://www.google.com";
            Assert.AreEqual("Google", Driver.Title);
        }

        [TestMethod]
        public void TestLogin()
        {
            Driver.Navigate().GoToUrl(URL + "Login");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.FindElementById("UserName").SendKeys("rok.tkalcic@student.um.si");
            Driver.FindElementById("Password").SendKeys("Admin123?");

            Driver.FindElementByCssSelector("button.btn.btn-outline-primary").Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Assert.IsTrue(Driver.PageSource.Contains("rok.tkalcic@student.um.si"));
        }

        [TestMethod]
        public void TestRegistration()
        {
            Driver.Navigate().GoToUrl(URL + "Registracija");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Driver.FindElementById("Ime").SendKeys("Karen");
            Driver.FindElementById("Priimek").SendKeys("Erdelji");
            Driver.FindElementById("datepicker").Clear();
            var js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("document.getElementById('datepicker').value='10/7/2000'");
            Driver.FindElementById("EMSO").SendKeys("1106999500176");
            Driver.FindElementByClassName("amount").SendKeys("20");
            Driver.FindElementById("Naslov").SendKeys("Koroška 108");
            Driver.FindElementByName("PostnaStevilka").SendKeys("2000");
            Driver.FindElementById("Posta").SendKeys("Maribor");
            Driver.FindElementById("Drzava").SendKeys("SVN");
            Driver.FindElementById("EPosta").SendKeys("karen.erdelji@gmail.com");
            Driver.FindElementById("Geslo").SendKeys("Dexter123?");
            Driver.FindElementById("PonovnoGeslo").SendKeys("Dexter123?");

            Driver.FindElementByCssSelector("input.btn.btn-outline-primary").Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Driver.Navigate().GoToUrl(URL + "Clan");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Assert.IsTrue(Driver.PageSource.Contains("Karen Erdelji"));
        }

        [TestMethod]
        public void TestCart()
        {
            Driver.Navigate().GoToUrl(URL + "Login");
            Driver.FindElementById("UserName").SendKeys("rok.tkalcic@student.um.si");
            Driver.FindElementById("Password").SendKeys("Admin123?");

            Driver.FindElementByCssSelector("button.btn.btn-outline-primary").Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl(URL + "Film");

            Driver.FindElementByClassName("text-success").Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.FindElementByCssSelector("a.btn.btn-outline-success").Click();

            Assert.IsFalse(Driver.PageSource.Contains("V košarici ni izdelkov"));
        }


        [TestMethod]
        public void TestDeleteUser()
        {
            Driver.Navigate().GoToUrl(URL + "Login");
            Driver.FindElementById("UserName").SendKeys("rok.tkalcic@student.um.si");
            Driver.FindElementById("Password").SendKeys("Admin123?");

            Driver.Navigate().GoToUrl(URL + "Clan");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Driver.FindElementByClassName("text-primary").Click();
            var text = Driver.FindElementByCssSelector("h1:nth-child(1)").GetAttribute("value");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Driver.FindElementByCssSelector("a.btn.btn-outline-danger").Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Assert.IsFalse(Driver.PageSource.Contains("Karen Erdelji"));
        }

        [TestCleanup]
        public void EdgeDriverCleanup()
        {
            Driver.Quit();
        }
    }
}
