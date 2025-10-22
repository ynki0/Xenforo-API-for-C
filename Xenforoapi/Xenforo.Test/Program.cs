using System;
using Xenforo.Api;

namespace Xenforo.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Create config
            var xenforoConfig = new XenforoConfig("https://domain.com/api", "<api key>");

            // Create Api
            var xenforoApi = new XenforoApi(xenforoConfig);

            // Login with credentials
            var userFromCredentials = xenforoApi.Authenticate("<username>", "<password>");

            // Login with cookies (you must retrieve one of theses keys yourself!)
            var userFromCookie = xenforoApi.AuthenticateFromSession("<xf_session>", "<xf_user>");

            // Find user by ID
            var userById = xenforoApi.FindUserById(1);

            Console.ReadKey();
        }
    }
}
