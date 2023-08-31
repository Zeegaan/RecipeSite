using System.Text.Json.Serialization;

namespace BlazorProj.ViewModels;

public class ImageViewModel
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
        
    [JsonPropertyName("url")]
    public string Url { get; set; }
}