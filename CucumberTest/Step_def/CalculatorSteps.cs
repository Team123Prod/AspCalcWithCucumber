using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CucumberTest.Step_def
{
    [Binding]
    public class MainSteps
    {

        private static IWebDriver driver;
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            driver = new ChromeDriver();
            driver.Url = @"http://localhost:63818/";
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            driver.Dispose();
        }

        [Given(@"I have opened calculator")]
        public void GivenIHaveOpenedCalculator()
        {
            driver.Url = @"http://localhost:63818/";
        }
        
        [When(@"I have entered (.*) into the calculator")]
        public void WhenIHaveEnteredIntoTheCalculator(int p0)
        {
            string id = "";
            switch (p0)
            {
                case 1:
                    id = "btn1";
                    break;
                case 2:
                    id = "btn2";
                    break;
                case 3:
                    id = "btn3";
                    break;
                case 4:
                    id = "btn4";
                    break;
                case 5:
                    id = "btn5";
                    break;
                case 6:
                    id = "btn6";
                    break;
                case 7:
                    id = "btn7";
                    break;
                case 8:
                    id = "btn8";
                    break;
                case 9:
                    id = "btn9";
                    break;
                case 0:
                    id = "btn0";
                    break;
            }
            driver.FindElement(By.Id(id)).Click();
        }
        
        [When(@"I press result button")]
        public void WhenIPressResultButton()
        {
            driver.FindElement(By.Id("btnGo")).Click();
        }
        
        [Then(@"The result field should be (.*)")]
        public void ThenTheResultFieldShouldBe(int p0)
        {
            Assert.AreEqual(driver.FindElement(By.Id("txtBox1")).GetAttribute("value"), p0.ToString());
        }
        
        [Then(@"The result field should be empty")]
        public void ThenTheResultFieldShouldBeEmpty()
        {
            Assert.AreEqual(driver.FindElement(By.Id("txtBox1")).GetAttribute("value"), "");
        }
        
        [Then(@"The result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.AreEqual(driver.FindElement(By.Id("txtBox1")).GetAttribute("value"), p0.ToString());
            driver.Navigate().Refresh();
        }

        [When(@"I press ""(.*)"" button")]
        public void WhenIPressButton(string p0)
        {
            string btn = "";
            switch (p0)
            {
                case "add":
                    btn = "btnPlus";
                    break;
                case "minus":
                    btn = "btnMinus";
                    break;
                case "multiply":
                    btn = "btnMultiply";
                    break;
                case "divide":
                    btn = "btnDiv";
                    break;
            }
            driver.FindElement(By.Id(btn)).Click();
        }
    }
}
