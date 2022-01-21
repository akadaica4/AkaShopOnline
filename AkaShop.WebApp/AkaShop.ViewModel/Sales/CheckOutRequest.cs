using System;
using System.Collections.Generic;
using System.Text;

namespace AkaShop.ViewModel.Sales
{
    public class CheckOutRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<OrderDetailViewModel> OrderDetail { get; set; } = new List<OrderDetailViewModel>();
    }
}
