using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Utils
{
    public static class Validator
    {
        public static bool ValidateTitle(string title)
        {
            return !string.IsNullOrWhiteSpace(title);
        }
    }
}
