namespace Apresentacao
{
    partial class FormContasCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContasCliente));
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.mkData = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btPagamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContas
            // 
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Location = new System.Drawing.Point(13, 13);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.RowTemplate.Height = 24;
            this.dgvContas.Size = new System.Drawing.Size(604, 475);
            this.dgvContas.TabIndex = 0;
            this.dgvContas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(871, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(871, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data:";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(838, 49);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 3;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateChanged);
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // tbValor
            // 
            this.tbValor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValor.Location = new System.Drawing.Point(943, 397);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 27);
            this.tbValor.TabIndex = 4;
            // 
            // mkData
            // 
            this.mkData.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkData.Location = new System.Drawing.Point(943, 280);
            this.mkData.Mask = "00/00/0000";
            this.mkData.Name = "mkData";
            this.mkData.Size = new System.Drawing.Size(100, 27);
            this.mkData.TabIndex = 5;
            this.mkData.ValidatingType = typeof(System.DateTime);
            this.mkData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkData_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(652, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(613, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selecione uma conta, em seguida uma data para o pagamento";
            // 
            // btConfirmar
            // 
            this.btConfirmar.Enabled = false;
            this.btConfirmar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.ForeColor = System.Drawing.SystemColors.Window;
            this.btConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btConfirmar.Image")));
            this.btConfirmar.Location = new System.Drawing.Point(875, 326);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(249, 35);
            this.btConfirmar.TabIndex = 7;
            this.btConfirmar.Text = "Confirmar Data";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btPagamento
            // 
            this.btPagamento.Enabled = false;
            this.btPagamento.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPagamento.ForeColor = System.Drawing.SystemColors.Window;
            this.btPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btPagamento.Image")));
            this.btPagamento.Location = new System.Drawing.Point(875, 442);
            this.btPagamento.Name = "btPagamento";
            this.btPagamento.Size = new System.Drawing.Size(249, 40);
            this.btPagamento.TabIndex = 8;
            this.btPagamento.Text = "Pagamento na hora";
            this.btPagamento.UseVisualStyleBackColor = true;
            this.btPagamento.Click += new System.EventHandler(this.btPagamento_Click);
            // 
            // FormContasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG701;
            this.ClientSize = new System.Drawing.Size(1318, 516);
            this.Controls.Add(this.btPagamento);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mkData);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvContas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormContasCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormContasCliente_FormClosing);
            this.Load += new System.EventHandler(this.FormContasCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.MaskedTextBox mkData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btPagamento;
    }
}