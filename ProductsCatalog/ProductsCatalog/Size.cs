using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductsCatalog
{
    public abstract class Size
    {
        public virtual string GetAsText()
        {
            return "";
        }
        public virtual int GetAsInt() { return 1; }

        public virtual double GetAsDouble() { return 1; }

    }
}
