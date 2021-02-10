using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Entidades
{
	public class Endereco
	{
		public int EnderecoId { get; set; }
		public string UF { get; set; }
		public string Cidade { get; set; }
		public string Bairro { get; set; }
		public int Numero { get; set; }
		public string? LinhaEndereco { get; set; }
	}
}
