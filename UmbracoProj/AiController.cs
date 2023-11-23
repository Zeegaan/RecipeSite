using System.Runtime.Serialization;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.Controllers;

namespace CycleHack;

public class AiController : UmbracoApiController
{
    public IActionResult GetRecipe(AiText input)
    {
        string myString = input.Text;
        return Ok();
    }
}

[DataContract]
public class AiText
{
    [DataMember(Name = "text")]
    public string Text { get; set; }
}


