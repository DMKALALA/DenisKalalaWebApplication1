# Project Overview

This project is a simple web API built with ASP.NET Core. It includes a controller that handles HTTP requests and returns responses in JSON format.

## Code Overview

### Controller

The `MyController.cs` file contains the main logic for handling API requests. It includes methods for GET, POST, PUT, and DELETE operations.

```csharp
using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("GET request successful");
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok("POST request successful");
        }

        [HttpPut]
        public IActionResult Put([FromBody] string value)
        {
            return Ok("PUT request successful");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("DELETE request successful");
        }
    }
}
