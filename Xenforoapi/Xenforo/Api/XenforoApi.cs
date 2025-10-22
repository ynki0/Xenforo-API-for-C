using System;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using Xenforo.Api.Models;
using Xenforo.Api.Entities;

namespace Xenforo.Api
{
    public class XenforoApi
    {
        private readonly XenforoConfig _config;

        private readonly IRestClient _client;

        public XenforoApi(XenforoConfig config)
        {
            if (config == null)
                throw new ArgumentNullException("Invalid config passed to XenforoApi constructor");

            _config = config;
            _client = new RestClient(config.EndpointUrl);
            _client.UseNewtonsoftJson();
        }

        public User AuthenticateFromSession(string sessionId, string rememberCookie)
        {
            if (string.IsNullOrEmpty(sessionId) || string.IsNullOrEmpty(rememberCookie))
                throw new Exception("Invalid parameter(s)");

            var request = new RestRequest("auth/from-session", Method.POST);
            request.AddHeader("XF-Api-Key", _config.ApiKey);
            request.AddParameter("session_id", sessionId);
            request.AddParameter("remember_cookie", rememberCookie);

            var response = _client.Post(request);
            if (!response.IsSuccessful)
                throw new Exception("POST failed");

            var data = JsonConvert.DeserializeObject<AuthResult>(response.Content);
            if (!data.Valid)
                throw new Exception("Result was invalid");

            return data.User;
        }

        public User Authenticate(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                throw new Exception("Invalid parameter(s)");

            var request = new RestRequest("auth/", Method.POST);
            request.AddHeader("XF-Api-Key", _config.ApiKey);
            request.AddParameter("login", login);
            request.AddParameter("password", password);

            var response = _client.Post(request);
            if (!response.IsSuccessful)
                throw new Exception("POST failed");

            var data = JsonConvert.DeserializeObject<AuthResult>(response.Content);
            if (!data.Valid)
                throw new Exception("Result was invalid");

            return data.User;
        }

        public User FindUserById(uint id)
        {
            var request = new RestRequest("users/" + id, Method.GET);
            request.AddHeader("XF-Api-Key", _config.ApiKey);
            request.AddParameter("with_posts", false);
            request.AddParameter("page", 0);

            var response = _client.Post(request);
            if (!response.IsSuccessful)
                throw new Exception("GET failed");

            var data = JsonConvert.DeserializeObject<AuthResult>(response.Content);
            if (!data.Valid)
                throw new Exception("Result was invalid");

            return data.User;
        }
    }
}
