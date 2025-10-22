using Newtonsoft.Json;

namespace Xenforo.Api.Models
{
    public class Error
    {
        /// <summary>
        /// This is a machine readable code for the error. There are many possible error codes as they are situation dependent
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// A human readable version of the error. This may change or may be translated and should not be used to identify the type of error
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
