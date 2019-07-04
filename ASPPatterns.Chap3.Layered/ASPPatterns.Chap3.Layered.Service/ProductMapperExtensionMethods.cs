using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Service
{
    public static class ProductMapperExtensionMethods
    {
        public static IList<ProductViewModel> ConvertToProductListViewModel(this IList<Model.Product> products)
        {
            IList<ProductViewModel> productViewModelList = new List<ProductViewModel>();

            foreach (var product in products)
            {
                ProductViewModel productViewModel = product.ConvertToProductViewModel();
                productViewModelList.Add(productViewModel);
            }

            return productViewModelList;
        }

        public static ProductViewModel ConvertToProductViewModel(this Model.Product product)
        {
            return new ProductViewModel();
        }
    }
}
