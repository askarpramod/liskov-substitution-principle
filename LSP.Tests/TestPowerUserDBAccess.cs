using NUnit.Framework;

namespace LSP.Tests
{
    internal class TestPowerUserDBAccess
    {
        [Test]
        public void PowerUserTest()
        {
            var powerUser = new PowerUser();

            DatabaseGateway.WriteToDBForce(powerUser, "payload");

            Assert.That("payload", Is.EqualTo(DatabaseGateway.ReadFromDB()));
        }
    }
}