using ECommerceWebFrom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceWebFrom.Logic
{
    public class EditProducts
    {
        public bool EditProduct(string ProductName, string ProductDesc, string ProductPrice, string ProductCategory, string ProductImagePath)
        {
            using (ProductContext _db = new ProductContext())
            {
            var myProduct = new Product();
            myProduct = _db.Products.Find(ProductName);
            myProduct.ProductName = ProductName;
            myProduct.Description = ProductDesc;
            myProduct.UnitPrice = Convert.ToDouble(ProductPrice);
            myProduct.ImagePath = ProductImagePath;
            myProduct.CategoryID = Convert.ToInt32(ProductCategory);

            
                // Add product to DB.
                
                _db.Products.Add(myProduct);
                _db.SaveChanges();

            }
            // Success.
            return true;
        }
    }

}