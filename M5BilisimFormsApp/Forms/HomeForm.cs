using M5BilisimFormsApp.Extensions;
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

namespace M5BilisimFormsApp.Forms
{
    public partial class HomeForm : Form
    {
        private IWebDriver _driver;
        private string Url => "https://www.m5bilisim.com/tr/on-parmak/hiz-testi/";
        public HomeForm()
        {
            InitializeComponent();
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            _driver = new ChromeDriver(service);
        }
            

        private void HomeForm_Load(object sender, EventArgs e)
        {
            _driver.Navigate().GoToUrl(Url);
            _driver.WaitForPageLoad(out string message);           
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var inputWord = _driver.FindElement(By.XPath("/html/body/div[4]/div[5]/div[2]/input"));
            var wordList = _driver.FindElement(By.Id("satir"));
            var words = wordList.FindElements(By.TagName("span"));
            inputWord.Click();
            while (true)
            {
                var remainingTime = _driver.FindElement(By.Id("zaman"));
                remainingTimeLabel.Text = remainingTime.Text;
                foreach (var word in words)
                {
                    inputWord.SendKeys(word.Text);
                    inputWord.SendKeys(OpenQA.Selenium.Keys.Space);
                }
            }
            
        }


    }
}
