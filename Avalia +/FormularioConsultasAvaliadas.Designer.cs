namespace Avalia__
{
    partial class FormularioConsultasAvaliadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioConsultasAvaliadas));
            this.panelConsultaAvaliadas = new System.Windows.Forms.Panel();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lblHistoricoConsulta = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelConsultaAvaliadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultaAvaliadas
            // 
            this.panelConsultaAvaliadas.Controls.Add(this.dgvConsultas);
            this.panelConsultaAvaliadas.Location = new System.Drawing.Point(58, 178);
            this.panelConsultaAvaliadas.Name = "panelConsultaAvaliadas";
            this.panelConsultaAvaliadas.Size = new System.Drawing.Size(868, 361);
            this.panelConsultaAvaliadas.TabIndex = 12;
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(0, 0);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.RowHeadersWidth = 51;
            this.dgvConsultas.Size = new System.Drawing.Size(877, 365);
            this.dgvConsultas.TabIndex = 0;
            this.dgvConsultas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultas_CellContentDoubleClick);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(884, 41);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 43);
            this.btnSair.TabIndex = 15;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbTitulo.Location = new System.Drawing.Point(69, 41);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(118, 31);
            this.lbTitulo.TabIndex = 14;
            this.lbTitulo.Text = "Áurea+";
            // 
            // lblHistoricoConsulta
            // 
            this.lblHistoricoConsulta.AutoSize = true;
            this.lblHistoricoConsulta.BackColor = System.Drawing.Color.Transparent;
            this.lblHistoricoConsulta.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoricoConsulta.Location = new System.Drawing.Point(126, 67);
            this.lblHistoricoConsulta.Name = "lblHistoricoConsulta";
            this.lblHistoricoConsulta.Size = new System.Drawing.Size(154, 29);
            this.lblHistoricoConsulta.TabIndex = 13;
            this.lblHistoricoConsulta.Text = "Minhas Consultas";
            // 
            // FormularioConsultasAvaliadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lblHistoricoConsulta);
            this.Controls.Add(this.panelConsultaAvaliadas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioConsultasAvaliadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas avaliadas";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormularioConsultasAvaliadas_Paint);
            this.panelConsultaAvaliadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultaAvaliadas;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lblHistoricoConsulta;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}