namespace Avalia__
{
    partial class FormularioAgendamentoConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioAgendamentoConsulta));
            this.panelAgendar = new System.Windows.Forms.Panel();
            this.lblObsevacao = new System.Windows.Forms.Label();
            this.dtpAtendimento = new System.Windows.Forms.ComboBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.c = new System.Windows.Forms.Label();
            this.lblinfoConsulta = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblsubtitulo = new System.Windows.Forms.Label();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelAgendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAgendar
            // 
            this.panelAgendar.Controls.Add(this.btnCancelar);
            this.panelAgendar.Controls.Add(this.btnContinuar);
            this.panelAgendar.Controls.Add(this.textBox1);
            this.panelAgendar.Controls.Add(this.lblObservacoes);
            this.panelAgendar.Controls.Add(this.lblObsevacao);
            this.panelAgendar.Controls.Add(this.dtpAtendimento);
            this.panelAgendar.Controls.Add(this.lblLocal);
            this.panelAgendar.Controls.Add(this.dtpData);
            this.panelAgendar.Controls.Add(this.lblData);
            this.panelAgendar.Controls.Add(this.comboBox2);
            this.panelAgendar.Controls.Add(this.lblMedicos);
            this.panelAgendar.Controls.Add(this.comboBox1);
            this.panelAgendar.Controls.Add(this.c);
            this.panelAgendar.Controls.Add(this.lblinfoConsulta);
            this.panelAgendar.Location = new System.Drawing.Point(70, 135);
            this.panelAgendar.Name = "panelAgendar";
            this.panelAgendar.Size = new System.Drawing.Size(855, 468);
            this.panelAgendar.TabIndex = 0;
            // 
            // lblObsevacao
            // 
            this.lblObsevacao.AutoSize = true;
            this.lblObsevacao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObsevacao.Location = new System.Drawing.Point(29, 246);
            this.lblObsevacao.Name = "lblObsevacao";
            this.lblObsevacao.Size = new System.Drawing.Size(0, 20);
            this.lblObsevacao.TabIndex = 12;
            // 
            // dtpAtendimento
            // 
            this.dtpAtendimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.dtpAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dtpAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAtendimento.FormattingEnabled = true;
            this.dtpAtendimento.Location = new System.Drawing.Point(455, 181);
            this.dtpAtendimento.Name = "dtpAtendimento";
            this.dtpAtendimento.Size = new System.Drawing.Size(346, 33);
            this.dtpAtendimento.TabIndex = 11;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblLocal.Location = new System.Drawing.Point(451, 149);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(147, 20);
            this.lblLocal.TabIndex = 10;
            this.lblLocal.Text = "Local de atendimento ";
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(33, 183);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(346, 31);
            this.dtpData.TabIndex = 9;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblData.Location = new System.Drawing.Point(29, 149);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 20);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "Data";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(455, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(346, 33);
            this.comboBox2.TabIndex = 7;
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblMedicos.Location = new System.Drawing.Point(451, 51);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(69, 20);
            this.lblMedicos.TabIndex = 6;
            this.lblMedicos.Text = "Médico(a)";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(346, 33);
            this.comboBox1.TabIndex = 5;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.c.Location = new System.Drawing.Point(29, 51);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(144, 20);
            this.c.TabIndex = 4;
            this.c.Text = "Especialidade Médica";
            // 
            // lblinfoConsulta
            // 
            this.lblinfoConsulta.AutoSize = true;
            this.lblinfoConsulta.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfoConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblinfoConsulta.Location = new System.Drawing.Point(16, 15);
            this.lblinfoConsulta.Name = "lblinfoConsulta";
            this.lblinfoConsulta.Size = new System.Drawing.Size(189, 18);
            this.lblinfoConsulta.TabIndex = 3;
            this.lblinfoConsulta.Text = "Informações da consulta";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblTitulo.Location = new System.Drawing.Point(65, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(62, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Aurea";
            // 
            // lblsubtitulo
            // 
            this.lblsubtitulo.AutoSize = true;
            this.lblsubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblsubtitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblsubtitulo.Location = new System.Drawing.Point(66, 85);
            this.lblsubtitulo.Name = "lblsubtitulo";
            this.lblsubtitulo.Size = new System.Drawing.Size(157, 22);
            this.lblsubtitulo.TabIndex = 2;
            this.lblsubtitulo.Text = "Agendar consulta";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblObservacoes.Location = new System.Drawing.Point(30, 236);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(150, 20);
            this.lblObservacoes.TabIndex = 13;
            this.lblObservacoes.Text = "Obervações (Opcional)";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(33, 281);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(775, 84);
            this.textBox1.TabIndex = 14;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(164)))), ((int)(((byte)(143)))));
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Location = new System.Drawing.Point(679, 408);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(129, 45);
            this.btnContinuar.TabIndex = 15;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(164)))), ((int)(((byte)(143)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(531, 408);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 45);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(875, 31);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 43);
            this.btnSair.TabIndex = 12;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // FormularioAgendamentoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 641);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblsubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelAgendar);
            this.Name = "FormularioAgendamentoConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de agendamento";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormularioAgendamentoConsulta_Paint);
            this.panelAgendar.ResumeLayout(false);
            this.panelAgendar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAgendar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblinfoConsulta;
        private System.Windows.Forms.Label lblsubtitulo;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label lblObsevacao;
        private System.Windows.Forms.ComboBox dtpAtendimento;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSair;
    }
}