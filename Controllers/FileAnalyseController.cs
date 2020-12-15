using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using file_metadata.Models;

namespace file_metadata.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class FileAnalyseController : ControllerBase
	{
		[HttpPost]
		public IActionResult Index([FromForm] IFormFile upfile)
		{
			FileMetadata data;
			try
			{
				data = new FileMetadata
				{
					Name = upfile.FileName,
					Size = upfile.Length,
					Type = upfile.ContentType
				};
			}
			catch (Exception)
			{
				return BadRequest();
			}

			return Ok(data);
		}
	}
}