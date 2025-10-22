using Newtonsoft.Json;
using Xenforo.Api.Entities;

namespace Xenforo.Api.Models
{
    public class AuthResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        public bool Valid
        {
            get => Success && Errors == null && User != null;
        }
    }
}
