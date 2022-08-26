using Newtonsoft.Json;
using System.Collections.Generic;

namespace SCTModel;

[JsonObject]
public record DeepLResponse
{
    [JsonConstructor]
    public DeepLResponse(IReadOnlyList<DeepLTranslation> translations) => this.Translations = translations;

    [JsonProperty("translations")]
    public IReadOnlyList<DeepLTranslation> Translations { get; }
}

[JsonObject("translations")]
public record DeepLTranslation
{
    [JsonConstructor]
    public DeepLTranslation(string sourceLanguage, string text)
    {
        this.SourceLanguage = sourceLanguage;
        this.Text = text;
    }

    [JsonProperty("detected_source_language")]
    public string SourceLanguage { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }
}
