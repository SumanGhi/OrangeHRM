using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace Base
{
    [TestFixture]
    public class BaseSetup
    {
        private ITakesScreenshot ts;
        private Screenshot screenshot;
        [SetUp]
        public void Init()
        {
            IConfigurationRoot configRoot = new ConfigurationBuilder().AddJsonFile(TestContext.CurrentContext.TestDirectory + @"\AppSettings.json").Build();
            IConfigurationSection section = configRoot.GetSection("AppSettings");
            AppSettings.AdminUrl = section["AdminUrl"].ToString();
            AppSettings.TimeOut = Convert.ToInt32(section["TimeOut"]);

            BasePage.webDriver.Manage().Window.Maximize();
            BasePage.webDriver.Navigate().GoToUrl(AppSettings.AdminUrl);
        }

        [TearDown]
        public void AfterTest()
        {
            string nowTime = DateTime.Now.ToString();
            //Console.WriteLine(nowTime);
            try
            {
                TestStatus status = TestContext.CurrentContext.Result.Outcome.Status;
                string stacktrace = TestContext.CurrentContext.Result.StackTrace;
                string errorMessage = "<pre>" + TestContext.CurrentContext.Result.Message + "</pre>";
                if (status == TestStatus.Failed)
                {
                    ts = (ITakesScreenshot)BasePage.webDriver;
                    screenshot = ts.GetScreenshot();
                    string screenshotFile = Path.Combine(TestContext.CurrentContext.WorkDirectory, TestContext.CurrentContext.Test.Name + ".png");
                    screenshot.SaveAsFile(screenshotFile, ScreenshotImageFormat.Png);
                    TestContext.AddTestAttachment(screenshotFile, "scr");
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                if(TestContext.CurrentContext.Test.Name=="SearchVacancies")
                    BasePage.webDriver.Quit();
            }
        }

    }
}
