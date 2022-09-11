using Flurl.Http;
using RS2Seminarski.Model;
using RS2Seminarski.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.WinUI.Services
{
    public class APIService
    {
        private string _resource = null;
        public string _endpoint = Settings.Default.ApiURL;

        public static string Username = null;
        public static string Password = null;
        public APIService(string resource)
        {
            _resource = resource;
        }

        public async Task<T> Get<T>(object search = null)
        {
            var query = "";
            if (search != null)
            {
                query = await search.ToQueryString();
            }

            var list = await $"{_endpoint}{_resource}?{query}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return list;
        }
        public async Task<T> GetById<T>(object id)
        {
            var result = await $"{_endpoint}{_resource}/{id}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> Post<T>(object request)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}".WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();

                return result;
            }
            catch (FlurlHttpException ex)
            {

                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }

        }
        public async Task<T> Put<T>(object id, object request)
        {
            var result = await $"{_endpoint}{_resource}/{id}".WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();

            return result;
        }

    }
}
