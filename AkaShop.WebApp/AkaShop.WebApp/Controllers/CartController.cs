using AkaShop.BEApiIntegration;
using AkaShop.Utilities.Constants;
using AkaShop.ViewModel.Sales;
using AkaShop.WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkaShop.WebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductApiClient productApiClinet;

        public CartController(IProductApiClient productApiClinet)
        {
            this.productApiClinet = productApiClinet;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetListItems()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            };
            return Ok(currentCart);
        }

        public async Task<IActionResult> AddToCart(int id, string languageId)
        {
            var product = await productApiClinet.GetById(id, languageId);
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if(session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            };
            int quantity = 1;
            if(currentCart.Any(x=>x.ProductId == id))
            {
                quantity = currentCart.First(x => x.ProductId == id).Quantity + 1;
            };

            var cartItem = new CartItemViewModel()
            {
                ProductId = id,
                Description = product.Description,
                Name = product.Name,
                Image = product.ThumbnailImge,
                Quantity = quantity,
                Price = product.Price
            };
            currentCart.Add(cartItem);
            HttpContext.Session.SetString(SystemConstants.CartSession,JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
        }

        public IActionResult UpdateCart(int id, int quantity)
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            };
            foreach(var item in currentCart)
            {
                if(item.ProductId == id)
                {
                    if(quantity == 0)
                    {
                        currentCart.Remove(item);
                        break;
                    }
                    item.Quantity = quantity;
                }
            }

            HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View(GetCheckoutViewModel());
        }

        [HttpPost]
        public IActionResult Checkout(CheckOutViewModel request)
        {
            var model = GetCheckoutViewModel();
            var orderDetails = new List<OrderDetailViewModel>();
            foreach(var item in model.CartItems)
            {
                orderDetails.Add(new OrderDetailViewModel()
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                });
            };
            var checkoutRequest = new CheckOutRequest()
            {
                Address = request.CheckOutModel.Address,
                Email = request.CheckOutModel.Email,
                Name = request.CheckOutModel.Name,
                PhoneNumber = request.CheckOutModel.PhoneNumber,
                OrderDetail = orderDetails
            };
            //TODO: add to API
            TempData["SuccessMsg"] = "Order puschased successful";
            return View(model);
        }


        private CheckOutViewModel GetCheckoutViewModel()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            };
            var checkoutviewModel = new CheckOutViewModel()
            {
                CartItems = currentCart,
                CheckOutModel = new CheckOutRequest()
            };
            return checkoutviewModel;
        }
    }
}
