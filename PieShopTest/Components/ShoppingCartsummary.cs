using System;
using Microsoft.AspNetCore.Mvc;

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
