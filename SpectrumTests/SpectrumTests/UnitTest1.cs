using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumCsharpNetCore
{
    public class SpectrrumTests : DriverHelper
    {

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--disable-blink-features=AutomationControlled");
            chromeOptions.AddArguments("--start-maximized");
            

            Driver = new ChromeDriver(@"C:\Users\VZ\Desktop\SeleniumNetCore", chromeOptions);

            Driver.Navigate().GoToUrl("https://official.spectrum.com/");
            

        }
        [Test]
        public void Test1()
        {
            CustomControll.SelectById_And_EnterText("form_street", "5415 maple ave");
            CustomControll.SelectById_And_EnterText("form_unit", "271");
            CustomControll.SelectById_And_EnterText("form_zip", "75235");
            CustomControll.ButtonClick("/html/body/header/form/div[1]/div[2]/div[3]/button");

            //CustomControll.ButtonClick("/html/body/div[1]/div[4]/div[1]/div/div[1]/div/div[1]/div/div[1]/div[2]/div/div[1]/div[6]/div[1]/div[1]/div[2]/div/div[1]/div");
            //CustomControll.SelectByText(Driver.FindElement(By.ClassName("card--header--toggle-switch--indicator ")), "TV");
            Thread.Sleep(20000);
            Driver.FindElement(By.XPath("//div[@class='featured-offer-filters-item '][2]")).Click();

            //Driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/div/div[1]/div/div[1]/div/div[1]/div[2]/div/div[1]/div[6]/div[1]/div[1]/div[2]/div/div[1]")).Click();
            Assert.Pass();
        }
    }
}