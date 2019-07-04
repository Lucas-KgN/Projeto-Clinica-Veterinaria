namespace Apresentacao
{
    partial class FormCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaixa));
            this.dgvGeral = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbValorFinal = new System.Windows.Forms.Label();
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGeral
            // 
            this.dgvGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeral.Location = new System.Drawing.Point(663, 54);
            this.dgvGeral.Name = "dgvGeral";
            this.dgvGeral.RowTemplate.Height = 24;
            this.dgvGeral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGeral.Size = new System.Drawing.Size(668, 495);
            this.dgvGeral.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(906, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Todos os registros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(27, 588);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor até o momento:";
            // 
            // lbValorFinal
            // 
            this.lbValorFinal.AutoSize = true;
            this.lbValorFinal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorFinal.ForeColor = System.Drawing.SystemColors.Window;
            this.lbValorFinal.Image = global::Apresentacao.Properties.Resources.OPSEG701;
            this.lbValorFinal.Location = new System.Drawing.Point(267, 588);
            this.lbValorFinal.Name = "lbValorFinal";
            this.lbValorFinal.Size = new System.Drawing.Size(30, 27);
            this.lbValorFinal.TabIndex = 6;
            this.lbValorFinal.Text = "...";
            this.lbValorFinal.Click += new System.EventHandler(this.lbValorFinal_Click);
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Location = new System.Drawing.Point(32, 54);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.RowTemplate.Height = 24;
            this.dgvCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaixa.Size = new System.Drawing.Size(563, 495);
            this.dgvCaixa.TabIndex = 7;
            this.dgvCaixa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaixa_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(206, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Entrada em caixa";
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG702;
            this.ClientSize = new System.Drawing.Size(1388, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCaixa);
            this.Controls.Add(this.lbValorFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGeral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.FormCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGeral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbValorFinal;
        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.Label label2;
    }
}