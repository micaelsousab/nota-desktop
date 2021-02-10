using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BackEnd.Entidades;
using BackEnd.Dados;

namespace BackEnd.Repositorios
{
	class RepositorioServico
	{
		private NotaContext db = new NotaContext();
		public Servico cadastrarServico(Servico servico)
		{
			db.Add(servico);
			db.SaveChanges();

			return db.Servicos.OrderByDescending(s => s.ServicoId).First();
		}

		public List<Servico> buscarServicosNomeCliente(string nomeCliente)
		{
			return db.Servicos.Where(s => s.Cliente.Nome.Contains(nomeCliente)).ToList();
		}

		public List<Servico> buscarServicosTelefoneFixoCliente(string telefoneFixoCliente)
		{
			return db.Servicos.Where(s => s.Cliente.TelefoneFixo.StartsWith(telefoneFixoCliente)).ToList();
		}
		
		public List<Servico> buscarServicosTelefoneCelularCliente(string telefoneCelularCliente)
		{
			return db.Servicos.Where(s => s.Cliente.TelefoneCelular.StartsWith(telefoneCelularCliente)).ToList();
		}
	}
}
