namespace ListifyClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListifyMenu output = new ListifyMenu();
            RequestHandler request = new RequestHandler();

            while (true) 
            {
                
                output.DisplayMenu();

                request.Post();
                request.Request();
                

            }
            

            

        }
    }
}