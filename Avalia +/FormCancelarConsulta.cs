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

            // Paleta de cores terrosa (baseada no seu design)
            Color fundoClaro = Color.FromArgb(253, 246, 240); // #fdf6f0 - marfim claro
            Color headerColor = Color.FromArgb(139, 94, 60);   // #8b5e3c - marrom escuro
            Color textoPadrao = Color.FromArgb(90, 74, 66);    // #5a4a42 - marrom médio
            Color borda = Color.FromArgb(210, 180, 140);       // #d2b48c - bege (para bordas)
            Color selColor = Color.FromArgb(216, 164, 143);    // #d8a48f - rosa terroso (seleção)

            // Aplicando as cores
            dgvCancelar.BackgroundColor = fundoClaro;
            dgvCancelar.GridColor = borda;
            dgvCancelar.BorderStyle = BorderStyle.None;

            // Cabeçalho das colunas
            dgvCancelar.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgvCancelar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCancelar.ColumnHeadersHeight = 40;
            dgvCancelar.EnableHeadersVisualStyles = false;
            dgvCancelar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCancelar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCancelar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Linhas alternadas
            dgvCancelar.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 240, 230);
            dgvCancelar.DefaultCellStyle.BackColor = fundoClaro;

            // Texto
            dgvCancelar.DefaultCellStyle.ForeColor = textoPadrao;
            dgvCancelar.AlternatingRowsDefaultCellStyle.ForeColor = textoPadrao;
            dgvCancelar.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCancelar.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);

            // Seleção
            dgvCancelar.DefaultCellStyle.SelectionBackColor = selColor;

            // Bordas e linhas
            dgvCancelar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCancelar.GridColor = borda;
            dgvCancelar.RowTemplate.Height = 35;

            // Configuração de redimensionamento
            dgvCancelar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCancelar.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvCancelar.DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);

            // Configurar colunas (exemplo)
            if (dgvCancelar.Columns.Count == 0)
            {
                dgvCancelar.Columns.Add("colIniciais", "Iniciais");
                dgvCancelar.Columns.Add("colPaciente", "Paciente");
                dgvCancelar.Columns.Add("colHorario", "Horário");
                dgvCancelar.Columns.Add("colTipo", "Tipo");
                dgvCancelar.Columns.Add("colStatus", "Status");

                // Centralizar coluna de iniciais
                dgvCancelar.Columns["colIniciais"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
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
                    var instituicoes = new tbInstituicaoTableAdapter().GetData().ToDictionary(i => i.IdInstituicao);

                    var consultas = consultaAdapter.GetData()
                        .Where(c => c.Id_usuario == _idUsuario)
                        .Where(c => string.IsNullOrEmpty(statusFiltro) || c.StatusConsulta == statusFiltro)
                        .Select(c =>
                        {
                            var medico = todosMedicos.TryGetValue(c.IdMedico, out var m)
                                ? $"{m.Nome} {m.Sobrenome}"
                                : "Médico não encontrado";

                            var local = (todosMedicos.TryGetValue(c.IdMedico, out var medicoSelecionado) &&
                                instituicoes.TryGetValue(medicoSelecionado.IdInstituicao, out var inst))
                                ? inst.NomeInstituicao
                                : "Local não encontrado";

                          

                            var observacoes = c.IsObservacoesNull() ? "" : c.Observacoes;

                            return new
                            {
                                IdConsulta = c.IdConsulta, 
                                Data = c.DataConsulta.ToString("dd/MM/yyyy HH:mm"),
                                Medico = medico,
                                Motivo = c.Motivo,
                                Status = c.StatusConsulta,
                                Observações = observacoes,
                                Local = local
                            };
                        })
                        .ToList();





                    dgvCancelar.DataSource = consultas;

                    if (dgvCancelar.Columns["IdConsulta"] != null)
                    {
                        dgvCancelar.Columns["IdConsulta"].Visible = false;
                    }
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
            controlador.ConfigInicial(this, panelbtnCancelar, btnSair, 25, Color.FromArgb(253, 246, 240));
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
                string local = row.Cells["Local"].Value?.ToString() ?? "";
              



                var consultaSelecionada = (dynamic)row.DataBoundItem;
                int idConsulta = consultaSelecionada.IdConsulta;


                var formConfirmarCancelamento = new frmConfirmarCancelamento(idConsulta, data, medico, motivo, status, observacoes, local);
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }
    }
}
