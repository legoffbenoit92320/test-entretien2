using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShopApi.Models;

namespace ShopApi.Controllers
{
    [ApiController]    
    public class ProductsController : ControllerBase
    {
        public ProductsController()
        {
            
        }

        [HttpGet]
        public List<Product> GetAllProduct()
        {
            var result = new List<Product>();
            using (var dbc = new ShopDBContext())
            {
                result= dbc.Product.ToList();
            }
            return result;
        }

        [HttpGet]
        public Product GetProduct(int id)
        {
            var product = new Product();
            using (var dbc = new ShopDBContext())
            {
                product = dbc.Product.FirstOrDefault(p => p.Id == id);
            }
            return product;
        }

        [HttpPost]
        public void CreateProduct(Product product)
        {
            using (var dbc = new ShopDBContext())
            {
                dbc.Add(product);
                dbc.SaveChanges();
            }
        }

        [HttpPut]
        public void UpdateProduct(Product product)
        {
            using (var dbc = new ShopDBContext())
            {
                var prdToUpdate = dbc.Product.FirstOrDefault(p => p.Id == product.Id);
                prdToUpdate.Name = product.Name;
                prdToUpdate.OrderItem = product.OrderItem;
                prdToUpdate.Price = product.Price;
                prdToUpdate.Stock = product.Stock;
                prdToUpdate.UpdateDate = product.UpdateDate;

                dbc.Update(prdToUpdate);
                dbc.SaveChanges();
            }
            
        }


    }
}
