namespace Avalia__
{
    partial class FormularioConsultasAgendadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioConsultasAgendadas));
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.lblHistoricoConsulta = new System.Windows.Forms.Label();
            this.btnConsultasTotais = new System.Windows.Forms.Button();
            this.btnRealizadas = new System.Windows.Forms.Button();
            this.btnAgendadas = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(78, 262);
            this.dgvConsultas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.RowHeadersWidth = 51;
            this.dgvConsultas.Size = new System.Drawing.Size(1135, 487);
            this.dgvConsultas.TabIndex = 0;
            // 
            // lblHistoricoConsulta
            // 
            this.lblHistoricoConsulta.AutoSize = true;
            this.lblHistoricoConsulta.BackColor = System.Drawing.Color.Transparent;
            this.lblHistoricoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoricoConsulta.Location = new System.Drawing.Point(73, 94);
            this.lblHistoricoConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistoricoConsulta.Name = "lblHistoricoConsulta";
            this.lblHistoricoConsulta.Size = new System.Drawing.Size(218, 29);
            this.lblHistoricoConsulta.TabIndex = 1;
            this.lblHistoricoConsulta.Text = "Minhas Consultas";
            // 
            // btnConsultasTotais
            // 
            this.btnConsultasTotais.BackColor = System.Drawing.Color.White;
            this.btnConsultasTotais.FlatAppearance.BorderSize = 0;
            this.btnConsultasTotais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultasTotais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultasTotais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.btnConsultasTotais.Location = new System.Drawing.Point(78, 179);
            this.btnConsultasTotais.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultasTotais.Name = "btnConsultasTotais";
            this.btnConsultasTotais.Size = new System.Drawing.Size(131, 42);
            this.btnConsultasTotais.TabIndex = 2;
            this.btnConsultasTotais.Text = "Todas";
            this.btnConsultasTotais.UseVisualStyleBackColor = false;
            this.btnConsultasTotais.Click += new System.EventHandler(this.btnConsultasTotais_Click);
            // 
            // btnRealizadas
            // 
            this.btnRealizadas.BackColor = System.Drawing.Color.White;
            this.btnRealizadas.FlatAppearance.BorderSize = 0;
            this.btnRealizadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.btnRealizadas.Location = new System.Drawing.Point(406, 179);
            this.btnRealizadas.Margin = new System.Windows.Forms.Padding(4);
            this.btnRealizadas.Name = "btnRealizadas";
            this.btnRealizadas.Size = new System.Drawing.Size(131, 42);
            this.btnRealizadas.TabIndex = 3;
            this.btnRealizadas.Text = "Realizadas";
            this.btnRealizadas.UseVisualStyleBackColor = false;
            this.btnRealizadas.Click += new System.EventHandler(this.btnRealizadas_Click);
            // 
            // btnAgendadas
            // 
            this.btnAgendadas.BackColor = System.Drawing.Color.White;
            this.btnAgendadas.FlatAppearance.BorderSize = 0;
            this.btnAgendadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.btnAgendadas.Location = new System.Drawing.Point(233, 179);
            this.btnAgendadas.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgendadas.Name = "btnAgendadas";
            this.btnAgendadas.Size = new System.Drawing.Size(143, 42);
            this.btnAgendadas.TabIndex = 4;
            this.btnAgendadas.Text = "Agendadas";
            this.btnAgendadas.UseVisualStyleBackColor = false;
            this.btnAgendadas.Click += new System.EventHandler(this.btnAgendadas_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.btnCancelar.Location = new System.Drawing.Point(568, 179);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 42);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(76, 41);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(81, 29);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "Aurea";
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
            this.btnSair.Location = new System.Drawing.Point(1149, 41);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(67, 53);
            this.btnSair.TabIndex = 10;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormularioConsultasAgendadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1312, 683);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgendadas);
            this.Controls.Add(this.btnRealizadas);
            this.Controls.Add(this.btnConsultasTotais);
            this.Controls.Add(this.lblHistoricoConsulta);
            this.Controls.Add(this.dgvConsultas);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioConsultasAgendadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minha consultas";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormularioConsultasAgendadas_Paint_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Label lblHistoricoConsulta;
        private System.Windows.Forms.Button btnConsultasTotais;
        private System.Windows.Forms.Button btnRealizadas;
        private System.Windows.Forms.Button btnAgendadas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnSair;
    }
}