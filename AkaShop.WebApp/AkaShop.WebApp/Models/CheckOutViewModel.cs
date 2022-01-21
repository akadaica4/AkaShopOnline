using AkaShop.ViewModel.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkaShop.WebApp.Models
{
    public class CheckOutViewModel
    {
        public List<CartItemViewModel> CartItems { get; set; }
        public CheckOutRequest CheckOutModel { get; set; }
    }
}
