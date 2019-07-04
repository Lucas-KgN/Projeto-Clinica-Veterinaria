namespace Apresentacao
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btCadastro = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btCadastraPet = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbIdade = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.btBusca = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.mkTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mkCPFBusca = new System.Windows.Forms.MaskedTextBox();
            this.mkCPF = new System.Windows.Forms.MaskedTextBox();
            this.btLista = new System.Windows.Forms.Button();
            this.btHistorico = new System.Windows.Forms.Button();
            this.btContas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(28, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(28, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(28, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(28, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefone:";
            // 
            // btCadastro
            // 
            this.btCadastro.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastro.ForeColor = System.Drawing.SystemColors.Window;
            this.btCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btCadastro.Image")));
            this.btCadastro.Location = new System.Drawing.Point(34, 256);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(338, 35);
            this.btCadastro.TabIndex = 6;
            this.btCadastro.Text = "Cadastrar";
            this.btCadastro.UseVisualStyleBackColor = true;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.SystemColors.Window;
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.Location = new System.Drawing.Point(294, 515);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(251, 45);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Enabled = false;
            this.btAtualizar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.ForeColor = System.Drawing.SystemColors.Window;
            this.btAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btAtualizar.Image")));
            this.btAtualizar.Location = new System.Drawing.Point(34, 314);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(338, 35);
            this.btAtualizar.TabIndex = 7;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btCadastraPet
            // 
            this.btCadastraPet.Enabled = false;
            this.btCadastraPet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastraPet.ForeColor = System.Drawing.SystemColors.Window;
            this.btCadastraPet.Image = ((System.Drawing.Image)(resources.GetObject("btCadastraPet.Image")));
            this.btCadastraPet.Location = new System.Drawing.Point(34, 372);
            this.btCadastraPet.Name = "btCadastraPet";
            this.btCadastraPet.Size = new System.Drawing.Size(338, 35);
            this.btCadastraPet.TabIndex = 13;
            this.btCadastraPet.Text = "Pet";
            this.btCadastraPet.UseVisualStyleBackColor = true;
            this.btCadastraPet.Click += new System.EventHandler(this.btCadastraPet_Click);
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(122, 23);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(250, 27);
            this.tbNome.TabIndex = 0;
            this.tbNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbIdade
            // 
            this.tbIdade.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdade.Location = new System.Drawing.Point(122, 61);
            this.tbIdade.Name = "tbIdade";
            this.tbIdade.Size = new System.Drawing.Size(100, 27);
            this.tbIdade.TabIndex = 1;
            this.tbIdade.TextChanged += new System.EventHandler(this.tbIdade_TextChanged);
            // 
            // tbEndereco
            // 
            this.tbEndereco.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndereco.Location = new System.Drawing.Point(122, 99);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(250, 27);
            this.tbEndereco.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(122, 172);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(250, 27);
            this.tbEmail.TabIndex = 4;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCliente.Location = new System.Drawing.Point(445, 23);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.Size = new System.Drawing.Size(743, 477);
            this.dgvCliente.TabIndex = 12;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(21, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nome:";
            // 
            // tbBusca
            // 
            this.tbBusca.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusca.Location = new System.Drawing.Point(90, 429);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(250, 27);
            this.tbBusca.TabIndex = 8;
            // 
            // btBusca
            // 
            this.btBusca.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusca.ForeColor = System.Drawing.SystemColors.Window;
            this.btBusca.Image = ((System.Drawing.Image)(resources.GetObject("btBusca.Image")));
            this.btBusca.Location = new System.Drawing.Point(25, 515);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(251, 45);
            this.btBusca.TabIndex = 10;
            this.btBusca.Text = "Buscar Cliente";
            this.btBusca.UseVisualStyleBackColor = true;
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(21, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "CPF:";
            // 
            // mkTelefone
            // 
            this.mkTelefone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkTelefone.Location = new System.Drawing.Point(122, 209);
            this.mkTelefone.Mask = "(00) 0000-0000";
            this.mkTelefone.Name = "mkTelefone";
            this.mkTelefone.Size = new System.Drawing.Size(204, 27);
            this.mkTelefone.TabIndex = 5;
            // 
            // mkCPFBusca
            // 
            this.mkCPFBusca.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCPFBusca.Location = new System.Drawing.Point(90, 466);
            this.mkCPFBusca.Mask = "000-000-000-00";
            this.mkCPFBusca.Name = "mkCPFBusca";
            this.mkCPFBusca.Size = new System.Drawing.Size(250, 27);
            this.mkCPFBusca.TabIndex = 9;
            // 
            // mkCPF
            // 
            this.mkCPF.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCPF.Location = new System.Drawing.Point(122, 136);
            this.mkCPF.Mask = "000-000-000-00";
            this.mkCPF.Name = "mkCPF";
            this.mkCPF.Size = new System.Drawing.Size(250, 27);
            this.mkCPF.TabIndex = 3;
            // 
            // btLista
            // 
            this.btLista.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLista.ForeColor = System.Drawing.SystemColors.Window;
            this.btLista.Image = ((System.Drawing.Image)(resources.GetObject("btLista.Image")));
            this.btLista.Location = new System.Drawing.Point(25, 576);
            this.btLista.Name = "btLista";
            this.btLista.Size = new System.Drawing.Size(251, 43);
            this.btLista.TabIndex = 14;
            this.btLista.Text = "Lista de Clientes";
            this.btLista.UseVisualStyleBackColor = true;
            this.btLista.Click += new System.EventHandler(this.btLista_Click);
            // 
            // btHistorico
            // 
            this.btHistorico.Enabled = false;
            this.btHistorico.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistorico.ForeColor = System.Drawing.SystemColors.Window;
            this.btHistorico.Image = ((System.Drawing.Image)(resources.GetObject("btHistorico.Image")));
            this.btHistorico.Location = new System.Drawing.Point(294, 578);
            this.btHistorico.Name = "btHistorico";
            this.btHistorico.Size = new System.Drawing.Size(251, 43);
            this.btHistorico.TabIndex = 21;
            this.btHistorico.Text = "Agenda de Consultas";
            this.btHistorico.UseVisualStyleBackColor = true;
            this.btHistorico.Click += new System.EventHandler(this.btHistorico_Click);
            // 
            // btContas
            // 
            this.btContas.Enabled = false;
            this.btContas.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContas.ForeColor = System.Drawing.SystemColors.Window;
            this.btContas.Image = ((System.Drawing.Image)(resources.GetObject("btContas.Image")));
            this.btContas.Location = new System.Drawing.Point(561, 578);
            this.btContas.Name = "btContas";
            this.btContas.Size = new System.Drawing.Size(251, 43);
            this.btContas.TabIndex = 22;
            this.btContas.Text = "Contas";
            this.btContas.UseVisualStyleBackColor = true;
            this.btContas.Click += new System.EventHandler(this.btContas_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG702;
            this.ClientSize = new System.Drawing.Size(1229, 633);
            this.Controls.Add(this.btContas);
            this.Controls.Add(this.btHistorico);
            this.Controls.Add(this.btLista);
            this.Controls.Add(this.mkCPF);
            this.Controls.Add(this.mkCPFBusca);
            this.Controls.Add(this.mkTelefone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btBusca);
            this.Controls.Add(this.tbBusca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.tbIdade);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btCadastraPet);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btCadastraPet;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbIdade;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Button btBusca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mkTelefone;
        private System.Windows.Forms.MaskedTextBox mkCPFBusca;
        private System.Windows.Forms.MaskedTextBox mkCPF;
        private System.Windows.Forms.Button btLista;
        private System.Windows.Forms.Button btHistorico;
        private System.Windows.Forms.Button btContas;
    }
}

