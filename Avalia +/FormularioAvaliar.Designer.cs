namespace Avalia__
{
    partial class FormularioAvaliar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioAvaliar));
            this.panelConsultaAvaliadas = new System.Windows.Forms.Panel();
            this.dgvConsultasAvaliadas = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lblHistoricoConsulta = new System.Windows.Forms.Label();
            this.lblTitulos = new System.Windows.Forms.Label();
            this.panelConsultaAvaliadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasAvaliadas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultaAvaliadas
            // 
            this.panelConsultaAvaliadas.Controls.Add(this.dgvConsultasAvaliadas);
            this.panelConsultaAvaliadas.Location = new System.Drawing.Point(47, 188);
            this.panelConsultaAvaliadas.Name = "panelConsultaAvaliadas";
            this.panelConsultaAvaliadas.Size = new System.Drawing.Size(868, 361);
            this.panelConsultaAvaliadas.TabIndex = 12;
            // 
            // dgvConsultasAvaliadas
            // 
            this.dgvConsultasAvaliadas.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultasAvaliadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultasAvaliadas.Location = new System.Drawing.Point(-3, 0);
            this.dgvConsultasAvaliadas.Name = "dgvConsultasAvaliadas";
            this.dgvConsultasAvaliadas.RowHeadersWidth = 51;
            this.dgvConsultasAvaliadas.Size = new System.Drawing.Size(877, 365);
            this.dgvConsultasAvaliadas.TabIndex = 0;
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
            this.btnSair.Location = new System.Drawing.Point(865, 66);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 43);
            this.btnSair.TabIndex = 15;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbTitulo.Location = new System.Drawing.Point(71, 66);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(118, 31);
            this.lbTitulo.TabIndex = 14;
            this.lbTitulo.Text = "Áurea+";
            // 
            // lblHistoricoConsulta
            // 
            this.lblHistoricoConsulta.AutoSize = true;
            this.lblHistoricoConsulta.BackColor = System.Drawing.Color.Transparent;
            this.lblHistoricoConsulta.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoricoConsulta.Location = new System.Drawing.Point(137, 88);
            this.lblHistoricoConsulta.Name = "lblHistoricoConsulta";
            this.lblHistoricoConsulta.Size = new System.Drawing.Size(170, 33);
            this.lblHistoricoConsulta.TabIndex = 13;
            this.lblHistoricoConsulta.Text = "Minhas Consultas";
            // 
            // lblTitulos
            // 
            this.lblTitulos.AutoSize = true;
            this.lblTitulos.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulos.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulos.Location = new System.Drawing.Point(399, 152);
            this.lblTitulos.Name = "lblTitulos";
            this.lblTitulos.Size = new System.Drawing.Size(170, 33);
            this.lblTitulos.TabIndex = 16;
            this.lblTitulos.Text = "Minhas Consultas";
            // 
            // FormularioAvaliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 707);
            this.Controls.Add(this.lblTitulos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lblHistoricoConsulta);
            this.Controls.Add(this.panelConsultaAvaliadas);
            this.Name = "FormularioAvaliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas Avaliadas";
            this.panelConsultaAvaliadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasAvaliadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultaAvaliadas;
        private System.Windows.Forms.DataGridView dgvConsultasAvaliadas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lblHistoricoConsulta;
        private System.Windows.Forms.Label lblTitulos;
    }
}