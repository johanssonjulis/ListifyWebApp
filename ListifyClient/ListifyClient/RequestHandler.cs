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
    }
}
