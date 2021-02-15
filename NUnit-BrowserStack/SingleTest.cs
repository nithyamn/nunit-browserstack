using NUnit.Framework;
using OpenQA.Selenium;

namespace BrowserStack
{
  [TestFixture("single", "chrome")]
  public class SingleTest : BrowserStackNUnitTest
  {
    public SingleTest(string profile, string environment) : base(profile, environment) { }

    [Test]
    public void SearchGoogle()
    {
      driver.Navigate().GoToUrl("https://www.google.com/ncr");
      IWebElement query = driver.FindElement(By.Name("q"));
      query.SendKeys("BrowserStack");
      query.Submit();
      System.Threading.Thread.Sleep(5000);
      Assert.AreEqual("BrowserStack - Google Search", driver.Title);
      if (driver.Title.Equals("BrowserStack - Google Search"))
      {
          ((IJavaScriptExecutor)driver).ExecuteScript("browserstack_executor: {\"action\": \"setSessionStatus\", \"arguments\": {\"status\":\"passed\", \"reason\": \"Expected\"}}");

      }
      else
      {
          ((IJavaScriptExecutor)driver).ExecuteScript("browserstack_executor: {\"action\": \"setSessionStatus\", \"arguments\": {\"status\":\"failed\", \"reason\": \"Unexpected\"}}");
      }
    }
  }
}
