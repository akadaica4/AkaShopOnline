using System;
using System.Collections.Generic;
using System.Text;

namespace AkaShop.Utilities.Exceptions
{
    public class AkaShopException : Exception
    {
        public AkaShopException()
        {
        }

        public AkaShopException(string message)
            : base(message)
        {
        }

        public AkaShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
