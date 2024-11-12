using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace proje44.Controllers
{
    public class Class2
    {
        public int yorumID { get; set; }
        public string yorumAd { get; set; }
        public string yorumBaslik { get; set; }
        public string yorumicerik { get; set; }
        public DateTime yorumDate { get; set; }
        public int BlogScore { get; set; }
        public bool yorumDurum { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
    public class YorumListesiApi : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44373/api/YorumListesiApi");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Class2>>(jsonString);
            return View(values);
        }
        public async Task<IActionResult> DeleteYorum(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync("https://localhost:44373/api/YorumListesiApi/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        //[HttpGet]
        //public IActionResult AddYorum()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> AddYorum(Class1 class1)
        //{
        //    var httpClient = new HttpClient();
        //    var jsonYorum = JsonConvert.SerializeObject(class1);
        //    StringContent content = new StringContent(jsonYorum, Encoding.UTF8, "application/json");
        //    var responseMessage = await httpClient.PostAsync("https://localhost:44373/api/Yazar", content);
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View(class1);
        //}

    }
}
