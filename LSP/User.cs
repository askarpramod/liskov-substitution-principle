using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public abstract class User
    {
        protected IDictionary<string, bool> StatusByRight { get; } = new Dictionary<string, bool>();
        public abstract void SetupAccessRight(string right, bool status);
        public bool GetValueOfAccessRight(string right)
        {
            StatusByRight.TryGetValue(right, out bool status);
            return status;
        }
    }
}
