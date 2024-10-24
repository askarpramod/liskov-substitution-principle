using System.Collections.Generic;

namespace LSP
{
    public class PowerUser : User
    {
        public override void SetupAccessRight(string right, bool status)
        {
            StatusByRight.Add(right, status);
        }
    }
}