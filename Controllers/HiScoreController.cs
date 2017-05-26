using System;
using System.Linq;
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

        [HttpGet("{page=0}")]
        public IActionResult Get(int page)
        {
			const int pageSize = 20;
            return Json(_hiScore.score
							.OrderByDescending(s => s.score)
							.Skip(page * pageSize)
							.Take(pageSize));
        }

		[HttpPost]
		public IActionResult Post([FromBody]Score score)
		{
			if (score == null)
			{
				throw new ArgumentNullException("score");
			}
 			if (string.IsNullOrEmpty(score.Player))
			{
				throw new ArgumentNullException("Player");
			}
			if (score.score < 0)
			{
				throw new ArgumentException("Score can't be negative");
			}

			int playerHiScore = score.score;
			var dbScore = _hiScore.score
				.Where(s => s.Player == score.Player)
				.FirstOrDefault();

			if (dbScore == null)
			{
				_hiScore.Add(score);
			}
			else
			{
				if (dbScore.score < score.score)
				{
					dbScore.score = score.score;
				}
				else
				{
					playerHiScore = dbScore.score;
				}
			}

			_hiScore.SaveChanges();

			return Json(playerHiScore);
		}

		private readonly HiScoreContext _hiScore;
	}
}