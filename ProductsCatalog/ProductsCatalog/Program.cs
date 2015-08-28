using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Size s = new BoxSize(1, 1, 1);
            s.GetAsText();
        }
    }
}
