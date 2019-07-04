namespace Apresentacao
{
    partial class FormOpcaoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpcaoCaixa));
            this.btInformacoes = new System.Windows.Forms.Button();
            this.btPagamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btInformacoes
            // 
            this.btInformacoes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btInformacoes.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInformacoes.ForeColor = System.Drawing.SystemColors.Window;
            this.btInformacoes.Image = ((System.Drawing.Image)(resources.GetObject("btInformacoes.Image")));
            this.btInformacoes.Location = new System.Drawing.Point(12, 12);
            this.btInformacoes.Name = "btInformacoes";
            this.btInformacoes.Size = new System.Drawing.Size(235, 41);
            this.btInformacoes.TabIndex = 1;
            this.btInformacoes.Text = "Informações ";
            this.btInformacoes.UseVisualStyleBackColor = false;
            this.btInformacoes.Click += new System.EventHandler(this.btInformacoes_Click);
            // 
            // btPagamento
            // 
            this.btPagamento.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btPagamento.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPagamento.ForeColor = System.Drawing.SystemColors.Window;
            this.btPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btPagamento.Image")));
            this.btPagamento.Location = new System.Drawing.Point(279, 12);
            this.btPagamento.Name = "btPagamento";
            this.btPagamento.Size = new System.Drawing.Size(235, 41);
            this.btPagamento.TabIndex = 2;
            this.btPagamento.Text = "Realizar Pagamento";
            this.btPagamento.UseVisualStyleBackColor = false;
            this.btPagamento.Click += new System.EventHandler(this.btPagamento_Click);
            // 
            // FormOpcaoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG70;
            this.ClientSize = new System.Drawing.Size(540, 68);
            this.Controls.Add(this.btPagamento);
            this.Controls.Add(this.btInformacoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormOpcaoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opções";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btInformacoes;
        private System.Windows.Forms.Button btPagamento;
    }
}