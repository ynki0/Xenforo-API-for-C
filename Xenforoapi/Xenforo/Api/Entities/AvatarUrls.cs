using Newtonsoft.Json;

namespace Xenforo.Api.Entities
{
    public class AvatarUrls
    {
        /// <summary>
        /// Avatar URL 384x384
        /// </summary>
        [JsonProperty("o")]
        public string O { get; set; }

        /// <summary>
        /// Avatar URL 384x384
        /// </summary>
        [JsonProperty("h")]
        public string H { get; set; }

        /// <summary>
        /// Avatar URL 192x192
        /// </summary>
        [JsonProperty("l")]
        public string L { get; set; }

        /// <summary>
        /// Avatar URL 96x96
        /// </summary>
        [JsonProperty("m")]
        public string M { get; set; }

        /// <summary>
        /// Avatar URL 48x48
        /// </summary>
        [JsonProperty("s")]
        public string S { get; set; }
    }
}
