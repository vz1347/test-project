using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCsharpNetCore
{
    internal class CustomControll : DriverHelper
    {
        /// <summary>Enter Text ("Text")</summary>
        public static void EnterText(IWebElement webElement, string Value)
        {
            webElement.SendKeys(Value);
        }
        /// <summary>Click</summary>
        public static void ClickElement(IWebElement webElement)
        {
            webElement.Click();
        }
        public static void SelectByValue(IWebElement webElement, string Value)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByValue(Value);
        }
        public static void SelectByText(IWebElement webElement, string Text)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByText(Text);
        }
        /// <summary>Enter text in selected ID ("ID","Text")</summary>
        public static void SelectById_And_EnterText(string Value, string Text)
        {
            IWebElement FormID = Driver.FindElement(By.Id(Value));
            FormID.SendKeys(Text);
        }
        /// <summary>Click on button by XPath("XPath")</summary>
        public static void ButtonClick(string Value)
        {
            IWebElement FormSubmit = Driver.FindElement(By.XPath(Value));
            FormSubmit.Click();   
        }
        public static void ToggleSwitch(string Value)
        {
            IWebElement SwitchClick = Driver.FindElement(By.XPath($"//*[contains(., '{Value}')]"));
            SwitchClick.Click();
        }
    }
}