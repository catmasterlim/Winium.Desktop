namespace WpfTestApplication.Tests.CommandTests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Remote;

    #endregion

    [TestFixture]
    public class FindTests : BaseTest<RemoteWebDriver>
    {
        #region Public Properties

        public IWebElement MainWindow
        {
            get
            {
                var mainWindowStrategy = By.XPath("/*[@AutomationId='WpfTestApplicationMainWindow']");
                return this.Driver.FindElement(mainWindowStrategy);
            }
        }

        #endregion

        #region Public Methods and Operators

        [Test]
        public void FindChildElementByClassName()
        {
            var child = this.MainWindow.FindElement(By.ClassName("TextBox"));
            Assert.NotNull(child);
        }

        [Test]
        public void FindChildElementById()
        {
            var child = this.MainWindow.FindElement(By.Id("TextBox1"));
            Assert.NotNull(child);
        }

        [Test]
        public void FindChildElementByName()
        {
            var child = this.MainWindow.FindElement(By.Name("IsEnabledTextListBox"));
            Assert.NotNull(child);
        }

        [Test]
        public void FindElementByClassName()
        {
            var element = this.Driver.FindElement(By.ClassName("Window"));
            Assert.NotNull(element);
        }

        [Test]
        public void FindElementById()
        {
            var element = this.MainWindow;
            Assert.NotNull(element);
        }

        [Test]
        public void FindElementByName()
        {
            var element = this.Driver.FindElement(By.Name("MainWindow"));
            Assert.NotNull(element);
        }

        [Test]
        public void FindElements()
        {
            var comboBox = this.MainWindow.FindElement(By.Id("TextComboBox"));
            comboBox.Click();

            var elements = comboBox.FindElements(By.ClassName("ListBoxItem"));
            Assert.AreEqual(6, elements.Count);
        }

        [Test]
        public void FindNoElements()
        {
            var elements = this.MainWindow.FindElements(By.Id("UnexistId"));
            Assert.AreEqual(0, elements.Count);
        }

        #endregion
    }
}
