using ChickMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ChickMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        public HomeController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var response = await _httpClient.GetStringAsync("http//api-service:8080/api/Chicken"); // Await 
                ViewBag.Chicken = response;
            }
            catch (Exception ex)
            {
                ViewBag.Chicken = "Error: " + ex.Message;
            }
            return View();
        }


    }
}
