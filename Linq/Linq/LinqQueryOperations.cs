using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq
{
    class LinqQueryOperations
    {
        public LinqQueryOperations()
        {
            
        }

        public void LinqQueryExamples()
        {
            List<Category> categoryList = new List<Category>()
            {
                new Category{CategoryName ="Sports"},
                new Category{CategoryName ="Furniture"},
                new Category{CategoryName ="Apparels"}
            };
            List<Product> productList = new List<Product>()
            {
                new Product{ProductName="Tennis Racket", CategoryId=1, Price=499.99, QuantityAvailable=50},
                new Product{ProductName="Tennis Ball", CategoryId=1, Price=100.00, QuantityAvailable=100},
                new Product{ProductName="Dining Table", CategoryId=2, Price=15000, QuantityAvailable=10},
                new Product{ProductName="Laptop Table", CategoryId=2, Price=7000.00, QuantityAvailable=15},
                new Product{ProductName="Levis Jeans", CategoryId=3, Price=2000, QuantityAvailable=100},
                new Product{ProductName="Louis Phillipe Shirt", CategoryId=3, Price=2500, QuantityAvailable=100}
            };

            //  display the product names of all the product
            //var listOfProdNames = from p in productList select p.ProductName;
            //foreach(var item in listOfProdNames)
            //{
            //    Console.WriteLine(item);
            //}

            // display the product names as well as price of all the products
            //var listOfProdNames = from p in productList select new { p.ProductName, p.Price };
            //foreach (var item in listOfProdNames)
            //{
            //    Console.WriteLine("ProductName:" + item.ProductName + ", Price:" + item.Price);
            //}

            // display the product names as well as price of all those products which are priced above 1000 Rs
            //var listOfProdNames = from p in productList where p.Price > 1000 select new { p.ProductName, p.Price };
            //foreach (var item in listOfProdNames)
            //{
            //    Console.WriteLine("ProductName:" + item.ProductName + ", Price:" + item.Price);
            //}

            // display the product names as well as price of all those products which are priced above 1000 Rs.and in the decreasing order of price
            //var listOfProdNames = from p in productList where p.Price > 1000 orderby p.Price descending, p.ProductName ascending   select new { p.ProductName, p.Price };
            //foreach (var item in listofprodnames)
            //{
            //    Console.writeline("productname:" + item.productname + ", price:" + item.price);
            //}

            // display the category id and number of products available in each category
            //var listOfProdNames = from p in productList group p by p.CategoryId into g select new { CatId =  g.Key, NoOfProducts =  g.Count()};
            //foreach (var item in listOfProdNames)
            //{
            //    Console.WriteLine("CatId:" + item.CatId + ", no of products:" + item.NoOfProducts);
            //}

            // display the product name, category name and price of all the products
            //var listOfProdNames = from p in productList
            //                        join c in categoryList on p.CategoryId equals c.CategoryId
            //                        select new { p.ProductName, c.CategoryName, p.Price };
            //foreach (var item in listOfProdNames)
            //{
            //    Console.WriteLine("Productname:" + item.ProductName + " CatName: " + item.CategoryName + ", price:" + item.Price);
            //}

            // display the category name and the total quantity of products available in each category
            //in the ascending order of category Id.
            var list = from p in productList
                       group p by p.CategoryId into g
                       join c in categoryList on g.Key equals c.CategoryId
                       orderby c.CategoryId
                       select new { CategoryName = c.CategoryName, QtyAvailable = g.Sum(x => x.QuantityAvailable) };
            foreach (var item in list)
            {
                Console.WriteLine("CategoryName:" + item.CategoryName + " QuantityAvailable: " + item.QtyAvailable);
            }

        }

    }
}
