namespace Apresentacao
{
    partial class FormProntuarioPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProntuarioPet));
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDono = new System.Windows.Forms.Label();
            this.lbPet = new System.Windows.Forms.Label();
            this.lbVet = new System.Windows.Forms.Label();
            this.mkData = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.RowTemplate.Height = 24;
            this.dgvConsultas.Size = new System.Drawing.Size(699, 378);
            this.dgvConsultas.TabIndex = 0;
            this.dgvConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(18, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(295, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Veterinário:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(18, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(295, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbDono
            // 
            this.lbDono.AutoSize = true;
            this.lbDono.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDono.Location = new System.Drawing.Point(85, 422);
            this.lbDono.Name = "lbDono";
            this.lbDono.Size = new System.Drawing.Size(21, 19);
            this.lbDono.TabIndex = 5;
            this.lbDono.Text = "...";
            // 
            // lbPet
            // 
            this.lbPet.AutoSize = true;
            this.lbPet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPet.Location = new System.Drawing.Point(68, 455);
            this.lbPet.Name = "lbPet";
            this.lbPet.Size = new System.Drawing.Size(21, 19);
            this.lbPet.TabIndex = 6;
            this.lbPet.Text = "...";
            // 
            // lbVet
            // 
            this.lbVet.AutoSize = true;
            this.lbVet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVet.Location = new System.Drawing.Point(410, 422);
            this.lbVet.Name = "lbVet";
            this.lbVet.Size = new System.Drawing.Size(21, 19);
            this.lbVet.TabIndex = 7;
            this.lbVet.Text = "...";
            this.lbVet.Click += new System.EventHandler(this.label7_Click);
            // 
            // mkData
            // 
            this.mkData.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkData.Location = new System.Drawing.Point(358, 448);
            this.mkData.Mask = "00/00/0000";
            this.mkData.Name = "mkData";
            this.mkData.Size = new System.Drawing.Size(95, 27);
            this.mkData.TabIndex = 8;
            this.mkData.ValidatingType = typeof(System.DateTime);
            // 
            // FormProntuarioPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG70;
            this.ClientSize = new System.Drawing.Size(729, 501);
            this.Controls.Add(this.mkData);
            this.Controls.Add(this.lbVet);
            this.Controls.Add(this.lbPet);
            this.Controls.Add(this.lbDono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormProntuarioPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prontuário";
            this.Load += new System.EventHandler(this.FormHistoricoPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDono;
        private System.Windows.Forms.Label lbPet;
        private System.Windows.Forms.Label lbVet;
        private System.Windows.Forms.MaskedTextBox mkData;
    }
}