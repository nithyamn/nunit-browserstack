using NUnit.Framework;
using OpenQA.Selenium;

namespace BrowserStack
{
  [TestFixture("parallel", "chrome")]
  [TestFixture("parallel", "edge")]
  [TestFixture("parallel", "safari")]
  [TestFixture("parallel", "samsung")]
  [TestFixture("parallel", "iphone")]
  [Parallelizable(ParallelScope.Fixtures)]
  public class ParallelTest : SingleTest
  {
    public ParallelTest(string profile, string environment) : base(profile, environment) { }
  }
}
