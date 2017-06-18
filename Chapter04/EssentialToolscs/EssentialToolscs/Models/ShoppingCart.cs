using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialToolscs.Models
{
    public class ShoppingCart
    {
        private LinqValueCalculator calc;

        public ShoppingCart(LinqValueCalculator calcParam)
        {
            calc = calcParam;
        }
        public IEnumerable<Product> Products { get; set; }

        public decimal CalcualteProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}