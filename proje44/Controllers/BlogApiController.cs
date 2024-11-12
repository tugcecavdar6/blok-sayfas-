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
    public class BlogApiController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44373/api/BlogApi");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Class3>>(jsonString);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBlog(Class3 class3)
        {
            var httpClient = new HttpClient();
            var jsonBlog = JsonConvert.SerializeObject(class3);
            StringContent content = new StringContent(jsonBlog, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync("https://localhost:44373/api/BlogApi", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(class3);
        }
        [HttpGet]
        public async Task<IActionResult> EditBlog(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44373/api/BlogApi/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonBlog = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Class3>(jsonBlog);
                return View(values);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> EditBlog(Class3 class3)
        {
            var httpClient = new HttpClient();
            var jsonBlog = JsonConvert.SerializeObject(class3);
            var content = new StringContent(jsonBlog, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PutAsync("https://localhost:44373/api/BlogApi/", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(class3);
        }
        public async Task<IActionResult> DeleteBlog(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync("https://localhost:44373/api/BlogApi/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
    public class Class3
    {
        public int BlogID { get; set; }
        public string BlogBaslik { get; set; }
        public string Blogicerik { get; set; }
        public string BlogkucukImg { get; set; }
        public string BlogImg { get; set; }
        public DateTime BlogTarih { get; set; }
        public bool BlogDurum { get; set; }
        public int kategoriID { get; set; }
        public Category Category { get; set; }
        public int yazarID { get; set; }
        public Yazar yazar { get; set; }
        public List<Yorumlar> yorumlars { get; set; }
    }
    }
