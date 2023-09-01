using System.Text.Json.Serialization;

namespace BlazorProj.ViewModels;

public class RecipePropertiesViewModel
{
    [JsonPropertyName("title")]
    public string Title { get; set; }
        
    [JsonPropertyName("image")]
    public ImageViewModel[] Images { get; set; }
    
    [JsonPropertyName("ingredients")]
    public string[] Ingredients { get; set; }
    
    [JsonPropertyName("recipeSteps")]
    public RichTextViewModel RecipeSteps { get; set; }
    
    [JsonPropertyName("teaserText")]
    public string TeaserText { get; set; }
}