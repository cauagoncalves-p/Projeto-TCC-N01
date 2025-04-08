namespace Avalia__
{
    partial class Form1
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.txtNomeLogin = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblAvalia = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblCriarConta = new System.Windows.Forms.Label();
            this.lblLinkCriarConta = new System.Windows.Forms.LinkLabel();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.lblLinkCriarConta);
            this.panelLogin.Controls.Add(this.lblCriarConta);
            this.panelLogin.Controls.Add(this.btnEntrar);
            this.panelLogin.Controls.Add(this.lblEsqueceuSenha);
            this.panelLogin.Controls.Add(this.textBox1);
            this.panelLogin.Controls.Add(this.lblSenha);
            this.panelLogin.Controls.Add(this.txtNomeLogin);
            this.panelLogin.Controls.Add(this.lblNome);
            this.panelLogin.Controls.Add(this.lblLogin);
            this.panelLogin.Controls.Add(this.lblAvalia);
            this.panelLogin.Location = new System.Drawing.Point(305, 58);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(335, 471);
            this.panelLogin.TabIndex = 0;
            // 
            // txtNomeLogin
            // 
            this.txtNomeLogin.Location = new System.Drawing.Point(39, 174);
            this.txtNomeLogin.MaxLength = 100;
            this.txtNomeLogin.Multiline = true;
            this.txtNomeLogin.Name = "txtNomeLogin";
            this.txtNomeLogin.Size = new System.Drawing.Size(257, 40);
            this.txtNomeLogin.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblNome.Location = new System.Drawing.Point(36, 135);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblLogin.Location = new System.Drawing.Point(108, 78);
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
            this.lblAvalia.Size = new System.Drawing.Size(78, 24);
            this.lblAvalia.TabIndex = 0;
            this.lblAvalia.Text = "Avalia+";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 277);
            this.textBox1.MaxLength = 100;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 40);
            this.textBox1.TabIndex = 5;
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
            // lblEsqueceuSenha
            // 
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
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(164)))), ((int)(((byte)(143)))));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(39, 371);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(257, 44);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            // 
            // lblCriarConta
            // 
            this.lblCriarConta.AutoSize = true;
            this.lblCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarConta.Location = new System.Drawing.Point(36, 435);
            this.lblCriarConta.Name = "lblCriarConta";
            this.lblCriarConta.Size = new System.Drawing.Size(151, 18);
            this.lblCriarConta.TabIndex = 8;
            this.lblCriarConta.Text = "Não tem uma conta? ";
            // 
            // lblLinkCriarConta
            // 
            this.lblLinkCriarConta.AutoSize = true;
            this.lblLinkCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkCriarConta.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblLinkCriarConta.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblLinkCriarConta.Location = new System.Drawing.Point(213, 435);
            this.lblLinkCriarConta.Name = "lblLinkCriarConta";
            this.lblLinkCriarConta.Size = new System.Drawing.Size(68, 18);
            this.lblLinkCriarConta.TabIndex = 9;
            this.lblLinkCriarConta.TabStop = true;
            this.lblLinkCriarConta.Text = "Crie uma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelLogin);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblAvalia;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtNomeLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.LinkLabel lblEsqueceuSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblCriarConta;
        private System.Windows.Forms.LinkLabel lblLinkCriarConta;
    }
}

