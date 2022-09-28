using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppBlog.Areas.HomePage.ViewComponents
{
    public class CallWeatherNews:ViewComponent
    {
        public async  Task<IViewComponentResult> InvokeAsync()
        {
            //var cityList = new List<HavaDurumu>();
            //cityList.Add(await sehirHavaDurumuAsync("Ankara"));
            //cityList.Add(await sehirHavaDurumuAsync("İstanbul"));
            //cityList.Add(await sehirHavaDurumuAsync("İzmir"));
            //cityList.Add(await sehirHavaDurumuAsync("Bursa"));
           
            
            
            //var model = new newsWeatherModel()
            //{
            //    havaDurumu = cityList,
               
            //};
           
            
            return View();
        }
        public async Task<HavaDurumu> sehirHavaDurumuAsync(string sehir)
        {
            var deneme = new HavaDurumu();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api.openweathermap.org/data/2.5/weather?q="+sehir+",TR&units=metric&appid=820acb409636873eaf84d7899535bfc8"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    deneme = JsonConvert.DeserializeObject<HavaDurumu>(apiResponse);
                }

            }

            return deneme;
        }

        public async Task<Haberler> haberlerAsync()
        {
            var deneme = new Haberler();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://inshorts.deta.dev/news?category=sports"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    deneme = JsonConvert.DeserializeObject<Haberler>(apiResponse);
                }

            }
            return deneme;
        }


        public class  newsWeatherModel
        {
            public List<HavaDurumu> havaDurumu { get; set; }
           
            public Haberler haberler { get; set; }
        }

        public class Main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
        }

        public class HavaDurumu
        {
            
            public Main main { get; set; }
            
            public string name { get; set; }
           
        }

        
        //DENEMEEE
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Datum
        {
            public string author { get; set; }
            public string content { get; set; }
            public string date { get; set; }
            public string id { get; set; }
            public string imageUrl { get; set; }
            public string readMoreUrl { get; set; }
            public string time { get; set; }
            public string title { get; set; }
            public string url { get; set; }
        }

        public class Haberler
        {
            public string category { get; set; }
            public List<Datum> data { get; set; }
            public bool success { get; set; }
        }



    }





}
