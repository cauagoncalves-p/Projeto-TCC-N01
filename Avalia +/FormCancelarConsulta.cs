using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avalia__.AureaMaxDataSetTableAdapters;

namespace Avalia__
{
    public partial class FormCancelarConsulta: Form
    {
        public FormCancelarConsulta()
        {
            InitializeComponent();
            CarregarDadosExemplo();
            ConfigurarTela();
        }
        private void ConfigurarTela()
        {
            // Configuração básica do formulário
            this.Text = "Cancelar Consulta";
            this.BackColor = Color.White;
            this.ClientSize = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 10);

            // Título
            var lblTitulo = new Label();
            lblTitulo.Text = "Cancelar Consulta";
            lblTitulo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(50, 50, 50);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(20, 20);
            this.Controls.Add(lblTitulo);

            // Subtítulo
            var lblSubtitulo = new Label();
            lblSubtitulo.Text = "Selecione a consulta que deseja cancelar";
            lblSubtitulo.Font = new Font("Segoe UI", 10);
            lblSubtitulo.ForeColor = Color.FromArgb(100, 100, 100);
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(20, 50);
            this.Controls.Add(lblSubtitulo);

            // DataGridView para as consultas
            dgvConsultas = new DataGridView();
            dgvConsultas.Location = new Point(20, 90);
            dgvConsultas.Size = new Size(760, 400);
            dgvConsultas.BackgroundColor = Color.White;
            dgvConsultas.BorderStyle = BorderStyle.None;
            dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultas.RowHeadersVisible = false;
            dgvConsultas.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvConsultas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvConsultas.ColumnHeadersHeight = 40;
            dgvConsultas.RowTemplate.Height = 35;
            this.Controls.Add(dgvConsultas);

            // Botão de cancelar
            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar Consulta Selecionada";
            btnCancelar.BackColor = Color.FromArgb(220, 50, 50);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnCancelar.Size = new Size(250, 40);
            btnCancelar.Location = new Point(530, 510);
            btnCancelar.Enabled = false;
            this.Controls.Add(btnCancelar);

            // Botão de voltar
            var btnVoltar = new Button();
            btnVoltar.Text = "Voltar";
            btnVoltar.BackColor = Color.FromArgb(240, 240, 240);
            btnVoltar.ForeColor = Color.FromArgb(80, 80, 80);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Font = new Font("Segoe UI", 10);
            btnVoltar.Size = new Size(100, 40);
            btnVoltar.Location = new Point(20, 510);
            btnVoltar.Click += (s, e) => this.Close();
            this.Controls.Add(btnVoltar);
        }
       

        private void CarregarDadosExemplo()
        {
            // Dados de exemplo para visualização
            var dadosExemplo = new[]
            {
                new { Data = "15/06/2023 14:00", Médico = "Dra. Ana Silva", Especialidade = "Ginecologia", Local = "Clínica Central", Motivo = "Consulta de rotina" },
                new { Data = "20/06/2023 10:30", Médico = "Dr. Carlos Mendes", Especialidade = "Cardiologia", Local = "Hospital Saúde", Motivo = "Acompanhamento" },
                new { Data = "25/06/2023 09:15", Médico = "Dra. Juliana Costa", Especialidade = "Dermatologia", Local = "Consulta Online", Motivo = "Avaliação de pele" }
            };

            dgvConsultas.DataSource = dadosExemplo;

            // Configura as colunas
            if (dgvConsultas.Columns.Count > 0)
            {
                dgvConsultas.Columns["Data"].HeaderText = "Data/Hora";
                dgvConsultas.Columns["Data"].Width = 150;
                dgvConsultas.Columns["Médico"].Width = 200;
                dgvConsultas.Columns["Especialidade"].Width = 150;
                dgvConsultas.Columns["Local"].Width = 150;
            }
        }

        // Controles
        private DataGridView dgvConsultas;
        private Button btnCancelar;

    }
}
