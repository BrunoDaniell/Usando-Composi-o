using System;
using System.Globalization;
using FixacaoComp.Entities;
using FixacaoComp.Entities.Enums;


namespace FixacaoComp.Entities
{
    internal class Product
    {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
