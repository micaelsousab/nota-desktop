using BackEnd.Entidades;
using BackEnd.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroClientes
{
    public partial class TelaExibirNota : Form
    {
        private RepositorioServico _repositorioServico = new RepositorioServico();

        int idNota = 0;

        public TelaExibirNota(int id)
        {
            InitializeComponent();

            Servico servico = _repositorioServico.BuscarServicoPorId(id);

            idNota = servico.Id;

            txtNomeCompleto.Text = servico.Cliente.Nome;
            txtEmail.Text = servico.Cliente.Email;
            txtUF.Text = servico.Cliente.Endereco.UF;

            txtCidade.Text = servico.Cliente.Endereco.Cidade;
            txtBairro.Text = servico.Cliente.Endereco.Bairro;
            txtNumero.Text = servico.Cliente.Endereco.Numero;
            txtEndereco.Text = servico.Cliente.Endereco.LinhaEndereco;

            if (!string.IsNullOrEmpty(servico.Cliente.TelefoneCelular))
                txtTelefoneCelular.Text = servico.Cliente.TelefoneCelular;

            if (!string.IsNullOrEmpty(servico.Cliente.TelefoneFixo))
                txtTelefoneFixo.Text = servico.Cliente.TelefoneFixo;

            ItemServico itemServico1 = servico.ItensServico[0];
            ItemServico itemServico2 = new ItemServico();
            ItemServico itemServico3 = new ItemServico();
            ItemServico itemServico4 = new ItemServico();
            ItemServico itemServico5 = new ItemServico();
            ItemServico itemServico6 = new ItemServico();
            ItemServico itemServico7 = new ItemServico();
            ItemServico itemServico8 = new ItemServico();
            ItemServico itemServico9 = new ItemServico();
            ItemServico itemServico10 = new ItemServico();
            ItemServico itemServico11 = new ItemServico();
            ItemServico itemServico12 = new ItemServico();
            ItemServico itemServico13 = new ItemServico();
            ItemServico itemServico14 = new ItemServico();
            ItemServico itemServico15 = new ItemServico();

            if (servico.ItensServico.Count > 1) itemServico2 = servico.ItensServico[1];
            if (servico.ItensServico.Count > 2) itemServico3 = servico.ItensServico[2];
            if (servico.ItensServico.Count > 3) itemServico4 = servico.ItensServico[3];
            if (servico.ItensServico.Count > 4) itemServico5 = servico.ItensServico[4];
            if (servico.ItensServico.Count > 5) itemServico6 = servico.ItensServico[5];
            if (servico.ItensServico.Count > 6) itemServico7 = servico.ItensServico[6];
            if (servico.ItensServico.Count > 7) itemServico8 = servico.ItensServico[7];
            if (servico.ItensServico.Count > 8) itemServico9 = servico.ItensServico[8];
            if (servico.ItensServico.Count > 9) itemServico10 = servico.ItensServico[9];
            if (servico.ItensServico.Count > 10) itemServico11 = servico.ItensServico[10];
            if (servico.ItensServico.Count > 11) itemServico12 = servico.ItensServico[11];
            if (servico.ItensServico.Count > 12) itemServico13 = servico.ItensServico[12];
            if (servico.ItensServico.Count > 13) itemServico14 = servico.ItensServico[13];
            if (servico.ItensServico.Count > 14) itemServico15 = servico.ItensServico[14];

            if (!string.IsNullOrEmpty(itemServico1.Descricao))
            {
                txtQuantidadeServico1.Text = itemServico1.Quantidade.ToString();
                txtServico1.Text = itemServico1.Descricao;
                //txtTotalServico1.Text = itemServico1.Valor.ToString("C");
                txtTotalServico1.Text = itemServico1.Valor.ToString();
            }

            if (!string.IsNullOrEmpty(itemServico2.Descricao))
            {
                txtQuantidadeServico2.Text = itemServico2.Quantidade.ToString();
                txtServico2.Text = itemServico2.Descricao;
                //txtTotalServico2.Text = itemServico2.Valor.ToString("C");
                txtTotalServico2.Text = itemServico2.Valor.ToString();
            }

            if (!string.IsNullOrEmpty(itemServico3.Descricao))
            {
                txtQuantidadeServico3.Text = itemServico3.Quantidade.ToString();
                txtServico3.Text = itemServico3.Descricao;
                //txtTotalServico3.Text = itemServico3.Valor.ToString("C");
                txtTotalServico3.Text = itemServico3.Valor.ToString();
            }

            if (!string.IsNullOrEmpty(itemServico4.Descricao))
            {
                txtQuantidadeServico4.Text = itemServico4.Quantidade.ToString();
                txtServico4.Text = itemServico4.Descricao;
                //txtTotalServico4.Text = itemServico4.Valor.ToString("C");
                txtTotalServico4.Text = itemServico4.Valor.ToString();
            }

            if (!string.IsNullOrEmpty(itemServico5.Descricao))
            {
                txtQuantidadeServico5.Text = itemServico5.Quantidade.ToString();
                txtServico5.Text = itemServico5.Descricao;
                //txtTotalServico5.Text = itemServico5.Valor.ToString("C");
                txtTotalServico5.Text = itemServico5.Valor.ToString();
            }

            if (!string.IsNullOrEmpty(itemServico6.Descricao))
            {
                txtQuantidadeServico6.Text = itemServico6.Quantidade.ToString();
                txtServico6.Text = itemServico6.Descricao;
                //txtTotalServico6.Text = itemServico6.Valor.ToString("C");
                txtTotalServico6.Text = itemServico6.Valor.ToString();
            }

            if (!string.IsNullOrEmpty(itemServico7.Descricao))
            {
                txtQuantidadeServico7.Text = itemServico7.Quantidade.ToString();
                txtServico7.Text = itemServico7.Descricao;
                //txtTotalServico7.Text = itemServico7.Valor.ToString("C");
                txtTotalServico7.Text = itemServico7.Valor.ToString();
            }

            if (!string.IsNullOrEmpty(itemServico8.Descricao))
            {
                txtQuantidadeServico8.Text = itemServico8.Quantidade.ToString();
                txtServico8.Text = itemServico8.Descricao;
                //txtTotalServico8.Text = itemServico8.Valor.ToString("C");
                txtTotalServico8.Text = itemServico8.Valor.ToString();
            }

            if (!string.IsNullOrEmpty(itemServico9.Descricao))
            {
                txtQuantidadeServico9.Text = itemServico9.Quantidade.ToString();
                txtServico9.Text = itemServico9.Descricao;
                //txtTotalServico9.Text = itemServico9.Valor.ToString("C");
                txtTotalServico9.Text = itemServico9.Valor.ToString();
            }

            if (!string.IsNullOrEmpty(itemServico10.Descricao))
            {
                txtQuantidadeServico10.Text = itemServico10.Quantidade.ToString();
                txtServico10.Text = itemServico10.Descricao;
                //txtTotalServico10.Text = itemServico10.Valor.ToString("C");
                txtTotalServico10.Text = itemServico10.Valor.ToString();
            }

            if (!string.IsNullOrEmpty(itemServico11.Descricao))
            {
                txtQuantidadeServico11.Text = itemServico11.Quantidade.ToString();
                txtServico11.Text = itemServico11.Descricao;
                //txtTotalServico11.Text = itemServico11.Valor.ToString("C");
                txtTotalServico12.Text = itemServico12.Valor.ToString();
            }

            if (!string.IsNullOrEmpty(itemServico12.Descricao))
            {
                txtQuantidadeServico12.Text = itemServico12.Quantidade.ToString();
                txtServico12.Text = itemServico12.Descricao;
                //txtTotalServico12.Text = itemServico12.Valor.ToString("C");
                txtTotalServico12.Text = itemServico12.Valor.ToString();
            }

            if (!string.IsNullOrEmpty(itemServico13.Descricao))
            {
                txtQuantidadeServico13.Text = itemServico13.Quantidade.ToString();
                txtServico13.Text = itemServico13.Descricao;
                //txtTotalServico13.Text = itemServico13.Valor.ToString("C");
                txtTotalServico13.Text = itemServico13.Valor.ToString();
            }

            if (!string.IsNullOrEmpty(itemServico14.Descricao))
            {
                txtQuantidadeServico14.Text = itemServico14.Quantidade.ToString();
                txtServico14.Text = itemServico14.Descricao;
                //txtTotalServico14.Text = itemServico14.Valor.ToString("C");
                txtTotalServico14.Text = itemServico14.Valor.ToString();
            }

            if (!string.IsNullOrEmpty(itemServico15.Descricao))
            {
                txtQuantidadeServico15.Text = itemServico15.Quantidade.ToString();
                txtServico15.Text = itemServico15.Descricao;
                //txtTotalServico15.Text = itemServico15.Valor.ToString("C");
                txtTotalServico14.Text = itemServico14.Valor.ToString();
            }

            var total = 0.0;

            foreach (var item in servico.ItensServico)
            {
                total += (item.Valor * item.Quantidade);
            }

            txtTotal.Text = total.ToString("C");

            txtAdiantamento.Text = servico.ValorAdiantamento.ToString();

            string valorRestante = (servico.ValorTotal - servico.ValorAdiantamento).ToString("C");

            txtResta.Text = valorRestante;

            txtDataEntrega.Text = servico.PrevisaoEntrega.ToString("dd/MM/yyyy");

            txtDataNota.Text = servico.DataRegistro.ToString("dd/MM/yyyy");

            txtObservacao.Text = servico.Observacoes;

            labelId.Text = servico.Id.ToString();

            btnSalvar.Enabled = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);

            btnPrint.Visible = true;
            btnSalvar.Visible = true;
            txtObservacao.Width = 447;
        }

        Bitmap bitmap;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = false;
            btnSalvar.Visible = false;
            txtObservacao.Width = 544;

            Panel panel = new Panel();

            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();

            Size size = this.ClientSize;

            bitmap = new Bitmap(size.Width, size.Height, graphics);

            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);

            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.ShowDialog();

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

        private Endereco ObterEndereco()
        {
            Endereco endereco = new Endereco
            {
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                LinhaEndereco = txtEndereco.Text,
                Numero = txtNumero.Text,
                UF = txtUF.Text
            };

            return endereco;
        }

        private Cliente ObterCliente(Endereco endereco)
        {
            Cliente cliente = new Cliente
            {
                Nome = txtNomeCompleto.Text,
                Email = txtEmail.Text,
                TelefoneCelular = txtTelefoneCelular.Text,
                TelefoneFixo = txtTelefoneFixo.Text,
                Endereco = endereco,
            };

            return cliente;
        }

        private void AtualizarTxtValorTotal()
        {
            List<ItemServico> listaItemServicos = ObterItensServico();

            var valorTotal = _repositorioServico.ObterValorTotalDaNota(listaItemServicos);

            txtTotal.Text = $"{valorTotal.ToString("C")}";

            ObterValorRestante();
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtTotalServico1_TextChanged(object sender, EventArgs e)
        {
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

            AtualizarTxtValorTotal();
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

            AtualizarTxtValorTotal();
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

            AtualizarTxtValorTotal();
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

            AtualizarTxtValorTotal();
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

            AtualizarTxtValorTotal();
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

            AtualizarTxtValorTotal();
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

            AtualizarTxtValorTotal();
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

            AtualizarTxtValorTotal();
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

            AtualizarTxtValorTotal();
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

            AtualizarTxtValorTotal();
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

            AtualizarTxtValorTotal();
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

            AtualizarTxtValorTotal();
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

            AtualizarTxtValorTotal();
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

            AtualizarTxtValorTotal();
        }

        private void txtServico1_TextChanged(object sender, EventArgs e)
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

        private void VerificarCamposPreenchidosParaAtivarBotaoSalvar()
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtNomeCompleto.Text))
                valido = false;

            if (string.IsNullOrEmpty(txtEmail.Text))
                valido = false;

            if (string.IsNullOrEmpty(txtUF.Text))
                valido = false;

            if (string.IsNullOrEmpty(txtCidade.Text))
                valido = false;

            if (string.IsNullOrEmpty(txtBairro.Text))
                valido = false;

            if (string.IsNullOrEmpty(txtNumero.Text))
                valido = false;

            if (string.IsNullOrEmpty(txtEndereco.Text))
                valido = false;

            if (string.IsNullOrEmpty(txtTelefoneCelular.Text) && string.IsNullOrEmpty(txtTelefoneFixo.Text))
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

                if (txtAdiantamento.Text.Contains("-"))
                {
                    txtAdiantamento.Text = "0";
                } 
                else
                {
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
        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtTelefoneFixo_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtTelefoneCelular_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtUF_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposPreenchidosParaAtivarBotaoSalvar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //double novoValorAdiantado = Convert.ToDouble(txtAdiantamento.Text.Substring(2), System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));
            //string observacao = txtObservacao.Text;

            Servico servico = _repositorioServico.BuscarServicoPorId(idNota);
            servico.ItensServico = ObterItensServico();
            servico.Cliente = ObterCliente(ObterEndereco());
            servico.Cliente.Endereco = ObterEndereco();
            servico.Observacoes = txtObservacao.Text;

            double total = 0.0;

            foreach (var itemServico in ObterItensServico())
            {
                total += (itemServico.Valor * itemServico.Quantidade);
            }

            servico.ValorTotal = total;
            servico.ValorAdiantamento = Convert.ToDouble(txtAdiantamento.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));

            try
            {
                servico.PrevisaoEntrega = Convert.ToDateTime(txtDataEntrega.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));

                _repositorioServico.AtualizarServico(idNota, servico);

                MessageBox.Show("Nota Atualizada com Sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO NA PREVISÃO DE ENTREGA!");
            }
        }
    }
}
