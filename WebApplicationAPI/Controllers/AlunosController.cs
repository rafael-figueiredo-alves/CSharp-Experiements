using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationAPI.Models;
using WebApplicationAPI.Services;

namespace WebApplicationAPI.Controllers
{
	public class Erro
	{
		public string? Mensagem { get; set; }
	}
	[Route("v1/api/[controller]")]
	[ApiController]
	public class AlunosController : ControllerBase
	{
		private IAlunos alunosManager = new Alunos();

		[HttpGet("{id}")]
		public ActionResult<Aluno> GetAluno(int id)
		{
			Aluno? aluno;

            try
			{
				aluno = alunosManager!.GetAluno(id);
            }
			catch (Exception ex)
			{
                var erro = new Erro()
                {
                    Mensagem = "Id inválido"
                };
                return BadRequest(erro);
            }
            if (aluno != null)
            {
                return Ok(aluno);
            }
			else
			{
				return BadRequest(new Erro() { Mensagem = "Id inválido 2" });
			}
        }

		[HttpGet("lista")]
		public ActionResult<List<Aluno>> GetAlunos()
		{
			return alunosManager!.GetAlunos();
		}
	}
}
