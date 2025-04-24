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
        private int _idUsuario;

        private void ConfigurarDataGridView()
        {
            // Configuração básica
            dgvCancelar.AutoGenerateColumns = false;
            dgvCancelar.AllowUserToAddRows = false;
            dgvCancelar.AllowUserToDeleteRows = false;
            dgvCancelar.ReadOnly = true;
            dgvCancelar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCancelar.MultiSelect = false;
            dgvCancelar.RowHeadersVisible = false;

            // Paleta inspirada no seu design
            Color fundoClaro = Color.FromArgb(250, 250, 252); // Branco muito suave
            Color azulHeader = Color.FromArgb(70, 130, 180);  // Azul médio (como o título dos cards)
            Color textoPadrao = Color.FromArgb(60, 60, 60);   // Cinza escuro suave
            Color textoClaro = Color.FromArgb(100, 100, 100); // Cinza médio
            Color borda = Color.FromArgb(230, 230, 235);      // Linha divisória suave

            // Aplicando as cores
            dgvCancelar.BackgroundColor = fundoClaro;
            dgvCancelar.GridColor = borda;
            dgvCancelar.BorderStyle = BorderStyle.None;

            // Cabeçalho das colunas
            dgvCancelar.ColumnHeadersDefaultCellStyle.BackColor = azulHeader;
            dgvCancelar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCancelar.ColumnHeadersHeight = 40;
            dgvCancelar.EnableHeadersVisualStyles = false;
            dgvCancelar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Linhas alternadas
            dgvCancelar.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 248);
            dgvCancelar.DefaultCellStyle.BackColor = fundoClaro;

            // Texto
            dgvCancelar.DefaultCellStyle.ForeColor = textoPadrao;
            dgvCancelar.AlternatingRowsDefaultCellStyle.ForeColor = textoPadrao;
            dgvCancelar.DefaultCellStyle.SelectionForeColor = textoPadrao;

            // Seleção (inspirado nos botões "Detalhes" da imagem)
            dgvCancelar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 230, 240);

            // Status específicos (como na imagem)
            dgvCancelar.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvCancelar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Borda entre as linhas (como os divisores na imagem)
            dgvCancelar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCancelar.GridColor = Color.FromArgb(240, 240, 240);

            // Configuração de redimensionamento
            dgvCancelar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCancelar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCancelar.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvCancelar.RowTemplate.Height = 40;
        }
        private void AjustarColunasDataGridView()
        {
            if (dgvCancelar.Columns.Count == 0) return;

            // Defina as larguras desejadas (sua configuração atual)
            var larguras = new Dictionary<string, int>
                {
                    { "Data", 200 },      // 200px
                    { "Médico", 250 },    // 350px
                    { "Motivo", 200 },    // 250px
                    { "Status", 150 },    // 150px
                    { "Observações", 150} // 100px
                };

            // Calcula o total das larguras definidas
            int totalLarguras = larguras.Sum(x => x.Value);

            // Verifica se a soma ultrapassa a largura disponível
            if (totalLarguras > dgvCancelar.Width)
            {
                // Se ultrapassar, reduz proporcionalmente
                double fatorReducao = (double)dgvCancelar.Width / totalLarguras;
                foreach (var item in larguras.Keys.ToList())
                {
                    larguras[item] = (int)(larguras[item] * fatorReducao);
                }
            }
            else if (totalLarguras < dgvCancelar.Width)
            {
                // Se sobrar espaço, distribui para a coluna Observações
                larguras["Observações"] += dgvCancelar.Width - totalLarguras;
            }

            // Aplica as larguras
            foreach (DataGridViewColumn coluna in dgvCancelar.Columns)
            {
                if (larguras.ContainsKey(coluna.Name))
                {
                    coluna.Width = larguras[coluna.Name];
                }
            }

            // Garante que a última coluna preencha qualquer espaço residual
            if (dgvCancelar.Columns.Count > 0)
            {
                dgvCancelar.Columns[dgvCancelar.Columns.Count - 1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void CarregarConsultasDoUsuario(string statusFiltro = "Agendada")
        {
            try
            {
                using (var consultaAdapter = new tbConsultaTableAdapter())
                using (var medicoAdapter = new tbMedicoTableAdapter())
                {
                    var todosMedicos = medicoAdapter.GetData().ToDictionary(m => m.IdMedico);

                    var consultas = consultaAdapter.GetData()
                        .Where(c => c.Id_usuario == _idUsuario)
                        .Where(c => string.IsNullOrEmpty(statusFiltro) || c.StatusConsulta == statusFiltro)
                        .Select(c =>
                        {
                            var medico = todosMedicos.TryGetValue(c.IdMedico, out var m)
                                ? $"{m.Nome} {m.Sobrenome}"
                                : "Médico não encontrado";

                            var observacoes = c.IsObservacoesNull() ? "" : c.Observacoes;

                            return new
                            {
                                Data = c.DataConsulta.ToString("dd/MM/yyyy HH:mm"),
                                Medico = medico,
                                Motivo = c.Motivo,
                                Status = c.StatusConsulta,
                                Observações = observacoes
                            };
                        })
                        .ToList();

                    dgvCancelar.DataSource = consultas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar consultas: {ex.Message}", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvCancelar.DataSource = new List<object>();
            }
        }

        public FormCancelarConsulta(int idUsuario)
        {
            InitializeComponent();
         
            dgvCancelar.CellClick += dgvCancelar_CellClick;
            _idUsuario = idUsuario;
            CarregarConsultasDoUsuario();
            ConfigurarDataGridView();
            AjustarColunasDataGridView();

            btnCancelar.Enabled = false;
            btnCancelar.BackColor = Color.Gray; 
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelCancelarConsulta, btnSair, 25, Color.White);
        }

        private void FormCancelarConsulta_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

 
        private void dgvCancelar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Habilita o botão e muda a cor
                btnCancelar.Enabled = true;
                btnCancelar.BackColor = Color.FromArgb(220, 53, 69); // vermelho bootstrap
                btnCancelar.ForeColor = Color.White;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (dgvCancelar.SelectedRows.Count > 0)
            {
                var row = dgvCancelar.SelectedRows[0];

                string data = row.Cells["Data"].Value?.ToString() ?? "";
                string medico = row.Cells["Medico"].Value?.ToString() ?? "";
                string motivo = row.Cells["Motivo"].Value?.ToString() ?? "";
                string status = row.Cells["Status"].Value?.ToString() ?? "";
                string observacoes = row.Cells["Observações"].Value?.ToString() ?? "";

                var formConfirmarCancelamento = new frmConfirmarCancelamento(data, medico, motivo, status, observacoes);
                formConfirmarCancelamento.ShowDialog();

                // Depois de cancelar, recarrega a grid e desativa o botão
                CarregarConsultasDoUsuario();
                btnCancelar.Enabled = false;
                btnCancelar.BackColor = Color.Gray;
            }
            else
            {
                MessageBox.Show("Selecione uma consulta para cancelar.");
            }
        }
    }
}
