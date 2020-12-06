using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.ModelProduct;

namespace Services.ServiceProduct
{
    public class ProductService : IProduct
    {
        List<product> products;

        public ProductService()
        {
            products = new List<product>();
        }
        public void Add(string productId, string productName, decimal productCost, decimal productPrice)
        {
            try
            {
                product product = new product()
                {
                    ProductId = productId,
                    ProductName = productName,
                    ProductCost = productCost,
                    ProductPrice = productPrice
                };
                products.Add(product);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void delete(string productId)
        {
           throw new NotImplementedException();
        }

        public List<product> List()
        {
            try
            {
                return products.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void update(string productId, string productName, decimal productCost, decimal productPrice)
        {
            throw new NotImplementedException();
        }

        product IProduct.search(string productId)
        {
            throw new NotImplementedException();
        }
    }
}
