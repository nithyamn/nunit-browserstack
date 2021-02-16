using NUnit.Framework;
using OpenQA.Selenium;
using System.Text.RegularExpressions;

namespace BrowserStack
{
  [TestFixture("local", "chrome")]
  public class LocalTest : BrowserStackNUnitTest
  {
    public LocalTest(string profile, string environment) : base(profile, environment) { }

    [Test]
    public void HealthCheck()
    {
      driver.Navigate().GoToUrl("http://bs-local.com:45691/check");
      //Assert.IsTrue(Regex.IsMatch(driver.PageSource, "Up and running", RegexOptions.IgnoreCase));
      /*if (Regex.IsMatch(driver.PageSource, "Up and running", RegexOptions.IgnoreCase))
      {
          ((IJavaScriptExecutor)driver).ExecuteScript("browserstack_executor: {\"action\": \"setSessionStatus\", \"arguments\": {\"status\":\"passed\", \"reason\": \"Expected\"}}");

      }
      else
      {
          ((IJavaScriptExecutor)driver).ExecuteScript("browserstack_executor: {\"action\": \"setSessionStatus\", \"arguments\": {\"status\":\"failed\", \"reason\": \"Unexpected\"}}");
      }*/
    }
  }
}
