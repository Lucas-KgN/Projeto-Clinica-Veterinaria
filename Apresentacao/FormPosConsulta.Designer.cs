namespace Apresentacao
{
    partial class FormPosConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPosConsulta));
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.tbResumo = new System.Windows.Forms.RichTextBox();
            this.tbRemedios = new System.Windows.Forms.RichTextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVet = new System.Windows.Forms.TextBox();
            this.tbPet = new System.Windows.Forms.TextBox();
            this.tbDono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btRetorno = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(19, 19);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(581, 637);
            this.dgvConsulta.TabIndex = 0;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(662, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resumo da Consulta:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(718, 383);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medicamentos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(753, 621);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor Final:";
            // 
            // tbValor
            // 
            this.tbValor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValor.Location = new System.Drawing.Point(880, 617);
            this.tbValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(200, 27);
            this.tbValor.TabIndex = 6;
            // 
            // btConfirmar
            // 
            this.btConfirmar.Enabled = false;
            this.btConfirmar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.ForeColor = System.Drawing.SystemColors.Window;
            this.btConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btConfirmar.Image")));
            this.btConfirmar.Location = new System.Drawing.Point(745, 670);
            this.btConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(203, 37);
            this.btConfirmar.TabIndex = 7;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // tbResumo
            // 
            this.tbResumo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResumo.Location = new System.Drawing.Point(886, 150);
            this.tbResumo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbResumo.Name = "tbResumo";
            this.tbResumo.Size = new System.Drawing.Size(476, 191);
            this.tbResumo.TabIndex = 4;
            this.tbResumo.Text = "";
            // 
            // tbRemedios
            // 
            this.tbRemedios.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemedios.Location = new System.Drawing.Point(881, 377);
            this.tbRemedios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRemedios.Name = "tbRemedios";
            this.tbRemedios.Size = new System.Drawing.Size(481, 205);
            this.tbRemedios.TabIndex = 5;
            this.tbRemedios.Text = "";
            // 
            // tbData
            // 
            this.tbData.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbData.Location = new System.Drawing.Point(1096, 76);
            this.tbData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(75, 27);
            this.tbData.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(1024, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Data:";
            // 
            // tbVet
            // 
            this.tbVet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVet.Location = new System.Drawing.Point(1158, 23);
            this.tbVet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbVet.Name = "tbVet";
            this.tbVet.Size = new System.Drawing.Size(180, 27);
            this.tbVet.TabIndex = 2;
            // 
            // tbPet
            // 
            this.tbPet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPet.Location = new System.Drawing.Point(782, 76);
            this.tbPet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPet.Name = "tbPet";
            this.tbPet.Size = new System.Drawing.Size(181, 27);
            this.tbPet.TabIndex = 1;
            // 
            // tbDono
            // 
            this.tbDono.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDono.Location = new System.Drawing.Point(784, 23);
            this.tbDono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDono.Name = "tbDono";
            this.tbDono.Size = new System.Drawing.Size(181, 27);
            this.tbDono.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(1026, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Veterinário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(663, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(661, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dono:";
            // 
            // btRetorno
            // 
            this.btRetorno.Enabled = false;
            this.btRetorno.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetorno.ForeColor = System.Drawing.SystemColors.Window;
            this.btRetorno.Image = ((System.Drawing.Image)(resources.GetObject("btRetorno.Image")));
            this.btRetorno.Location = new System.Drawing.Point(957, 670);
            this.btRetorno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRetorno.Name = "btRetorno";
            this.btRetorno.Size = new System.Drawing.Size(203, 37);
            this.btRetorno.TabIndex = 8;
            this.btRetorno.Text = "Marcar Retorno";
            this.btRetorno.UseVisualStyleBackColor = true;
            this.btRetorno.Click += new System.EventHandler(this.btRetorno_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1169, 670);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Marcar Exame";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG701;
            this.ClientSize = new System.Drawing.Size(1419, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btRetorno);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVet);
            this.Controls.Add(this.tbPet);
            this.Controls.Add(this.tbDono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbRemedios);
            this.Controls.Add(this.tbResumo);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsulta);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormPosConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pós Consulta";
            this.Load += new System.EventHandler(this.FormPosConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.RichTextBox tbResumo;
        private System.Windows.Forms.RichTextBox tbRemedios;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVet;
        private System.Windows.Forms.TextBox tbPet;
        private System.Windows.Forms.TextBox tbDono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btRetorno;
        private System.Windows.Forms.Button button1;
    }
}