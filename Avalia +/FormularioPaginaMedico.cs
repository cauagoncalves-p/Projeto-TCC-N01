using Avalia__.AureaMaxDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Avalia__
{
    public partial class FormularioPaginaMedico: Form
    {
        private int _idMedico;
        private void CarregarConsultasDoMedico()
        {
            try

            {
                using (var consultaAdapter = new tbConsultaTableAdapter())
                using (var usuarioAdapter = new tbUsuarioTableAdapter())
                using (var avaliacaoAdapter = new tbAvaliacaoTableAdapter())
                {
                    // Carrega todos os usuários (pacientes)
                    var todosPacientes = usuarioAdapter.GetData().ToDictionary(u => u.Id_usuario);

                    // Carrega as consultas do médico atual
                    var todasConsultas = consultaAdapter.GetData().Where(c => c.IdMedico == _idMedico).ToList();

                    var consultas = todasConsultas
                        .Select(c =>
                        {
                            var paciente = todosPacientes.TryGetValue(c.Id_usuario, out var u)
                                ? $"{u.Nome} {u.Sobrenome}"
                                : "Paciente não encontrado";

                            var observacoes = c.IsObservacoesNull() ? "" : c.Observacoes;

                            return new
                            {
                                Paciente = paciente,
                                Data = c.DataConsulta.ToString("dd/MM/yyyy HH:mm"),
                                Status = c.StatusConsulta,
                                Observações = observacoes
                            };
                        })
                        .ToList();

                    dgvConsultasMedico.DataSource = consultas;

                    // Número de consultas que o médico tem
                    int totalConsultas = todasConsultas.Count;
                    lblTotalConsultas.Text = totalConsultas.ToString();

                    // Número de consultas pendentes
                    int totalAgendadas = todasConsultas.Count(c => c.StatusConsulta == "Agendada");
                    lblTotalPendentes.Text = totalAgendadas.ToString();

                    // Número de consultas realizadas
                    int totalRealizadas = todasConsultas.Count(c => c.StatusConsulta == "Realizada");
                    lblTotalRealizadas.Text = totalRealizadas.ToString();

                    // Número de consultas urgentes
                    int totalUrgentes = todasConsultas.Count(c => c.StatusConsulta == "Urgente");
                    lblTotalUrgencia.Text = totalUrgentes.ToString();

                    // -------- AVALIAÇÕES E PORCENTAGENS --------
                    var idsConsultas = todasConsultas.Select(c => c.IdConsulta).ToList();
                    var avaliacoes = avaliacaoAdapter.GetData()
                        .Where(a => idsConsultas.Contains(a.IdConsulta))
                        .ToList();

                    int totalAvaliacoes = avaliacoes.Count;

                    if (totalAvaliacoes > 0)
                    {
                        int notas5 = avaliacoes.Count(a => a.Nota == 5);
                        int notas4 = avaliacoes.Count(a => a.Nota == 4);
                        int notas3 = avaliacoes.Count(a => a.Nota == 3);
                        int notas2 = avaliacoes.Count(a => a.Nota == 2);
                        int notas1 = avaliacoes.Count(a => a.Nota == 1);

                        double porcentagem5 = (notas5 * 100.0) / totalAvaliacoes;
                        double porcentagem4 = (notas4 * 100.0) / totalAvaliacoes;
                        double porcentagem3 = (notas3 * 100.0) / totalAvaliacoes;
                        double porcentagem2 = (notas2 * 100.0) / totalAvaliacoes;
                        double porcentagem1 = (notas1 * 100.0) / totalAvaliacoes;

                        lblNota5.Text = $"{porcentagem5:F1}%";
                        lblNota4.Text = $"{porcentagem4:F1}%";
                        lblNota3.Text = $"{porcentagem3:F1}%";
                        lblNota2.Text = $"{porcentagem2:F1}%";
                        lblNota1.Text = $"{porcentagem1:F1}%";
                        lblTotalAvaliacao.Text = $"({totalAvaliacoes.ToString()}\navaliações)";

                        // Agora calcula a média das notas!
                        double mediaNotas = avaliacoes.Average(a => a.Nota);
                        lblNota.Text = $"{mediaNotas:F1}"; // Mostra a média com 1 casa decimal
                    }
                    else
                    {
                        lblNota5.Text = "0%";
                        lblNota4.Text = "0%";
                        lblNota3.Text = "0%";
                        lblNota2.Text = "0%";
                        lblNota1.Text = "0%";
                        lblTotalAvaliacao.Text = "0";
                        lblNota.Text = "0.0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar consultas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvConsultasMedico.DataSource = new List<object>(); // Limpa em caso de erro
            }
        }

        public FormularioPaginaMedico(int idMedico)
        {
            InitializeComponent();
            _idMedico = idMedico;
            CarregarConsultasDoMedico();
            ConfigurarDataGridView();
            AjustarColunasDataGridView();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panel1, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panel2, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panel3, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panel4, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panel5, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panel6, btnSair, 25, Color.White);

           

        }
        private void FormularioPaginaMedico_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }
        private void dgvConsultasMedicoMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConfigurarDataGridView()
        {
            // Configuração básica
            dgvConsultasMedico.AutoGenerateColumns = false;
            dgvConsultasMedico.AllowUserToAddRows = false;
            dgvConsultasMedico.AllowUserToDeleteRows = false;
            dgvConsultasMedico.ReadOnly = true;
            dgvConsultasMedico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultasMedico.MultiSelect = false;
            dgvConsultasMedico.RowHeadersVisible = false;

            // Paleta de cores terrosa (baseada no seu design)
            Color fundoClaro = Color.FromArgb(253, 246, 240); // #fdf6f0 - marfim claro
            Color headerColor = Color.FromArgb(139, 94, 60);   // #8b5e3c - marrom escuro
            Color textoPadrao = Color.FromArgb(90, 74, 66);    // #5a4a42 - marrom médio
            Color borda = Color.FromArgb(210, 180, 140);       // #d2b48c - bege (para bordas)
            Color selColor = Color.FromArgb(216, 164, 143);    // #d8a48f - rosa terroso (seleção)

            // Aplicando as cores
            dgvConsultasMedico.BackgroundColor = fundoClaro;
            dgvConsultasMedico.GridColor = borda;
            dgvConsultasMedico.BorderStyle = BorderStyle.None;

            // Cabeçalho das colunas
            dgvConsultasMedico.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgvConsultasMedico.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvConsultasMedico.ColumnHeadersHeight = 40;
            dgvConsultasMedico.EnableHeadersVisualStyles = false;
            dgvConsultasMedico.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvConsultasMedico.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvConsultasMedico.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Linhas alternadas
            dgvConsultasMedico.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 240, 230);
            dgvConsultasMedico.DefaultCellStyle.BackColor = fundoClaro;

            // Texto
            dgvConsultasMedico.DefaultCellStyle.ForeColor = textoPadrao;
            dgvConsultasMedico.AlternatingRowsDefaultCellStyle.ForeColor = textoPadrao;
            dgvConsultasMedico.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvConsultasMedico.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);

            // Seleção
            dgvConsultasMedico.DefaultCellStyle.SelectionBackColor = selColor;

            // Bordas e linhas
            dgvConsultasMedico.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConsultasMedico.GridColor = borda;
            dgvConsultasMedico.RowTemplate.Height = 35;

            // Configuração de redimensionamento
            dgvConsultasMedico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultasMedico.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvConsultasMedico.DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);

            // Configurar colunas (exemplo)
            if (dgvConsultasMedico.Columns.Count == 0)
            {
                dgvConsultasMedico.Columns.Add("colPaciente", "Paciente");
                dgvConsultasMedico.Columns.Add("colHorario", "Horário");
                dgvConsultasMedico.Columns.Add("colTipo", "Tipo");
                dgvConsultasMedico.Columns.Add("colStatus", "Observações");
            }
        }
            private void AjustarColunasDataGridView()
            {
            if (dgvConsultasMedico.Columns.Count == 0) return;

                var larguras = new Dictionary<string, int>
                        {
                            { "Paciente", 150 },
                            { "Data", 120 },
                            { "Status", 100 },
                            { "Observações", 200 }
                        };

            int totalLarguras = larguras.Sum(x => x.Value);

            // Ajuste proporcional se necessário
            if (totalLarguras > dgvConsultasMedico.Width)
            {
                double fatorReducao = (double)dgvConsultasMedico.Width / totalLarguras;
                foreach (var item in larguras.Keys.ToList())
                {
                    larguras[item] = (int)(larguras[item] * fatorReducao);
                }
            }
            else if (totalLarguras < dgvConsultasMedico.Width)
            {
                // Distribui espaço extra para Observações
                if (larguras.ContainsKey("Observações"))
                    larguras["Observações"] += dgvConsultasMedico.Width - totalLarguras;
            }

            // Aplicação das larguras
            foreach (DataGridViewColumn coluna in dgvConsultasMedico.Columns)
            {
                if (larguras.ContainsKey(coluna.Name))
                {
                    coluna.Width = larguras[coluna.Name];
                }
            }

            // Última coluna preenchendo espaço restante
            dgvConsultasMedico.Columns[dgvConsultasMedico.Columns.Count - 1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
