using System.Text.Json.Serialization;

namespace BlazorProj.ViewModels;

public class StartItemViewModel
{
    [JsonPropertyName("path")]
    public string Path { get; set; }
}