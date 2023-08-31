using System.Text.Json.Serialization;

namespace BlazorProj.ViewModels;

public class RecipeViewModel
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
        
    [JsonPropertyName("route")]
    public RouteViewModel RouteViewModel { get; set; }
        
    [JsonPropertyName("properties")]
    public RecipePropertiesViewModel PropertiesViewModel { get; set; }
}