using System;
using T2009M.lab.s2;
using T2009M.session1;

namespace T2009M.lab.s3
{
    public class Program
    {

        public static void Main(string[] args)
        {

       
            Diamond dim = new Diamond(1, "Diamond Black", 10000, 1, "diamond.png", "This is a black diamond", 20);
            Product fs1 = new Fashion(2, "T-Shirt", 2000,2, "t-shirt.jpg", "This is T-shirt", "red", "XL");
            Product fs2 = new Fashion(3, "Adidas Ultraboost", 5000,5, "ultraboot.png", "This is Ultraboost", "black", "44");
            Cart ca = new Cart(1, "Dang Jinner", "Ninh Binh", "Vietnam");
            ca.AddNewProduct(dim);
            ca.AddNewProduct(fs1);
            ca.AddNewProduct(fs2);
            ca.RemoveProduct(dim);
            ca.AddQuantityProduct(fs1, 10);
            ca.DecreaseQuantityProduct(fs2, 4);
            Console.WriteLine("ID khach hang: " + ca.Id);
            Console.WriteLine("Ten khach hang: " + ca.Customer);
            Console.WriteLine("Thanh pho: " + ca.City);
            Console.WriteLine("Quoc gia: "+ca.Country);
            Console.WriteLine("Gio hang: ");
            Console.WriteLine("---------------");
            ca.GetProductInCart();
            Console.WriteLine("---------------");
            Console.WriteLine("Tong tien la: " + ca.CalcGrandTotal());
            
            

        }
    }
}