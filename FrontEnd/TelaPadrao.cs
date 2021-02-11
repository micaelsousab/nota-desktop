using BackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegistroClientes
{
	public partial class TelaPadrao : Form
	{
		public TelaPadrao()
		{
			InitializeComponent();
		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

        private void txtQuantidadeServico5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            List<ItemServico> listaItemServicos = new List<ItemServico>();

            listaItemServicos.Add(new ItemServico { Quantidade = Int32.Parse(txtQuantidadeServico1.Text), Descricao = txtServico1.Text, Valor = Convert.ToDouble(txtTotalServico1.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR")) });
            listaItemServicos.Add(new ItemServico { Quantidade = Int32.Parse(txtQuantidadeServico2.Text), Descricao = txtServico1.Text, Valor = Convert.ToDouble(txtTotalServico1.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR")) });
            listaItemServicos.Add(new ItemServico { Quantidade = Int32.Parse(txtQuantidadeServico3.Text), Descricao = txtServico1.Text, Valor = Convert.ToDouble(txtTotalServico1.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR")) });
            listaItemServicos.Add(new ItemServico { Quantidade = Int32.Parse(txtQuantidadeServico4.Text), Descricao = txtServico1.Text, Valor = Convert.ToDouble(txtTotalServico1.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR")) });
            listaItemServicos.Add(new ItemServico { Quantidade = Int32.Parse(txtQuantidadeServico5.Text), Descricao = txtServico1.Text, Valor = Convert.ToDouble(txtTotalServico1.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR")) });
            listaItemServicos.Add(new ItemServico { Quantidade = Int32.Parse(txtQuantidadeServico6.Text), Descricao = txtServico1.Text, Valor = Convert.ToDouble(txtTotalServico1.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR")) });
            listaItemServicos.Add(new ItemServico { Quantidade = Int32.Parse(txtQuantidadeServico7.Text), Descricao = txtServico1.Text, Valor = Convert.ToDouble(txtTotalServico1.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR")) });
            listaItemServicos.Add(new ItemServico { Quantidade = Int32.Parse(txtQuantidadeServico8.Text), Descricao = txtServico1.Text, Valor = Convert.ToDouble(txtTotalServico1.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR")) });
            listaItemServicos.Add(new ItemServico { Quantidade = Int32.Parse(txtQuantidadeServico9.Text), Descricao = txtServico1.Text, Valor = Convert.ToDouble(txtTotalServico1.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR")) });
            listaItemServicos.Add(new ItemServico { Quantidade = Int32.Parse(txtQuantidadeServico10.Text), Descricao = txtServico1.Text, Valor = Convert.ToDouble(txtTotalServico1.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR")) });

            Endereco endereco = new Endereco
            {
                Bairro = txtBairroEnderecoCliente.Text,
                Cidade = txtCidadeEnderecoCliente.Text,
                LinhaEndereco = txtLinhaEnderecoCliente.Text,
                Numero = txtNumeroEnderecoCliente.Text,
                UF = txtUFEnderecoCliente.Text
            };

            Cliente cliente = new Cliente
            {
                Nome = txtNomeCliente.Text,
                Email = txtEmailCliente.Text,
                TelefoneCelular = txtTelefoneCelularCliente.Text,
                TelefoneFixo = txtTelefoneFixoCliente.Text,
                Endereco = endereco,
                
            };

            Servico servico = new Servico
            {
                Cliente = cliente,
                
            };
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }

        private void txtTotalServico10_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtServico1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
