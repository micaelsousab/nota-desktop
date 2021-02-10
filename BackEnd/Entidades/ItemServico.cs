using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Entidades
{
	public class ItemServico
	{
		public int ItemServicoId { get; set; }
		public string Descricao { get; set; }
		public double Valor { get; set; }

		public int ServicoId { get; set; }
		public Servico Servico { get; set; }
	}
}
