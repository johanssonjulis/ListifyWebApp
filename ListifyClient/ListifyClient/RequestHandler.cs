using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ListifyClient


{
    public class RequestHandler
    {


        public RequestHandler() 
        {

        }

        public void Request()
        {
            
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"You wrote {choice}");
            Get();
        }
        public void Get()
        {
            
            HttpClient httpClient = new HttpClient();
           
            Uri uri = new Uri("https://localhost:7277/api/Listify");

            
            HttpResponseMessage response = httpClient.GetAsync(uri).Result;

            
            Console.WriteLine("Status Code: " + (int)response.StatusCode);
            Console.WriteLine("Means: " + response.StatusCode);

           
            string text = response.Content.ReadAsStringAsync().Result;

            
            Console.WriteLine(text);


        }
        public void Post()
        {
            HttpClient httpClient = new HttpClient();
            Uri uri = new Uri("https://localhost:7277/api/Listify");



            string json = JsonConvert.SerializeObject(new Listify(10, "julia"));

            Console.WriteLine("Json sent: " + json);


            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");


            HttpResponseMessage response = httpClient.PostAsync(uri, content).Result;
            Console.WriteLine("Status Code: " + (int)response.StatusCode);
            Console.WriteLine("Means: " + response.StatusCode);

        }
        public void Put() 
        {
            HttpClient httpClient = new HttpClient();
            Uri uri = new Uri("https://localhost:7277/api/Listify");

            HttpResponseMessage response = httpClient.GetAsync(uri).Result;


            Console.WriteLine("Status Code: " + (int)response.StatusCode);
            Console.WriteLine("Means: " + response.StatusCode);


            string text = response.Content.ReadAsStringAsync().Result;


            Console.WriteLine(text);


        }
        public void Delete() 
        {
            HttpClient httpClient = new HttpClient();
            Uri uri = new Uri("https://localhost:7277/api/Listify");

            HttpResponseMessage response = httpClient.DeleteAsync(uri).Result;


            Console.WriteLine("Status Code: " + (int)response.StatusCode);
            Console.WriteLine("Means: " + response.StatusCode);


            string text = response.Content.ReadAsStringAsync().Result;


            Console.WriteLine(text);

    }
        }
}

