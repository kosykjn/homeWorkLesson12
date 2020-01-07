using System;

namespace homeWorkLesson12_3
{
    struct Product
    {
        public string Name;
        public string Shop;
        public int Price;

        public void ShowInfo()
        {
            Console.WriteLine($"Товар: {Name}\nНазвание магазина: {Shop}\nЦена: {Price}");
        }
    }
}
