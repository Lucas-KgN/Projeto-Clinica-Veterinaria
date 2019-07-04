namespace Apresentacao
{
    partial class FormAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnimal));
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.tbRaca = new System.Windows.Forms.TextBox();
            this.btCadastro = new System.Windows.Forms.Button();
            this.dgvPet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBuscaNome = new System.Windows.Forms.TextBox();
            this.btBusca = new System.Windows.Forms.Button();
            this.btListaPets = new System.Windows.Forms.Button();
            this.btConsulta = new System.Windows.Forms.Button();
            this.btHistorico = new System.Windows.Forms.Button();
            this.btExames = new System.Windows.Forms.Button();
            this.tbIdade = new System.Windows.Forms.TextBox();
            this.btAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.SystemColors.Window;
            this.Nome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nome.Image = global::Apresentacao.Properties.Resources.OPSEG70;
            this.Nome.Location = new System.Drawing.Point(13, 23);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(63, 22);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Raça:";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(82, 24);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 27);
            this.tbNome.TabIndex = 0;
            // 
            // tbTipo
            // 
            this.tbTipo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTipo.Location = new System.Drawing.Point(82, 111);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(100, 27);
            this.tbTipo.TabIndex = 2;
            // 
            // tbRaca
            // 
            this.tbRaca.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRaca.Location = new System.Drawing.Point(82, 150);
            this.tbRaca.Name = "tbRaca";
            this.tbRaca.Size = new System.Drawing.Size(100, 27);
            this.tbRaca.TabIndex = 3;
            // 
            // btCadastro
            // 
            this.btCadastro.BackColor = System.Drawing.SystemColors.Window;
            this.btCadastro.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btCadastro.Image")));
            this.btCadastro.Location = new System.Drawing.Point(30, 207);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(152, 41);
            this.btCadastro.TabIndex = 4;
            this.btCadastro.Text = "Cadastro";
            this.btCadastro.UseVisualStyleBackColor = false;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // dgvPet
            // 
            this.dgvPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPet.Location = new System.Drawing.Point(218, 18);
            this.dgvPet.Name = "dgvPet";
            this.dgvPet.RowTemplate.Height = 24;
            this.dgvPet.Size = new System.Drawing.Size(662, 266);
            this.dgvPet.TabIndex = 9;
            this.dgvPet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPet_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = global::Apresentacao.Properties.Resources.OPSEG70;
            this.label1.Location = new System.Drawing.Point(13, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbBuscaNome
            // 
            this.tbBuscaNome.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscaNome.Location = new System.Drawing.Point(82, 341);
            this.tbBuscaNome.Name = "tbBuscaNome";
            this.tbBuscaNome.Size = new System.Drawing.Size(100, 27);
            this.tbBuscaNome.TabIndex = 5;
            // 
            // btBusca
            // 
            this.btBusca.BackColor = System.Drawing.SystemColors.Window;
            this.btBusca.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBusca.Image = ((System.Drawing.Image)(resources.GetObject("btBusca.Image")));
            this.btBusca.Location = new System.Drawing.Point(17, 386);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(236, 41);
            this.btBusca.TabIndex = 12;
            this.btBusca.Text = "Buscar Pet";
            this.btBusca.UseVisualStyleBackColor = false;
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click);
            // 
            // btListaPets
            // 
            this.btListaPets.BackColor = System.Drawing.SystemColors.Window;
            this.btListaPets.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListaPets.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btListaPets.Image = ((System.Drawing.Image)(resources.GetObject("btListaPets.Image")));
            this.btListaPets.Location = new System.Drawing.Point(17, 451);
            this.btListaPets.Name = "btListaPets";
            this.btListaPets.Size = new System.Drawing.Size(236, 41);
            this.btListaPets.TabIndex = 13;
            this.btListaPets.Text = "Lista de Pets";
            this.btListaPets.UseVisualStyleBackColor = false;
            this.btListaPets.Click += new System.EventHandler(this.btListaPets_Click);
            // 
            // btConsulta
            // 
            this.btConsulta.BackColor = System.Drawing.SystemColors.Window;
            this.btConsulta.Enabled = false;
            this.btConsulta.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btConsulta.Image")));
            this.btConsulta.Location = new System.Drawing.Point(259, 386);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(236, 41);
            this.btConsulta.TabIndex = 14;
            this.btConsulta.Text = "Marcar Consulta";
            this.btConsulta.UseVisualStyleBackColor = false;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // btHistorico
            // 
            this.btHistorico.BackColor = System.Drawing.SystemColors.Window;
            this.btHistorico.Enabled = false;
            this.btHistorico.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistorico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btHistorico.Image = ((System.Drawing.Image)(resources.GetObject("btHistorico.Image")));
            this.btHistorico.Location = new System.Drawing.Point(501, 386);
            this.btHistorico.Name = "btHistorico";
            this.btHistorico.Size = new System.Drawing.Size(236, 41);
            this.btHistorico.TabIndex = 15;
            this.btHistorico.Text = "Prontuário";
            this.btHistorico.UseVisualStyleBackColor = false;
            this.btHistorico.Click += new System.EventHandler(this.button1_Click);
            // 
            // btExames
            // 
            this.btExames.BackColor = System.Drawing.SystemColors.Window;
            this.btExames.Enabled = false;
            this.btExames.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExames.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btExames.Image = ((System.Drawing.Image)(resources.GetObject("btExames.Image")));
            this.btExames.Location = new System.Drawing.Point(259, 451);
            this.btExames.Name = "btExames";
            this.btExames.Size = new System.Drawing.Size(236, 41);
            this.btExames.TabIndex = 16;
            this.btExames.Text = "Agenda de Exames";
            this.btExames.UseVisualStyleBackColor = false;
            this.btExames.Click += new System.EventHandler(this.btExames_Click);
            // 
            // tbIdade
            // 
            this.tbIdade.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdade.Location = new System.Drawing.Point(82, 69);
            this.tbIdade.Name = "tbIdade";
            this.tbIdade.Size = new System.Drawing.Size(100, 27);
            this.tbIdade.TabIndex = 1;
            // 
            // btAtualizar
            // 
            this.btAtualizar.BackColor = System.Drawing.SystemColors.Window;
            this.btAtualizar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btAtualizar.Image")));
            this.btAtualizar.Location = new System.Drawing.Point(30, 268);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(152, 41);
            this.btAtualizar.TabIndex = 17;
            this.btAtualizar.Text = "Atualização";
            this.btAtualizar.UseVisualStyleBackColor = false;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // FormAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG70;
            this.ClientSize = new System.Drawing.Size(908, 500);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btExames);
            this.Controls.Add(this.btHistorico);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.btListaPets);
            this.Controls.Add(this.btBusca);
            this.Controls.Add(this.tbBuscaNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPet);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.tbRaca);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.tbIdade);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAnimal_FormClosing);
            this.Load += new System.EventHandler(this.FormAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.TextBox tbRaca;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.DataGridView dgvPet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBuscaNome;
        private System.Windows.Forms.Button btBusca;
        private System.Windows.Forms.Button btListaPets;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button btHistorico;
        private System.Windows.Forms.Button btExames;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox tbIdade;
        private System.Windows.Forms.Button btAtualizar;
    }
}