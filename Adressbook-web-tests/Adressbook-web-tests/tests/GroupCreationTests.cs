using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAdressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("123");
            group.Footer = "456";
            group.Header = "789";

            app.Groups.Create(group);
        }

        [Test]

        public void EmtyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Footer = "";
            group.Header = "";

            app.Groups.Create(group);
        }
    }
}
