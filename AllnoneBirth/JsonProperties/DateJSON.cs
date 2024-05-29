using System.ComponentModel;
using Newtonsoft.Json;

namespace AllnoneBirth.JsonProperties;

public class DateJSON
{
    [JsonProperty("date")]
    [DefaultValue("01.01.2000")]
    public string Date { get; set; }
}