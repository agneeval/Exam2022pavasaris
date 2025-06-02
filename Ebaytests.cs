using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestFixture]
    public class UITests
    {
        private IWebDriver driver;

        [SetUp] // jaizpilda,pirms katra testa
        public void Setup()
        {
            var options = new ChromeOptions();
            driver = new ChromeDriver(@"C:\Users\Leman\OneDrive\Documents\Cplus fili\chromedriver-win64\chromedriver-win64\", options); // inicialize chrome draiveri
            driver.Navigate().GoToUrl("https://www.ebay.com");
        }

        [Test] //
        public void Test1_field()
        {
            var searchField = driver.FindElement(By.Id("gh-ac")); 
            if (searchField != null)
            {
                Console.WriteLine("Elements ar ID 'gh-ac' atrasts."); 
            }
        }

        [Test]
        public void Test2_search()
        {
            var searchButton = driver.FindElement(By.Id("gh-btn"));
            if (searchButton != null)
            {
                Console.WriteLine("Elements ar ID 'gh-btn' atrasts."); 
            }
        }

        [TearDown] 
        public void Teardown()
        {
            driver.Quit(); // aizver chrome
        }
    }
}
