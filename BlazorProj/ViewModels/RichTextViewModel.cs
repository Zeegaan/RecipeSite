using System.Text.Json.Serialization;

namespace BlazorProj.ViewModels;

public class RichTextViewModel
{
    [JsonPropertyName("markup")]
    public string Markup { get; set; }
}