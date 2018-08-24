using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _5eCharacterBuilder.StandardCore.Data
{
    public interface IDbContext
    {
        Task CreateOrUpdateTable<T>() where T : class, IEntity, new();
        Task<T> GetItemAsync<T>(int id) where T : class, IEntity, new();
        Task<int> SaveItemAsync<T>(T item) where T : class, IEntity, new();
        Task<int> DeleteItemAsync<T>(T item) where T : class, IEntity, new();
    }
}
