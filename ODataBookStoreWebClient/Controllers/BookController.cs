using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using ODataBookStore.EDM;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace ODataBookStoreWebClient.Controllers
{
    public class BookController : Controller
    {

        private HttpClient _client;
        private string BookApiUrl;

        public BookController()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            BookApiUrl = "https://localhost:44339/odata/Books";
        
        }

        [HttpGet]
        public IActionResult Index()
        {

            var response = _client.GetAsync(BookApiUrl).Result;
            string data = response.Content.ReadAsStringAsync().Result;

            dynamic jsonResponse = JObject.Parse(data);
            var value = jsonResponse.value;

            List<Book> books = ((JArray)value).Select(book => new Book()
            {
                Id = (int) book["Id"],
                Author = (string) book["Author"],
                ISBN = (string) book["ISBN"],
                Title = (string) book["Title"],
                Price = (decimal) book["Price"],
            }).ToList();

            return View(books);
        }
    }
}
