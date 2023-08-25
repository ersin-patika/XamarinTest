using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SecureSafe.Services
{
	public class AnotherService : IDataStore<AnotherService>
	{
		public AnotherService()
		{
			// When needed another data source
		}

        Task<AnotherService> IDataStore<AnotherService>.GetItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<AnotherService>> IDataStore<AnotherService>.GetItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}

