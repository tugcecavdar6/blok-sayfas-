using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace proje44.Controllers
{
    public class YazarTest : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44373/api/Yazar");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Class1>>(jsonString);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddYazar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddYazar(Class1 class1)
        {
            var httpClient = new HttpClient();
            var jsonYazar = JsonConvert.SerializeObject(class1);
            StringContent content = new StringContent(jsonYazar, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync("https://localhost:44373/api/Yazar", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(class1);
        }
        [HttpGet]
        public async Task<IActionResult> EditYazar(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44373/api/Yazar/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonYazar = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Class1>(jsonYazar);
                return View(values);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> EditYazar(Class1 class1)
        {
            var httpClient = new HttpClient();
            var jsonYazar = JsonConvert.SerializeObject(class1);
            var content = new StringContent(jsonYazar, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PutAsync("https://localhost:44373/api/Yazar/", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(class1);
        }
        public async Task<IActionResult> DeleteYazar(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync("https://localhost:44373/api/Yazar/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


    }
    public class Class1
    {
        public int yazarID { get; set; }
        public string yazarAd { get; set; }
        public string yazarHakkinda { get; set; }
        public string yazarImg { get; set; }
        public string yazarMail { get; set; }
        public string yazarSifre { get; set; }
        public bool yazarDurum { get; set; }
       public List<Blog> blogs { get; set; }
    }
}
