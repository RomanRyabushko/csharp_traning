using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAdressbookTests
{
    [TestFixture]

    public class ContactDeleteTests : TestBase
    {

        [Test]
        public void ContactDeleteTest()
        {

            GroupData newData = new GroupData("zzz");
            newData.Footer = "ttt";
            newData.Header = "qqq";

            app.Groups.Modify(1, newData);

        }
    }
}