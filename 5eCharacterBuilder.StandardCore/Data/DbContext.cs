using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _5eCharacterBuilder.StandardCore.Data
{
    public class DbContext : IDbContext
    {

        private readonly SQLiteAsyncConnection _database;
        public DbContext(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath, SQLiteOpenFlags.Create |
                                                  SQLiteOpenFlags.ReadWrite |
                                                  SQLiteOpenFlags.FullMutex);
        }
        public Task CreateOrUpdateTable<T>() where T : IEntity, new() 
        {
            return _database.CreateTableAsync<T>();
        }

        Task<int> IDbContext.DeleteItemAsync<T>(T item)
        {
            return _database.DeleteAsync(item);
        }

        Task<T> IDbContext.GetItemAsync<T>(int id)
        {
            return _database.Table<T>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        Task<int> IDbContext.SaveItemAsync<T>(T item)
        {
            return item.Id == 0 ? _database.InsertAsync(item) : _database.UpdateAsync(item);
        }
    }
}
