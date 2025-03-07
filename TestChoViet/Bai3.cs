using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChoViet
{
    [TestClass]
    public class Bai3
    {
        [TestMethod]
        public void DangKy()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://vitimex.com.vn/");
            Thread.Sleep(1000);
            driver.Navigate().GoToUrl("https://vitimex.com.vn/dang-ky.html");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"name\"]")).SendKeys("PhamVietManh");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"phone\"]")).SendKeys("0848277707");
            Thread.Sleep(1000); 
            driver.FindElement(By.XPath("//*[@id=\"pass-regis\"]")).SendKeys("PhamVietManh1#");
            Thread.Sleep(1000); 
            driver.FindElement(By.XPath("//*[@id=\"pass-confirm\"]")).SendKeys("PhamVietManh1#");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"register-btn\"]")).Click();
            Thread.Sleep(1000);
        }
        [TestMethod]
        public void DangNhap()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://vitimex.com.vn/");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"myPage\"]/header/div[2]/div/div[2]/div[2]/div[2]/a")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"account\"]")).SendKeys("0848277707");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"pass\"]")).SendKeys("PhamVietManh1#");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"signin-btn\"]")).Click();

        }
    }
}
