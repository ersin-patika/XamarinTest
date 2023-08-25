using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SecureSafe.Services
{
    public interface IDataStore<T>
    {
        Task<T> GetItemAsync(int id);
        Task<IEnumerable<T>> GetItemsAsync();
    }
}

