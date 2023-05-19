using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationAPI.Models
{
	public class Aluno
	{
		[Required]
		public int Id { get; set; }
		[MaxLength(40, ErrorMessage = "Tamanho máximo 40 caracteres")]
		[MinLength(1, ErrorMessage = "Tamanh mínimo 1 caracter")]
		public string Nome { get; set; } = "tese";
		public int Idade { get; set; }
		public bool Ativo { get; set; } = false;

	}
}
