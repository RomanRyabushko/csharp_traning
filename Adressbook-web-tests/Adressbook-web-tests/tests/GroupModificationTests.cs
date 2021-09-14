using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAdressbookTests
{
    [TestFixture]

    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {

        GroupData newData = new GroupData("zzz");
        newData.Footer = null;
        newData.Header = null;

        app.Groups.Modify(0, newData);

        }
    }
}
