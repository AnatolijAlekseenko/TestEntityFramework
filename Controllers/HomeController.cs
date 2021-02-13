using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestWork2021.Core;
using TestWork2021.Models;

namespace TestWork2021.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpPost]
        public IActionResult DelAllData()
        {
            productRepository.DelAllData();
            return RedirectToAction("Index");
            //var MyModel = productRepository.GetProducts();
            //return View(MyModel);
        }

        /// <summary>
        /// Метод в который загружает данные в базу исходя из введеной ссылки
        /// </summary>
        /// <param name="setUrl"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult setUrl(string setUrl)
        {

            //небольшой обработчик правильности ввода что значение не может быть пустым и дожно содержать 
            //строку вида https://nikopol.org

              if (!string.IsNullOrEmpty(setUrl) && setUrl.Contains("https://nikopol.org"))
                {
                    //Метод отображает информацию на сайте по URL
                    productRepository.SaveWithSiteProduct(setUrl);

                    var MyModel = productRepository.GetProducts();
                    return View(MyModel);
                }
                else
                {
                //Просто будет обновлятся страница
                return RedirectToAction("Index");
                }
                      

            
        }


        private readonly ProductsRepository productRepository;
        public HomeController(ProductsRepository productRepository)
        {
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
            productRepository.DeleteProduct(new Product() { id = id });
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
