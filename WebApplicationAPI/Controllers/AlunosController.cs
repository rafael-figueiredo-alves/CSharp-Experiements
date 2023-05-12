using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Controllers
{
	[Route("v1/api/[controller]")]
	[ApiController]
	public class AlunosController : ControllerBase
	{
		[HttpGet]
		public ActionResult<Aluno> GetAluno()
		{
			return new Aluno() { Id = 1, Nome = "Rafaela" };
		}

		[HttpGet("lista")]
		public ActionResult<List<Aluno>> GetAlunos()
		{
			List<Aluno> Lista = new()
			{
				new Aluno() { Id = 1, Nome = "Davi Alves" },
				new Aluno() { Id = 2, Nome = "Rafaela" },
				new Aluno() { Id = 3, Nome = "Jailza" }
			};
			return Lista;
		}
	}
}
