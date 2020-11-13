using Newtonsoft.Json;

namespace ProPublicaCongressAPI.InternalModels
{
    internal class SpecificBillDetailSubject
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url_name")]
        public string UrlName { get; set; }
    }
}