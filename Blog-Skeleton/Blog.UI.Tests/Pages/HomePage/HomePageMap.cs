﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.UI.Tests.Pages.HomePage
{
    public partial class HomePage
    {
        public IWebElement Logo
        {
            get
            {
                return this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a")));
            }
        }

        public IWebElement Login
        {
            get
            {
                return this.Wait.Until(w => w.FindElement(By.Id("loginLink")));
            }
        }

        public IWebElement Logoff
        {
            get
            {
                return this.Wait.Until(w => w.FindElement(By.CssSelector("#logoutForm > ul > li:nth-child(3) > a")));
            }
        }
        public IWebElement Register
        {
            get
            {
                return this.Wait.Until(w => w.FindElement(By.Id("registerLink")));
            }
        }

        public IWebElement GreatingLink
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a"));
            }

        }

       
    }
}
