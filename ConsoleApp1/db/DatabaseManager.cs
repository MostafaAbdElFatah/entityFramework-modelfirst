using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.db
{
    class DatabaseManager
    {
        ProductEntityModelContainer db = new ProductEntityModelContainer();

        // fetch data
        public List<Product> getAllProducts()
        {
            try
            {
                return db.Products.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // create data
        public bool addProduct(Product product)
        {
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
            return true;
        }

        // update data
        public bool updateProduct(Product product)
        {
            try
            {
                db.Products.Add(product);
                db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
            return true;
        }

        // delete data
        public bool deleteProduct(Product product)
        {
            try
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
            return true;
        }

    }
}

