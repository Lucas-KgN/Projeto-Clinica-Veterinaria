namespace Apresentacao
{
    partial class FormExamesAgendadosPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExamesAgendadosPet));
            this.dgvExames = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExames
            // 
            this.dgvExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExames.Location = new System.Drawing.Point(12, 12);
            this.dgvExames.Name = "dgvExames";
            this.dgvExames.RowTemplate.Height = 24;
            this.dgvExames.Size = new System.Drawing.Size(715, 426);
            this.dgvExames.TabIndex = 0;
            // 
            // FormExamesAgendadosPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.OPSEG702;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.dgvExames);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormExamesAgendadosPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exames Agendados";
            this.Load += new System.EventHandler(this.FormExamesAgendadosPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExames;
    }
}