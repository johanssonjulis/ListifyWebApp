using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace ListifyClient
{
    public class ListifyMenu
    {
        public void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("This is the client");
                Console.WriteLine("1. -> Get    | See your lists");
                Console.WriteLine("2. -> Post   | Add list");
                Console.WriteLine("3. -> Put    | Update list");
                Console.WriteLine("4. -> Delete | Delete list");
                Console.WriteLine("5. -> Quit   | Quit the program");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "1":
                    case "get":
                        Get();
                        break;
                    case "2":
                    case "post":
                        Post();
                        break;
                    case "3":
                    case "put":
                        Put();
                        break;
                    case "4":
                    case "delete":
                        Delete();
                        break;
                    case "quit":

                        return;
                }
            }
        }

        private void Get()
        {
            Console.WriteLine("Please write the id of the list you want:");
            string id = Console.ReadLine();

            HttpClient client = new HttpClient();
            Uri uri = new Uri("https://localhost:7277/api/Listify/GetListifyById?id=" + id);

            HttpResponseMessage response = client.GetAsync(uri).Result;
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(json);
                var listify = System.Text.Json.JsonSerializer.Deserialize<Listify>(json);
                
                Console.WriteLine($"Your list: {listify.tasks}");
            }
            else
            {
                Console.WriteLine("Error. " + response.ReasonPhrase);
            }
        }

        private void Post()
        {
            Console.WriteLine("What's the name of the list?");
            string listName = Console.ReadLine();
            
            var listify = new Listify() { Name = listName };
            List<ItemTask> itemTask = new List<ItemTask>();

            string task;
            ItemTask addedTask;
            string input;

            while (true)
            {
                Console.WriteLine("Press q to quit, y to add task to list");
                input = Console.ReadLine();
                if (input.Equals("q"))
                    break;
                if (input.Equals("y"))
                {                                 
                    Console.WriteLine("Add task:");
                    task = Console.ReadLine();
                    addedTask = new ItemTask() { TaskDescription = task };
                    itemTask.Add(addedTask);
                }
            }

            listify.tasks = itemTask;

            HttpClient httpClient = new HttpClient();
            Uri uri = new Uri("https://localhost:7277/api/Listify/PostList");

            string json = System.Text.Json.JsonSerializer.Serialize(listify);

            StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = httpClient.PostAsync(uri, stringContent).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(listify.Name + " successfully registered!");
            }
            else
            {
                Console.WriteLine("Post failed. Status Code " + (int)response.StatusCode + ": " + response.StatusCode);
            }
        }

        private void Put()
        {
            throw new NotImplementedException();
        }

        private void Delete()
        {
            Console.WriteLine("Please write the id nr of the list you want to delete.");
            string listId = Console.ReadLine();

            HttpClient client = new HttpClient();
            Uri uri = new Uri("https://localhost:7277/api/Listify/Delete/" + listId);

            HttpResponseMessage response = client.DeleteAsync(uri).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine($"List with id {listId} successfully deleted.");
            }
            else
            {
                Console.WriteLine("Error. " + response.ReasonPhrase);
            }

        }
    }
}
