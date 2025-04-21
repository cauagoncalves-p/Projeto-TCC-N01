namespace Avalia__
{
    partial class FormInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblentrar = new System.Windows.Forms.Label();
            this.lblAvalia = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.lblMedico);
            this.panelLogin.Controls.Add(this.lblPaciente);
            this.panelLogin.Controls.Add(this.btnEntrar);
            this.panelLogin.Controls.Add(this.btnMedico);
            this.panelLogin.Controls.Add(this.btnPaciente);
            this.panelLogin.Controls.Add(this.btnSair);
            this.panelLogin.Controls.Add(this.lblentrar);
            this.panelLogin.Controls.Add(this.lblAvalia);
            this.panelLogin.Location = new System.Drawing.Point(433, 55);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(447, 601);
            this.panelLogin.TabIndex = 1;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.BackColor = System.Drawing.Color.FloralWhite;
            this.lblMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(59, 455);
            this.lblMedico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(321, 18);
            this.lblMedico.TabIndex = 15;
            this.lblMedico.Text = "Acesse seu painel profissional e agendamentos";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.BackColor = System.Drawing.Color.FloralWhite;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(56, 265);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(320, 18);
            this.lblPaciente.TabIndex = 14;
            this.lblPaciente.Text = "Acesse seu histórico de consultas e avaliações";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(164)))), ((int)(((byte)(143)))));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(44, 510);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(353, 55);
            this.btnEntrar.TabIndex = 13;
            this.btnEntrar.Text = "Continuar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.BackColor = System.Drawing.Color.FloralWhite;
            this.btnMedico.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.btnMedico.FlatAppearance.BorderSize = 2;
            this.btnMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnMedico.Image")));
            this.btnMedico.Location = new System.Drawing.Point(44, 335);
            this.btnMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(353, 154);
            this.btnMedico.TabIndex = 12;
            this.btnMedico.Text = "Sou Medico";
            this.btnMedico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMedico.UseVisualStyleBackColor = false;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackColor = System.Drawing.Color.FloralWhite;
            this.btnPaciente.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.btnPaciente.FlatAppearance.BorderSize = 2;
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnPaciente.Image")));
            this.btnPaciente.Location = new System.Drawing.Point(44, 150);
            this.btnPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(353, 154);
            this.btnPaciente.TabIndex = 11;
            this.btnPaciente.Text = "Sou Paciente";
            this.btnPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
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
            // lblentrar
            // 
            this.lblentrar.AutoSize = true;
            this.lblentrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblentrar.Location = new System.Drawing.Point(99, 101);
            this.lblentrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblentrar.Name = "lblentrar";
            this.lblentrar.Size = new System.Drawing.Size(265, 25);
            this.lblentrar.TabIndex = 1;
            this.lblentrar.Text = "Como você deseja entrar?";
            // 
            // lblAvalia
            // 
            this.lblAvalia.AutoSize = true;
            this.lblAvalia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvalia.Location = new System.Drawing.Point(157, 38);
            this.lblAvalia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvalia.Name = "lblAvalia";
            this.lblAvalia.Size = new System.Drawing.Size(111, 29);
            this.lblAvalia.TabIndex = 0;
            this.lblAvalia.Text = "Áuerea+";
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.panelLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInicial";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormInicial_Paint);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblentrar;
        private System.Windows.Forms.Label lblAvalia;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblMedico;
    }
}