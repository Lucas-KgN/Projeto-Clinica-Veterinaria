namespace Apresentacao
{
    partial class FormAgendaVet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgendaVet));
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.mkDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.mkDataFim = new System.Windows.Forms.MaskedTextBox();
            this.btConfirmaData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(345, 12);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.RowTemplate.Height = 24;
            this.dgvConsultas.Size = new System.Drawing.Size(776, 426);
            this.dgvConsultas.TabIndex = 0;
            this.dgvConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(18, 18);
            this.calendario.MaxSelectionCount = 30;
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 14;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // mkDataInicio
            // 
            this.mkDataInicio.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkDataInicio.Location = new System.Drawing.Point(151, 311);
            this.mkDataInicio.Mask = "00/00/0000";
            this.mkDataInicio.Name = "mkDataInicio";
            this.mkDataInicio.Size = new System.Drawing.Size(100, 27);
            this.mkDataInicio.TabIndex = 13;
            this.mkDataInicio.ValidatingType = typeof(System.DateTime);
            this.mkDataInicio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkDataInicio_MaskInputRejected);
            // 
            // mkDataFim
            // 
            this.mkDataFim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkDataFim.Location = new System.Drawing.Point(151, 351);
            this.mkDataFim.Mask = "00/00/0000";
            this.mkDataFim.Name = "mkDataFim";
            this.mkDataFim.Size = new System.Drawing.Size(100, 27);
            this.mkDataFim.TabIndex = 12;
            // 
            // btConfirmaData
            // 
            this.btConfirmaData.BackColor = System.Drawing.SystemColors.Window;
            this.btConfirmaData.Enabled = false;
            this.btConfirmaData.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmaData.ForeColor = System.Drawing.SystemColors.Window;
            this.btConfirmaData.Image = global::Apresentacao.Properties.Resources.OPSEG702;
            this.btConfirmaData.Location = new System.Drawing.Point(49, 237);
            this.btConfirmaData.Name = "btConfirmaData";
            this.btConfirmaData.Size = new System.Drawing.Size(202, 39);
            this.btConfirmaData.TabIndex = 11;
            this.btConfirmaData.Text = "Confirmar Data";
            this.btConfirmaData.UseVisualStyleBackColor = false;
            this.btConfirmaData.Click += new System.EventHandler(this.btConfirmaData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Image = global::Apresentacao.Properties.Resources.OPSEG70;
            this.label2.Location = new System.Drawing.Point(11, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data de Fim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Image = global::Apresentacao.Properties.Resources.OPSEG70;
            this.label1.Location = new System.Drawing.Point(11, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data de Inicio:";
            // 
            // FormAgendaVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG70;
            this.ClientSize = new System.Drawing.Size(1138, 450);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.mkDataInicio);
            this.Controls.Add(this.mkDataFim);
            this.Controls.Add(this.btConfirmaData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAgendaVet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Veterinário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAgendaVet_FormClosing);
            this.Load += new System.EventHandler(this.FormHistoricoVet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.MaskedTextBox mkDataInicio;
        private System.Windows.Forms.MaskedTextBox mkDataFim;
        private System.Windows.Forms.Button btConfirmaData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}