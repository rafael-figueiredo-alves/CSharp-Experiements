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
    [ApiVersion("1.0")]
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

        [HttpPost]
        public ActionResult<List<Aluno>> PostAluno([FromBody] Aluno aluno)
        {
            alunosManager.AddAluno(aluno);
            return Ok(alunosManager!.GetAlunos());
        }

        [HttpPut]
        public ActionResult<List<Aluno>> PutAluno([FromBody] Aluno aluno)
        {
            alunosManager.UpdateAluno(aluno);
            return Ok(alunosManager!.GetAlunos());
        }

        [HttpPatch]
        public ActionResult<List<Aluno>> PatchAluno([FromBody] Aluno aluno)
        {
            alunosManager.UpdateAluno(aluno);
            return Ok(alunosManager!.GetAlunos());
        }

        [HttpDelete("{id}")]
        public ActionResult<List<Aluno>> DeleteAluno(int id)
        {
            alunosManager.DeleteAluno(id);
            return Ok(alunosManager!.GetAlunos());
        }
    }

    [ApiVersion("2.0")]
    [Route("v2/api/[controller]")]
    [ApiController]
    public class AlunosV2Controller : ControllerBase
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

        [HttpPost]
        public ActionResult<List<Aluno>> PostAluno([FromBody] Aluno aluno)
        {
            alunosManager.AddAluno(aluno);
            return Ok(alunosManager!.GetAlunos());
        }

        [HttpPut]
        public ActionResult<List<Aluno>> PutAluno([FromBody] Aluno aluno)
        {
            alunosManager.UpdateAluno(aluno);
            return Ok(alunosManager!.GetAlunos());
        }

        [HttpPatch]
        public ActionResult<List<Aluno>> PatchAluno([FromBody] Aluno aluno)
        {
            alunosManager.UpdateAluno(aluno);
            return Ok(alunosManager!.GetAlunos());
        }

        [HttpDelete("{id}")]
        public ActionResult<List<Aluno>> DeleteAluno(int id)
        {
            alunosManager.DeleteAluno(id);
            return Ok(alunosManager!.GetAlunos());
        }
    }
}
