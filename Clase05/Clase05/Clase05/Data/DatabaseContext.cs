using Clase05.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Data
{
    public class DatabaseContext
    {
        public SQLiteAsyncConnection Connection { get; }
        public DatabaseContext(string dbPath)
        {
            Connection = new SQLiteAsyncConnection(dbPath);
            Connection.CreateTableAsync<TaskToDo>().Wait();
        }

        public async Task<int> InsertItemAsync(TaskToDo item)
        {
            return await Connection.InsertAsync(item);
        }
        public async Task<List<TaskToDo>> GetItemsAsync()
        {
            return await Connection.Table<TaskToDo>().ToListAsync();
        }

        //DELETE de TAREA
        public async Task<int> DeleteItemAsync(TaskToDo item)
        {
            return await Connection.DeleteAsync(item);
        }


    }
}
