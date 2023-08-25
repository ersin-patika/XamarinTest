using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Essentials;

using NUnit.Framework.Interfaces;
using SecureSafe.Models;
using System.Diagnostics;

namespace SecureSafe.Services
{

    /// <summary>
	/// Punk API service.
	/// </summary>
    /// 
	public class BeerService : IDataStore<BeerModel>
    {

		private const string BaseUrl = "https://api.punkapi.com/v2/";
        

        List<BeerModel> beerModels=new List<BeerModel>();

        public BeerService()
        {

            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                // network disconnected , open Dialog for message                
                //return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetStringAsync(BaseUrl + "beers");                    
                    beerModels = JsonConvert.DeserializeObject<List<BeerModel>>(response.Result.ToString());                    
                }
            }
            catch (Exception ex)
            {
                Utils.Logger.Log(ex, "BeerService");
                //Debug.WriteLine(ex);                
            }
        }
   

        /// <summary>
		/// Lists beers asynchronously.
		/// </summary>
		/// <returns>A list of beers.</returns>
		/// <param name="id">Specific beer id.</param>		
        /// 
        public async Task<BeerModel> GetItemAsync(int id)
        {            
            return await Task.FromResult(beerModels.FirstOrDefault(s => s.Id == id));
        }

        /// <summary>
        /// Lists all beers asynchronously.
        /// </summary>
        /// <returns>A list of beers.</returns>        
        public async Task<IEnumerable<BeerModel>> GetItemsAsync()
        {
            return await Task.FromResult(beerModels);
        }

	}
}

