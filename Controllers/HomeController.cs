using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestWork2021.Core;
using TestWork2021.Models;

namespace TestWork2021.Controllers
{
    public class HomeController : Controller
    {
      
        private readonly IHostingEnvironment _hostingEnvironment;
      
      



        #region Очистка таблицы БД
        /// <summary>
        /// Очистка таблицы БД
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DelAllData()
        {
            productRepository.DelAllData();
            return RedirectToAction("Index");
            //var MyModel = productRepository.GetProducts();
            //return View(MyModel);
        }
        #endregion 

        #region Метод в который загружает данные в базу исходя из введеной ссылки
        /// <summary>
        /// Метод в который загружает данные в базу исходя из введеной ссылки
        /// </summary>
        /// <param name="setUrl"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult setUrl(string setUrl)
        {
            string webRootPath = _hostingEnvironment.WebRootPath;

            //небольшой обработчик правильности ввода что значение не может быть пустым и дожно содержать 
            //строку вида https://nikopol.org

            if (!string.IsNullOrEmpty(setUrl) && setUrl.Contains("https://nikopol.org"))
                {
                    //Метод отображает информацию на сайте по URL
                    productRepository.SaveWithSiteProduct(setUrl, webRootPath);

                    var MyModel = productRepository.GetProducts();
                    return View(MyModel);
                }
                else
                {
                //Просто будет обновлятся страница
                return RedirectToAction("Index");
                }
        }
        #endregion

        private readonly ProductsRepository productRepository;
        public HomeController(ProductsRepository productRepository, IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var MyModel = productRepository.GetProducts();
            return View(MyModel);
        }
        public IActionResult ProductsEdit(int id)
        {
            //либо создаем новую статью, либо выбираем существующую и передаем в качестве модели в представление
            Product model = id == default ? new Product() : productRepository.GetProductById(id);
            return View(model);
        }
        [HttpPost] //в POST-версии метода сохраняем/обновляем запись в БД
        public IActionResult ProductEdit(Product model)
        {
            if (ModelState.IsValid)
            {
                productRepository.SaveProduct(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }
        [HttpPost] //т.к. удаление статьи изменяет состояние приложения, нельзя использовать метод GET
        public IActionResult ProductDelete(int id)
        {
            productRepository.DeleteProduct(new Product() { Id = id });
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
