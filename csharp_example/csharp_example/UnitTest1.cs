 using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;

namespace csharp_example
{
    [TestClass]
    public class FirstTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void start()
        {
            driver = new InternetExplorerDriver("C:/Tools/"); // объект драйвера, с которым взаимодействуем далее, вызывая driver
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Test]
        public void CSS_test_with_mountains()
        {
             driver.Url = "https://www.pexels.com/";
             Actions actions = new Actions(driver);
             IWebElement search = driver.FindElement(By.CssSelector("input[placeholder='Search for free photos and videos']")); // поиск по абсолютному пути
             search.SendKeys("mountains");
             driver.FindElement(By.CssSelector("button#search-action.rd__button")).Click(); // поиск по классу
             driver.FindElement(By.CssSelector("article[data-meta-title='Silhouette Of Mountains · Free Stock Photo']")).Click(); // поиск конкретного эл-та по уникальному атрибуту
             IWebElement dropdown = driver.FindElement(By.CssSelector("div[class='rd__dropdown rd__dropdown--right']")); //задаём элемент drop
             actions.MoveToElement(dropdown).Build().Perform(); //наведение на элемент dropdown
             driver.FindElement(By.CssSelector("input[value='640x411']")).Click();
             driver.FindElement(By.CssSelector("button[class='js-download-custom-size-submit rd__button rd__button--full-width']")).Click();
             Thread.Sleep(10000); 
        }

        [Test]
        public void Test2()
        {
            driver.Url = "https://www.pexels.com/";
            Actions actions = new Actions(driver);
            IWebElement search = driver.FindElement(By.CssSelector("html body header section div form div input")); // поиск по абсолютному пути
            search.SendKeys("mountains");
            driver.FindElement(By.CssSelector("button#search-action.rd__button")).Click(); // поиск по классу
            driver.FindElement(By.CssSelector("article[data-meta-title='Silhouette Of Mountains · Free Stock Photo']")).Click(); // поиск конкретного эл-та по уникальному атрибуту
            IWebElement dropdown = driver.FindElement(By.CssSelector("div[class='rd__dropdown rd__dropdown--right']")); //задаём элемент drop
            actions.MoveToElement(dropdown).Build().Perform(); //наведение на элемент dropdown
            driver.FindElement(By.CssSelector("input[value='640x411']")).Click();
            driver.FindElement(By.CssSelector("button[class='js-download-custom-size-submit rd__button rd__button--full-width']")).Click();
            Thread.Sleep(10000);
            
        }

        [TearDown]
        public void stop()
        {
            driver.Quit();
            driver = null;
        }        
    }


    /* Свалка
     * 
            driver.FindElement().SendKeys(Keys.ArrowDown);
     **/
}

/* Свалка
 * 
            IWebElement test1 = driver.FindElement(By.XPath(".//*"));
            driver.FindElement().SendKeys(Keys.ArrowDown);
            test1.SendKeys(Keys.);
            test1.SendKeys(Keys.ArrowDown);
            test1.SendKeys(Keys.ArrowDown);
            test1.SendKeys(Keys.Enter);
            driver.FindElement(By.ClassName("HF9Klc ZYMsjf")).Click();
            driver.FindElement(By.Name("btnG")).Click();
            wait.Until(ExpectedConditions.TitleIs("webdriver - Поиск в Google")); 


 *
 * */
