
namespace RegistroClientes
{
	partial class TelaPadrao
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.abasTela = new System.Windows.Forms.TabControl();
			this.novoServico = new System.Windows.Forms.TabPage();
			this.consultarServico = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNomeCliente = new System.Windows.Forms.TextBox();
			this.labelNomeCliente = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.labelEmailCliente = new System.Windows.Forms.Label();
			this.txtTelefoneFixoCliente = new System.Windows.Forms.TextBox();
			this.txtTelefoneCelularCliente = new System.Windows.Forms.TextBox();
			this.labelTelefoneFixoCliente = new System.Windows.Forms.Label();
			this.labelTelefoneCelularCliente = new System.Windows.Forms.Label();
			this.txtUFEnderecoCliente = new System.Windows.Forms.TextBox();
			this.labelUFCLiente = new System.Windows.Forms.Label();
			this.txtCidadeEnderecoCliente = new System.Windows.Forms.TextBox();
			this.labelCidadeEnderecoCliente = new System.Windows.Forms.Label();
			this.labelBairroEnderecoCliente = new System.Windows.Forms.Label();
			this.txtBairroEnderecoCliente = new System.Windows.Forms.TextBox();
			this.labelNumeroEnderecoCliente = new System.Windows.Forms.Label();
			this.txtNumeroEnderecoCliente = new System.Windows.Forms.TextBox();
			this.txtLinhaEnderecoCliente = new System.Windows.Forms.TextBox();
			this.labelLinhaEnderecoCliente = new System.Windows.Forms.Label();
			this.txtQuantidadeServico1 = new System.Windows.Forms.TextBox();
			this.txtQuantidadeServico2 = new System.Windows.Forms.TextBox();
			this.txtQuantidadeServico3 = new System.Windows.Forms.TextBox();
			this.txtQuantidadeServico4 = new System.Windows.Forms.TextBox();
			this.labelServicosQuantidade = new System.Windows.Forms.Label();
			this.abasTela.SuspendLayout();
			this.novoServico.SuspendLayout();
			this.SuspendLayout();
			// 
			// abasTela
			// 
			this.abasTela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.abasTela.Controls.Add(this.novoServico);
			this.abasTela.Controls.Add(this.consultarServico);
			this.abasTela.Location = new System.Drawing.Point(12, 12);
			this.abasTela.Name = "abasTela";
			this.abasTela.SelectedIndex = 0;
			this.abasTela.Size = new System.Drawing.Size(579, 688);
			this.abasTela.TabIndex = 0;
			// 
			// novoServico
			// 
			this.novoServico.Controls.Add(this.labelServicosQuantidade);
			this.novoServico.Controls.Add(this.txtQuantidadeServico4);
			this.novoServico.Controls.Add(this.txtQuantidadeServico3);
			this.novoServico.Controls.Add(this.txtQuantidadeServico2);
			this.novoServico.Controls.Add(this.txtQuantidadeServico1);
			this.novoServico.Controls.Add(this.labelLinhaEnderecoCliente);
			this.novoServico.Controls.Add(this.txtLinhaEnderecoCliente);
			this.novoServico.Controls.Add(this.labelNumeroEnderecoCliente);
			this.novoServico.Controls.Add(this.txtNumeroEnderecoCliente);
			this.novoServico.Controls.Add(this.txtBairroEnderecoCliente);
			this.novoServico.Controls.Add(this.labelBairroEnderecoCliente);
			this.novoServico.Controls.Add(this.labelCidadeEnderecoCliente);
			this.novoServico.Controls.Add(this.txtCidadeEnderecoCliente);
			this.novoServico.Controls.Add(this.labelUFCLiente);
			this.novoServico.Controls.Add(this.txtUFEnderecoCliente);
			this.novoServico.Controls.Add(this.labelTelefoneCelularCliente);
			this.novoServico.Controls.Add(this.labelTelefoneFixoCliente);
			this.novoServico.Controls.Add(this.txtTelefoneCelularCliente);
			this.novoServico.Controls.Add(this.txtTelefoneFixoCliente);
			this.novoServico.Controls.Add(this.labelEmailCliente);
			this.novoServico.Controls.Add(this.textBox1);
			this.novoServico.Controls.Add(this.labelNomeCliente);
			this.novoServico.Controls.Add(this.txtNomeCliente);
			this.novoServico.Controls.Add(this.label1);
			this.novoServico.Location = new System.Drawing.Point(4, 24);
			this.novoServico.Name = "novoServico";
			this.novoServico.Padding = new System.Windows.Forms.Padding(3);
			this.novoServico.Size = new System.Drawing.Size(571, 660);
			this.novoServico.TabIndex = 0;
			this.novoServico.Text = "Novo Serviço";
			this.novoServico.UseVisualStyleBackColor = true;
			this.novoServico.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// consultarServico
			// 
			this.consultarServico.Location = new System.Drawing.Point(4, 24);
			this.consultarServico.Name = "consultarServico";
			this.consultarServico.Padding = new System.Windows.Forms.Padding(3);
			this.consultarServico.Size = new System.Drawing.Size(571, 660);
			this.consultarServico.TabIndex = 1;
			this.consultarServico.Text = "Consultar Serviços";
			this.consultarServico.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(10, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(317, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cadastrar Serviço";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtNomeCliente
			// 
			this.txtNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNomeCliente.Location = new System.Drawing.Point(10, 91);
			this.txtNomeCliente.Name = "txtNomeCliente";
			this.txtNomeCliente.Size = new System.Drawing.Size(304, 23);
			this.txtNomeCliente.TabIndex = 1;
			// 
			// labelNomeCliente
			// 
			this.labelNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelNomeCliente.AutoSize = true;
			this.labelNomeCliente.Location = new System.Drawing.Point(10, 73);
			this.labelNomeCliente.Name = "labelNomeCliente";
			this.labelNomeCliente.Size = new System.Drawing.Size(96, 15);
			this.labelNomeCliente.TabIndex = 2;
			this.labelNomeCliente.Text = "Nome Completo";
			this.labelNomeCliente.Click += new System.EventHandler(this.label2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(10, 144);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(304, 23);
			this.textBox1.TabIndex = 3;
			// 
			// labelEmailCliente
			// 
			this.labelEmailCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelEmailCliente.AutoSize = true;
			this.labelEmailCliente.Location = new System.Drawing.Point(10, 126);
			this.labelEmailCliente.Name = "labelEmailCliente";
			this.labelEmailCliente.Size = new System.Drawing.Size(36, 15);
			this.labelEmailCliente.TabIndex = 4;
			this.labelEmailCliente.Text = "Email";
			// 
			// txtTelefoneFixoCliente
			// 
			this.txtTelefoneFixoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTelefoneFixoCliente.Location = new System.Drawing.Point(340, 91);
			this.txtTelefoneFixoCliente.Margin = new System.Windows.Forms.Padding(10);
			this.txtTelefoneFixoCliente.Name = "txtTelefoneFixoCliente";
			this.txtTelefoneFixoCliente.Size = new System.Drawing.Size(221, 23);
			this.txtTelefoneFixoCliente.TabIndex = 5;
			// 
			// txtTelefoneCelularCliente
			// 
			this.txtTelefoneCelularCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTelefoneCelularCliente.Location = new System.Drawing.Point(340, 144);
			this.txtTelefoneCelularCliente.Margin = new System.Windows.Forms.Padding(10);
			this.txtTelefoneCelularCliente.Name = "txtTelefoneCelularCliente";
			this.txtTelefoneCelularCliente.Size = new System.Drawing.Size(221, 23);
			this.txtTelefoneCelularCliente.TabIndex = 6;
			// 
			// labelTelefoneFixoCliente
			// 
			this.labelTelefoneFixoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTelefoneFixoCliente.AutoSize = true;
			this.labelTelefoneFixoCliente.Location = new System.Drawing.Point(340, 72);
			this.labelTelefoneFixoCliente.Name = "labelTelefoneFixoCliente";
			this.labelTelefoneFixoCliente.Size = new System.Drawing.Size(76, 15);
			this.labelTelefoneFixoCliente.TabIndex = 7;
			this.labelTelefoneFixoCliente.Text = "Telefone Fixo";
			// 
			// labelTelefoneCelularCliente
			// 
			this.labelTelefoneCelularCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTelefoneCelularCliente.AutoSize = true;
			this.labelTelefoneCelularCliente.Location = new System.Drawing.Point(340, 125);
			this.labelTelefoneCelularCliente.Name = "labelTelefoneCelularCliente";
			this.labelTelefoneCelularCliente.Size = new System.Drawing.Size(91, 15);
			this.labelTelefoneCelularCliente.TabIndex = 8;
			this.labelTelefoneCelularCliente.Text = "Telefone Celular";
			// 
			// txtUFEnderecoCliente
			// 
			this.txtUFEnderecoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUFEnderecoCliente.Location = new System.Drawing.Point(10, 207);
			this.txtUFEnderecoCliente.Name = "txtUFEnderecoCliente";
			this.txtUFEnderecoCliente.Size = new System.Drawing.Size(61, 23);
			this.txtUFEnderecoCliente.TabIndex = 9;
			// 
			// labelUFCLiente
			// 
			this.labelUFCLiente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelUFCLiente.AutoSize = true;
			this.labelUFCLiente.Location = new System.Drawing.Point(10, 186);
			this.labelUFCLiente.Name = "labelUFCLiente";
			this.labelUFCLiente.Size = new System.Drawing.Size(21, 15);
			this.labelUFCLiente.TabIndex = 10;
			this.labelUFCLiente.Text = "UF";
			// 
			// txtCidadeEnderecoCliente
			// 
			this.txtCidadeEnderecoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCidadeEnderecoCliente.Location = new System.Drawing.Point(84, 207);
			this.txtCidadeEnderecoCliente.Margin = new System.Windows.Forms.Padding(10);
			this.txtCidadeEnderecoCliente.Name = "txtCidadeEnderecoCliente";
			this.txtCidadeEnderecoCliente.Size = new System.Drawing.Size(230, 23);
			this.txtCidadeEnderecoCliente.TabIndex = 11;
			// 
			// labelCidadeEnderecoCliente
			// 
			this.labelCidadeEnderecoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelCidadeEnderecoCliente.AutoSize = true;
			this.labelCidadeEnderecoCliente.Location = new System.Drawing.Point(84, 186);
			this.labelCidadeEnderecoCliente.Name = "labelCidadeEnderecoCliente";
			this.labelCidadeEnderecoCliente.Size = new System.Drawing.Size(44, 15);
			this.labelCidadeEnderecoCliente.TabIndex = 12;
			this.labelCidadeEnderecoCliente.Text = "Cidade";
			// 
			// labelBairroEnderecoCliente
			// 
			this.labelBairroEnderecoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelBairroEnderecoCliente.AutoSize = true;
			this.labelBairroEnderecoCliente.Location = new System.Drawing.Point(340, 189);
			this.labelBairroEnderecoCliente.Name = "labelBairroEnderecoCliente";
			this.labelBairroEnderecoCliente.Size = new System.Drawing.Size(38, 15);
			this.labelBairroEnderecoCliente.TabIndex = 13;
			this.labelBairroEnderecoCliente.Text = "Bairro";
			// 
			// txtBairroEnderecoCliente
			// 
			this.txtBairroEnderecoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBairroEnderecoCliente.Location = new System.Drawing.Point(340, 207);
			this.txtBairroEnderecoCliente.Margin = new System.Windows.Forms.Padding(10);
			this.txtBairroEnderecoCliente.Name = "txtBairroEnderecoCliente";
			this.txtBairroEnderecoCliente.Size = new System.Drawing.Size(147, 23);
			this.txtBairroEnderecoCliente.TabIndex = 14;
			// 
			// labelNumeroEnderecoCliente
			// 
			this.labelNumeroEnderecoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelNumeroEnderecoCliente.AutoSize = true;
			this.labelNumeroEnderecoCliente.Location = new System.Drawing.Point(500, 186);
			this.labelNumeroEnderecoCliente.Name = "labelNumeroEnderecoCliente";
			this.labelNumeroEnderecoCliente.Size = new System.Drawing.Size(51, 15);
			this.labelNumeroEnderecoCliente.TabIndex = 16;
			this.labelNumeroEnderecoCliente.Text = "Número";
			// 
			// txtNumeroEnderecoCliente
			// 
			this.txtNumeroEnderecoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNumeroEnderecoCliente.Location = new System.Drawing.Point(500, 207);
			this.txtNumeroEnderecoCliente.Name = "txtNumeroEnderecoCliente";
			this.txtNumeroEnderecoCliente.Size = new System.Drawing.Size(61, 23);
			this.txtNumeroEnderecoCliente.TabIndex = 15;
			// 
			// txtLinhaEnderecoCliente
			// 
			this.txtLinhaEnderecoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLinhaEnderecoCliente.Location = new System.Drawing.Point(10, 261);
			this.txtLinhaEnderecoCliente.Name = "txtLinhaEnderecoCliente";
			this.txtLinhaEnderecoCliente.Size = new System.Drawing.Size(551, 23);
			this.txtLinhaEnderecoCliente.TabIndex = 17;
			// 
			// labelLinhaEnderecoCliente
			// 
			this.labelLinhaEnderecoCliente.AutoSize = true;
			this.labelLinhaEnderecoCliente.Location = new System.Drawing.Point(10, 240);
			this.labelLinhaEnderecoCliente.Name = "labelLinhaEnderecoCliente";
			this.labelLinhaEnderecoCliente.Size = new System.Drawing.Size(56, 15);
			this.labelLinhaEnderecoCliente.TabIndex = 18;
			this.labelLinhaEnderecoCliente.Text = "Endereço";
			// 
			// txtQuantidadeServico1
			// 
			this.txtQuantidadeServico1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQuantidadeServico1.Location = new System.Drawing.Point(10, 332);
			this.txtQuantidadeServico1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
			this.txtQuantidadeServico1.Name = "txtQuantidadeServico1";
			this.txtQuantidadeServico1.Size = new System.Drawing.Size(61, 23);
			this.txtQuantidadeServico1.TabIndex = 19;
			// 
			// txtQuantidadeServico2
			// 
			this.txtQuantidadeServico2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQuantidadeServico2.Location = new System.Drawing.Point(10, 362);
			this.txtQuantidadeServico2.Margin = new System.Windows.Forms.Padding(10);
			this.txtQuantidadeServico2.Name = "txtQuantidadeServico2";
			this.txtQuantidadeServico2.Size = new System.Drawing.Size(61, 23);
			this.txtQuantidadeServico2.TabIndex = 20;
			// 
			// txtQuantidadeServico3
			// 
			this.txtQuantidadeServico3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQuantidadeServico3.Location = new System.Drawing.Point(10, 392);
			this.txtQuantidadeServico3.Margin = new System.Windows.Forms.Padding(10);
			this.txtQuantidadeServico3.Name = "txtQuantidadeServico3";
			this.txtQuantidadeServico3.Size = new System.Drawing.Size(61, 23);
			this.txtQuantidadeServico3.TabIndex = 21;
			// 
			// txtQuantidadeServico4
			// 
			this.txtQuantidadeServico4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQuantidadeServico4.Location = new System.Drawing.Point(10, 422);
			this.txtQuantidadeServico4.Margin = new System.Windows.Forms.Padding(10);
			this.txtQuantidadeServico4.Name = "txtQuantidadeServico4";
			this.txtQuantidadeServico4.Size = new System.Drawing.Size(61, 23);
			this.txtQuantidadeServico4.TabIndex = 22;
			// 
			// labelServicosQuantidade
			// 
			this.labelServicosQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelServicosQuantidade.AutoSize = true;
			this.labelServicosQuantidade.Location = new System.Drawing.Point(10, 314);
			this.labelServicosQuantidade.Name = "labelServicosQuantidade";
			this.labelServicosQuantidade.Size = new System.Drawing.Size(32, 15);
			this.labelServicosQuantidade.TabIndex = 23;
			this.labelServicosQuantidade.Text = "QTD.";
			// 
			// TelaPadrao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 712);
			this.Controls.Add(this.abasTela);
			this.Name = "TelaPadrao";
			this.Text = "TelaPadrao";
			this.abasTela.ResumeLayout(false);
			this.novoServico.ResumeLayout(false);
			this.novoServico.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl abasTela;
		private System.Windows.Forms.TabPage novoServico;
		private System.Windows.Forms.TabPage consultarServico;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelNomeCliente;
		private System.Windows.Forms.TextBox txtNomeCliente;
		private System.Windows.Forms.Label labelLinhaEnderecoCliente;
		private System.Windows.Forms.TextBox txtLinhaEnderecoCliente;
		private System.Windows.Forms.Label labelNumeroEnderecoCliente;
		private System.Windows.Forms.TextBox txtNumeroEnderecoCliente;
		private System.Windows.Forms.TextBox txtBairroEnderecoCliente;
		private System.Windows.Forms.Label labelBairroEnderecoCliente;
		private System.Windows.Forms.Label labelCidadeEnderecoCliente;
		private System.Windows.Forms.TextBox txtCidadeEnderecoCliente;
		private System.Windows.Forms.Label labelUFCLiente;
		private System.Windows.Forms.TextBox txtUFEnderecoCliente;
		private System.Windows.Forms.Label labelTelefoneCelularCliente;
		private System.Windows.Forms.Label labelTelefoneFixoCliente;
		private System.Windows.Forms.TextBox txtTelefoneCelularCliente;
		private System.Windows.Forms.TextBox txtTelefoneFixoCliente;
		private System.Windows.Forms.Label labelEmailCliente;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label labelServicosQuantidade;
		private System.Windows.Forms.TextBox txtQuantidadeServico4;
		private System.Windows.Forms.TextBox txtQuantidadeServico3;
		private System.Windows.Forms.TextBox txtQuantidadeServico2;
		private System.Windows.Forms.TextBox txtQuantidadeServico1;
	}
}