using System.Collections.Concurrent;
using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using static ListifyWebApp.DataAccess.IRepository;
using Microsoft.Azure.Cosmos;

namespace ListifyWebApp.DataAccess
{
    public class CosmosDBRepository<T> : IRepository<T> where T : class
    {
        private readonly Container _container;

        public CosmosDBRepository(Container c)
        {
            _container = c;
        }

        public async Task<T> GetByIdAsync(string id)
        {
            var query = new QueryDefinition("SELECT * FROM c WHERE c.id = @id")
                .WithParameter("@id", id);
            var iterator = _container.GetItemQueryIterator<T>(query);
            while (iterator.HasMoreResults)
            {
                var response = await iterator.ReadNextAsync();
                return response.FirstOrDefault();
            }
            throw new Exception("Not Found.");
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var query = new QueryDefinition("SELECT * FROM c");
            var results = new List<T>();
            var iterator = _container.GetItemQueryIterator<T>(query);
            while (iterator.HasMoreResults)
            {
                var response = await iterator.ReadNextAsync();
                results.AddRange(response.ToList());
            }
            return results;
        }

        public async Task AddAsync(T entity)
        {
            await _container.CreateItemAsync(entity);
        }

        public async Task UpdateAsync(string id, T entity)
        {
            await _container.ReplaceItemAsync(entity, id);
        }

        public async Task DeleteAsync(string id)
        {
            await _container.DeleteItemAsync<T>(id, PartitionKey.None);
        }
    }
}
