using System.Collections.Generic;
using NUnit.Framework;

namespace LSP.Tests
{
    internal class TestGenericUserDBAccess
    {
        private const string WriteToDatabase = "write to database";
        private const string ChangeInDatabase = "change in database";

        [Test]
        public void ShouldNotGetValueOfAccessRightWhenRightIsProtectedTest()
        {
            HashSet<string> protectedRights = new HashSet<string>();
            protectedRights.Add(WriteToDatabase);

            GenericUser genericUser = new GenericUser(protectedRights);
            genericUser.SetupAccessRight(WriteToDatabase, true);

            Assert.False(genericUser.GetValueOfAccessRight(WriteToDatabase));
        }

        [Test]
        public void ShouldGetValueOfAccessRightWhenRightIsNotProtectedTest()
        {
            GenericUser genericUser = new GenericUser(new HashSet<string>());
            genericUser.SetupAccessRight(ChangeInDatabase, true);

            Assert.True(genericUser.GetValueOfAccessRight(ChangeInDatabase));
        }
    }
}