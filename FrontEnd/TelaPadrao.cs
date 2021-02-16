using BackEnd.Entidades;
using BackEnd.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            ObterValorRestante();
        }

        private void txtAdiantamento_TextChanged(object sender, EventArgs e)
        {
            double i = 0;
            string s = txtTotalServico1.Text.Replace(',', '.');
            bool resultado = double.TryParse(s, out i);

            if (resultado)
            {
                ObterValorRestante();
                VerificarCamposPreenchidosParaAtivarBotaoSalvar();
            }
            else
            {
                txtTotalServico1.Text = string.Empty;
            }
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
            TelaExibirNota telaExibirNota = new TelaExibirNota(Int32.Parse(txtTotalServico1.Text));
            telaExibirNota.Show();

            double i = 0;
            string s = txtTotalServico1.Text.Replace(',', '.');
            bool resultado = double.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtTotalServico1.Text = string.Empty;
        }

        private void txtTotalServico2_TextChanged(object sender, EventArgs e)
        {
            double i = 0;
            string s = txtTotalServico2.Text.Replace(',', '.');
            bool resultado = double.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtTotalServico2.Text = string.Empty;
        }

        private void txtTotalServico3_TextChanged(object sender, EventArgs e)
        {
            double i = 0;
            string s = txtTotalServico3.Text.Replace(',', '.');
            bool resultado = double.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtTotalServico3.Text = string.Empty;
        }

        private void txtTotalServico4_TextChanged(object sender, EventArgs e)
        {
            double i = 0;
            string s = txtTotalServico4.Text.Replace(',', '.');
            bool resultado = double.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtTotalServico4.Text = string.Empty;
        }

        private void txtTotalServico5_TextChanged(object sender, EventArgs e)
        {
            double i = 0;
            string s = txtTotalServico5.Text.Replace(',', '.');
            bool resultado = double.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtTotalServico5.Text = string.Empty;
        }

        private void txtTotalServico6_TextChanged(object sender, EventArgs e)
        {
            double i = 0;
            string s = txtTotalServico6.Text.Replace(',', '.');
            bool resultado = double.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtTotalServico6.Text = string.Empty;
        }

        private void txtTotalServico7_TextChanged(object sender, EventArgs e)
        {
            double i = 0;
            string s = txtTotalServico7.Text.Replace(',', '.');
            bool resultado = double.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtTotalServico7.Text = string.Empty;
        }

        private void txtTotalServico8_TextChanged(object sender, EventArgs e)
        {
            double i = 0;
            string s = txtTotalServico8.Text.Replace(',', '.');
            bool resultado = double.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtTotalServico8.Text = string.Empty;
        }

        private void txtTotalServico9_TextChanged(object sender, EventArgs e)
        {
            double i = 0;
            string s = txtTotalServico9.Text.Replace(',', '.');
            bool resultado = double.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtTotalServico9.Text = string.Empty;
        }

        private void txtTotalServico10_TextChanged(object sender, EventArgs e)
        {
            double i = 0;
            string s = txtTotalServico10.Text.Replace(',', '.');
            bool resultado = double.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtTotalServico10.Text = string.Empty;
        }

        private void txtTotalServico11_TextChanged(object sender, EventArgs e)
        {
            double i = 0;
            string s = txtTotalServico11.Text.Replace(',', '.');
            bool resultado = double.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtTotalServico11.Text = string.Empty;
        }

        private void txtTotalServico12_TextChanged(object sender, EventArgs e)
        {
            double i = 0;
            string s = txtTotalServico12.Text.Replace(',', '.');
            bool resultado = double.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtTotalServico12.Text = string.Empty;
        }

        private void txtTotalServico13_TextChanged(object sender, EventArgs e)
        {
            double i = 0;
            string s = txtTotalServico13.Text.Replace(',', '.');
            bool resultado = double.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtTotalServico13.Text = string.Empty;
        }

        private void txtTotalServico14_TextChanged(object sender, EventArgs e)
        {
            double i = 0;
            string s = txtTotalServico14.Text.Replace(',', '.');
            bool resultado = double.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtTotalServico14.Text = string.Empty;
        }

        private void txtTotalServico15_TextChanged(object sender, EventArgs e)
        {
            double i = 0;
            string s = txtTotalServico15.Text.Replace(',', '.');
            bool resultado = double.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtTotalServico15.Text = string.Empty;
        }

        private void txtQuantidadeServico1_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = txtQuantidadeServico1.Text;
            bool resultado = int.TryParse(s, out i); 

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtQuantidadeServico1.Text = string.Empty;
        }

        private void txtQuantidadeServico2_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = txtQuantidadeServico2.Text;
            bool resultado = int.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtQuantidadeServico2.Text = string.Empty;
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
            int i = 0;
            string s = txtQuantidadeServico3.Text;
            bool resultado = int.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtQuantidadeServico3.Text = string.Empty;
        }

        private void txtQuantidadeServico4_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = txtQuantidadeServico4.Text;
            bool resultado = int.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtQuantidadeServico4.Text = string.Empty;
        }

        private void txtQuantidadeServico5_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = txtQuantidadeServico5.Text;
            bool resultado = int.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtQuantidadeServico5.Text = string.Empty;
        }

        private void txtQuantidadeServico6_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = txtQuantidadeServico6.Text;
            bool resultado = int.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtQuantidadeServico6.Text = string.Empty;
        }

        private void txtQuantidadeServico7_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = txtQuantidadeServico7.Text;
            bool resultado = int.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtQuantidadeServico7.Text = string.Empty;
        }

        private void txtQuantidadeServico8_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = txtQuantidadeServico8.Text;
            bool resultado = int.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtQuantidadeServico8.Text = string.Empty;
        }

        private void txtQuantidadeServico9_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = txtQuantidadeServico9.Text;
            bool resultado = int.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtQuantidadeServico9.Text = string.Empty;
        }

        private void txtQuantidadeServico10_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = txtQuantidadeServico10.Text;
            bool resultado = int.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtQuantidadeServico10.Text = string.Empty;
        }

        private void txtQuantidadeServico11_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = txtQuantidadeServico11.Text;
            bool resultado = int.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtQuantidadeServico11.Text = string.Empty;
        }

        private void txtQuantidadeServico12_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = txtQuantidadeServico12.Text;
            bool resultado = int.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtQuantidadeServico12.Text = string.Empty;
        }

        private void txtQuantidadeServico13_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = txtQuantidadeServico13.Text;
            bool resultado = int.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtQuantidadeServico13.Text = string.Empty;
        }

        private void txtQuantidadeServico14_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = txtQuantidadeServico14.Text;
            bool resultado = int.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtQuantidadeServico14.Text = string.Empty;
        }

        private void txtQuantidadeServico15_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string s = txtQuantidadeServico15.Text;
            bool resultado = int.TryParse(s, out i);

            if (resultado)
                AtualizarTxtValorTotal();
            else
                txtQuantidadeServico15.Text = string.Empty;
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtTelefoneFixoCliente_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtEmailCliente_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtTelefoneCelularCliente_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtUFEnderecoCliente_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtCidadeEnderecoCliente_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtBairroEnderecoCliente_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtNumeroEnderecoCliente_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtLinhaEnderecoCliente_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void VerificarCamposPreenchidosParaAtivarBotaoSalvar()
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtNomeCliente.Text))
                valido = false;

            if (string.IsNullOrEmpty(txtEmailCliente.Text))
                valido = false;

            if (string.IsNullOrEmpty(txtUFEnderecoCliente.Text))
                valido = false;

            if (string.IsNullOrEmpty(txtCidadeEnderecoCliente.Text))
                valido = false;

            if (string.IsNullOrEmpty(txtBairroEnderecoCliente.Text))
                valido = false;

            if (string.IsNullOrEmpty(txtNumeroEnderecoCliente.Text))
                valido = false;

            if (string.IsNullOrEmpty(txtLinhaEnderecoCliente.Text))
                valido = false;

            if (string.IsNullOrEmpty(txtTelefoneCelularCliente.Text) && string.IsNullOrEmpty(txtTelefoneFixoCliente.Text))
                valido = false;

            if (!ObterItensServico().Any())
                valido = false;

            if (!string.IsNullOrEmpty(txtAdiantamento.Text) && !string.IsNullOrEmpty(txtTotal.Text))
            {
                List<ItemServico> listaItemServicos = ObterItensServico();

                if (listaItemServicos.Any())
                {
                    var adiantamento = Convert.ToDouble(txtAdiantamento.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));
                    var total = _repositorioServico.ObterValorTotalDaNota(listaItemServicos);

                    if (adiantamento > total)
                        valido = false;
                }
            }
            else
            {
                valido = false;
            }

            if (valido)
                btnSalvar.Enabled = true;
            else
                btnSalvar.Enabled = false;
        }

        private void ObterValorRestante()
        {
            List<ItemServico> listaItemServicos = ObterItensServico();

            if (listaItemServicos.Any())
            {
                var valorTotalDaNota = _repositorioServico.ObterValorTotalDaNota(listaItemServicos);

                if (!string.IsNullOrEmpty(txtAdiantamento.Text))
                {
                    var adiantamento = Convert.ToDouble(txtAdiantamento.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));

                    txtResta.Text = $"{(valorTotalDaNota - adiantamento).ToString("C")}";
                }
                else
                {
                    txtResta.Text = $"{(valorTotalDaNota).ToString("C")}";
                }
            }
        }

        private void AtualizarTxtValorTotal()
        {
            List<ItemServico> listaItemServicos = ObterItensServico();

            var valorTotal = _repositorioServico.ObterValorTotalDaNota(listaItemServicos);

            txtTotal.Text = $"{valorTotal.ToString("C")}";

            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void abasTela_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
