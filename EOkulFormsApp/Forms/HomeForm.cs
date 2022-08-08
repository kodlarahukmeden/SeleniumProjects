using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GithubFormsApp.Forms
{
    public partial class HomeForm : Form
    {
        private IWebDriver _driver;
        private readonly string url = "https://github.com";
        //.wb-break-all
        public HomeForm()
        {
            InitializeComponent();
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            _driver = new ChromeDriver(service);
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
            _driver.Navigate().GoToUrl(url + "/login");
            //var link = _driver.FindElement(By.XPath("/html/body/form/section[1]/div/div/a[2]"));
            //link.Click();
            if (_driver.Url == this.url + "/signup")
                MessageBox.Show("kayıt sayfası başarıyla yüklendi");

            urlListBox.Items.Add(_driver.Url);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
         
            //var securityCode = _driver.FindElement(By.XPath("/html/body/form/div[4]/div/div/div/div/div[2]/div[2]/div/input"));
            //var userName = _driver.FindElement(By.XPath("/html/body/form/div[4]/div/div/div/div/div[2]/div[3]/div/input"));
            //var password = _driver.FindElement(By.XPath("/html/body/form/div[4]/div/div/div/div/div[2]/div[4]/div/input"));
            //var loginButton = _driver.FindElement(By.XPath("/html/body/form/div[4]/div/div/div/div/div[2]/div[5]/div/div/button"));

            //securityCode.SendKeys(securityCodeTextBox.Text);
            //userName.SendKeys(userNameTextBox.Text);
            //password.SendKeys(userPasswordTextBox.Text);
            //loginButton.Click();

            //_driver.Quit();

            var userNameInput = _driver.FindElement(By.Id("login_field"));
            var passwordInput = _driver.FindElement(By.Id("password"));
            var signInButton = _driver.FindElement(By.XPath("/html/body/div[3]/main/div/div[4]/form/div/input[12]"));

            userNameInput.SendKeys(userNameTextBox.Text);
            passwordInput.SendKeys(userPasswordTextBox.Text);
            signInButton.Click();
            Thread.Sleep(2000);
            _driver.Navigate().GoToUrl(url +"/" + userNameTextBox.Text);

            urlListBox.Items.Add(_driver.Url);
        }

        private void GetRepositoriesButton_Click(object sender, EventArgs e)
        {
            var repositoriesLink =_driver.FindElement(By.XPath("//*[@id='js-pjax-container']/div[1]/div/div/div[2]/div/nav/a[2]"));
            repositoriesLink.Click();
            Thread.Sleep(3000);

            var respositories = _driver.FindElements(By.CssSelector(".wb-break-all"));

            foreach (var repositoryNames in respositories)
            {
                var link = repositoryNames.FindElement(By.TagName("a"));
                repositoriesTreeView.Nodes.Add(link.Text);
            }


        }

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            userPasswordTextBox.UseSystemPasswordChar = false;
            
        }
    }
}
