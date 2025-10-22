using System;

namespace Xenforo.Api
{
    public class XenforoConfig
    {
        public string EndpointUrl { get; private set; }

        public string ApiKey { get; private set; }

        public XenforoConfig(string endpointUrl, string apiKey)
        {
            EndpointUrl = endpointUrl;
            ApiKey = apiKey;
        }
    }
}
