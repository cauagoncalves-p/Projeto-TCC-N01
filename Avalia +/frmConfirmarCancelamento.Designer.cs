namespace Avalia__
{
    partial class frmConfirmarCancelamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmarCancelamento));
            this.btnSair = new System.Windows.Forms.Button();
            this.lblsubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelCancelarConsulta = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnManterConsulta = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.cbxMotivo = new System.Windows.Forms.ComboBox();
            this.lblMotivoCancelamento = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfoObservacao = new System.Windows.Forms.Label();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.lblInfoHoraData = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.lblInfoLocal = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblInfoMedico = new System.Windows.Forms.Label();
            this.lblMedica = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelCancelarConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(1109, 65);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(67, 53);
            this.btnSair.TabIndex = 15;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblsubtitulo
            // 
            this.lblsubtitulo.AutoSize = true;
            this.lblsubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblsubtitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblsubtitulo.Location = new System.Drawing.Point(168, 103);
            this.lblsubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsubtitulo.Name = "lblsubtitulo";
            this.lblsubtitulo.Size = new System.Drawing.Size(200, 33);
            this.lblsubtitulo.TabIndex = 14;
            this.lblsubtitulo.Text = "Agende sua consulta";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(85, 65);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 36);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Áurea+";
            // 
            // panelCancelarConsulta
            // 
            this.panelCancelarConsulta.AutoScroll = true;
            this.panelCancelarConsulta.Controls.Add(this.label1);
            this.panelCancelarConsulta.Controls.Add(this.btnCancelar);
            this.panelCancelarConsulta.Controls.Add(this.btnManterConsulta);
            this.panelCancelarConsulta.Controls.Add(this.textBox1);
            this.panelCancelarConsulta.Controls.Add(this.lblDetalhes);
            this.panelCancelarConsulta.Controls.Add(this.cbxMotivo);
            this.panelCancelarConsulta.Controls.Add(this.lblMotivoCancelamento);
            this.panelCancelarConsulta.Controls.Add(this.lblInfo);
            this.panelCancelarConsulta.Controls.Add(this.label2);
            this.panelCancelarConsulta.Controls.Add(this.lblInfoObservacao);
            this.panelCancelarConsulta.Controls.Add(this.lblObservacoes);
            this.panelCancelarConsulta.Controls.Add(this.lblInfoHoraData);
            this.panelCancelarConsulta.Controls.Add(this.lblDataHora);
            this.panelCancelarConsulta.Controls.Add(this.lblInfoLocal);
            this.panelCancelarConsulta.Controls.Add(this.lblLocal);
            this.panelCancelarConsulta.Controls.Add(this.lblInfoMedico);
            this.panelCancelarConsulta.Controls.Add(this.lblMedica);
            this.panelCancelarConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.panelCancelarConsulta.Location = new System.Drawing.Point(93, 183);
            this.panelCancelarConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCancelarConsulta.Name = "panelCancelarConsulta";
            this.panelCancelarConsulta.Size = new System.Drawing.Size(1109, 492);
            this.panelCancelarConsulta.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 751);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(164)))), ((int)(((byte)(143)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(815, 657);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(231, 59);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar Consulta";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnManterConsulta
            // 
            this.btnManterConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(164)))), ((int)(((byte)(143)))));
            this.btnManterConsulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(164)))), ((int)(((byte)(143)))));
            this.btnManterConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManterConsulta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManterConsulta.ForeColor = System.Drawing.Color.White;
            this.btnManterConsulta.Location = new System.Drawing.Point(567, 657);
            this.btnManterConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManterConsulta.Name = "btnManterConsulta";
            this.btnManterConsulta.Size = new System.Drawing.Size(215, 59);
            this.btnManterConsulta.TabIndex = 14;
            this.btnManterConsulta.Text = "Manter consulta";
            this.btnManterConsulta.UseVisualStyleBackColor = false;
            this.btnManterConsulta.Click += new System.EventHandler(this.btnManterConsulta_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox1.Location = new System.Drawing.Point(56, 478);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(988, 150);
            this.textBox1.TabIndex = 13;
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblDetalhes.Location = new System.Drawing.Point(52, 449);
            this.lblDetalhes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(205, 25);
            this.lblDetalhes.TabIndex = 12;
            this.lblDetalhes.Text = "Detalhes (Opcional)";
            // 
            // cbxMotivo
            // 
            this.cbxMotivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.cbxMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMotivo.Font = new System.Drawing.Font("Arial", 14F);
            this.cbxMotivo.FormattingEnabled = true;
            this.cbxMotivo.Items.AddRange(new object[] {
            "Selecione um motivo",
            "Conflito de horário",
            "Emergência/Imprevisto",
            "Troca de médico",
            "Outro motivo"});
            this.cbxMotivo.Location = new System.Drawing.Point(56, 385);
            this.cbxMotivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxMotivo.Name = "cbxMotivo";
            this.cbxMotivo.Size = new System.Drawing.Size(988, 34);
            this.cbxMotivo.TabIndex = 11;
            // 
            // lblMotivoCancelamento
            // 
            this.lblMotivoCancelamento.AutoSize = true;
            this.lblMotivoCancelamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoCancelamento.Location = new System.Drawing.Point(52, 331);
            this.lblMotivoCancelamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotivoCancelamento.Name = "lblMotivoCancelamento";
            this.lblMotivoCancelamento.Size = new System.Drawing.Size(320, 23);
            this.lblMotivoCancelamento.TabIndex = 10;
            this.lblMotivoCancelamento.Text = "Motivo do cancelamento (Opcional)";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblInfo.Location = new System.Drawing.Point(52, 263);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(432, 25);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Deseja realamente cancelar esta consulta? ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1051, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // lblInfoObservacao
            // 
            this.lblInfoObservacao.AutoSize = true;
            this.lblInfoObservacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoObservacao.Location = new System.Drawing.Point(679, 167);
            this.lblInfoObservacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoObservacao.Name = "lblInfoObservacao";
            this.lblInfoObservacao.Size = new System.Drawing.Size(112, 23);
            this.lblInfoObservacao.TabIndex = 7;
            this.lblInfoObservacao.Text = "observação";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblObservacoes.Location = new System.Drawing.Point(679, 135);
            this.lblObservacoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(140, 25);
            this.lblObservacoes.TabIndex = 6;
            this.lblObservacoes.Text = "Observações";
            // 
            // lblInfoHoraData
            // 
            this.lblInfoHoraData.AutoSize = true;
            this.lblInfoHoraData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoHoraData.Location = new System.Drawing.Point(679, 78);
            this.lblInfoHoraData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoHoraData.Name = "lblInfoHoraData";
            this.lblInfoHoraData.Size = new System.Drawing.Size(113, 23);
            this.lblInfoHoraData.TabIndex = 5;
            this.lblInfoHoraData.Text = "Data - Hora";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblDataHora.Location = new System.Drawing.Point(679, 46);
            this.lblDataHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(123, 25);
            this.lblDataHora.TabIndex = 4;
            this.lblDataHora.Text = "Data - Hora";
            // 
            // lblInfoLocal
            // 
            this.lblInfoLocal.AutoSize = true;
            this.lblInfoLocal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoLocal.Location = new System.Drawing.Point(52, 167);
            this.lblInfoLocal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoLocal.Name = "lblInfoLocal";
            this.lblInfoLocal.Size = new System.Drawing.Size(92, 23);
            this.lblInfoLocal.TabIndex = 3;
            this.lblInfoLocal.Text = "endereço";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblLocal.Location = new System.Drawing.Point(52, 135);
            this.lblLocal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(64, 25);
            this.lblLocal.TabIndex = 2;
            this.lblLocal.Text = "Local";
            // 
            // lblInfoMedico
            // 
            this.lblInfoMedico.AutoSize = true;
            this.lblInfoMedico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoMedico.Location = new System.Drawing.Point(52, 78);
            this.lblInfoMedico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoMedico.Name = "lblInfoMedico";
            this.lblInfoMedico.Size = new System.Drawing.Size(73, 23);
            this.lblInfoMedico.TabIndex = 1;
            this.lblInfoMedico.Text = "medico";
            // 
            // lblMedica
            // 
            this.lblMedica.AutoSize = true;
            this.lblMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblMedica.Location = new System.Drawing.Point(52, 46);
            this.lblMedica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedica.Name = "lblMedica";
            this.lblMedica.Size = new System.Drawing.Size(82, 25);
            this.lblMedica.TabIndex = 0;
            this.lblMedica.Text = "Médica";
            // 
            // frmConfirmarCancelamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.panelCancelarConsulta);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblsubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConfirmarCancelamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar consulta";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmConfirmarCancelamento_Paint);
            this.panelCancelarConsulta.ResumeLayout(false);
            this.panelCancelarConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblsubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelCancelarConsulta;
        private System.Windows.Forms.Label lblInfoObservacao;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.Label lblInfoHoraData;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label lblInfoLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblInfoMedico;
        private System.Windows.Forms.Label lblMedica;
        private System.Windows.Forms.Button btnManterConsulta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDetalhes;
        private System.Windows.Forms.ComboBox cbxMotivo;
        private System.Windows.Forms.Label lblMotivoCancelamento;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}