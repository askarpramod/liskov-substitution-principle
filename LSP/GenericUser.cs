using System.Collections.Generic;

namespace LSP
{
    public class GenericUser : PowerUser
    {
        private readonly HashSet<string> _protectedRights;

        public GenericUser(HashSet<string> protectedRights)
        {
            _protectedRights = protectedRights;
        }

        public override void SetupAccessRight(string right, bool value)
        {
            if (!_protectedRights.Contains(right))
            {
                AccessRights.Add(right, value);
            }
        }
    }
}