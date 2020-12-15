using Microsoft.AspNetCore.Mvc;

namespace file_metadata.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class FileAnalyseController : ControllerBase
	{
		// GET
		public IActionResult Index()
		{
			return Ok();
		}
	}
}