using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ModelProduct
{
   public interface IProduct
    {
        void Add(string productId, string productName, decimal productCost, decimal productPrice);
        product search(string productId);
        void update(string productId, string productName, decimal productCost, decimal productPrice);
        void delete(string productId);
        List<product> List();
    }
}
