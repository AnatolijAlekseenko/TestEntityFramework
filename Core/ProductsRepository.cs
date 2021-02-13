using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWork2021.Core
{
    //CRUD-операции (create, read, update, delete)
    public class ProductsRepository
    {
        private readonly AppDBContext context;
        public ProductsRepository(AppDBContext context)
        {
            this.context = context;
        }

        //выбрать все записи из таблицы Product
        public IQueryable<Product> GetProducts()
        {
            return context.Product.OrderBy(x => x.naim);
        }

        //найти определенную запись по id
        public Product GetProductById(int id)
        {
            return context.Product.Single(x => x.id == id);
        }

        //сохранить новую либо обновить существующую запись в БД
        public int SaveProduct(Product entity)
        {
            if (entity.id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

            return entity.id;
        }

        //удалить существующую запись
        public void DeleteProduct(Product entity)
        {
            context.Product.Remove(entity);
            context.SaveChanges();
        }


        //Очищаем все данные в БД
        public void DelAllData()
        {
            context.Database.ExecuteSqlRaw("DELETE FROM Product");
        }

            public void SaveWithSiteProduct(string url)
        {
            //Здесь будет вставка информации на сайт
             Worker worker = new Worker();
             var Data = worker.GetData(url);

            foreach (var item in Data)
            {
                context.Product.Add(new Product() { 
                   
                    // id = item.id, - нельзя так как ключ в БД
                    sku = item.sku,
                    naim = item.naim,
                    url = item.url

                    });
                context.SaveChanges(); 
            }
        }

    }
}
