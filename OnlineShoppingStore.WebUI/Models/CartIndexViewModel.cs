using OnlineShoppingStore.Domain.Entities;
using OnlineShoppingStore.WebUI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.WebUI.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        public CartController CartController { get; internal set; }
    }
}