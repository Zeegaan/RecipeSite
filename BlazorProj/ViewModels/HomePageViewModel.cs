using System.Text.Json.Serialization;

namespace BlazorProj.ViewModels;


public class HomePageViewModel
{
    [JsonPropertyName("properties")]
    public HomePagePropertyViewModel Properties { get; set; }
}