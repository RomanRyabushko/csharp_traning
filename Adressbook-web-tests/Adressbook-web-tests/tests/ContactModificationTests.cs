using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAdressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void TheContactModificationTest()
        {
            app.Navigator.GoToContactPage();
            ContactData contact = new ContactData("qqq");
            contact.Middlename = "www";
            contact.Lastname = "eee";

            app.Contact.ModifyContact(1, contact);

        }

    }
}