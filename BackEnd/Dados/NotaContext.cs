using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using BackEnd.Entidades;

namespace BackEnd.Dados
{
	public class NotaContext : DbContext
	{
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Endereco> Enderecos{ get; set; }
		public DbSet<ItemServico> ItensServicos { get; set; }
		public DbSet<Servico> Servicos { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlite("Data Source=nota-prod.db");
	}
}
