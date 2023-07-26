using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAsService
{
    public static class Util
    {
        private const string APP_SET_KEY_ENDPOINT_API = "EndpointCatAPI";
        private const string APP_SET_KEY_ENDPOINT_API_BREEDS = "EndpointCatAPIBreeds";
        private const string APP_SET_KEY_ENDPOINT_API_SEARCH_BREED = "EndpointCatAPISearchBreed";

        private static string EndpointAPI
        {
            get
            {
                return ConfigurationManager.AppSettings[APP_SET_KEY_ENDPOINT_API];
            }
        }

        public static string EndpointAPIBreeds
        {
            get
            {
                return EndpointAPI + ConfigurationManager.AppSettings[APP_SET_KEY_ENDPOINT_API_BREEDS];
            }
        }

        public static string GetEndpointAPISearchBreed(string breedId)
        {
            return string.Format(EndpointAPI + ConfigurationManager.AppSettings[APP_SET_KEY_ENDPOINT_API_SEARCH_BREED], breedId);
        }
    }
}
