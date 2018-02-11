using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            //  for tutorial 1 : LINQ Queries examples
            //LinqQueryOperations linqQueryOperations = new LinqQueryOperations();
            //linqQueryOperations.LinqQueryExamples();

            //  for tutorial 2 : LINQ methods examples
            List<Category> categoryList = new List<Category>()
                                        {
                                        new Category{CategoryName ="Sports"},
                                        new Category{CategoryName ="Furniture"},
                                        new Category{CategoryName ="Apparels"}
                                        };

            Product productOne = new Product { ProductName = "Tennis Racket", CategoryId = 1, Price = 499.99, QuantityAvailable = 50 };
            Product productTwo = new Product { ProductName = "Tennis Racket", CategoryId = 1, Price = 499.99, QuantityAvailable = 50 };
            Product productThree = new Product { ProductName = "Tennis Ball", CategoryId = 1, Price = 100.00, QuantityAvailable = 100 };
            Product productFour = new Product { ProductName = "Dining Table", CategoryId = 2, Price = 15000, QuantityAvailable = 10 };
            Product productFive = new Product { ProductName = "Laptop Table", CategoryId = 2, Price = 7000.00, QuantityAvailable = 15 };
            Product productSix = new Product { ProductName = "Levis Jeans", CategoryId = 3, Price = 2000, QuantityAvailable = 100 };
            Product productSeven = new Product { ProductName = "Wrangler Shirt", CategoryId = 3, Price = 2000, QuantityAvailable = 100 };
            List<Product> productList = new List<Product>()
                {
                    productOne,
                    productTwo,
                    productThree,
                    productFour,
                    productFive,
                    productSix,
                    productSeven
                };
            string[] productClass = { "A", "B", "C", "D", "E", "F", "G" };

            List<Product> outDatedProducts = new List<Product>()
            {
                productSix,
                productSeven
            };

            //  return a list of products whose price is greater than 1000 order price)
            //var list = productList.Where(x => x.Price > 1000).Select(x=> new { x.ProductName, x.Price }).OrderByDescending(x=> x.Price).ThenBy(x => x.ProductName);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.ProductName + ":" + item.Price);
            //    //Console.WriteLine(item);
            //}

            // calculate the number of products in each category: catid, noOfProducts
            //var list = productList.GroupBy(x => x.CategoryId).Select(x => new { CatID = x.Key, NoOfProds = x.Count() });
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.CatID + ":" + item.NoOfProds);
            //    //Console.WriteLine(item);
            //}

            // display prod name, cat name & prod price.
            //var list = productList.Join(categoryList,
            //    p => p.CategoryId,
            //    c => c.CategoryId,
            //    (p, c) => new { p, c })
            //    .Select(x => new { x.p.ProductName, x.c.CategoryName, x.p.Price });
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.ProductName + ":" + item.CategoryName + ":" + item.Price);
            //    //Console.WriteLine(item);
            //}

            // Partitioning operators (Take, Skip, TakeWhile, SkipWhile
            //var list = productList.TakeWhile(x => x.Price < 1000);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.ProductName +  ":" + item.Price);
            //    //Console.WriteLine(item);
            //}

            // Set operators(Distinct, Except):
            //var list = productList.Select(x => x.CategoryId).Distinct();
            //var list = productList.Except(outDatedProducts);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.ProductName + ":" + item.Price);
            //    //Console.WriteLine(item);
            //}

            // Quantifiers(Contains, All, Any):
            //var flag = productList.Any(x => x.Price > 1000);
            //Console.WriteLine(flag);

            //  Aggregate Operators(Max, Min, Sum, Count
            var number = productList.Sum(x => x.Price);
             Console.WriteLine(number);

        }

    }
}



