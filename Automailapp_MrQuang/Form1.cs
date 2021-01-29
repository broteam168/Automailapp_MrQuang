using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automailapp_MrQuang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://facebook.com");
            IWebElement UserTextbox = driver.FindElement(By.Id("email"));
            UserTextbox.SendKeys("broteam168@gmail.com");
            Thread.Sleep(RandomNumber(500, 2000));
            IWebElement PassTextbox = driver.FindElement(By.Id("pass"));
            PassTextbox.SendKeys("broteamson");
            Thread.Sleep(RandomNumber(500, 2000));
            driver.FindElement(By.Name("login")).Click();

            //   ScrollToBottom(driver);

        }
        private readonly Random _random = new Random();

        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        private void ScrollToBottom(IWebDriver driver)
        {
            long scrollHeight = 0;

            do
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                var newScrollHeight = (long)js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight); return document.body.scrollHeight;");

                if (newScrollHeight == scrollHeight)
                {
                    break;
                }
                else
                {
                    scrollHeight = newScrollHeight;
                    Thread.Sleep(400);
                }
            } while (true);
        }
    }
}

