namespace Apresentacao
{
    partial class FormOpcaoExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpcaoExame));
            this.btInformacoes = new System.Windows.Forms.Button();
            this.btMarcar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btInformacoes
            // 
            this.btInformacoes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btInformacoes.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInformacoes.ForeColor = System.Drawing.SystemColors.Window;
            this.btInformacoes.Image = ((System.Drawing.Image)(resources.GetObject("btInformacoes.Image")));
            this.btInformacoes.Location = new System.Drawing.Point(30, 12);
            this.btInformacoes.Name = "btInformacoes";
            this.btInformacoes.Size = new System.Drawing.Size(178, 37);
            this.btInformacoes.TabIndex = 0;
            this.btInformacoes.Text = "Informações ";
            this.btInformacoes.UseVisualStyleBackColor = false;
            this.btInformacoes.Click += new System.EventHandler(this.btInformacoes_Click);
            // 
            // btMarcar
            // 
            this.btMarcar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btMarcar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMarcar.ForeColor = System.Drawing.SystemColors.Window;
            this.btMarcar.Image = ((System.Drawing.Image)(resources.GetObject("btMarcar.Image")));
            this.btMarcar.Location = new System.Drawing.Point(233, 12);
            this.btMarcar.Name = "btMarcar";
            this.btMarcar.Size = new System.Drawing.Size(182, 37);
            this.btMarcar.TabIndex = 1;
            this.btMarcar.Text = "Marcar Exame";
            this.btMarcar.UseVisualStyleBackColor = false;
            this.btMarcar.Click += new System.EventHandler(this.btMarcar_Click);
            // 
            // FormOpcaoExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG70;
            this.ClientSize = new System.Drawing.Size(444, 67);
            this.Controls.Add(this.btMarcar);
            this.Controls.Add(this.btInformacoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormOpcaoExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opções";
            this.Load += new System.EventHandler(this.FormOpcaoExame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btInformacoes;
        private System.Windows.Forms.Button btMarcar;
    }
}