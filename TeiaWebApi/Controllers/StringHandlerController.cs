using Microsoft.AspNetCore.Mvc;
using TeiaWebApi.Core;

namespace TeiaWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StringHandlerController : ControllerBase
{
    /// <summary>
    /// Handles the incoming string input.
    /// </summary>
    /// <param name="input">The input string to be handled.</param>
    /// <returns>The response from handling the input string.</returns>
    [HttpPost]
    public IActionResult Post(HandlerInput input)
    {
        var stringHandler = new StringHandler();
        var response = stringHandler.HandleString(input);
        return Ok(response);
    }

}
