using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Carrito = new ArrayList();

            Carrito.Add(new ShopingCart("Cebolla",1000));
            Carrito.Add(new ShopingCart("Gelatina",500));
            Carrito.Add(new ShopingCart("Galletas",1500));
            Carrito.Add(new ShopingCart("Papaya",2500));
            Carrito.Add(new ShopingCart("Leche",2600));

            foreach (ShopingCart CarritoItem in Carrito)
            {
                Console.WriteLine("Elemento: {0} --- ${1}", CarritoItem.itemName, CarritoItem.price);
            }

            Console.ReadLine();
        }
    }

    public class ShopingCart
    {
        public string itemName;
        public double price;

        public ShopingCart(string _itemName, double _price)
        {
            this.itemName = _itemName;
            this.price = _price;
        }
    }
}
