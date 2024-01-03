using Microsoft.AspNetCore.Mvc;
using OSOS_Test_Solution.Services;

namespace OSOS_Test_Solution.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WordTransformController : ControllerBase
    {
        private readonly IWordTransformService _wordTransformService;

        public WordTransformController(IWordTransformService wordTransformService)
        {
            _wordTransformService = wordTransformService;
        }

        [HttpGet(Name = "GetTransformedWord")]
        public IActionResult Transform(string stringValue)
        {
            try
            {
                string transformedString = _wordTransformService.Transform(stringValue);
                return Ok(transformedString);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}
