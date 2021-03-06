using System;
using System.Collections.Generic;
using System.Text;

namespace AkaShop.Utilities.Constants
{
    public class SystemConstants
    {
        public const string MainConnectionString = "AkaShopDbConnection";
        public const string CartSession = "CartSession";

        public class AppSettings
        {
            public const string DefaultLanguageId = "DefaultLanguageId";
            public const string Token = "Token";
            public const string BaseAddress = "BaseAddress";
            
        }
        public class ProductSetting
        {
            public const int NumberOfFeaturedProducts = 4;
            public const int NumberOfLatestProducts = 6;
        }

        public class ProductConstnats
        {
            public const string NA = "N/A";
        }
    }
}
