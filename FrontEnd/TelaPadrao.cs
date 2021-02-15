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
            labelNumeroNota.Text = _repositorioServico.ObterIdProximaNota();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtServico1_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtTotalServico1_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtTotalServico2_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtTotalServico3_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtTotalServico4_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtTotalServico5_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtTotalServico6_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtTotalServico7_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtTotalServico8_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtTotalServico9_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtTotalServico10_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtTotalServico11_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtTotalServico12_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtTotalServico13_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtTotalServico14_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtTotalServico15_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtQuantidadeServico1_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtQuantidadeServico2_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtServico2_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtServico3_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtServico4_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtServico5_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtServico6_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtServico7_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtServico8_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtServico9_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtServico10_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtServico11_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtServico12_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtServico13_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtServico14_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtServico15_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtQuantidadeServico3_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtQuantidadeServico4_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtQuantidadeServico5_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtQuantidadeServico6_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtQuantidadeServico7_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtQuantidadeServico8_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtQuantidadeServico9_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtQuantidadeServico10_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtQuantidadeServico11_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtQuantidadeServico12_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtQuantidadeServico13_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtQuantidadeServico14_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void txtQuantidadeServico15_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtValorTotal();
        }

        private void AtualizarTxtValorTotal()
        {
            List<ItemServico> listaItemServicos = ObterItensServico();

            var valorTotal = _repositorioServico.ObterValorTotalDaNota(listaItemServicos);

            txtTotal.Text = $"{valorTotal.ToString("C")}";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            List<ItemServico> listaItemServicos = ObterItensServico();

            Endereco endereco = ObterEndereco();

            Cliente cliente = ObterCliente(endereco);

            Servico servico = ObterServico(cliente, listaItemServicos);

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

            if (!string.IsNullOrEmpty(txtQuantidadeServico3.Text) &&
                !string.IsNullOrEmpty(txtServico3.Text) &&
                !string.IsNullOrEmpty(txtTotalServico3.Text))
            {
                listaItemServicos.Add(new ItemServico
                {
                    Quantidade = Int32.Parse(txtQuantidadeServico3.Text),
                    Descricao = txtServico3.Text,
                    Valor = Convert.ToDouble(txtTotalServico3.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                });
            }

            if (!string.IsNullOrEmpty(txtQuantidadeServico4.Text) &&
                !string.IsNullOrEmpty(txtServico4.Text) &&
                !string.IsNullOrEmpty(txtTotalServico4.Text))
            {
                listaItemServicos.Add(new ItemServico
                {
                    Quantidade = Int32.Parse(txtQuantidadeServico4.Text),
                    Descricao = txtServico4.Text,
                    Valor = Convert.ToDouble(txtTotalServico4.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                });
            }

            if (!string.IsNullOrEmpty(txtQuantidadeServico5.Text) &&
                !string.IsNullOrEmpty(txtServico5.Text) &&
                !string.IsNullOrEmpty(txtTotalServico5.Text))
            {
                listaItemServicos.Add(new ItemServico
                {
                    Quantidade = Int32.Parse(txtQuantidadeServico5.Text),
                    Descricao = txtServico5.Text,
                    Valor = Convert.ToDouble(txtTotalServico5.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                });
            }

            if (!string.IsNullOrEmpty(txtQuantidadeServico6.Text) &&
                !string.IsNullOrEmpty(txtServico6.Text) &&
                !string.IsNullOrEmpty(txtTotalServico6.Text))
            {
                listaItemServicos.Add(new ItemServico
                {
                    Quantidade = Int32.Parse(txtQuantidadeServico6.Text),
                    Descricao = txtServico6.Text,
                    Valor = Convert.ToDouble(txtTotalServico6.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                });
            }

            if (!string.IsNullOrEmpty(txtQuantidadeServico7.Text) &&
                !string.IsNullOrEmpty(txtServico7.Text) &&
                !string.IsNullOrEmpty(txtTotalServico7.Text))
            {
                listaItemServicos.Add(new ItemServico
                {
                    Quantidade = Int32.Parse(txtQuantidadeServico7.Text),
                    Descricao = txtServico7.Text,
                    Valor = Convert.ToDouble(txtTotalServico7.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                });
            }

            if (!string.IsNullOrEmpty(txtQuantidadeServico8.Text) &&
                !string.IsNullOrEmpty(txtServico8.Text) &&
                !string.IsNullOrEmpty(txtTotalServico8.Text))
            {
                listaItemServicos.Add(new ItemServico
                {
                    Quantidade = Int32.Parse(txtQuantidadeServico8.Text),
                    Descricao = txtServico8.Text,
                    Valor = Convert.ToDouble(txtTotalServico8.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                });
            }

            if (!string.IsNullOrEmpty(txtQuantidadeServico9.Text) &&
                !string.IsNullOrEmpty(txtServico9.Text) &&
                !string.IsNullOrEmpty(txtTotalServico9.Text))
            {
                listaItemServicos.Add(new ItemServico
                {
                    Quantidade = Int32.Parse(txtQuantidadeServico9.Text),
                    Descricao = txtServico9.Text,
                    Valor = Convert.ToDouble(txtTotalServico9.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                });
            }

            if (!string.IsNullOrEmpty(txtQuantidadeServico10.Text) &&
                !string.IsNullOrEmpty(txtServico10.Text) &&
                !string.IsNullOrEmpty(txtTotalServico10.Text))
            {
                listaItemServicos.Add(new ItemServico
                {
                    Quantidade = Int32.Parse(txtQuantidadeServico10.Text),
                    Descricao = txtServico10.Text,
                    Valor = Convert.ToDouble(txtTotalServico10.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                });
            }

            if (!string.IsNullOrEmpty(txtQuantidadeServico11.Text) &&
                !string.IsNullOrEmpty(txtServico11.Text) &&
                !string.IsNullOrEmpty(txtTotalServico11.Text))
            {
                listaItemServicos.Add(new ItemServico
                {
                    Quantidade = Int32.Parse(txtQuantidadeServico11.Text),
                    Descricao = txtServico11.Text,
                    Valor = Convert.ToDouble(txtTotalServico11.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                });
            }

            if (!string.IsNullOrEmpty(txtQuantidadeServico12.Text) &&
                !string.IsNullOrEmpty(txtServico12.Text) &&
                !string.IsNullOrEmpty(txtTotalServico12.Text))
            {
                listaItemServicos.Add(new ItemServico
                {
                    Quantidade = Int32.Parse(txtQuantidadeServico12.Text),
                    Descricao = txtServico12.Text,
                    Valor = Convert.ToDouble(txtTotalServico12.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                });
            }

            if (!string.IsNullOrEmpty(txtQuantidadeServico13.Text) &&
                !string.IsNullOrEmpty(txtServico13.Text) &&
                !string.IsNullOrEmpty(txtTotalServico13.Text))
            {
                listaItemServicos.Add(new ItemServico
                {
                    Quantidade = Int32.Parse(txtQuantidadeServico13.Text),
                    Descricao = txtServico13.Text,
                    Valor = Convert.ToDouble(txtTotalServico13.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                });
            }

            if (!string.IsNullOrEmpty(txtQuantidadeServico14.Text) &&
                !string.IsNullOrEmpty(txtServico14.Text) &&
                !string.IsNullOrEmpty(txtTotalServico14.Text))
            {
                listaItemServicos.Add(new ItemServico
                {
                    Quantidade = Int32.Parse(txtQuantidadeServico14.Text),
                    Descricao = txtServico14.Text,
                    Valor = Convert.ToDouble(txtTotalServico14.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                });
            }

            if (!string.IsNullOrEmpty(txtQuantidadeServico15.Text) &&
                !string.IsNullOrEmpty(txtServico15.Text) &&
                !string.IsNullOrEmpty(txtTotalServico15.Text))
            {
                listaItemServicos.Add(new ItemServico
                {
                    Quantidade = Int32.Parse(txtQuantidadeServico15.Text),
                    Descricao = txtServico15.Text,
                    Valor = Convert.ToDouble(txtTotalServico15.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                });
            }

            return listaItemServicos;
        }
    }
}
