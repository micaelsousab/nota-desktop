using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Entidades
{
	class Servico
	{
		private Guid id;
		public Guid Id
		{
			get
			{
				if (id == null)
				{
					id = Guid.NewGuid();
				}
				return id;
			}
			set {
				if (id == null)
				{
					id = value;
				}
			}
		}

		private DateTime dataRegistro;
		public DateTime DataRegistro
		{
			get
			{
				if (dataRegistro == null)
				{
					dataRegistro = DateTime.Now;
				}
				return dataRegistro;
			}
			set {
				if (dataRegistro == null)
				{
					dataRegistro = value;
				}
			}
		}

		public Cliente Cliente { get; set; }
		public IList<ItemServico> Itens { get; set; }
		public DateTime PrevisaoEntrega { get; set; }
		public double ValorTotal { get; set; }
		public double ValorAdiantamento { get; set; }
		public double ValorDevido => ValorTotal - ValorAdiantamento;
		public string? Observacoes { get; set; }

		public Servico(Cliente cliente, List<ItemServico> itens, DateTime previsaoEntrega, double valorTotal, double valorAdiantamento = 0, string? observacoes = null)
		{
			Id = Guid.NewGuid();
			DataRegistro = DateTime.Now;
			Cliente = cliente;
			Itens = itens;
			PrevisaoEntrega = previsaoEntrega;
			ValorTotal = valorTotal;
			ValorAdiantamento = valorAdiantamento;
			Observacoes = observacoes;
		}
		public Servico(Guid id, DateTime dataRegistro)
		{
			Id = id;
			DataRegistro = dataRegistro;
		}
		public Servico()
		{
			Id = Guid.NewGuid();
			DataRegistro = DateTime.Now;
		}
	}
}
