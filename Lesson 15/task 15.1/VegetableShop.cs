using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultProject.Lesson_15.task_15._1
{

    class VegetableShop
    {
        private readonly List<Product> products = new List<Product>();

        public void AddProducts(IEnumerable<Product> newProducts)
        {
            products.AddRange(newProducts);
        }

        public void PrintProductsInfo()
        {
            decimal total = 0;
            foreach (var p in products)
            {
                Console.WriteLine(p.GetInfo());
                total += p.Price;
            }
            Console.WriteLine($"Total products price: {total}");
        }
    }

    abstract class Product
    {
        public string Name { get; }
        protected decimal BasePrice { get; }

        protected Product(string name, decimal basePrice)
        {
            Name = name;
            BasePrice = basePrice;
        }

        public abstract decimal Price { get; }
        public abstract string GetInfo();
    }

    class Carrot : Product
    {
        public Carrot(decimal basePrice) : base("Carrot", basePrice) { }
        public override decimal Price => BasePrice;
        public override string GetInfo() => $"Product: {Name}, Price: {Price}";
    }

    class Tomato : Product
    {
        public Tomato(decimal basePrice) : base("Tomato", basePrice) { }
        public override decimal Price => BasePrice;
        public override string GetInfo() => $"Product: {Name}, Price: {Price}";
    }

    class Potato : Product
    {
        public int Count { get; }
        public Potato(decimal basePrice, int count) : base("Potato", basePrice)
        {
            Count = count;
        }
        public override decimal Price => BasePrice * Count;
        public override string GetInfo() => $"Product: {Name}, Price: {BasePrice}, Count: {Count}, Total price: {Price}";
    }

    class Cucumber : Product
    {
        public int Count { get; }
        public Cucumber(decimal basePrice, int count) : base("Cucumber", basePrice)
        {
            Count = count;
        }
        public override decimal Price => BasePrice * Count;
        public override string GetInfo() => $"Product: {Name}, Price: {BasePrice}, Count: {Count}, Total price: {Price}";
    }

    class EnterInShop
    {
        public static void Exit()
        {
            var products = new List<Product>()
            {
                new Carrot(10),
                new Potato(22, 5),
                new Cucumber(12, 14),
                new Tomato(12)
            };

            VegetableShop shop = new VegetableShop();
            shop.AddProducts(products);
            shop.PrintProductsInfo();
        }
    }
}
