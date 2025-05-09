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
            this.mktCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblVerifica = new System.Windows.Forms.Label();
            this.lblAvalia = new System.Windows.Forms.Label();
            this.ll = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelVerificaCPF.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVerificaCPF
            // 
            this.panelVerificaCPF.Controls.Add(this.mktCPF);
            this.panelVerificaCPF.Controls.Add(this.btnContinuar);
            this.panelVerificaCPF.Controls.Add(this.txtEmail);
            this.panelVerificaCPF.Controls.Add(this.lblemail);
            this.panelVerificaCPF.Controls.Add(this.lblCPF);
            this.panelVerificaCPF.Controls.Add(this.lblVerifica);
            this.panelVerificaCPF.Controls.Add(this.lblAvalia);
            this.panelVerificaCPF.Location = new System.Drawing.Point(444, 97);
            this.panelVerificaCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelVerificaCPF.Name = "panelVerificaCPF";
            this.panelVerificaCPF.Size = new System.Drawing.Size(447, 484);
            this.panelVerificaCPF.TabIndex = 1;
            // 
            // mktCPF
            // 
            this.mktCPF.Location = new System.Drawing.Point(52, 181);
            this.mktCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mktCPF.Mask = "000,000,000-00";
            this.mktCPF.Name = "mktCPF";
            this.mktCPF.Size = new System.Drawing.Size(341, 22);
            this.mktCPF.TabIndex = 12;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(164)))), ((int)(((byte)(143)))));
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.Location = new System.Drawing.Point(52, 357);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(343, 54);
            this.btnContinuar.TabIndex = 7;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmail.Location = new System.Drawing.Point(52, 263);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(341, 48);
            this.txtEmail.TabIndex = 5;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblemail.Location = new System.Drawing.Point(48, 234);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(58, 23);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "Email";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblCPF.Location = new System.Drawing.Point(48, 155);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(49, 23);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF";
            // 
            // lblVerifica
            // 
            this.lblVerifica.AutoSize = true;
            this.lblVerifica.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblVerifica.Location = new System.Drawing.Point(104, 97);
            this.lblVerifica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerifica.Name = "lblVerifica";
            this.lblVerifica.Size = new System.Drawing.Size(231, 36);
            this.lblVerifica.TabIndex = 1;
            this.lblVerifica.Text = "Validação de cadastro";
            // 
            // lblAvalia
            // 
            this.lblAvalia.AutoSize = true;
            this.lblAvalia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvalia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAvalia.Location = new System.Drawing.Point(143, 59);
            this.lblAvalia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvalia.Name = "lblAvalia";
            this.lblAvalia.Size = new System.Drawing.Size(118, 36);
            this.lblAvalia.TabIndex = 0;
            this.lblAvalia.Text = "Áurea+";
            // 
            // ll
            // 
            this.ll.AutoSize = true;
            this.ll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ll.Location = new System.Drawing.Point(977, 97);
            this.ll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(0, 23);
            this.ll.TabIndex = 13;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(1289, 671);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(13, 12);
            this.btnSair.TabIndex = 13;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // FormularioCadCPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.ll);
            this.Controls.Add(this.panelVerificaCPF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioCadCPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmação CPF";
            this.Load += new System.EventHandler(this.FormularioCadCPF_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormularioCadCPF_Paint);
            this.panelVerificaCPF.ResumeLayout(false);
            this.panelVerificaCPF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVerificaCPF;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblVerifica;
        private System.Windows.Forms.Label lblAvalia;
        private System.Windows.Forms.MaskedTextBox mktCPF;
        private System.Windows.Forms.Label ll;
        private System.Windows.Forms.Button btnSair;
    }
}