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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.lblTrocarSenha = new System.Windows.Forms.Label();
            this.lblAvalia = new System.Windows.Forms.Label();
            this.txtConfirmeSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmeNovaSenha = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
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
            this.panelConfirmeSenha.Location = new System.Drawing.Point(325, 45);
            this.panelConfirmeSenha.Name = "panelConfirmeSenha";
            this.panelConfirmeSenha.Size = new System.Drawing.Size(335, 471);
            this.panelConfirmeSenha.TabIndex = 2;
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
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(164)))), ((int)(((byte)(143)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(39, 408);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(257, 44);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(39, 160);
            this.txtNovaSenha.MaxLength = 100;
            this.txtNovaSenha.Multiline = true;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(257, 40);
            this.txtNovaSenha.TabIndex = 3;
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblNovaSenha.Location = new System.Drawing.Point(36, 130);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(65, 13);
            this.lblNovaSenha.TabIndex = 2;
            this.lblNovaSenha.Text = "Nova senha";
            // 
            // lblTrocarSenha
            // 
            this.lblTrocarSenha.AutoSize = true;
            this.lblTrocarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrocarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblTrocarSenha.Location = new System.Drawing.Point(112, 68);
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
            // txtConfirmeSenha
            // 
            this.txtConfirmeSenha.Location = new System.Drawing.Point(39, 262);
            this.txtConfirmeSenha.MaxLength = 100;
            this.txtConfirmeSenha.Multiline = true;
            this.txtConfirmeSenha.Name = "txtConfirmeSenha";
            this.txtConfirmeSenha.Size = new System.Drawing.Size(257, 40);
            this.txtConfirmeSenha.TabIndex = 13;
            // 
            // lblConfirmeNovaSenha
            // 
            this.lblConfirmeNovaSenha.AutoSize = true;
            this.lblConfirmeNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblConfirmeNovaSenha.Location = new System.Drawing.Point(36, 232);
            this.lblConfirmeNovaSenha.Name = "lblConfirmeNovaSenha";
            this.lblConfirmeNovaSenha.Size = new System.Drawing.Size(102, 13);
            this.lblConfirmeNovaSenha.TabIndex = 12;
            this.lblConfirmeNovaSenha.Text = "Confirme sua Senha";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(36, 203);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 14;
            // 
            // FormularioConfirmeTrocarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelConfirmeSenha);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioConfirmeTrocarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmarção de troca de senha";
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