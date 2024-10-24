using System.Collections.Generic;

namespace LSP
{
    public class PowerUser
    {
        protected IDictionary<string, bool> AccessRights { get; } = new Dictionary<string, bool>();

        public virtual void SetupAccessRight(string right, bool value)
        {
            AccessRights.Add(right, value);
        }

        public bool GetValueOfAccessRight(string right)
        {
            AccessRights.TryGetValue(right, out bool value);

            return value;
        }
    }
}