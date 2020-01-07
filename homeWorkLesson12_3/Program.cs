using System;
using System.Collections.Generic;

namespace homeWorkLesson12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Product[2];

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Имя продукта:");
                products[i].Name = Console.ReadLine();

                Console.WriteLine("Имя магазина:");
                  products[i].Shop = Console.ReadLine();

                Console.WriteLine("Введите цену:");
                products[i].Price = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(new string('-', 20));
            }

            Console.WriteLine("Выберите магазин:");
            string shop = Console.ReadLine();

            try
            {
                var findProducts = GetProductsByShop(shop, products);

                foreach (var findProduct in findProducts)
                {
                    findProduct.ShowInfo();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        static Product[] GetProductsByShop(string shop, Product[] inputProducts)
        {
            var resultProducts = new List<Product>();

            foreach (var inputPrice in inputProducts)
            {
                if (inputPrice.Shop == shop)
                {
                    resultProducts.Add(inputPrice);
                }  
            }

            if (resultProducts.Count > 0)
            {
                return resultProducts.ToArray();
            }
            else
            {
                throw new Exception($"Среди товаров нету ни одного с названием магазина {shop}");
            }         
        }
    }
}
