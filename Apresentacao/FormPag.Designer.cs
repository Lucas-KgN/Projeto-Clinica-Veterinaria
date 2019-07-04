namespace Apresentacao
{
    partial class FormPag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPag));
            this.btBusca = new System.Windows.Forms.Button();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPagamentos = new System.Windows.Forms.DataGridView();
            this.btLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btBusca
            // 
            this.btBusca.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusca.ForeColor = System.Drawing.SystemColors.Window;
            this.btBusca.Image = ((System.Drawing.Image)(resources.GetObject("btBusca.Image")));
            this.btBusca.Location = new System.Drawing.Point(715, 262);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(207, 37);
            this.btBusca.TabIndex = 4;
            this.btBusca.Text = "Buscar Cliente";
            this.btBusca.UseVisualStyleBackColor = true;
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click);
            // 
            // tbBusca
            // 
            this.tbBusca.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusca.Location = new System.Drawing.Point(786, 202);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(136, 27);
            this.tbBusca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(704, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cliente:";
            // 
            // btConfirmar
            // 
            this.btConfirmar.Enabled = false;
            this.btConfirmar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.ForeColor = System.Drawing.SystemColors.Window;
            this.btConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btConfirmar.Image")));
            this.btConfirmar.Location = new System.Drawing.Point(715, 117);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(207, 35);
            this.btConfirmar.TabIndex = 2;
            this.btConfirmar.Text = "Confirmar Pagamento";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // tbValor
            // 
            this.tbValor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValor.Location = new System.Drawing.Point(806, 60);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(116, 27);
            this.tbValor.TabIndex = 1;
            // 
            // tbCliente
            // 
            this.tbCliente.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(786, 15);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(136, 27);
            this.tbCliente.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(704, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(704, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cliente:";
            // 
            // dgvPagamentos
            // 
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamentos.Location = new System.Drawing.Point(12, 12);
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.RowTemplate.Height = 24;
            this.dgvPagamentos.Size = new System.Drawing.Size(675, 390);
            this.dgvPagamentos.TabIndex = 22;
            this.dgvPagamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagamentos_CellContentClick);
            // 
            // btLista
            // 
            this.btLista.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLista.ForeColor = System.Drawing.SystemColors.Window;
            this.btLista.Image = ((System.Drawing.Image)(resources.GetObject("btLista.Image")));
            this.btLista.Location = new System.Drawing.Point(715, 320);
            this.btLista.Name = "btLista";
            this.btLista.Size = new System.Drawing.Size(207, 37);
            this.btLista.TabIndex = 5;
            this.btLista.Text = "Lista de Contas";
            this.btLista.UseVisualStyleBackColor = true;
            this.btLista.Click += new System.EventHandler(this.btLista_Click);
            // 
            // FormPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG701;
            this.ClientSize = new System.Drawing.Size(945, 428);
            this.Controls.Add(this.btLista);
            this.Controls.Add(this.dgvPagamentos);
            this.Controls.Add(this.btBusca);
            this.Controls.Add(this.tbBusca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.FormPag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBusca;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPagamentos;
        private System.Windows.Forms.Button btLista;
    }
}