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
    public partial class TelaExibirNota : Form
    {
        private RepositorioServico _repositorioServico = new RepositorioServico();

        public TelaExibirNota(int id)
        {
            InitializeComponent();

            Servico servico = _repositorioServico.BuscarServicoPorId(id);

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
                txtTelefoneCelular.Text = servico.Cliente.TelefoneFixo;

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

            if (!string.IsNullOrEmpty(itemServico1.Descricao) != null)
            {
                txtQuantidadeServico1.Text = itemServico1.Quantidade.ToString();
                txtServico1.Text = itemServico1.Descricao;
                txtTotalServico1.Text = itemServico1.Valor.ToString("C");
            }

            if (!string.IsNullOrEmpty(itemServico2.Descricao))
            {
                txtQuantidadeServico2.Text = itemServico2.Quantidade.ToString();
                txtServico2.Text = itemServico2.Descricao;
                txtTotalServico2.Text = itemServico2.Valor.ToString("C");
            }

            if (!string.IsNullOrEmpty(itemServico3.Descricao))
            {
                txtQuantidadeServico3.Text = itemServico3.Quantidade.ToString();
                txtServico3.Text = itemServico3.Descricao;
                txtTotalServico3.Text = itemServico3.Valor.ToString("C");
            }

            if (!string.IsNullOrEmpty(itemServico4.Descricao))
            {
                txtQuantidadeServico4.Text = itemServico4.Quantidade.ToString();
                txtServico4.Text = itemServico4.Descricao;
                txtTotalServico4.Text = itemServico4.Valor.ToString("C");
            }

            if (!string.IsNullOrEmpty(itemServico5.Descricao))
            {
                txtQuantidadeServico5.Text = itemServico5.Quantidade.ToString();
                txtServico5.Text = itemServico5.Descricao;
                txtTotalServico5.Text = itemServico5.Valor.ToString("C");
            }

            if (!string.IsNullOrEmpty(itemServico6.Descricao))
            {
                txtQuantidadeServico6.Text = itemServico6.Quantidade.ToString();
                txtServico6.Text = itemServico6.Descricao;
                txtTotalServico6.Text = itemServico6.Valor.ToString("C");
            }

            if (!string.IsNullOrEmpty(itemServico7.Descricao))
            {
                txtQuantidadeServico7.Text = itemServico7.Quantidade.ToString();
                txtServico7.Text = itemServico7.Descricao;
                txtTotalServico7.Text = itemServico7.Valor.ToString("C");
            }

            if (!string.IsNullOrEmpty(itemServico8.Descricao))
            {
                txtQuantidadeServico8.Text = itemServico8.Quantidade.ToString();
                txtServico8.Text = itemServico8.Descricao;
                txtTotalServico8.Text = itemServico8.Valor.ToString("C");
            }

            if (!string.IsNullOrEmpty(itemServico9.Descricao))
            {
                txtQuantidadeServico9.Text = itemServico9.Quantidade.ToString();
                txtServico9.Text = itemServico9.Descricao;
                txtTotalServico9.Text = itemServico9.Valor.ToString("C");
            }

            if (!string.IsNullOrEmpty(itemServico10.Descricao))
            {
                txtQuantidadeServico10.Text = itemServico10.Quantidade.ToString();
                txtServico10.Text = itemServico10.Descricao;
                txtTotalServico10.Text = itemServico10.Valor.ToString("C");
            }

            if (!string.IsNullOrEmpty(itemServico11.Descricao))
            {
                txtQuantidadeServico11.Text = itemServico11.Quantidade.ToString();
                txtServico11.Text = itemServico11.Descricao;
                txtTotalServico11.Text = itemServico11.Valor.ToString("C");
            }

            if (!string.IsNullOrEmpty(itemServico12.Descricao))
            {
                txtQuantidadeServico12.Text = itemServico12.Quantidade.ToString();
                txtServico12.Text = itemServico12.Descricao;
                txtTotalServico12.Text = itemServico12.Valor.ToString("C");
            }

            if (!string.IsNullOrEmpty(itemServico13.Descricao))
            {
                txtQuantidadeServico13.Text = itemServico13.Quantidade.ToString();
                txtServico13.Text = itemServico13.Descricao;
                txtTotalServico13.Text = itemServico13.Valor.ToString("C");
            }

            if (!string.IsNullOrEmpty(itemServico14.Descricao))
            {
                txtQuantidadeServico14.Text = itemServico14.Quantidade.ToString();
                txtServico14.Text = itemServico14.Descricao;
                txtTotalServico14.Text = itemServico14.Valor.ToString("C");
            }

            if (!string.IsNullOrEmpty(itemServico15.Descricao))
            {
                txtQuantidadeServico15.Text = itemServico15.Quantidade.ToString();
                txtServico15.Text = itemServico15.Descricao;
                txtTotalServico15.Text = itemServico15.Valor.ToString("C");
            }

            var total = 0.0;

            foreach (var item in servico.ItensServico)
            {
                total += (item.Valor * item.Quantidade);
            }

            txtTotal.Text = total.ToString("C");

            txtAdiantamento.Text = servico.ValorAdiantamento.ToString("C");

            if (servico.ValorDevido > 0)
            {
                txtResta.Text = servico.ValorDevido.ToString().Replace('.', ',');
            }
            else
            {
                txtResta.Text = servico.ValorDevido.ToString("C");
                txtResta.ReadOnly = true;
            }

            txtDataEntrega.Text = servico.PrevisaoEntrega.ToString("dd/MM/yyyy");

            txtDataNota.Text = servico.DataRegistro.ToString("dd/MM/yyyy");

            txtObservacao.Text = servico.Observacoes;

            labelId.Text = servico.Id.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
