using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Base
{
    public class BasePage
    {
        public static IWebDriver _webDriver;
        public static IWebDriver webDriver
        {
            get
            {
                if (_webDriver == null)
                {
                    ChromeOptions options = new();
                    //options.AddArguments("headless");
                    _webDriver = new ChromeDriver(options);
                }
                return _webDriver;
            }
        }
        public WebDriverWait waitElement;
        public BasePage()
        {
            //webDriver = driver;
            waitElement = new WebDriverWait(webDriver, TimeSpan.FromSeconds(AppSettings.TimeOut));
        }
        public IWebElement WaitUntilElementIsVisible(string Identifier)
        {
            Thread.Sleep(2000);
            return waitElement.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Identifier)));
        }
        // This can be used to fill the form 
        public void Add(List<IWebElement> inputElements, List<string> inputValues)
        {
            for (int i = 0; i < inputElements.Count; i++)
            {
                Thread.Sleep(1000);
                inputElements[i].SendKeys(inputValues[i]);
            }
        }
    }
}
