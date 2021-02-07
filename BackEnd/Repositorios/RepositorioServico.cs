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
		public Servico cadastrarServico(Servico servico)
		{
			return DadosServicos.criarServico(servico);
		}

		public List<Servico> buscarServicosNomeCliente(string nomeCliente)
		{
			return DadosServicos.query().Where(servico => servico.Cliente.Nome.Contains(nomeCliente)).ToList();
		}

		public List<Servico> buscarServicosTelefoneFixoCliente(string telefoneFixoCliente)
		{
			return DadosServicos.query().Where(servico => servico.Cliente.TelefoneFixo.Trim().StartsWith(telefoneFixoCliente)).ToList();
		}
		
		public List<Servico> buscarServicosTelefoneCelularCliente(string telefoneCelularCliente)
		{
			return DadosServicos.query().Where(servico => servico.Cliente.TelefoneCelular.Trim().StartsWith(telefoneCelularCliente)).ToList();
		}
	}
}
