﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAdressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void TheContactCreationTest()
        {
            app.Navigator.GoToAddNewContactPage();
            ContactData contact = new ContactData("777");
            contact.Middlename = "";
            contact.Lastname = "888";

            app.Contact.Create(contact);
               
         }

     }
}

