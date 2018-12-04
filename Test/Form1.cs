using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;


namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        ChromeDriver Chrome;
        InternetExplorerDriver IEDriever;
        

        private void button1_Click(object sender, EventArgs e)
        {
            Chrome = new ChromeDriver();
            Chrome.Navigate().GoToUrl("http://ibitsa.tech/");
            IWebElement input = Chrome.FindElement(By.Id("txtMail"));
            IWebElement inputPassword = Chrome.FindElement(By.Id("txtPassword"));
            IWebElement submitAuth = Chrome.FindElement(By.Name("signIn"));
           
            

            System.Threading.Thread.Sleep(1000);
            input.SendKeys("plad@mail.ru");
            System.Threading.Thread.Sleep(1000);
            inputPassword.SendKeys("678908asd");
            System.Threading.Thread.Sleep(1000);
            submitAuth.Click();
            System.Threading.Thread.Sleep(1000);
            IWebElement btnOut = Chrome.FindElement(By.Id("btnSignOut"));
            btnOut.Click();
            Chrome.Quit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chrome = new ChromeDriver();
            Chrome.Navigate().GoToUrl("http://ibitsa.tech/");
            IWebElement inputRegName = Chrome.FindElement(By.Id("first_name"));
            IWebElement inputRegLastName = Chrome.FindElement(By.Id("last_name"));
            IWebElement inputRegMailBox = Chrome.FindElement(By.Id("txtNewMail"));
            IWebElement inputRegPassword = Chrome.FindElement(By.Id("txtNewPassword"));
            IWebElement inputRegGender = Chrome.FindElement(By.Id("rdnMale"));
            IWebElement inputBirthDay = Chrome.FindElement(By.Id("chkDay"));
            IWebElement inputBirthMonth = Chrome.FindElement(By.Id("chkMonth"));
            IWebElement inputBirthYear = Chrome.FindElement(By.Id("chkYear"));
            IWebElement inputBtnReg = Chrome.FindElement(By.Name("signUp"));

            var builder = new StringBuilder();
            var builderPassword = new StringBuilder();
            var builderName = new StringBuilder();
            var builderLastName = new StringBuilder();
            var random = new Random();
            var length = random.Next(6, 10); // Максимальная случайная длина последовательности.
            for (var i = 0; i < length; i++)
            {
                builderName.Append((char)random.Next('а', 'я' + 1));
                builderLastName.Append((char)random.Next('а', 'я' + 1));
                builder.Append((char)random.Next('a', 'z' + 1)); // Случайная последовательность символов от A до Z.
                builderPassword.Append((char)random.Next('a', 'z' + 1));
                
            }

            System.Threading.Thread.Sleep(1000);
            inputRegName.SendKeys(builderName.ToString());
            System.Threading.Thread.Sleep(1000);
            inputRegLastName.SendKeys(builderLastName.ToString());
            System.Threading.Thread.Sleep(1000);
            inputRegMailBox.SendKeys(builder.ToString() + "@mail.ru");
            System.Threading.Thread.Sleep(1000);
            inputRegPassword.SendKeys(builderPassword.ToString());
            System.Threading.Thread.Sleep(1000);
            inputRegGender.Click();
            System.Threading.Thread.Sleep(1000);
            
            inputBirthDay.Click();
            for (int i = 0; i < 12; i++)
            {
                inputBirthDay.SendKeys(OpenQA.Selenium.Keys.Down);
            }
            inputBirthDay.SendKeys(OpenQA.Selenium.Keys.Enter);
            System.Threading.Thread.Sleep(1000);

            inputBirthMonth.Click();
            for (int i = 0; i < 9; i++)
            {
                inputBirthMonth.SendKeys(OpenQA.Selenium.Keys.Down);
            }
            inputBirthMonth.SendKeys(OpenQA.Selenium.Keys.Enter);
            System.Threading.Thread.Sleep(1000);

            inputBirthYear.Click();
            for (int i = 0; i < 22; i++)
            {
                inputBirthYear.SendKeys(OpenQA.Selenium.Keys.Down);
            }
            inputBirthYear.SendKeys(OpenQA.Selenium.Keys.Enter);
            System.Threading.Thread.Sleep(1000);

            inputBtnReg.Click();

            System.Threading.Thread.Sleep(3000);

            Chrome.Quit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chrome = new ChromeDriver();
            Chrome.Navigate().GoToUrl("http://ibitsa.tech/");
            IWebElement input = Chrome.FindElement(By.Id("txtMail"));
            IWebElement inputPassword = Chrome.FindElement(By.Id("txtPassword"));
            IWebElement submitAuth = Chrome.FindElement(By.Name("signIn"));



            System.Threading.Thread.Sleep(1000);
            input.SendKeys("plad@mail.ru");
            System.Threading.Thread.Sleep(1000);
            inputPassword.SendKeys("678908");
            System.Threading.Thread.Sleep(1000);
            submitAuth.Click();
            System.Threading.Thread.Sleep(3000);
            Chrome.Quit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Chrome = new ChromeDriver();
            Chrome.Navigate().GoToUrl("http://ibitsa.tech/");
            IWebElement inputRegName = Chrome.FindElement(By.Id("first_name"));
            IWebElement inputRegLastName = Chrome.FindElement(By.Id("last_name"));
            IWebElement inputRegMailBox = Chrome.FindElement(By.Id("txtNewMail"));
            IWebElement inputRegPassword = Chrome.FindElement(By.Id("txtNewPassword"));
            IWebElement inputRegGender = Chrome.FindElement(By.Id("rdnMale"));
            IWebElement inputBirthDay = Chrome.FindElement(By.Id("chkDay"));
            IWebElement inputBirthMonth = Chrome.FindElement(By.Id("chkMonth"));
            IWebElement inputBirthYear = Chrome.FindElement(By.Id("chkYear"));
            IWebElement inputBtnReg = Chrome.FindElement(By.Name("signUp"));

            var builder = new StringBuilder();
            var builderPassword = new StringBuilder();
            var builderName = new StringBuilder();
            var builderLastName = new StringBuilder();
            var random = new Random();
            var length = random.Next(6, 10); // Максимальная случайная длина последовательности.
            for (var i = 0; i < length; i++)
            {
                builderName.Append((char)random.Next('а', 'я' + 1));
                builderLastName.Append((char)random.Next('а', 'я' + 1));
                builder.Append((char)random.Next('a', 'z' + 1)); // Случайная последовательность символов от A до Z.
                builderPassword.Append((char)random.Next('a', 'z' + 1));

            }

            System.Threading.Thread.Sleep(1000);
            inputRegName.SendKeys(builderName.ToString());
            System.Threading.Thread.Sleep(1000);
            inputRegLastName.SendKeys(builderLastName.ToString());
            System.Threading.Thread.Sleep(1000);
            inputRegMailBox.SendKeys(builder.ToString());
            System.Threading.Thread.Sleep(1000);
            inputRegPassword.SendKeys(builderPassword.ToString());
            System.Threading.Thread.Sleep(1000);
            inputRegGender.Click();
            System.Threading.Thread.Sleep(1000);

            inputBirthDay.Click();
            for (int i = 0; i < 12; i++)
            {
                inputBirthDay.SendKeys(OpenQA.Selenium.Keys.Down);
            }
            inputBirthDay.SendKeys(OpenQA.Selenium.Keys.Enter);
            System.Threading.Thread.Sleep(1000);

            inputBirthMonth.Click();
            for (int i = 0; i < 9; i++)
            {
                inputBirthMonth.SendKeys(OpenQA.Selenium.Keys.Down);
            }
            inputBirthMonth.SendKeys(OpenQA.Selenium.Keys.Enter);
            System.Threading.Thread.Sleep(1000);

            inputBirthYear.Click();
            for (int i = 0; i < 22; i++)
            {
                inputBirthYear.SendKeys(OpenQA.Selenium.Keys.Down);
            }
            inputBirthYear.SendKeys(OpenQA.Selenium.Keys.Enter);
            System.Threading.Thread.Sleep(1000);

            inputBtnReg.Click();

            System.Threading.Thread.Sleep(3000);

            Chrome.Quit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Chrome = new ChromeDriver();
            Chrome.Navigate().GoToUrl("http://ibitsa.tech/");
            IWebElement input = Chrome.FindElement(By.Id("txtMail"));
            IWebElement inputPassword = Chrome.FindElement(By.Id("txtPassword"));
            IWebElement submitAuth = Chrome.FindElement(By.Name("signIn"));
            



            System.Threading.Thread.Sleep(1000);
            input.SendKeys("plad@mail.ru");
            System.Threading.Thread.Sleep(1000);
            inputPassword.SendKeys("678908asd");
            System.Threading.Thread.Sleep(1000);
            submitAuth.Click();
            System.Threading.Thread.Sleep(1000);
            IWebElement friends = Chrome.FindElement(By.XPath("/html/body/div[1]/div[1]/div[3]/div/div"));
            friends.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement chooseFriend = Chrome.FindElement(By.XPath("//*[@id='3']"));
            chooseFriend.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement textMessage = Chrome.FindElement(By.Id("me"));
            textMessage.SendKeys("Привет");
            System.Threading.Thread.Sleep(1000);
            IWebElement sendMessage = Chrome.FindElement(By.XPath("/html/body/div[1]/div[3]/form/input"));
            sendMessage.Click();
            System.Threading.Thread.Sleep(3000);
            IWebElement btnOut = Chrome.FindElement(By.Id("btnSignOut"));
            btnOut.Click();
            Chrome.Quit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Chrome = new ChromeDriver();
            Chrome.Navigate().GoToUrl("http://ibitsa.tech/");
            IWebElement input = Chrome.FindElement(By.Id("txtMail"));
            IWebElement inputPassword = Chrome.FindElement(By.Id("txtPassword"));
            IWebElement submitAuth = Chrome.FindElement(By.Name("signIn"));



            System.Threading.Thread.Sleep(1000);
            input.SendKeys("plad@mail.ru");
            System.Threading.Thread.Sleep(1000);
            inputPassword.SendKeys("678908asd");
            System.Threading.Thread.Sleep(1000);
            submitAuth.Click();
            System.Threading.Thread.Sleep(1000);

            var builderNotifName = new StringBuilder();
            var builderNotifText = new StringBuilder();
            var random = new Random();
            var length = random.Next(6, 10); // Максимальная случайная длина последовательности.
            for (var i = 0; i < length; i++)
            {
                builderNotifName.Append((char)random.Next('а', 'я' + 1));
                builderNotifText.Append((char)random.Next('а', 'я' + 1));
            }

            IWebElement btnNotif = Chrome.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/div/a"));
            btnNotif.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement btnAddNotif = Chrome.FindElement(By.Id("btnAddNote"));
            btnAddNotif.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement nameNotif = Chrome.FindElement(By.XPath("//*[@id='txtName']"));
            nameNotif.SendKeys(builderNotifName.ToString());
            System.Threading.Thread.Sleep(1000);

            IWebElement textNotif = Chrome.FindElement(By.XPath("//*[@id='txtText']"));
            textNotif.SendKeys(builderNotifText.ToString());
            System.Threading.Thread.Sleep(1000);

            IWebElement btnWriteNotif = Chrome.FindElement(By.XPath("//*[@id='btnSend']"));
            btnWriteNotif.Click();
            System.Threading.Thread.Sleep(3000);

            IWebElement btnOut = Chrome.FindElement(By.Id("btnSignOut"));
            btnOut.Click();
            Chrome.Quit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Chrome = new ChromeDriver();
            Chrome.Navigate().GoToUrl("http://ibitsa.tech/school.php");

            IWebElement btnUpload = Chrome.FindElement(By.Name("upload"));
            btnUpload.SendKeys("C:\\Users\\Vlad\\Desktop\\I-no_GGXrd_Portrait.png");
            System.Threading.Thread.Sleep(2000);

            IWebElement btnUploadFile = Chrome.FindElement(By.XPath("/html/body/form/input[2]"));
            btnUploadFile.Click();
           

            System.Threading.Thread.Sleep(3000);
            Chrome.Quit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Chrome = new ChromeDriver();
            Chrome.Navigate().GoToUrl("http://ibitsa.tech/school.php");

            IWebElement btnUpload = Chrome.FindElement(By.Name("upload"));
            btnUpload.SendKeys("C:\\Users\\Vlad\\Desktop\\01_pantera_cowboys_from_hell_myzuka.fm.mp3");
            System.Threading.Thread.Sleep(2000);

            IWebElement btnUploadFile = Chrome.FindElement(By.XPath("/html/body/form/input[2]"));
            btnUploadFile.Click();


            System.Threading.Thread.Sleep(3000);
            Chrome.Quit();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
