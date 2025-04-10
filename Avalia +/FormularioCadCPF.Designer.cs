namespace Avalia__
{
    partial class FormularioCadCPF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCadCPF));
            this.panelVerificaCPF = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblLinkFazerLogin = new System.Windows.Forms.LinkLabel();
            this.lblVerificaCPF = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblVerifica = new System.Windows.Forms.Label();
            this.lblAvalia = new System.Windows.Forms.Label();
            this.mktCPF = new System.Windows.Forms.MaskedTextBox();
            this.panelVerificaCPF.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVerificaCPF
            // 
            this.panelVerificaCPF.Controls.Add(this.mktCPF);
            this.panelVerificaCPF.Controls.Add(this.btnSair);
            this.panelVerificaCPF.Controls.Add(this.lblLinkFazerLogin);
            this.panelVerificaCPF.Controls.Add(this.lblVerificaCPF);
            this.panelVerificaCPF.Controls.Add(this.btnContinuar);
            this.panelVerificaCPF.Controls.Add(this.txtEmail);
            this.panelVerificaCPF.Controls.Add(this.lblemail);
            this.panelVerificaCPF.Controls.Add(this.lblCPF);
            this.panelVerificaCPF.Controls.Add(this.lblVerifica);
            this.panelVerificaCPF.Controls.Add(this.lblAvalia);
            this.panelVerificaCPF.Location = new System.Drawing.Point(325, 45);
            this.panelVerificaCPF.Name = "panelVerificaCPF";
            this.panelVerificaCPF.Size = new System.Drawing.Size(335, 471);
            this.panelVerificaCPF.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(267, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 43);
            this.btnSair.TabIndex = 11;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblLinkFazerLogin
            // 
            this.lblLinkFazerLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblLinkFazerLogin.AutoSize = true;
            this.lblLinkFazerLogin.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblLinkFazerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkFazerLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblLinkFazerLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblLinkFazerLogin.Location = new System.Drawing.Point(201, 435);
            this.lblLinkFazerLogin.Name = "lblLinkFazerLogin";
            this.lblLinkFazerLogin.Size = new System.Drawing.Size(81, 18);
            this.lblLinkFazerLogin.TabIndex = 9;
            this.lblLinkFazerLogin.TabStop = true;
            this.lblLinkFazerLogin.Text = "Fazer login";
            this.lblLinkFazerLogin.Click += new System.EventHandler(this.lblLinkFazerLogin_Click);
            // 
            // lblVerificaCPF
            // 
            this.lblVerificaCPF.AutoSize = true;
            this.lblVerificaCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificaCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblVerificaCPF.Location = new System.Drawing.Point(54, 435);
            this.lblVerificaCPF.Name = "lblVerificaCPF";
            this.lblVerificaCPF.Size = new System.Drawing.Size(154, 18);
            this.lblVerificaCPF.TabIndex = 8;
            this.lblVerificaCPF.Text = "Já possuiu cadastro? ";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(164)))), ((int)(((byte)(143)))));
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.Location = new System.Drawing.Point(39, 353);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(257, 44);
            this.btnContinuar.TabIndex = 7;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(39, 277);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 40);
            this.txtEmail.TabIndex = 5;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblemail.Location = new System.Drawing.Point(36, 238);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "Email";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(32, 173);
            this.txtCPF.MaxLength = 100;
            this.txtCPF.Multiline = true;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(257, 40);
            this.txtCPF.TabIndex = 3;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblCPF.Location = new System.Drawing.Point(36, 135);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF";
            // 
            // lblVerifica
            // 
            this.lblVerifica.AutoSize = true;
            this.lblVerifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblVerifica.Location = new System.Drawing.Point(54, 78);
            this.lblVerifica.Name = "lblVerifica";
            this.lblVerifica.Size = new System.Drawing.Size(173, 20);
            this.lblVerifica.TabIndex = 1;
            this.lblVerifica.Text = "Verficação de cadastro";
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
            // mktCPF
            // 
            this.mktCPF.Location = new System.Drawing.Point(39, 170);
            this.mktCPF.Mask = "000,000,000-00";
            this.mktCPF.Name = "mktCPF";
            this.mktCPF.Size = new System.Drawing.Size(226, 20);
            this.mktCPF.TabIndex = 12;
            // 
            // FormularioCadCPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelVerificaCPF);
            this.Controls.Add(this.txtCPF);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioCadCPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirme CPF";
            this.Load += new System.EventHandler(this.FormularioCadCPF_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormularioCadCPF_Paint);
            this.panelVerificaCPF.ResumeLayout(false);
            this.panelVerificaCPF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVerificaCPF;
        private System.Windows.Forms.LinkLabel lblLinkFazerLogin;
        private System.Windows.Forms.Label lblVerificaCPF;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblVerifica;
        private System.Windows.Forms.Label lblAvalia;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox mktCPF;
    }
}