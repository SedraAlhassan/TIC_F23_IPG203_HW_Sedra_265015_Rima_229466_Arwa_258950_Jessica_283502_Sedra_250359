using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Utils
{
    public class ItemCounter
    {
        public static int TotalItems { get; private set; } = 0;

        public ItemCounter()
        {
            TotalItems++;
        }
    }
}

