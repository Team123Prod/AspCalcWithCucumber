using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;



namespace UITests
{
    [TestFixture(typeof(ChromeDriver))]


    public class TestWithMultipleBrowsers<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        private IWebDriver driver = new TWebDriver();
        [SetUp]
        public void CreateDriver()
        {
            driver.Url = @"http://localhost:63818/";
        }
        [OneTimeTearDown]

        public void Cleanup()
        {
            driver.Dispose();
        }
        [Test]
        [Category("IsElementExists")]
        [TestCase("btn1", TestName = "IsElementExists_1")]
        [TestCase("btn2", TestName = "IsElementExists_2")]
        [TestCase("btn3", TestName = "IsElementExists_3")]
        [TestCase("btn4", TestName = "IsElementExists_4")]
        [TestCase("btn5", TestName = "IsElementExists_5")]
        [TestCase("btn6", TestName = "IsElementExists_6")]
        [TestCase("btn7", TestName = "IsElementExists_7")]
        [TestCase("btn8", TestName = "IsElementExists_8")]
        [TestCase("btn9", TestName = "IsElementExists_9")]
        [TestCase("btn0", TestName = "IsElementExists_0")]
        [TestCase("btnMinus", TestName = "IsElementExists_10")]
        [TestCase("btnPlus", TestName = "IsElementExists_11")]
        [TestCase("btnMultiply", TestName = "IsElementExists_12")]
        [TestCase("btnDiv", TestName = "IsElementExists_13")]
        [TestCase("btnGo", TestName = "IsElementExists_14")]
        [TestCase("txtBox1", TestName = "IsElementExists_15")]
        public void IsElementExists(string a)
        {
            Assert.AreEqual(driver.FindElement(By.Id(a)).Displayed, true);
            driver.Navigate().Refresh();
        }

        [Test]
        [Category("SimpleCheck")]
        [TestCase("btn1", "1", TestName = "SimpleCheck_1")]
        [TestCase("btn2", "2", TestName = "SimpleCheck_2")]
        [TestCase("btn3", "3", TestName = "SimpleCheck_3")]
        [TestCase("btn4", "4", TestName = "SimpleCheck_4")]
        [TestCase("btn5", "5", TestName = "SimpleCheck_5")]
        [TestCase("btn6", "6", TestName = "SimpleCheck_6")]
        [TestCase("btn7", "7", TestName = "SimpleCheck_7")]
        [TestCase("btn8", "8", TestName = "SimpleCheck_8")]
        [TestCase("btn9", "9", TestName = "SimpleCheck_9")]
        [TestCase("btn0", "0", TestName = "SimpleCheck_10")]

        public void SimpleCheck(string a, string b)
        {
            driver.FindElement(By.Id(a)).Click();
            Assert.AreEqual(driver.FindElement(By.Id("txtBox1")).GetAttribute("value"), b);
            driver.Navigate().Refresh();
        }

        [Test]
        [Category("ComplexCheck")]
        [TestCase(new string[] { "btn7", "btn7", "btn7" }, "777", TestName = "ComplexCheck_1")]
        [TestCase(new string[] { "btn7", "btn8", "btn8" }, "788", TestName = "ComplexCheck_2")]
        [TestCase(new string[] { "btn7", "btn7", "btn8", "btn5" }, "7785", TestName = "ComplexCheck_3")]
        [TestCase(new string[] { "btn5", "btn1", "btn0", "btn1", "btn0" }, "51010", TestName = "ComplexCheck_4")]

        public void ComplexCheck(string[] a, string b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                driver.FindElement(By.Id(a[i])).Click();
            }
            Assert.AreEqual(b, driver.FindElement(By.Id("txtBox1")).GetAttribute("value"));
            driver.Navigate().Refresh();
        }

        [Test]
        [Category("RealJob")]
        [TestCase(new string[] { "btn5", "btnMultiply", "btn3", "btnGo" }, "15", TestName = "RealJob_1")]
        [TestCase(new string[] { "btn6", "btnDiv", "btn3", "btnGo" }, "2", TestName = "RealJob_2")]
        [TestCase(new string[] { "btn5", "btnPlus", "btn3", "btnGo" }, "8", TestName = "RealJob_3")]
        [TestCase(new string[] { "btn5", "btnMinus", "btn3", "btnGo" }, "2", TestName = "RealJob_4")]
        public void RealJob(string[] a, string b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                driver.FindElement(By.Id(a[i])).Click();
            }
            Assert.AreEqual(driver.FindElement(By.Id("txtBox1")).GetAttribute("value"), b);
            driver.Navigate().Refresh();
        }
    }
}