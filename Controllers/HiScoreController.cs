using Microsoft.AspNetCore.Mvc;
using webapiplayground.Models;

namespace webapiplayground.Controllers
{
	[Route("api/[controller]")]
	public class HiScoreController : Controller
	{
		public HiScoreController(HiScoreContext hiScore)
		{
			_hiScore = hiScore;
		}

        [HttpGet]
        public string Get()
        {
            return "test";
        }

		private readonly HiScoreContext _hiScore;
	}
}