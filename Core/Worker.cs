using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWork2021.Core
{
    public class Worker
    {
		public List<Product> GetData(string url)
		{
			//var url = "https://nikopol.org/";
			var web = new HtmlWeb();
			var doc = web.Load(url);
			var htmlNodes = doc.DocumentNode.SelectNodes("//ul[@class='b-product-gallery']");
			List<Product> products = new List<Product>();
			foreach (var node in htmlNodes)
			{
				int intcount = node.ChildNodes.Count; // 21 
				for (int i = 0; i < intcount; i++)
				{
					var product = new Product();

					product.id = i+1; //Что б не с нуля начинался

					var html = node.ChildNodes[i].InnerHtml;
					var htmlDoc = new HtmlDocument();
					htmlDoc.LoadHtml(html);

					///Номер позиции
					var SCU_ID = htmlDoc.DocumentNode.SelectNodes("//div[@class='b-product-gallery__sku']");
					foreach (var nodeSCU_ID in SCU_ID) product.sku = nodeSCU_ID.InnerText;

					///Наименование товара
					HtmlNodeCollection title = htmlDoc.DocumentNode
								  .SelectNodes("//a[@class='b-product-gallery__image-link']");

					foreach (var nodeTitle in title)
					{
						product.naim = nodeTitle.Attributes["title"].Value;

						product.url = nodeTitle.Descendants("img").First().GetAttributeValue("longdesc", null);



					}
					///Ссылка на изображение
					HtmlNodeCollection link = htmlDoc.DocumentNode
								  .SelectNodes("//img[@class='b-product-gallery__image']");



					if (string.IsNullOrEmpty(product.url) && link != null)
					{
						foreach (var nodeLink in link)
						{
							//Console.WriteLine("-----" + nodeLink.InnerText);
							product.url = nodeLink.Attributes["src"].Value;
						}
					}

					products.Add(product);


					//	}
				}
				
				


			}
			//Console.ReadKey();

			return products;

		}
		
	}

	
}
