﻿namespace Avalia__
{
    partial class FormularioLoginMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioLoginMedico));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblLinkCriarConta = new System.Windows.Forms.LinkLabel();
            this.lblCriarConta = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtCRMLogin = new System.Windows.Forms.TextBox();
            this.lblcrm = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblAvalia = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.btnSair);
            this.panelLogin.Controls.Add(this.lblLinkCriarConta);
            this.panelLogin.Controls.Add(this.lblCriarConta);
            this.panelLogin.Controls.Add(this.btnEntrar);
            this.panelLogin.Controls.Add(this.lblEsqueceuSenha);
            this.panelLogin.Controls.Add(this.txtSenhaLogin);
            this.panelLogin.Controls.Add(this.lblSenha);
            this.panelLogin.Controls.Add(this.txtCRMLogin);
            this.panelLogin.Controls.Add(this.lblcrm);
            this.panelLogin.Controls.Add(this.lblLogin);
            this.panelLogin.Controls.Add(this.lblAvalia);
            this.panelLogin.Location = new System.Drawing.Point(325, 45);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(335, 471);
            this.panelLogin.TabIndex = 1;
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
            // lblLinkCriarConta
            // 
            this.lblLinkCriarConta.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblLinkCriarConta.AutoSize = true;
            this.lblLinkCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkCriarConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblLinkCriarConta.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblLinkCriarConta.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblLinkCriarConta.Location = new System.Drawing.Point(201, 435);
            this.lblLinkCriarConta.Name = "lblLinkCriarConta";
            this.lblLinkCriarConta.Size = new System.Drawing.Size(114, 18);
            this.lblLinkCriarConta.TabIndex = 9;
            this.lblLinkCriarConta.TabStop = true;
            this.lblLinkCriarConta.Text = "Solicitar acesso";
            this.lblLinkCriarConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkCriarConta_LinkClicked);
            // 
            // lblCriarConta
            // 
            this.lblCriarConta.AutoSize = true;
            this.lblCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblCriarConta.Location = new System.Drawing.Point(54, 435);
            this.lblCriarConta.Name = "lblCriarConta";
            this.lblCriarConta.Size = new System.Drawing.Size(151, 18);
            this.lblCriarConta.TabIndex = 8;
            this.lblCriarConta.Text = "Não tem uma conta? ";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(164)))), ((int)(((byte)(143)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(39, 371);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(257, 44);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblEsqueceuSenha
            // 
            this.lblEsqueceuSenha.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblEsqueceuSenha.AutoSize = true;
            this.lblEsqueceuSenha.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblEsqueceuSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblEsqueceuSenha.Location = new System.Drawing.Point(180, 334);
            this.lblEsqueceuSenha.Name = "lblEsqueceuSenha";
            this.lblEsqueceuSenha.Size = new System.Drawing.Size(116, 13);
            this.lblEsqueceuSenha.TabIndex = 6;
            this.lblEsqueceuSenha.TabStop = true;
            this.lblEsqueceuSenha.Text = "Esqueceu sua senha ?";
            this.lblEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEsqueceuSenha_LinkClicked);
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(39, 277);
            this.txtSenhaLogin.MaxLength = 50;
            this.txtSenhaLogin.Multiline = true;
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.PasswordChar = '*';
            this.txtSenhaLogin.Size = new System.Drawing.Size(257, 40);
            this.txtSenhaLogin.TabIndex = 5;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblSenha.Location = new System.Drawing.Point(36, 238);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // txtCRMLogin
            // 
            this.txtCRMLogin.Location = new System.Drawing.Point(39, 174);
            this.txtCRMLogin.MaxLength = 13;
            this.txtCRMLogin.Multiline = true;
            this.txtCRMLogin.Name = "txtCRMLogin";
            this.txtCRMLogin.Size = new System.Drawing.Size(257, 40);
            this.txtCRMLogin.TabIndex = 3;
            this.txtCRMLogin.TextChanged += new System.EventHandler(this.txtCRMLogin_TextChanged);
            // 
            // lblcrm
            // 
            this.lblcrm.AutoSize = true;
            this.lblcrm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblcrm.Location = new System.Drawing.Point(36, 135);
            this.lblcrm.Name = "lblcrm";
            this.lblcrm.Size = new System.Drawing.Size(31, 13);
            this.lblcrm.TabIndex = 2;
            this.lblcrm.Text = "CRM";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblLogin.Location = new System.Drawing.Point(92, 78);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(112, 20);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Faça seu login";
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
            // FormularioLoginMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioLoginMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Medico ";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormularioLoginMedico_Paint);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.LinkLabel lblLinkCriarConta;
        private System.Windows.Forms.Label lblCriarConta;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel lblEsqueceuSenha;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtCRMLogin;
        private System.Windows.Forms.Label lblcrm;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblAvalia;
    }
}