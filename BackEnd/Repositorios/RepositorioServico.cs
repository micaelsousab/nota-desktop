using System;
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
			return _db.Servicos.Include(x => x.Cliente.Endereco).Include(x => x.ItensServico).Where(x => x.Id == id).FirstOrDefault();
		}

		public List<Servico> BuscarTodosServicos()
		{
			return _db.Servicos.Include(x => x.Cliente.Endereco).Include(x => x.ItensServico).ToList();
		}

		public List<Servico> BuscarServicosPorNomeCliente(string pesquisa)
		{
			return _db.Servicos.Include(x => x.Cliente.Endereco).Include(x => x.ItensServico).Where(s => s.Cliente.Nome.Contains(pesquisa)).ToList();
		}

		public List<Servico> BuscarServicosPorTelefoneCelularCliente(string pesquisa)
		{
			return _db.Servicos.Include(x => x.Cliente.Endereco).Include(x => x.ItensServico).Where(s => s.Cliente.TelefoneFixo.Contains(pesquisa) ||
																									     s.Cliente.TelefoneCelular.Contains(pesquisa)).ToList();
		}

		public List<Servico> BuscarServicosPorEmailCliente(string pesquisa)
		{
			return _db.Servicos.Include(x => x.Cliente.Endereco).Include(x => x.ItensServico).Where(s => s.Cliente.Email.Contains(pesquisa)).ToList();
		}

		public List<Servico> BuscarServicoPorNota(int id)
		{
			List<Servico> listaServicos = new List<Servico>();

			listaServicos.Add(_db.Servicos.Include(x => x.Cliente.Endereco).Include(x => x.ItensServico).Where(x => x.Id == id).FirstOrDefault());

			return listaServicos;
		}

		public List<Servico> BuscarServicosNaoPagosCliente()
		{
			return _db.Servicos.Include(x => x.Cliente.Endereco).Include(x => x.ItensServico).Where(s => s.ValorAdiantamento < s.ValorTotal).ToList();
		}

		public List<Servico> BuscarServicosPagosCliente()
		{
			return _db.Servicos.Include(x => x.Cliente.Endereco).Include(x => x.ItensServico).Where(s => s.ValorAdiantamento == s.ValorTotal).ToList();
		}

		public List<Servico> BuscarServicosHoje()
		{
			return _db.Servicos.Include(x => x.Cliente.Endereco).Include(x => x.ItensServico).Where(x => x.DataRegistro.Day == DateTime.Now.Day &&
																										 x.DataRegistro.Month == DateTime.Now.Month &&
																									     x.DataRegistro.Year == DateTime.Now.Year).ToList();
		}

		public List<Servico> BuscarServicosDoMes()
		{
			return _db.Servicos.Include(x => x.Cliente.Endereco).Include(x => x.ItensServico).Where(x => x.DataRegistro.Month == DateTime.Now.Month &&
																										 x.DataRegistro.Year == DateTime.Now.Year).ToList();
		}

		public List<Servico> BuscarUltimoServico()
		{
			List<Servico> listaServicos = new List<Servico>();

			listaServicos.Add(_db.Servicos.Include(x => x.Cliente.Endereco).Include(x => x.ItensServico).OrderByDescending(x => x.Id).FirstOrDefault());

			return listaServicos;
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

		public string ObterIdProximaNota()
        {
            if (_db.Servicos.Any())
            {
				var ultimoId = _db.Servicos.OrderByDescending(x => x.Id).FirstOrDefault().Id;

				return $"{ultimoId + 1}";
			}
			else
            {
				return "1";
            }
        }

		public void AtualizarValorRestante(int idNota, double novoValorAdiantado)
		{
			Servico servico = _db.Servicos.Find(idNota);

			servico.ValorAdiantamento = novoValorAdiantado;

			_db.Entry(servico).State = EntityState.Modified;
			_db.SaveChanges();
		}

		public void AtualizarObservacao(int idNota, string observacao)
        {
			Servico servico = _db.Servicos.Find(idNota);

			servico.Observacoes = observacao;

			_db.Entry(servico).State = EntityState.Modified;
			_db.SaveChanges();
        }

		public void AtualizarServico(int idNota, Servico servicoAtualizado)
		{
			Servico servico = _db.Servicos.Find(idNota);

			servico = servicoAtualizado;

			_db.Entry(servico).State = EntityState.Modified;
			_db.SaveChanges();
		}
	}
}
