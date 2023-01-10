using Newtonsoft.Json;

namespace Youbike.Models;

public class YoubikeData
{

    [JsonProperty("sno")]
    public string? Sno { get; set; }

    [JsonProperty("sna")]
    public string Sna { get; set; } = null!;

    [JsonProperty("tot")] public string Tot { get; set; } = "";

    [JsonProperty("sbi")] public string Sbi { get; set; } = "";

    [JsonProperty("sarea")] public string Sarea { get; set; } = "";

    [JsonProperty("mday")] public string Mday { get; set; } = "";

    [JsonProperty("lat")] public string Lat { get; set; } = "";

    [JsonProperty("lng")] public string Lng { get; set; } = "";

    [JsonProperty("ar")] public string Ar { get; set; } = "";

    [JsonProperty("sareaen")] public string Sareaen { get; set; } = "";

    [JsonProperty("snaen")] public string Snaen { get; set; } = "";

    [JsonProperty("aren")] public string Aren { get; set; } = "";

    [JsonProperty("bemp")] public string Bemp { get; set; } = "";

    [JsonProperty("act")] public string Act { get; set; } = "";
}

