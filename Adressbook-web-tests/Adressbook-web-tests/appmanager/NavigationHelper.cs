using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAdressbookTests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) 
            : base(manager)
        {
            this.baseURL = baseURL;
        }
        public void GoToHomePage()
        {
            if (driver.Url == baseURL + "/addressbook/")
            {
                return;
            }
                driver.Navigate().GoToUrl(baseURL + "/addressbook/");
        }

        public void GoToGroupsPage()
        {
            if (driver.Url == baseURL + "/addressbook/group.php"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }
        public void GoToAddNewContactPage()
        {
            if (driver.Url == baseURL + "/addressbook/edit.php"
                && IsElementPresent(By.Name("Enter")))
            {
                return;
            }
            driver.FindElement(By.LinkText("add new")).Click();
        }
        public void GoToContactPage()
        {
            driver.FindElement(By.LinkText("home")).Click();
        }

    }

}
