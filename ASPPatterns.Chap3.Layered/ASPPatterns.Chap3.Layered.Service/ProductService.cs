using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Service
{
    public class ProductService
    {
        private Model.ProductService _productService;

        public ProductListResponse GetAllProductsFor(ProductListRequest productListRequest)
        {
            ProductListResponse productListResponse = new ProductListResponse();
            IList<Model.Product> productEntities = _productService.GetAllProductsFor(productListRequest.customerType);

            productListResponse.Products = productEntities.ConvertToProductListViewModel();
            productListResponse.Success = true;

            return productListResponse;
        }
    }
}
