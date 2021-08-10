using Newtonsoft.Json;
namespace PizaService.Core
{
public class ToppingConfiguration
    {
        [JsonProperty("toppings")]
        public string[] Toppings { get; set; }
    }
}