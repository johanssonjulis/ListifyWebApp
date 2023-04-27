using Microsoft.Azure.Cosmos;

namespace ListifyWebApp.DataAccess
{
    public class InitDB
    {
        public InitDB() { }

        public void Init() 
        {
            string endpointUri = "https://localhost:7277/"; // Där ligger min CosmosDB-server
            string primaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw=="; // Den är den hemliga nyckeln som authentiserar mig mot servern

            CosmosClient client = new CosmosClient(endpointUri, primaryKey); // Här skapar jag en klient, som kan "prata" med databasen.

            string databaseName = "ListifyDB";
            string containerName = "Listify";

            DatabaseResponse database = client.CreateDatabaseIfNotExistsAsync(databaseName).GetAwaiter().GetResult(); // skapar databasen om den inte finns, synkront (i samma tråd som resten av applikationen kör)

            var container = database.Database.CreateContainerIfNotExistsAsync(containerName, "/partitionKey").GetAwaiter().GetResult(); // exakt samma sak för containern


        }

    }
}
