using Newtonsoft.Json;
using System.Collections.Generic;

namespace CRUDWithRestAPI.Data
{
    public class Response
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("data")]
        public List<User> Users { get; set; }
    }
}
