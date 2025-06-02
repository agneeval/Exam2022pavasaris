using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IWebDriver driver;
        public Form1()
        {
            InitializeComponent();

            //pielikta
            var options = new ChromeOptions();
            options.AddExcludedArgument("enable-logging");

            // Diver lokacijas maina	
            driver = new ChromeDriver(@"C:\Users\Leman\OneDrive\Documents\Cplus fili\chromedriver-win64\chromedriver-win64\");
            driver.Url = "https://www.ebay.com";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //vecais string textBox1.TextKey = textBox1.Text;

            IWebElement element = driver.FindElement(By.Id("gh-ac"));
            textBox2.Text = textBox1.Text;
            element.SendKeys(textBox1.Text);

            IWebElement Serachbutton = driver.FindElement(By.Id("gh-btn"));
            Searchbutton.Click();

            await Task.Delay(500);
            string currentUrl = driver.Url;
            textBox2.Text = driver.Url;
            //vecais richTextBox1.AppendText(textBox2.Text);
            richTextBox1.AppendText(currentUrl + Environment.NewLine);
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void richTextBox1_TextChanged(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)

        {
            driver.Navigate().Back();

            // Iztīra laukus
            textBox2.Text = "";
            richTextBox1.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            driver.Navigate().Back();
            //sos varbūt nevajag?!
            textBox1.Clear();
            textBox2.Clear();
        }

        //poga close aizver visus logus
        private void button2_Click(object sender, EventArgs e)
        {
            driver.Quit();
        }
}
