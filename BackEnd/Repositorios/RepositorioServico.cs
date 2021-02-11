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
		private NotaContext _db = new NotaContext();

		public Servico cadastrarServico(Servico servico)
		{
			_db.Add(servico);
			_db.SaveChanges();

			return _db.Servicos.OrderByDescending(s => s.ServicoId).First();
		}

		public List<Servico> buscarServicosNomeCliente(string nomeCliente)
		{
			return _db.Servicos.Where(s => s.Cliente.Nome.Contains(nomeCliente)).ToList();
		}

		public List<Servico> buscarServicosTelefoneFixoCliente(string telefoneFixoCliente)
		{
			return _db.Servicos.Where(s => s.Cliente.TelefoneFixo.StartsWith(telefoneFixoCliente)).ToList();
		}
		
		public List<Servico> buscarServicosTelefoneCelularCliente(string telefoneCelularCliente)
		{
			return _db.Servicos.Where(s => s.Cliente.TelefoneCelular.StartsWith(telefoneCelularCliente)).ToList();
		}
	}
}
