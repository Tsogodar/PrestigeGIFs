using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace PG2
{
    class API
    {
        public dynamic getData(string apiPath)
        {
            var publicFilesRequest = new HttpClient().GetAsync("http://localhost:3000/files" + apiPath).Result;
            var response = publicFilesRequest.Content.ReadAsStringAsync().Result;
            var responseJson = JsonConvert.DeserializeObject<dynamic>(response);
            return responseJson;
        }

        public string register(string login,string password)
        {
            var registerFormData = new Dictionary<string, string>
            {
                { "login", login },
                { "password", password }
            };
            var creds = new FormUrlEncodedContent(registerFormData);
            var registerRequest = new HttpClient().PostAsync("http://localhost:3000/auth/register", creds).Result;
            var response = registerRequest.Content.ReadAsStringAsync().Result;
            return response;
        }

        public string login(string login, string password)
        {
            bool loginStatus = false;
            var loginFormData = new Dictionary<string, string>
            {
                { "login", login },
                { "password", password }
            };
            var creds = new FormUrlEncodedContent(loginFormData);
            var loginRequest = new HttpClient().PostAsync("http://localhost:3000/auth/login", creds).Result;
            var response = loginRequest.Content.ReadAsStringAsync().Result;
            return response;
        }

        public string saveFileData(string owner, string filename,string scope)
        {
            var fileData = new Dictionary<string, string>
            {
                { "owner", owner },
                { "filename", filename },
                { "scope",scope }
            };
            var saveFileRequest = new HttpClient().PostAsync("http://localhost:3000/files/add", new FormUrlEncodedContent(fileData)).Result;
            var response = saveFileRequest.Content.ReadAsStringAsync().Result;
            return response;
        }

        public string exists(string owner, string filename)
        {
            var fileData = new Dictionary<string, string>
            {
                { "owner", owner },
                { "filename", filename }
            };
            var saveFileRequest = new HttpClient().PostAsync("http://localhost:3000/files/exists", new FormUrlEncodedContent(fileData)).Result;
            var response = saveFileRequest.Content.ReadAsStringAsync().Result;
            return response;
        }
    }
}
