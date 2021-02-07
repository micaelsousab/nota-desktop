using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using BackEnd.Entidades;

namespace BackEnd.Dados
{
	class DadosServicos
	{
		private static List<Servico> Servicos { get; set; }
		private static string localFileName => @"./servicos.json";

		static DadosServicos()
		{
			if (!File.Exists(localFileName))
			{
				File.Create(localFileName);
			}
			string jsonString = File.ReadAllText(localFileName);
			Servicos = JsonSerializer.Deserialize<List<Servico>>(jsonString);
		}

		public static IEnumerable<Servico> query()
		{
			return Servicos; 
		}

		public static List<Servico> listarServicos()
		{
			return Servicos;
		}

		public static Servico criarServico(Servico servico)
		{
			Servicos.Add(servico);
			atualizarArquivo();
			return servico;
		}

		public static void atualizarArquivo()
		{
			string jsonString = JsonSerializer.Serialize<List<Servico>>(Servicos);
			File.WriteAllText(localFileName, jsonString);
		}
	}
}
