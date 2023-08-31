using System.Text.Json.Serialization;

namespace BlazorProj.ViewModels;

public class HomePagePropertyViewModel
{
    
    [JsonPropertyName("header")]
    public string? Header { get; set; }
        
    [JsonPropertyName("recipes")]
    public RecipeViewModel[] Recipes { get; set; }
}