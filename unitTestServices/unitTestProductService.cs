using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.ServiceProduct;

namespace unitTestServices
{
    [TestClass]
    public class unitTestProductService
    {
        ProductService ProductService;
        [TestInitialize]
        public void productServiceIntialize()
        {
            ProductService = new ProductService();
        }
        [TestMethod]
        public void TestMethodAdd()
        {
            ProductService.Add("ABC123", "Erasor", (decimal)10.00, (decimal)15.00);

        }

        [TestMethod]
        public void TestMethodList()
        {
            ProductService.List();
        }
    }
}
