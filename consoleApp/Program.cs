using System;
using Services.ServiceProduct;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService ProductService = new ProductService();
            ProductService.Add("ABC123", "Erasor", (decimal)10.00, (decimal)15.00);
            ProductService.Add("ABC345", "Pensil", (decimal)10.00, (decimal)15.00);
            ProductService.Add("ABC678", "Pen", (decimal)10.00, (decimal)15.00);
            ProductService.Add("ABC910", "Paper", (decimal)10.00, (decimal)15.00);
            ProductService.Add("ABC112", "Ruler", (decimal)10.00, (decimal)15.00);

            var listProduct = ProductService.List();

            foreach(var item in listProduct)
            {
                Console.WriteLine(item.ProductId+" "+item.ProductName+" "+item.ProductCost+" "+item.ProductPrice);
            }

           
        }
    }
}
