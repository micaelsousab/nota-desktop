using BackEnd.Entidades;
using BackEnd.Repositorios;
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
        private RepositorioServico _repositorioServico = new RepositorioServico();

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
            List<ItemServico> listaItemServicos = this.ObterItensServico();

            Endereco endereco = this.ObterEndereco();

            Cliente cliente = this.ObterCliente(endereco);

            Servico servico = this.ObterServico(cliente, listaItemServicos);

            _repositorioServico.CadastrarServico(servico);
        }

        private Endereco ObterEndereco()
        {
            Endereco endereco = new Endereco
            {
                Bairro = txtBairroEnderecoCliente.Text,
                Cidade = txtCidadeEnderecoCliente.Text,
                LinhaEndereco = txtLinhaEnderecoCliente.Text,
                Numero = txtNumeroEnderecoCliente.Text,
                UF = txtUFEnderecoCliente.Text
            };

            return endereco;
        }

        private Cliente ObterCliente(Endereco endereco)
        {
            Cliente cliente = new Cliente
            {
                Nome = txtNomeCliente.Text,
                Email = txtEmailCliente.Text,
                TelefoneCelular = txtTelefoneCelularCliente.Text,
                TelefoneFixo = txtTelefoneFixoCliente.Text,
                Endereco = endereco,
            };

            return cliente;
        }

        private Servico ObterServico(Cliente cliente, List<ItemServico> listaItemServicos)
        {
            Servico servico = new Servico
            {
                Cliente = cliente,
                DataRegistro = DateTime.Now,
                ValorTotal = _repositorioServico.ObterValorTotalDaNota(listaItemServicos),
                ItensServico = listaItemServicos,
                Observacoes = textObservacao.Text,
                ValorAdiantamento = Convert.ToDouble(txtAdiantamento.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR")),
                PrevisaoEntrega = dtPrevistaEntrega.Value,
            };

            return servico;
        }

        private List<ItemServico> ObterItensServico()
        {
            List<ItemServico> listaItemServicos = new List<ItemServico>();

            if (!string.IsNullOrEmpty(txtQuantidadeServico1.Text) &&
                !string.IsNullOrEmpty(txtServico1.Text) &&
                !string.IsNullOrEmpty(txtTotalServico1.Text))
            {
                listaItemServicos.Add(new ItemServico
                {
                    Quantidade = Int32.Parse(txtQuantidadeServico1.Text),
                    Descricao = txtServico1.Text,
                    Valor = Convert.ToDouble(txtTotalServico1.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                });
            }

            if (!string.IsNullOrEmpty(txtQuantidadeServico2.Text) &&
                !string.IsNullOrEmpty(txtServico2.Text) &&
                !string.IsNullOrEmpty(txtTotalServico2.Text))
            {
                listaItemServicos.Add(new ItemServico
                {
                    Quantidade = Int32.Parse(txtQuantidadeServico2.Text),
                    Descricao = txtServico2.Text,
                    Valor = Convert.ToDouble(txtTotalServico2.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                });
            }

            return listaItemServicos;
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
