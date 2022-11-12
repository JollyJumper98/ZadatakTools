using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

            IWebElement name = driver.FindElement(By.Id("firstName"));
            name.SendKeys("Dusan");

            IWebElement lastName = driver.FindElement(By.Id("lastName"));
            lastName.SendKeys("Dobric");

            IWebElement email = driver.FindElement(By.Id("userEmail"));
            email.SendKeys("tinpudimirvla@gmail.com");

            IWebElement mobile = driver.FindElement(By.Id("userNumber"));
            mobile.SendKeys("3816055555");

            IWebElement birth = driver.FindElement(By.Id("dateOfBirthInput"));
            birth.Submit();

            //IWebElement subjects = driver.FindElement(By.Id("subjectsContainer"));
            //subjects.SendKeys("Programiranje");

            IWebElement address = driver.FindElement(By.Id("currentAddress"));
            address.SendKeys("Beograd");

            driver.Quit();

           




                
        }
    }
}
