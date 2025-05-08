using Avalia__.AureaMaxDataSetTableAdapters;
using Avalia__.Controles;
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
        Mensagem_do_sistema mensagem = new Mensagem_do_sistema();
        private void CarregarConsultasDoMedico(string statusFiltro = "")
        {
             try
             {
                using (var consultaAdapter = new tbConsultaTableAdapter())
                using (var usuarioAdapter = new tbUsuarioTableAdapter())
                using (var avaliacaoAdapter = new tbAvaliacaoTableAdapter())
                {
                    var todosPacientes = usuarioAdapter.GetData().ToDictionary(u => u.Id_usuario);

                    // Aplica o filtro por status, se houver
                    var todasConsultas = consultaAdapter.GetData()
                        .Where(c => c.IdMedico == _idMedico)
                        .Where(c => string.IsNullOrEmpty(statusFiltro) || c.StatusConsulta == statusFiltro).OrderBy(c => c.DataConsulta)
                        .ToList();

                    var consultas = todasConsultas
                        .Select(c =>
                        {
                            var paciente = todosPacientes.TryGetValue(c.Id_usuario, out var u)
                                ? $"{u.Nome} {u.Sobrenome}"
                                : "Paciente não encontrado";

                            var observacoes = c.IsObservacoesNull() ? "" : c.Observacoes;

                            return new
                            {
                                Id_Consulta = c.IdConsulta,
                                Paciente = paciente,
                                Data = c.DataConsulta.ToString("dd/MM/yyyy"),
                                Hora = c.HorarioConsulta.ToString(@"hh\:mm"),
                                Status = c.StatusConsulta,
                                Observações = observacoes
                            };
                        })
                        .ToList();

                    dgvConsultasMedico.DataSource = consultas;

                    // Atualiza os contadores SEM FILTRO, sempre usando todas as consultas do médico:
                    var todasConsultasMedico = consultaAdapter.GetData()
                        .Where(c => c.IdMedico == _idMedico)
                        .ToList();

                    lblTotalConsultas.Text = todasConsultasMedico.Count.ToString();
                    lblTotalPendentes.Text = todasConsultasMedico.Count(c => c.StatusConsulta == "Agendada").ToString();
                    lblTotalRealizadas.Text = todasConsultasMedico.Count(c => c.StatusConsulta == "Realizada" || c.StatusConsulta == "Avaliada").ToString();
                    lblTotalUrgencia.Text = todasConsultasMedico.Count(c => c.StatusConsulta == "Urgente").ToString();


                    var idsConsultas = todasConsultasMedico.Select(c => c.IdConsulta).ToList();
                    var avaliacoes = avaliacaoAdapter.GetData()
                        .Where(a => idsConsultas.Contains(a.IdConsulta))
                        .ToList();

                    int totalAvaliacoes = avaliacoes.Count;

                    if (totalAvaliacoes > 0)
                    {
                        // Calcula a média geral considerando as 4 notas
                        double mediaNotas = avaliacoes.Average(a =>
                            (a.Atendimento_comunicacao + a.Conhecimento_tecnico + a.Respeito_empatia + a.Tempo_de_espera) / 4.0
                        );

                        lblNota.Text = $"{mediaNotas:F1}";

                        // Porcentagem de médias arredondadas para cada nota de 1 a 5
                        lblNota5.Text = $"{(avaliacoes.Count(a => Math.Round((a.Atendimento_comunicacao + a.Conhecimento_tecnico + a.Respeito_empatia + a.Tempo_de_espera) / 4.0) == 5) * 100.0 / totalAvaliacoes):F1}%";
                        lblNota4.Text = $"{(avaliacoes.Count(a => Math.Round((a.Atendimento_comunicacao + a.Conhecimento_tecnico + a.Respeito_empatia + a.Tempo_de_espera) / 4.0) == 4) * 100.0 / totalAvaliacoes):F1}%";
                        lblNota3.Text = $"{(avaliacoes.Count(a => Math.Round((a.Atendimento_comunicacao + a.Conhecimento_tecnico + a.Respeito_empatia + a.Tempo_de_espera) / 4.0) == 3) * 100.0 / totalAvaliacoes):F1}%";
                        lblNota2.Text = $"{(avaliacoes.Count(a => Math.Round((a.Atendimento_comunicacao + a.Conhecimento_tecnico + a.Respeito_empatia + a.Tempo_de_espera) / 4.0) == 2) * 100.0 / totalAvaliacoes):F1}%";
                        lblNota1.Text = $"{(avaliacoes.Count(a => Math.Round((a.Atendimento_comunicacao + a.Conhecimento_tecnico + a.Respeito_empatia + a.Tempo_de_espera) / 4.0) == 1) * 100.0 / totalAvaliacoes):F1}%";

                        lblTotalAvaliacao.Text = $"({totalAvaliacoes}\navaliações)";
                    }
                    else
                    {
                        lblNota.Text = "0.0";
                        lblNota1.Text = lblNota2.Text = lblNota3.Text = lblNota4.Text = lblNota5.Text = "0%";
                        lblTotalAvaliacao.Text = "(0 avaliações)";
                    }

                    dgvConsultasMedico.Columns["Id_Consulta"].Visible = false;
                }
        }
         catch (Exception ex)
         {
                MessageBox.Show($"Erro ao carregar consultas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvConsultasMedico.DataSource = new List<object>();
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
            controlador.ConfigInicial(this, panelConsultasTotais, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panelPendentes, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, paelRealizadas, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panelUrgente, btnSair, 25, Color.White);
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
                dgvConsultasMedico.Columns.Add("colHora", "Hora");
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
                            { "Observações", 200 },
                            { "Hora", 100 }
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

        private void dgvConsultasMedico_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvConsultasMedico.Rows[e.RowIndex];
            var dados = (dynamic)row.DataBoundItem;
            string hora = row.Cells["Hora"].Value.ToString();
            int IdConsulta = dados.Id_Consulta;
            string paciente = row.Cells["Paciente"].Value.ToString();
            string data = row.Cells["Data"].Value.ToString();
            string status = row.Cells["Status"].Value.ToString();
            string observacoes = row.Cells["Observações"].Value.ToString();
       

            DateTime dataConsulta;
            if (DateTime.TryParse(data, out dataConsulta))
            {
                DateTime dataAtual = DateTime.Now;

                if (dataAtual.Date < dataConsulta.Date)
                {
                    mensagem.MensagemError("Essa consulta ainda vai acontecer.\nApenas é possível dar o diagnóstico no dia da consulta ou após ela.");
                    return;
                }

                this.Hide();
                // Abrir novo formulário com os dados
                FormularioProntuarioPaciente detalhes = new FormularioProntuarioPaciente(IdConsulta, paciente, data,hora, status, observacoes);
                detalhes.ShowDialog();

                this.Show();
            }
            else
            {
                MessageBox.Show("Data inválida!");
            }
        }

        private void panelConsultasTotais_Click(object sender, EventArgs e)
        {
            CarregarConsultasDoMedico();
        }

        private void panelPendentes_Click(object sender, EventArgs e)
        {
            CarregarConsultasDoMedico("Agendada");
        }

        private void paelRealizadas_Click(object sender, EventArgs e)
        {
            CarregarConsultasDoMedico("Realizada");
            CarregarConsultasDoMedico("Avaliada");
        }

        private void panelUrgente_Click(object sender, EventArgs e)
        {
            CarregarConsultasDoMedico("Urgente");
        }
    }
}
