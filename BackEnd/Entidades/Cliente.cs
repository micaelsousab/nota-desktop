﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Entidades
{
	class Cliente
	{
		public string Nome { get; set; }
		public string Email { get; set; }
		public string? TelefoneFixo { get; set; }
		public string? TelefoneCelular { get; set; }
		public Endereco Endereco { get; set; }
	}
}