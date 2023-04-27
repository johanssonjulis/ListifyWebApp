namespace ListifyClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            Output output = new Output();
            RequestHandler request = new RequestHandler();

            while (true) 
            {
                
                output.DisplayOptions();
                
                request.Request();
                

            }
            

            

        }
    }
}