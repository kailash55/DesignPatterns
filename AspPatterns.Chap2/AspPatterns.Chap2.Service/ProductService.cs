using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AspPatterns.Chap2.Service
{
    public class ProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IList<Product> GetAllProductsIn(int categoryId)
        {
            IList<Product> products;
            string storageKey = string.Format("products_in_category_id_{0}", categoryId);

            products = GetListFromCache();

            if(products == null)
            {
                products = _productRepository.GetAllProductsIn(categoryId);
                InsertIntoCache(storageKey, products);
            }

            return products;
        }

        private void InsertIntoCache(string storageKey, IList<Product> products)
        {
            //Code to insert product List into cache
            throw new NotImplementedException();
        }

        private IList<Product> GetListFromCache()
        {
            //Code to get Product List from cache
            throw new NotImplementedException();
        }
    }
}
