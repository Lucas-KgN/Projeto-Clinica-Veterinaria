namespace Apresentacao
{
    partial class FormVeterinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVeterinario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btLista = new System.Windows.Forms.Button();
            this.mkCPF = new System.Windows.Forms.MaskedTextBox();
            this.mkCPFBusca = new System.Windows.Forms.MaskedTextBox();
            this.mkTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btBusca = new System.Windows.Forms.Button();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvVet = new System.Windows.Forms.DataGridView();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbIdade = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCadastro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btHistorico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVet)).BeginInit();
            this.SuspendLayout();
            // 
            // btLista
            // 
            this.btLista.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLista.ForeColor = System.Drawing.SystemColors.Window;
            this.btLista.Image = ((System.Drawing.Image)(resources.GetObject("btLista.Image")));
            this.btLista.Location = new System.Drawing.Point(16, 500);
            this.btLista.Name = "btLista";
            this.btLista.Size = new System.Drawing.Size(237, 37);
            this.btLista.TabIndex = 12;
            this.btLista.Text = "Lista de Veterinários";
            this.btLista.UseVisualStyleBackColor = true;
            this.btLista.Click += new System.EventHandler(this.btLista_Click_1);
            // 
            // mkCPF
            // 
            this.mkCPF.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCPF.Location = new System.Drawing.Point(111, 119);
            this.mkCPF.Mask = "000-000-000-00";
            this.mkCPF.Name = "mkCPF";
            this.mkCPF.Size = new System.Drawing.Size(250, 27);
            this.mkCPF.TabIndex = 3;
            // 
            // mkCPFBusca
            // 
            this.mkCPFBusca.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkCPFBusca.Location = new System.Drawing.Point(80, 395);
            this.mkCPFBusca.Mask = "000-000-000-00";
            this.mkCPFBusca.Name = "mkCPFBusca";
            this.mkCPFBusca.Size = new System.Drawing.Size(250, 27);
            this.mkCPFBusca.TabIndex = 9;
            // 
            // mkTelefone
            // 
            this.mkTelefone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkTelefone.Location = new System.Drawing.Point(111, 192);
            this.mkTelefone.Mask = "(00) 0000-0000";
            this.mkTelefone.Name = "mkTelefone";
            this.mkTelefone.Size = new System.Drawing.Size(204, 27);
            this.mkTelefone.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(10, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 22);
            this.label8.TabIndex = 43;
            this.label8.Text = "CPF:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btBusca
            // 
            this.btBusca.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusca.ForeColor = System.Drawing.SystemColors.Window;
            this.btBusca.Image = ((System.Drawing.Image)(resources.GetObject("btBusca.Image")));
            this.btBusca.Location = new System.Drawing.Point(16, 442);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(239, 33);
            this.btBusca.TabIndex = 10;
            this.btBusca.Text = "Buscar Veteriário";
            this.btBusca.UseVisualStyleBackColor = true;
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click_1);
            // 
            // tbBusca
            // 
            this.tbBusca.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusca.Location = new System.Drawing.Point(80, 359);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(250, 27);
            this.tbBusca.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(10, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 22);
            this.label7.TabIndex = 42;
            this.label7.Text = "Nome:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dgvVet
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVet.Location = new System.Drawing.Point(476, 6);
            this.dgvVet.Name = "dgvVet";
            this.dgvVet.RowTemplate.Height = 24;
            this.dgvVet.Size = new System.Drawing.Size(666, 416);
            this.dgvVet.TabIndex = 14;
            this.dgvVet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVet_CellContentClick);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(111, 155);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(250, 27);
            this.tbEmail.TabIndex = 4;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndereco.Location = new System.Drawing.Point(111, 82);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(250, 27);
            this.tbEndereco.TabIndex = 2;
            // 
            // tbIdade
            // 
            this.tbIdade.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdade.Location = new System.Drawing.Point(111, 44);
            this.tbIdade.Name = "tbIdade";
            this.tbIdade.Size = new System.Drawing.Size(100, 27);
            this.tbIdade.TabIndex = 1;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(111, 6);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(250, 27);
            this.tbNome.TabIndex = 0;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Enabled = false;
            this.btAtualizar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.ForeColor = System.Drawing.SystemColors.Window;
            this.btAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btAtualizar.Image")));
            this.btAtualizar.Location = new System.Drawing.Point(15, 296);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(338, 33);
            this.btAtualizar.TabIndex = 7;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click_1);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.SystemColors.Window;
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.Location = new System.Drawing.Point(281, 442);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(237, 33);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click_1);
            // 
            // btCadastro
            // 
            this.btCadastro.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastro.ForeColor = System.Drawing.SystemColors.Window;
            this.btCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btCadastro.Image")));
            this.btCadastro.Location = new System.Drawing.Point(15, 243);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(338, 32);
            this.btCadastro.TabIndex = 6;
            this.btCadastro.Text = "Cadastrar";
            this.btCadastro.UseVisualStyleBackColor = true;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(12, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Telefone:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Email:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "CPF:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Endereço:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Idade:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btHistorico
            // 
            this.btHistorico.Enabled = false;
            this.btHistorico.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistorico.ForeColor = System.Drawing.SystemColors.Window;
            this.btHistorico.Image = ((System.Drawing.Image)(resources.GetObject("btHistorico.Image")));
            this.btHistorico.Location = new System.Drawing.Point(281, 500);
            this.btHistorico.Name = "btHistorico";
            this.btHistorico.Size = new System.Drawing.Size(239, 33);
            this.btHistorico.TabIndex = 13;
            this.btHistorico.Text = "Agenda de Consultas";
            this.btHistorico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btHistorico.UseVisualStyleBackColor = true;
            this.btHistorico.Click += new System.EventHandler(this.btHistorico_Click);
            // 
            // FormVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG701;
            this.ClientSize = new System.Drawing.Size(1188, 555);
            this.Controls.Add(this.btHistorico);
            this.Controls.Add(this.btLista);
            this.Controls.Add(this.mkCPF);
            this.Controls.Add(this.mkCPFBusca);
            this.Controls.Add(this.mkTelefone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btBusca);
            this.Controls.Add(this.tbBusca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvVet);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.tbIdade);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormVeterinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinário";
            this.Load += new System.EventHandler(this.FormVeterinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLista;
        private System.Windows.Forms.MaskedTextBox mkCPF;
        private System.Windows.Forms.MaskedTextBox mkCPFBusca;
        private System.Windows.Forms.MaskedTextBox mkTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btBusca;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvVet;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbIdade;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btHistorico;
    }
}