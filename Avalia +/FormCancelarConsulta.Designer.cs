﻿namespace Avalia__
{
    partial class FormCancelarConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCancelarConsulta));
            this.panelCancelarConsulta = new System.Windows.Forms.Panel();
            this.dgvCancelar = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblsubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelbtnCancelar = new System.Windows.Forms.Panel();
            this.panelCancelarConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelar)).BeginInit();
            this.panelbtnCancelar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCancelarConsulta
            // 
            this.panelCancelarConsulta.Controls.Add(this.dgvCancelar);
            this.panelCancelarConsulta.Location = new System.Drawing.Point(57, 145);
            this.panelCancelarConsulta.Name = "panelCancelarConsulta";
            this.panelCancelarConsulta.Size = new System.Drawing.Size(868, 361);
            this.panelCancelarConsulta.TabIndex = 0;
            // 
            // dgvCancelar
            // 
            this.dgvCancelar.BackgroundColor = System.Drawing.Color.White;
            this.dgvCancelar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancelar.Location = new System.Drawing.Point(0, 0);
            this.dgvCancelar.Name = "dgvCancelar";
            this.dgvCancelar.Size = new System.Drawing.Size(877, 365);
            this.dgvCancelar.TabIndex = 0;
            this.dgvCancelar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCancelar_CellClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(195, 31);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(456, 48);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar Consulta";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(875, 46);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 43);
            this.btnSair.TabIndex = 15;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblsubtitulo
            // 
            this.lblsubtitulo.AutoSize = true;
            this.lblsubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblsubtitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblsubtitulo.Location = new System.Drawing.Point(126, 80);
            this.lblsubtitulo.Name = "lblsubtitulo";
            this.lblsubtitulo.Size = new System.Drawing.Size(225, 29);
            this.lblsubtitulo.TabIndex = 14;
            this.lblsubtitulo.Text = "Cancelamento de Consulta";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(60, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 31);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Áurea+";
            // 
            // panelbtnCancelar
            // 
            this.panelbtnCancelar.Controls.Add(this.btnCancelar);
            this.panelbtnCancelar.Location = new System.Drawing.Point(57, 516);
            this.panelbtnCancelar.Name = "panelbtnCancelar";
            this.panelbtnCancelar.Size = new System.Drawing.Size(868, 100);
            this.panelbtnCancelar.TabIndex = 16;
            // 
            // FormCancelarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelbtnCancelar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblsubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelCancelarConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCancelarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Consulta";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormCancelarConsulta_Paint);
            this.panelCancelarConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelar)).EndInit();
            this.panelbtnCancelar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCancelarConsulta;
        private System.Windows.Forms.DataGridView dgvCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblsubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelbtnCancelar;
    }
}