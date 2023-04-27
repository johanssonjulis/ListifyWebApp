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
        }
        public void Get()
        {
            HttpClient httpClient = new HttpClient();
            Uri uri = new Uri("https://localhost:7104/api/Product");

            // For Post, I want to send in something called HttpContent.
            // I create an object that will accept the variables I want
            // to send. In this case, just a string.
            DataContent dataContent = new DataContent("Anything else!");

            // JsonConvert is from Newtonsoft.Json, a package one can
            // install. It is well liked. An alternative for JsonSerializer.Serialize.
            string json = JsonConvert.SerializeObject(dataContent);

            Console.WriteLine("Json sent: " + json);

            
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            
            HttpResponseMessage response = httpClient.PostAsync(uri, content).Result;
            Console.WriteLine("Status Code: " + (int)response.StatusCode);
            Console.WriteLine("Means: " + response.StatusCode);

        }
        public void Post() 
        {
            
        }
        public void Put() 
        {
        
        }
        public void Delete() 
        {

        }
    }
}
