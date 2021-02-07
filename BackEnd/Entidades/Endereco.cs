using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Entidades
{
	class Endereco
	{
		public string UF { get; set; }
		public string Cidade { get; set; }
		public string Bairro { get; set; }
		public int Numero { get; set; }
		public string? LinhaEndereco { get; set; }
	}
}
