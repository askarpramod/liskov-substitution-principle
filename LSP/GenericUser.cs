using System.Collections.Generic;

namespace LSP
{
    public class GenericUser : User
    {
        private readonly HashSet<string> _protectedRights;

        public GenericUser(HashSet<string> protectedRights)
        {
            _protectedRights = protectedRights;
        }

        public override void SetupAccessRight(string right, bool status)
        {
            if (IsNotContains(right))
            {
                StatusByRight.Add(right, status);
            }
        }

        private bool IsNotContains(string right)
        {
            return !_protectedRights.Contains(right);
        }
    }
}