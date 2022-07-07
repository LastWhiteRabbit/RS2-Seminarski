using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.WinUI
{
    public class APIService
    {
        private string _resource = null;
        public string _endpoint = "http://localhost:5113/api/";
        public APIService(string resource)
        {
            _resource = resource;
        }

        public async Task<T> Get<T>()
        {
            var list = await $"{_endpoint}{_resource}".GetJsonAsync<T>();

            return list;
        }
        public async Task<T> GetById<T>(object id)
        {
            var result = await $"{_endpoint}{_resource}/{id}".GetJsonAsync<T>();

            return result;
        }

    }
}
