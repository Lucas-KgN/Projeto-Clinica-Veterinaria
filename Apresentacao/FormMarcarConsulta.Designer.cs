namespace Apresentacao
{
    partial class FormMarcarConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarcarConsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btMarcar = new System.Windows.Forms.Button();
            this.tbDono = new System.Windows.Forms.TextBox();
            this.tbPet = new System.Windows.Forms.TextBox();
            this.dgvConsultaVets = new System.Windows.Forms.DataGridView();
            this.tbVet = new System.Windows.Forms.TextBox();
            this.mcData = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.TextBox();
            this.btData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVets)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(8, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Veterinário:";
            // 
            // btMarcar
            // 
            this.btMarcar.Enabled = false;
            this.btMarcar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMarcar.ForeColor = System.Drawing.SystemColors.Window;
            this.btMarcar.Image = ((System.Drawing.Image)(resources.GetObject("btMarcar.Image")));
            this.btMarcar.Location = new System.Drawing.Point(327, 421);
            this.btMarcar.Name = "btMarcar";
            this.btMarcar.Size = new System.Drawing.Size(206, 31);
            this.btMarcar.TabIndex = 6;
            this.btMarcar.Text = "Marcar";
            this.btMarcar.UseVisualStyleBackColor = true;
            this.btMarcar.Click += new System.EventHandler(this.btMarcar_Click);
            // 
            // tbDono
            // 
            this.tbDono.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDono.Location = new System.Drawing.Point(80, 36);
            this.tbDono.Name = "tbDono";
            this.tbDono.Size = new System.Drawing.Size(122, 27);
            this.tbDono.TabIndex = 0;
            // 
            // tbPet
            // 
            this.tbPet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPet.Location = new System.Drawing.Point(66, 90);
            this.tbPet.Name = "tbPet";
            this.tbPet.Size = new System.Drawing.Size(122, 27);
            this.tbPet.TabIndex = 1;
            // 
            // dgvConsultaVets
            // 
            this.dgvConsultaVets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVets.Location = new System.Drawing.Point(327, 73);
            this.dgvConsultaVets.Name = "dgvConsultaVets";
            this.dgvConsultaVets.RowTemplate.Height = 24;
            this.dgvConsultaVets.Size = new System.Drawing.Size(560, 206);
            this.dgvConsultaVets.TabIndex = 7;
            this.dgvConsultaVets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbVet
            // 
            this.tbVet.Enabled = false;
            this.tbVet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVet.Location = new System.Drawing.Point(123, 142);
            this.tbVet.Name = "tbVet";
            this.tbVet.Size = new System.Drawing.Size(121, 27);
            this.tbVet.TabIndex = 2;
            // 
            // mcData
            // 
            this.mcData.Location = new System.Drawing.Point(12, 245);
            this.mcData.Name = "mcData";
            this.mcData.TabIndex = 4;
            this.mcData.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcData_DateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(8, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data:";
            // 
            // tbData
            // 
            this.tbData.Enabled = false;
            this.tbData.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbData.Location = new System.Drawing.Point(71, 194);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(161, 27);
            this.tbData.TabIndex = 3;
            // 
            // btData
            // 
            this.btData.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btData.ForeColor = System.Drawing.SystemColors.Window;
            this.btData.Image = ((System.Drawing.Image)(resources.GetObject("btData.Image")));
            this.btData.Location = new System.Drawing.Point(327, 366);
            this.btData.Name = "btData";
            this.btData.Size = new System.Drawing.Size(206, 28);
            this.btData.TabIndex = 5;
            this.btData.Text = "Confirmar Data";
            this.btData.UseVisualStyleBackColor = true;
            this.btData.Click += new System.EventHandler(this.btData_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(348, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(525, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Por favor selecione um veterinário e uma data para a consulta.";
            // 
            // FormMarcarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG702;
            this.ClientSize = new System.Drawing.Size(938, 481);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btData);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mcData);
            this.Controls.Add(this.tbVet);
            this.Controls.Add(this.dgvConsultaVets);
            this.Controls.Add(this.tbPet);
            this.Controls.Add(this.tbDono);
            this.Controls.Add(this.btMarcar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMarcarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btMarcar;
        private System.Windows.Forms.TextBox tbDono;
        private System.Windows.Forms.TextBox tbPet;
        private System.Windows.Forms.DataGridView dgvConsultaVets;
        private System.Windows.Forms.TextBox tbVet;
        private System.Windows.Forms.MonthCalendar mcData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btData;
        private System.Windows.Forms.Label label5;
    }
}