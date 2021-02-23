using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TestWork2021.Controllers;


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
            //.Take(2) - что то на подобии комманды TOP в SQL
            return context.Product.OrderBy(x => x.Naim);
        }

        //найти определенную запись по id
        public Product GetProductById(int id)
        {
            return context.Product.Single(x => x.Id == id);
        }

        //сохранить новую либо обновить существующую запись в БД
        public int SaveProduct(Product entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

            return entity.Id;
        }

        //удалить существующую запись
        public void DeleteProduct(Product entity)
        {
            context.Product.Remove(entity);
            context.SaveChanges();
        }

        public void DelAllData()
        {
            context.Database.ExecuteSqlRaw("DELETE FROM Product");
        }


        //Очищаем все данные в БД
        public void SaveImage(object sender,EventArgs e)
        {
           // if()

            //var aaa = Server.MapPath("~/Image" + "filename");

            //context.Database.ExecuteSqlRaw("DELETE FROM Product");
        }

        public void SaveWithSiteProduct(string url, string webRootPath)
        {
            
            //Здесь будет вставка информации на сайт
            Worker worker = new Worker();
             var Data = worker.GetData(url);
         


            foreach (var item in Data)
            {
                context.Product.Add(new Product() { 
                   
                    // id = item.id, - нельзя так как ключ в БД
                    Sku = item.Sku,
                    Naim = item.Naim,
                    Url = item.Url.Replace("https://images.ua.prom.st/", "")

                //item.url

            });

                //Сохранияем в каталог
                Save(webRootPath, item.Url);


                context.SaveChanges(); 
            }
        }



        #region Сохраннеие в каталог изображений
       
        public void Save(string webRootPath,string URL)
        {
            string path = "";
            path = Path.Combine(webRootPath, "Image");
            System.Net.WebClient webClient = new WebClient();
            // string URL = @"https://images.ua.prom.st/1075415876_w272_h200_albom-dlya-risovaniya.jpg";
            string filename = URL.Replace("https://images.ua.prom.st/", "");

            webClient.DownloadFile(URL, path + @"\" + filename);
        }
        #endregion

    }

}
