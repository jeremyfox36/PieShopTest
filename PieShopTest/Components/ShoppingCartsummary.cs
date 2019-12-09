using System;
using Microsoft.AspNetCore.Mvc;
using PieShopTest.Models;

namespace PieShopTest.Components
{
    public class ShoppingCartsummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartsummary()
        {

        }
    }
}
