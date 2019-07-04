namespace Apresentacao
{
    partial class FormCriarExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCriarExame));
            this.btLista = new System.Windows.Forms.Button();
            this.btBusca = new System.Windows.Forms.Button();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbTempo = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCadastro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbObjetivo = new System.Windows.Forms.RichTextBox();
            this.dgvExames = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btAgendados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).BeginInit();
            this.SuspendLayout();
            // 
            // btLista
            // 
            this.btLista.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLista.ForeColor = System.Drawing.SystemColors.Window;
            this.btLista.Image = ((System.Drawing.Image)(resources.GetObject("btLista.Image")));
            this.btLista.Location = new System.Drawing.Point(22, 551);
            this.btLista.Name = "btLista";
            this.btLista.Size = new System.Drawing.Size(251, 48);
            this.btLista.TabIndex = 9;
            this.btLista.Text = "Lista de Exames";
            this.btLista.UseVisualStyleBackColor = true;
            this.btLista.Click += new System.EventHandler(this.btLista_Click);
            // 
            // btBusca
            // 
            this.btBusca.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusca.ForeColor = System.Drawing.SystemColors.Window;
            this.btBusca.Image = ((System.Drawing.Image)(resources.GetObject("btBusca.Image")));
            this.btBusca.Location = new System.Drawing.Point(22, 478);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(251, 48);
            this.btBusca.TabIndex = 7;
            this.btBusca.Text = "Buscar Exame";
            this.btBusca.UseVisualStyleBackColor = true;
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click);
            // 
            // tbBusca
            // 
            this.tbBusca.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusca.Location = new System.Drawing.Point(183, 415);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(243, 27);
            this.tbBusca.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(8, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 22);
            this.label7.TabIndex = 42;
            this.label7.Text = "Nome do exame:";
            // 
            // tbValor
            // 
            this.tbValor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValor.Location = new System.Drawing.Point(74, 236);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(115, 27);
            this.tbValor.TabIndex = 3;
            // 
            // tbTempo
            // 
            this.tbTempo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTempo.Location = new System.Drawing.Point(191, 200);
            this.tbTempo.Name = "tbTempo";
            this.tbTempo.Size = new System.Drawing.Size(97, 27);
            this.tbTempo.TabIndex = 2;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(183, 17);
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
            this.btAtualizar.Location = new System.Drawing.Point(21, 335);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(338, 34);
            this.btAtualizar.TabIndex = 5;
            this.btAtualizar.Text = "Atualizar Exame";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.SystemColors.Window;
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.Location = new System.Drawing.Point(279, 478);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(251, 48);
            this.btExcluir.TabIndex = 8;
            this.btExcluir.Text = "Excluir Exame";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btCadastro
            // 
            this.btCadastro.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastro.ForeColor = System.Drawing.SystemColors.Window;
            this.btCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btCadastro.Image")));
            this.btCadastro.Location = new System.Drawing.Point(21, 286);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(338, 34);
            this.btCadastro.TabIndex = 4;
            this.btCadastro.Text = "Cadastrar Exame";
            this.btCadastro.UseVisualStyleBackColor = true;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(7, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(7, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tempo de execução:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Objetivo do exame:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome do exame:";
            // 
            // tbObjetivo
            // 
            this.tbObjetivo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObjetivo.Location = new System.Drawing.Point(191, 54);
            this.tbObjetivo.Name = "tbObjetivo";
            this.tbObjetivo.Size = new System.Drawing.Size(235, 133);
            this.tbObjetivo.TabIndex = 1;
            this.tbObjetivo.Text = "";
            // 
            // dgvExames
            // 
            this.dgvExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExames.Location = new System.Drawing.Point(470, 54);
            this.dgvExames.Name = "dgvExames";
            this.dgvExames.RowTemplate.Height = 24;
            this.dgvExames.Size = new System.Drawing.Size(458, 330);
            this.dgvExames.TabIndex = 46;
            this.dgvExames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExames_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(632, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 22);
            this.label4.TabIndex = 47;
            this.label4.Text = "Exames da clínica";
            // 
            // btAgendados
            // 
            this.btAgendados.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgendados.ForeColor = System.Drawing.SystemColors.Window;
            this.btAgendados.Image = ((System.Drawing.Image)(resources.GetObject("btAgendados.Image")));
            this.btAgendados.Location = new System.Drawing.Point(279, 551);
            this.btAgendados.Name = "btAgendados";
            this.btAgendados.Size = new System.Drawing.Size(251, 48);
            this.btAgendados.TabIndex = 10;
            this.btAgendados.Text = "Exames Agendados";
            this.btAgendados.UseVisualStyleBackColor = true;
            this.btAgendados.Click += new System.EventHandler(this.btAgendados_Click);
            // 
            // FormCriarExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG702;
            this.ClientSize = new System.Drawing.Size(974, 622);
            this.Controls.Add(this.btAgendados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvExames);
            this.Controls.Add(this.tbObjetivo);
            this.Controls.Add(this.btLista);
            this.Controls.Add(this.btBusca);
            this.Controls.Add(this.tbBusca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbTempo);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCriarExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exames";
            this.Load += new System.EventHandler(this.FormCriarExame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btLista;
        private System.Windows.Forms.Button btBusca;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbTempo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbObjetivo;
        private System.Windows.Forms.DataGridView dgvExames;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAgendados;
    }
}