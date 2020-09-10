using Newtonsoft.Json;
using System;

namespace CRUDWithRestAPI.Data
{
    public class CRUDUser
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedTimestamp { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedTimestamp { get; set; }
    }
}
