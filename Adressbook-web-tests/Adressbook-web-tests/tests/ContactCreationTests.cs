using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAdressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void TheContactCreationTests()
        {
            app.Navigator.GoToAddNewContactPage();
            ContactData contact = new ContactData("777");
            contact.Middlename = "";
            contact.Lastname = "888";
            app.Groups
                .FillContactForm(contact)
                .SubmitAccountCreation()
                .ReturnToHomePage();
         }

     }
}

