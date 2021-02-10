using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Entidades
{
	public class Servico
	{
		public int ServicoId { get; set; }
		public DateTime DataRegistro { get; set; }
		public DateTime PrevisaoEntrega { get; set; }
		public double ValorTotal { get; set; }
		public double ValorAdiantamento { get; set; }
		public string? Observacoes { get; set; }

		public int ClienteId { get; set; }
		public Cliente Cliente { get; set; }

		public List<ItemServico> ItensServico { get; } = new List<ItemServico>();

		public double ValorDevido => ValorTotal - ValorAdiantamento;
	}
}
