using Newtonsoft.Json;

namespace Xenforo.Api.Entities
{
    public class User
    {
        [JsonProperty("avatar_urls")]
        public AvatarUrls AvatarUrls { get; set; }

        [JsonProperty("custom_title")]
        public string CustomTitle { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("is_admin")]
        public bool IsAdmin { get; set; }

        [JsonProperty("is_discouraged")]
        public bool IsDiscouraged { get; set; }

        [JsonProperty("is_moderator")]
        public bool IsModerator { get; set; }

        [JsonProperty("is_staff")]
        public bool IsStaff { get; set; }

        [JsonProperty("is_super_admin")]
        public bool IsSuperAdmin { get; set; }

        [JsonProperty("last_activity")]
        public int LastActivity { get; set; }

        [JsonProperty("register_date")]
        public int RegisterDate { get; set; }

        [JsonProperty("secondary_group_ids")]
        public int[] SecondaryGroupIds { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("user_group_id")]
        public int UserGroupId { get; set; }

        [JsonProperty("user_id")]
        public uint? UserId { get; set; }

        [JsonProperty("user_state")]
        public string UserState { get; set; }

        [JsonProperty("user_title")]
        public string UserTitle { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("view_url")]
        public string ViewUrl { get; set; }

        public bool IsGuest
        {
            get => UserId == null || UserId.Equals(0) || string.IsNullOrEmpty(Username);
        }
    }
}
