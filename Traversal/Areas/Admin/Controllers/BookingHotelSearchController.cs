﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Traversal.Areas.Admin.Models;
namespace Traversal.Areas.Admin.Controllers
{
    public class BookingHotelSearchController : Controller
    {
        [Area("Admin")]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?room_number=1&adults_number=2&checkout_date=2024-05-24&filter_by_currency=EUR&units=metric&locale=en-gb&checkin_date=2024-05-19&dest_type=city&dest_id=-1456928&order_by=popularity&children_ages=5%2C0&children_number=2&include_adjacency=true&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0"),
                Headers =
    {
        { "X-RapidAPI-Key", "aaca464d2bmshaa35f81362e2898p1942b2jsn36c22d5af144" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var replace = body.Replace(".", "");
                var value = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(replace);
                return View(value.results);
            }
        }


        [HttpGet]
        public IActionResult GetCitydestId()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetCitydestId(string p)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={p}&locale=en-gb"),
                Headers =
    {
        { "X-RapidAPI-Key", "aaca464d2bmshaa35f81362e2898p1942b2jsn36c22d5af144" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                return View();
            }
        }
    }
}
