using Microsoft.AspNetCore.Mvc;
using TeiaWebApi.Core;

namespace TeiaWebApi.Controllers;

[Route("api/manipulacao-string")]
[ApiController]
public class StringHandlerController : ControllerBase
{
    /// <summary>
    /// Handles the incoming POST request with JSON input.
    /// </summary>
    /// <param name="input">The JSON input containing the text to be handled.</param>
    /// <returns>The result of handling the input text.</returns>
    [HttpPost]
    public IActionResult Post(JSONInput? input)
    {
        if (input is not null)
        {
            var response = StringHandler.HandleString(input.Texto!);
            return Ok(response);
        }
        else
        {
            return BadRequest();
        }
    }
}
