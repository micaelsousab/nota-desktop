﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BackEnd.Entidades;
using BackEnd.Dados;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Repositorios
{
	public class RepositorioServico
	{
		private NotaContext _db = new NotaContext();

		public Servico CadastrarServico(Servico servico)
		{
			_db.Add(servico);
			_db.SaveChanges();

			return _db.Servicos.OrderByDescending(s => s.Id).First();
		}

		public Servico BuscarServicoPorId(int id)
        {
			return _db.Servicos.Include(x => x.Cliente.Endereco).Where(x => x.Id == id).FirstOrDefault();
        }

		public List<Servico> BuscarServicosNomeCliente(string nomeCliente)
		{
			return _db.Servicos.Where(s => s.Cliente.Nome.Contains(nomeCliente)).ToList();
		}

		public List<Servico> BuscarServicosTelefoneFixoCliente(string telefoneFixoCliente)
		{
			return _db.Servicos.Where(s => s.Cliente.TelefoneFixo.StartsWith(telefoneFixoCliente)).ToList();
		}
		
		public List<Servico> BuscarServicosTelefoneCelularCliente(string telefoneCelularCliente)
		{
			return _db.Servicos.Where(s => s.Cliente.TelefoneCelular.StartsWith(telefoneCelularCliente)).ToList();
		}

		public double ObterValorTotalDaNota(List<ItemServico> listaItemServicos)
        {
			double valorTotal = 0.0;

            foreach (var item in listaItemServicos)
            {
				valorTotal += (item.Valor * item.Quantidade);
            }

			return valorTotal;
        }

		public List<Servico> BuscarTodosServicos()
        {
			return _db.Servicos.Include(x => x.Cliente.Endereco).ToList();
        }

		public string ObterIdProximaNota()
        {
            if (_db.Servicos.Any())
            {
				var ultimoId = _db.Servicos.OrderByDescending(x => x.Id).FirstOrDefault().Id;

				return $"{ultimoId + 1}";
			}
			else
            {
				return "0";
            }
        }
	}
}
