using Newtonsoft.Json;
using AllnoneBirth.Data;

namespace AllnoneBirth.JsonProperties;

public class ChooseLang
{
    /*[JsonProperty("language", Required = Required.Always)]
    public Languages.SupportedLanguage Language { get; set; }*/

    [JsonProperty("symbolAmount", Required = Required.Always)]
    public int SymbolAmount { get; set; }
}
