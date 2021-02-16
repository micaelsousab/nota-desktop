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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
