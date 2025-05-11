namespace Avalia__
{
    partial class FormularioConfirmeTrocarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioConfirmeTrocarSenha));
            this.panelConfirmeSenha = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.txtConfirmeSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmeNovaSenha = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.lblTrocarSenha = new System.Windows.Forms.Label();
            this.lblAvalia = new System.Windows.Forms.Label();
            this.panelConfirmeSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConfirmeSenha
            // 
            this.panelConfirmeSenha.Controls.Add(this.lblError);
            this.panelConfirmeSenha.Controls.Add(this.txtConfirmeSenha);
            this.panelConfirmeSenha.Controls.Add(this.lblConfirmeNovaSenha);
            this.panelConfirmeSenha.Controls.Add(this.btnSair);
            this.panelConfirmeSenha.Controls.Add(this.btnConfirmar);
            this.panelConfirmeSenha.Controls.Add(this.txtNovaSenha);
            this.panelConfirmeSenha.Controls.Add(this.lblNovaSenha);
            this.panelConfirmeSenha.Controls.Add(this.lblTrocarSenha);
            this.panelConfirmeSenha.Controls.Add(this.lblAvalia);
            this.panelConfirmeSenha.Location = new System.Drawing.Point(437, 101);
            this.panelConfirmeSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelConfirmeSenha.Name = "panelConfirmeSenha";
            this.panelConfirmeSenha.Size = new System.Drawing.Size(447, 484);
            this.panelConfirmeSenha.TabIndex = 2;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(48, 250);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 14;
            // 
            // txtConfirmeSenha
            // 
            this.txtConfirmeSenha.Font = new System.Drawing.Font("Wingdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtConfirmeSenha.Location = new System.Drawing.Point(52, 295);
            this.txtConfirmeSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmeSenha.MaxLength = 100;
            this.txtConfirmeSenha.Multiline = true;
            this.txtConfirmeSenha.Name = "txtConfirmeSenha";
            this.txtConfirmeSenha.PasswordChar = 'l';
            this.txtConfirmeSenha.Size = new System.Drawing.Size(341, 48);
            this.txtConfirmeSenha.TabIndex = 13;
            // 
            // lblConfirmeNovaSenha
            // 
            this.lblConfirmeNovaSenha.AutoSize = true;
            this.lblConfirmeNovaSenha.Font = new System.Drawing.Font("Arial", 13F);
            this.lblConfirmeNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblConfirmeNovaSenha.Location = new System.Drawing.Point(48, 266);
            this.lblConfirmeNovaSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmeNovaSenha.Name = "lblConfirmeNovaSenha";
            this.lblConfirmeNovaSenha.Size = new System.Drawing.Size(208, 25);
            this.lblConfirmeNovaSenha.TabIndex = 12;
            this.lblConfirmeNovaSenha.Text = "Confirme sua Senha";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(361, 15);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(67, 53);
            this.btnSair.TabIndex = 10;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(164)))), ((int)(((byte)(143)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(52, 378);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(343, 54);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Font = new System.Drawing.Font("Wingdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtNovaSenha.Location = new System.Drawing.Point(52, 197);
            this.txtNovaSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNovaSenha.MaxLength = 100;
            this.txtNovaSenha.Multiline = true;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = 'l';
            this.txtNovaSenha.Size = new System.Drawing.Size(341, 48);
            this.txtNovaSenha.TabIndex = 3;
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Font = new System.Drawing.Font("Arial", 13F);
            this.lblNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblNovaSenha.Location = new System.Drawing.Point(51, 167);
            this.lblNovaSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(127, 25);
            this.lblNovaSenha.TabIndex = 2;
            this.lblNovaSenha.Text = "Nova senha";
            // 
            // lblTrocarSenha
            // 
            this.lblTrocarSenha.AutoSize = true;
            this.lblTrocarSenha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrocarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblTrocarSenha.Location = new System.Drawing.Point(137, 106);
            this.lblTrocarSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrocarSenha.Name = "lblTrocarSenha";
            this.lblTrocarSenha.Size = new System.Drawing.Size(165, 29);
            this.lblTrocarSenha.TabIndex = 1;
            this.lblTrocarSenha.Text = "Trocar Senha";
            // 
            // lblAvalia
            // 
            this.lblAvalia.AutoSize = true;
            this.lblAvalia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvalia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAvalia.Location = new System.Drawing.Point(162, 70);
            this.lblAvalia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvalia.Name = "lblAvalia";
            this.lblAvalia.Size = new System.Drawing.Size(118, 36);
            this.lblAvalia.TabIndex = 0;
            this.lblAvalia.Text = "Áurea+";
            // 
            // FormularioConfirmeTrocarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.panelConfirmeSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioConfirmeTrocarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troca de senha";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormularioConfirmeTrocarSenha_Paint);
            this.panelConfirmeSenha.ResumeLayout(false);
            this.panelConfirmeSenha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConfirmeSenha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.Label lblTrocarSenha;
        private System.Windows.Forms.Label lblAvalia;
        private System.Windows.Forms.TextBox txtConfirmeSenha;
        private System.Windows.Forms.Label lblConfirmeNovaSenha;
        private System.Windows.Forms.Label lblError;
    }
}