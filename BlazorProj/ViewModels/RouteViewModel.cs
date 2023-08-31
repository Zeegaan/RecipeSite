using System.Text.Json.Serialization;

namespace BlazorProj.ViewModels;

public class RouteViewModel
{
    [JsonPropertyName("path")]
    public string Path { get; set; }
        
    [JsonPropertyName("startItem")]
    public StartItemViewModel StartItemViewModel { get; set; }
}