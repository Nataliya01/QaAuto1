﻿// Generated by Selenium IDE
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;


namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }

    [TestFixture]
    public class SignupTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void signup()
        {
            driver.Navigate().GoToUrl("https://qauto.forstudy.space/");
            driver.Manage().Window.Size = new System.Drawing.Size(1050, 840);
            driver.FindElement(By.CssSelector(".hero-descriptor_btn")).Click();
            driver.FindElement(By.Id("signupName")).Click();
            driver.FindElement(By.Id("signupName")).SendKeys("hhh");
            driver.FindElement(By.Id("signupLastName")).Click();
            driver.FindElement(By.Id("signupLastName")).SendKeys("hhhh");
            driver.FindElement(By.Id("signupEmail")).Click();
            driver.FindElement(By.Id("signupEmail")).SendKeys("hhhh@i.ua");
            driver.FindElement(By.Id("signupPassword")).Click();
            driver.FindElement(By.Id("signupPassword")).SendKeys("Nataly.m01");
            driver.FindElement(By.Id("signupRepeatPassword")).Click();
            driver.FindElement(By.Id("signupRepeatPassword")).SendKeys("Nataly.m01");
            driver.FindElement(By.CssSelector(".btn-primary:nth-child(1)")).Click();
        }
    }

}
