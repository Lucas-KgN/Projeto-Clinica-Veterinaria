namespace Apresentacao
{
    partial class FormAgendaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgendaCliente));
            this.dgvConsultasCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btConfirmaData = new System.Windows.Forms.Button();
            this.mkDataFim = new System.Windows.Forms.MaskedTextBox();
            this.mkDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultasCliente
            // 
            this.dgvConsultasCliente.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvConsultasCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultasCliente.Location = new System.Drawing.Point(354, 12);
            this.dgvConsultasCliente.Name = "dgvConsultasCliente";
            this.dgvConsultasCliente.RowTemplate.Height = 24;
            this.dgvConsultasCliente.Size = new System.Drawing.Size(776, 426);
            this.dgvConsultasCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(6, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data de Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(6, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Fim:";
            // 
            // btConfirmaData
            // 
            this.btConfirmaData.BackColor = System.Drawing.SystemColors.Window;
            this.btConfirmaData.Enabled = false;
            this.btConfirmaData.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmaData.ForeColor = System.Drawing.SystemColors.Window;
            this.btConfirmaData.Image = ((System.Drawing.Image)(resources.GetObject("btConfirmaData.Image")));
            this.btConfirmaData.Location = new System.Drawing.Point(50, 237);
            this.btConfirmaData.Name = "btConfirmaData";
            this.btConfirmaData.Size = new System.Drawing.Size(200, 39);
            this.btConfirmaData.TabIndex = 5;
            this.btConfirmaData.Text = "Confirmar Data";
            this.btConfirmaData.UseVisualStyleBackColor = false;
            this.btConfirmaData.Click += new System.EventHandler(this.btConfirmaData_Click);
            // 
            // mkDataFim
            // 
            this.mkDataFim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkDataFim.Location = new System.Drawing.Point(150, 384);
            this.mkDataFim.Mask = "00/00/0000";
            this.mkDataFim.Name = "mkDataFim";
            this.mkDataFim.Size = new System.Drawing.Size(100, 27);
            this.mkDataFim.TabIndex = 6;
            // 
            // mkDataInicio
            // 
            this.mkDataInicio.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkDataInicio.Location = new System.Drawing.Point(150, 343);
            this.mkDataInicio.Mask = "00/00/0000";
            this.mkDataInicio.Name = "mkDataInicio";
            this.mkDataInicio.Size = new System.Drawing.Size(100, 27);
            this.mkDataInicio.TabIndex = 7;
            this.mkDataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // calendario
            // 
            this.calendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.calendario.Location = new System.Drawing.Point(18, 18);
            this.calendario.MaxSelectionCount = 30;
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 8;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateChanged);
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // FormAgendaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG701;
            this.ClientSize = new System.Drawing.Size(1146, 450);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.mkDataInicio);
            this.Controls.Add(this.mkDataFim);
            this.Controls.Add(this.btConfirmaData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultasCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAgendaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Cliente";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAgendaCliente_FormClosing);
            this.Load += new System.EventHandler(this.FormHistoricoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultasCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConfirmaData;
        private System.Windows.Forms.MaskedTextBox mkDataFim;
        private System.Windows.Forms.MaskedTextBox mkDataInicio;
        private System.Windows.Forms.MonthCalendar calendario;
    }
}