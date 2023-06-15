using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            // IDisposable pattern implementation of C#
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //var deletedEntity = context.Entry(entity);
                //deletedEntity.State = EntityState.Deleted;
                //context.SaveChanges();

                context.Products.Remove(context.Products.SingleOrDefault(p => p.ProductId == entity.ProductId));
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
            }            
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //var updatedEntity = context.Entry(entity);
                //updatedEntity.State = EntityState.Modified;
                //context.SaveChanges();

                var productToUpdate = context.Products.SingleOrDefault(p => p.ProductId == entity.ProductId);
                productToUpdate.ProductName = entity.ProductName;
                productToUpdate.UnitPrice = entity.UnitPrice;
                productToUpdate.UnitsInStock = entity.UnitsInStock;
                productToUpdate.CategoryId = entity.CategoryId;
                context.SaveChanges();
            }
        }
    }
}
