namespace Avalia__
{
    partial class FormularioTrocarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioTrocarSenha));
            this.panelTrocarSenha = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTrocarSenha = new System.Windows.Forms.Label();
            this.lblAvalia = new System.Windows.Forms.Label();
            this.lblDescritivo = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panelTrocarSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTrocarSenha
            // 
            this.panelTrocarSenha.Controls.Add(this.lblDescritivo);
            this.panelTrocarSenha.Controls.Add(this.btnSair);
            this.panelTrocarSenha.Controls.Add(this.btnProximo);
            this.panelTrocarSenha.Controls.Add(this.txtEmail);
            this.panelTrocarSenha.Controls.Add(this.lblEmail);
            this.panelTrocarSenha.Controls.Add(this.lblTrocarSenha);
            this.panelTrocarSenha.Controls.Add(this.lblAvalia);
            this.panelTrocarSenha.Location = new System.Drawing.Point(325, 45);
            this.panelTrocarSenha.Name = "panelTrocarSenha";
            this.panelTrocarSenha.Size = new System.Drawing.Size(335, 471);
            this.panelTrocarSenha.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(271, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 43);
            this.btnSair.TabIndex = 10;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(164)))), ((int)(((byte)(143)))));
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.ForeColor = System.Drawing.Color.White;
            this.btnProximo.Location = new System.Drawing.Point(39, 371);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(257, 44);
            this.btnProximo.TabIndex = 7;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblEmail.Location = new System.Drawing.Point(36, 218);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblTrocarSenha
            // 
            this.lblTrocarSenha.AutoSize = true;
            this.lblTrocarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrocarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblTrocarSenha.Location = new System.Drawing.Point(92, 78);
            this.lblTrocarSenha.Name = "lblTrocarSenha";
            this.lblTrocarSenha.Size = new System.Drawing.Size(105, 20);
            this.lblTrocarSenha.TabIndex = 1;
            this.lblTrocarSenha.Text = "Trocar Senha";
            // 
            // lblAvalia
            // 
            this.lblAvalia.AutoSize = true;
            this.lblAvalia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvalia.Location = new System.Drawing.Point(127, 31);
            this.lblAvalia.Name = "lblAvalia";
            this.lblAvalia.Size = new System.Drawing.Size(90, 24);
            this.lblAvalia.TabIndex = 0;
            this.lblAvalia.Text = "Áuerea+";
            // 
            // lblDescritivo
            // 
            this.lblDescritivo.AutoSize = true;
            this.lblDescritivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescritivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblDescritivo.Location = new System.Drawing.Point(35, 140);
            this.lblDescritivo.Name = "lblDescritivo";
            this.lblDescritivo.Size = new System.Drawing.Size(249, 20);
            this.lblDescritivo.TabIndex = 11;
            this.lblDescritivo.Text = "Informe seu email para prosseguir";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(39, 265);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 40);
            this.txtEmail.TabIndex = 3;
            // 
            // FormularioTrocarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelTrocarSenha);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioTrocarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trocar Senha";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormularioTrocarSenha_Paint);
            this.panelTrocarSenha.ResumeLayout(false);
            this.panelTrocarSenha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTrocarSenha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTrocarSenha;
        private System.Windows.Forms.Label lblAvalia;
        private System.Windows.Forms.Label lblDescritivo;
        private System.Windows.Forms.TextBox txtEmail;
    }
}