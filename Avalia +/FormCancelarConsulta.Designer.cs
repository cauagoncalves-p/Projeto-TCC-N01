namespace Avalia__
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
            this.btnSair = new System.Windows.Forms.Button();
            this.lblsubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelCancelarConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCancelarConsulta
            // 
            this.panelCancelarConsulta.Controls.Add(this.dgvCancelar);
            this.panelCancelarConsulta.Location = new System.Drawing.Point(63, 165);
            this.panelCancelarConsulta.Name = "panelCancelarConsulta";
            this.panelCancelarConsulta.Size = new System.Drawing.Size(868, 493);
            this.panelCancelarConsulta.TabIndex = 0;
            // 
            // dgvCancelar
            // 
            this.dgvCancelar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancelar.Location = new System.Drawing.Point(38, 34);
            this.dgvCancelar.Name = "dgvCancelar";
            this.dgvCancelar.Size = new System.Drawing.Size(783, 435);
            this.dgvCancelar.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(881, 36);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 43);
            this.btnSair.TabIndex = 15;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // lblsubtitulo
            // 
            this.lblsubtitulo.AutoSize = true;
            this.lblsubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblsubtitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblsubtitulo.Location = new System.Drawing.Point(72, 88);
            this.lblsubtitulo.Name = "lblsubtitulo";
            this.lblsubtitulo.Size = new System.Drawing.Size(164, 22);
            this.lblsubtitulo.TabIndex = 14;
            this.lblsubtitulo.Text = "Cancelar Consulta";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblTitulo.Location = new System.Drawing.Point(71, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(62, 25);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Aurea";
            // 
            // FormCancelarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 685);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblsubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelCancelarConsulta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCancelarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Consulta";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormCancelarConsulta_Paint);
            this.panelCancelarConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCancelarConsulta;
        private System.Windows.Forms.DataGridView dgvCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblsubtitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}