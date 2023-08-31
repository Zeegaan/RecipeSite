using System.Text.Json.Serialization;

namespace BlazorProj.ViewModels;

public class RecipePropertiesViewModel
{
    [JsonPropertyName("title")]
    public string Title { get; set; }
        
    [JsonPropertyName("image")]
    public ImageViewModel[] Images { get; set; }
}