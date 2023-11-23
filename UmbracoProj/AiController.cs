using System.Runtime.Serialization;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using OpenAI.API;
using Umbraco.Cms.Web.Common.Controllers;

namespace CycleHack;

public class AiController : UmbracoApiController
{
    private readonly string _apiKey;
    public AiController(IConfiguration configuration)
    {
        _apiKey = configuration.GetValue<string>("OpenAI:ApiKey");
    }
    public async Task<IActionResult> GetRecipe(AiText input)
    {
        var recipe = await GetOpenAIText(input.Text);
        return Ok(recipe);
    }
    
    private string GetRecipePrompt(string input)
    {
        return $"I'd like you to create a recipe for {input}. the recipe should be a json object. There should be a title property which is a string, the ingredients are an [] of object {{ name: string, amount: string }}, and instructions are a string with property name instructions. please use double quotes around all strings and not single quotes.";
    }
    
    private async Task<Recipe> GetOpenAIText(string input) 
    {
        OpenAIAPI client = new OpenAIAPI(_apiKey);
        var response = await client.Completions.CreateCompletionAsync(GetRecipePrompt(input), max_tokens: 1000);
        var result = response.Completions[0].Text;
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        var recipe = JsonSerializer.Deserialize<Recipe>(result, options);
        return recipe;
    }
}


public class Recipe
{
    public string Title { get; set; }
    
    public List<Ingredient> Ingredients { get; set; }
    
    public string Instructions { get; set; }
}

public class Ingredient
{
    public string Name { get; set; }
    
    public string Amount { get; set; }
}

[DataContract]
public class AiText
{
    [DataMember(Name = "text")]
    public string Text { get; set; }
}


