using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAdressbookTests
{
    [TestFixture]

    public class LoginTests : TestBase
    {
        [Test]

        public void loginWithValidCredentials()
        {
            //prepare
            app.Auth.Logout();

            //action
            AccountData accaunt = new AccountData("admin", "secret");
            app.Auth.Login(accaunt);

            //verification
            Assert.IsTrue(app.Auth.IsLoggedIn(accaunt));
        }
         [Test]

        public void loginWithInvalidCredentials()
        {
            //prepare
            app.Auth.Logout();

            //action
            AccountData accaunt = new AccountData("admin", "123456");
            app.Auth.Login(accaunt);

            //verification
            Assert.IsFalse(app.Auth.IsLoggedIn(accaunt));
        }
    }
}
