namespace Apresentacao
{
    partial class FormMarcarExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarcarExame));
            this.tbPet = new System.Windows.Forms.TextBox();
            this.tbDono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvExames = new System.Windows.Forms.DataGridView();
            this.tbData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbObjetivo = new System.Windows.Forms.RichTextBox();
            this.tbTempo = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btData = new System.Windows.Forms.Button();
            this.mcData = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPet
            // 
            this.tbPet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPet.Location = new System.Drawing.Point(667, 75);
            this.tbPet.Name = "tbPet";
            this.tbPet.Size = new System.Drawing.Size(122, 27);
            this.tbPet.TabIndex = 1;
            // 
            // tbDono
            // 
            this.tbDono.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDono.Location = new System.Drawing.Point(676, 28);
            this.tbDono.Name = "tbDono";
            this.tbDono.Size = new System.Drawing.Size(122, 27);
            this.tbDono.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(608, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "Pet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(599, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Dono:";
            // 
            // btConfirmar
            // 
            this.btConfirmar.Enabled = false;
            this.btConfirmar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.ForeColor = System.Drawing.SystemColors.Window;
            this.btConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btConfirmar.Image")));
            this.btConfirmar.Location = new System.Drawing.Point(1012, 365);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(206, 37);
            this.btConfirmar.TabIndex = 8;
            this.btConfirmar.Text = "Confirmar Exame";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // tbValor
            // 
            this.tbValor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValor.Location = new System.Drawing.Point(712, 364);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(135, 27);
            this.tbValor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(581, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Valor Final:";
            // 
            // dgvExames
            // 
            this.dgvExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExames.Location = new System.Drawing.Point(12, 12);
            this.dgvExames.Name = "dgvExames";
            this.dgvExames.RowTemplate.Height = 24;
            this.dgvExames.Size = new System.Drawing.Size(503, 486);
            this.dgvExames.TabIndex = 20;
            this.dgvExames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExames_CellContentClick);
            // 
            // tbData
            // 
            this.tbData.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbData.Location = new System.Drawing.Point(1040, 28);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(86, 27);
            this.tbData.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(977, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "Data:";
            // 
            // tbObjetivo
            // 
            this.tbObjetivo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObjetivo.Location = new System.Drawing.Point(712, 168);
            this.tbObjetivo.Name = "tbObjetivo";
            this.tbObjetivo.Size = new System.Drawing.Size(235, 133);
            this.tbObjetivo.TabIndex = 3;
            this.tbObjetivo.Text = "";
            // 
            // tbTempo
            // 
            this.tbTempo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTempo.Location = new System.Drawing.Point(712, 318);
            this.tbTempo.Name = "tbTempo";
            this.tbTempo.Size = new System.Drawing.Size(106, 27);
            this.tbTempo.TabIndex = 4;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(697, 117);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(250, 27);
            this.tbNome.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(531, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 22);
            this.label5.TabIndex = 47;
            this.label5.Text = "Tempo de execução:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(531, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 22);
            this.label8.TabIndex = 46;
            this.label8.Text = "Objetivo do exame:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(531, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 22);
            this.label9.TabIndex = 45;
            this.label9.Text = "Nome do exame:";
            // 
            // btData
            // 
            this.btData.Enabled = false;
            this.btData.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btData.ForeColor = System.Drawing.SystemColors.Window;
            this.btData.Image = ((System.Drawing.Image)(resources.GetObject("btData.Image")));
            this.btData.Location = new System.Drawing.Point(1012, 308);
            this.btData.Name = "btData";
            this.btData.Size = new System.Drawing.Size(206, 37);
            this.btData.TabIndex = 7;
            this.btData.Text = "Confirmar Data";
            this.btData.UseVisualStyleBackColor = true;
            this.btData.Click += new System.EventHandler(this.btData_Click);
            // 
            // mcData
            // 
            this.mcData.Location = new System.Drawing.Point(981, 76);
            this.mcData.Name = "mcData";
            this.mcData.TabIndex = 48;
            this.mcData.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcData_DateChanged);
            // 
            // FormMarcarExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG70;
            this.ClientSize = new System.Drawing.Size(1312, 514);
            this.Controls.Add(this.btData);
            this.Controls.Add(this.mcData);
            this.Controls.Add(this.tbObjetivo);
            this.Controls.Add(this.tbTempo);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPet);
            this.Controls.Add(this.tbDono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvExames);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMarcarExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMarcarExame_FormClosing);
            this.Load += new System.EventHandler(this.FormMarcarExame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPet;
        private System.Windows.Forms.TextBox tbDono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvExames;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbObjetivo;
        private System.Windows.Forms.TextBox tbTempo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btData;
        private System.Windows.Forms.MonthCalendar mcData;
    }
}