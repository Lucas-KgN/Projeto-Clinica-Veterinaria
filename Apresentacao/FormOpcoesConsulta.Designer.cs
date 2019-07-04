namespace Apresentacao
{
    partial class FormOpcoesConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpcoesConsulta));
            this.btMarcar = new System.Windows.Forms.Button();
            this.btPos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMarcar
            // 
            this.btMarcar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btMarcar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMarcar.ForeColor = System.Drawing.SystemColors.Window;
            this.btMarcar.Image = ((System.Drawing.Image)(resources.GetObject("btMarcar.Image")));
            this.btMarcar.Location = new System.Drawing.Point(46, 12);
            this.btMarcar.Name = "btMarcar";
            this.btMarcar.Size = new System.Drawing.Size(199, 36);
            this.btMarcar.TabIndex = 0;
            this.btMarcar.Text = "Marcar Consulta";
            this.btMarcar.UseVisualStyleBackColor = false;
            this.btMarcar.Click += new System.EventHandler(this.btMarcar_Click);
            // 
            // btPos
            // 
            this.btPos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btPos.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPos.ForeColor = System.Drawing.SystemColors.Window;
            this.btPos.Image = ((System.Drawing.Image)(resources.GetObject("btPos.Image")));
            this.btPos.Location = new System.Drawing.Point(281, 12);
            this.btPos.Name = "btPos";
            this.btPos.Size = new System.Drawing.Size(199, 36);
            this.btPos.TabIndex = 1;
            this.btPos.Text = "Pós Consulta";
            this.btPos.UseVisualStyleBackColor = false;
            this.btPos.Click += new System.EventHandler(this.btPos_Click);
            // 
            // FormOpcoesConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG70;
            this.ClientSize = new System.Drawing.Size(522, 71);
            this.Controls.Add(this.btPos);
            this.Controls.Add(this.btMarcar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormOpcoesConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opções";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMarcar;
        private System.Windows.Forms.Button btPos;
    }
}