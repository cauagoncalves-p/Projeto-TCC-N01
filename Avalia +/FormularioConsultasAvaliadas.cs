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

namespace Avalia__
{
    public partial class FormularioConsultasAvaliadas: Form
    {
        private int _idUsuario;
        Mensagem_do_sistema mensagem_Do_Sistema = new Mensagem_do_sistema();
        private void ConfigurarDataGridView()
        {
            // Configuração básica
            dgvConsultas.AutoGenerateColumns = false;
            dgvConsultas.AllowUserToAddRows = false;
            dgvConsultas.AllowUserToDeleteRows = false;
            dgvConsultas.ReadOnly = true;
            dgvConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultas.MultiSelect = false;
            dgvConsultas.RowHeadersVisible = false;

            // Paleta de cores terrosa (baseada no seu design)
            Color fundoClaro = Color.FromArgb(253, 246, 240); // #fdf6f0 - marfim claro
            Color headerColor = Color.FromArgb(139, 94, 60);   // #8b5e3c - marrom escuro
            Color textoPadrao = Color.FromArgb(90, 74, 66);    // #5a4a42 - marrom médio
            Color borda = Color.FromArgb(210, 180, 140);       // #d2b48c - bege (para bordas)
            Color selColor = Color.FromArgb(216, 164, 143);    // #d8a48f - rosa terroso (seleção)

            // Aplicando as cores
            dgvConsultas.BackgroundColor = fundoClaro;
            dgvConsultas.GridColor = borda;
            dgvConsultas.BorderStyle = BorderStyle.None;

            // Cabeçalho das colunas
            dgvConsultas.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgvConsultas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvConsultas.ColumnHeadersHeight = 40;
            dgvConsultas.EnableHeadersVisualStyles = false;
            dgvConsultas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvConsultas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvConsultas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Linhas alternadas
            dgvConsultas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 240, 230);
            dgvConsultas.DefaultCellStyle.BackColor = fundoClaro;

            // Texto
            dgvConsultas.DefaultCellStyle.ForeColor = textoPadrao;
            dgvConsultas.AlternatingRowsDefaultCellStyle.ForeColor = textoPadrao;
            dgvConsultas.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvConsultas.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);

            // Seleção
            dgvConsultas.DefaultCellStyle.SelectionBackColor = selColor;

            // Bordas e linhas
            dgvConsultas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConsultas.GridColor = borda;
            dgvConsultas.RowTemplate.Height = 35;

            // Configuração de redimensionamento
            dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvConsultas.DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);

            // Configurar colunas (exemplo)
            if (dgvConsultas.Columns.Count == 0)
            { 
                dgvConsultas.Columns.Add("colMedico", "Medico");
                dgvConsultas.Columns.Add("colHorario", "Horário");
                dgvConsultas.Columns.Add("colTipo", "Tipo");
                dgvConsultas.Columns.Add("colStatus", "Status");
            }
        }
        private void AjustarColunasDataGridView()
        {
            if (dgvConsultas.Columns.Count == 0) return;

            // Defina as larguras desejadas (sua configuração atual)
            var larguras = new Dictionary<string, int>
                {
                    { "Medico", 200 },      // 200px
                    { "Local", 250 },    // 350px
                    { "Status", 200 },    // 250px
                    { "Data", 150 },    // 150px
                };

            // Calcula o total das larguras definidas
            int totalLarguras = larguras.Sum(x => x.Value);

            // Verifica se a soma ultrapassa a largura disponível
            if (totalLarguras > dgvConsultas.Width)
            {
                // Se ultrapassar, reduz proporcionalmente
                double fatorReducao = (double)dgvConsultas.Width / totalLarguras;
                foreach (var item in larguras.Keys.ToList())
                {
                    larguras[item] = (int)(larguras[item] * fatorReducao);
                }
            }

            // Aplica as larguras
            foreach (DataGridViewColumn coluna in dgvConsultas.Columns)
            {
                if (larguras.ContainsKey(coluna.Name))
                {
                    coluna.Width = larguras[coluna.Name];
                }
            }

            // Garante que a última coluna preencha qualquer espaço residual
            if (dgvConsultas.Columns.Count > 0)
            {
                dgvConsultas.Columns[dgvConsultas.Columns.Count - 1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void CarregarConsultasDoUsuario()
        {
            try
            {
                using (var consultaAdapter = new tbConsultaTableAdapter())
                using (var medicoAdapter = new tbMedicoTableAdapter())
                {
                    var todosMedicos = medicoAdapter.GetData().ToDictionary(m => m.IdMedico);

                    var consultas = consultaAdapter.GetData()
                        .Where(c => c.Id_usuario == _idUsuario)
                        .Where(c => c.StatusConsulta == "Avaliada")
                        .Select(c =>
                        {
                            var medico = todosMedicos.TryGetValue(c.IdMedico, out var m)
                                ? $"{m.Nome} {m.Sobrenome}"
                                : "Médico não encontrado";

                            var observacoes = c.IsObservacoesNull() ? "" : c.Observacoes;

                            return new
                            {
                                IdConsulta = c.IdConsulta,
                                Data = c.DataConsulta.ToString("dd/MM/yyyy HH:mm"),
                                Medico = medico,
                                Motivo = c.Motivo,
                                Status = c.StatusConsulta
                            };
                        })
                        .ToList();

                    dgvConsultas.DataSource = consultas;
                    dgvConsultas.Columns["IdConsulta"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar consultas: {ex.Message}", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvConsultas.DataSource = new List<object>();
            }
        }
        public FormularioConsultasAvaliadas(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            CarregarConsultasDoUsuario();
            ConfigurarDataGridView();
            AjustarColunasDataGridView();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this,panelConsultaAvaliadas, btnSair, 25, Color.White);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }

        private void FormularioConsultasAvaliadas_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void dgvConsultas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dgvConsultas.Rows[e.RowIndex];
            string idConsulta = linha.Cells["IdConsulta"].Value.ToString();
            int idcons = int.Parse(idConsulta);

            if (e.RowIndex >= 0)
            {
                // Busca o diagnóstico
                DiagnosticoMedicoTableAdapter diagnosticoAdapter = new DiagnosticoMedicoTableAdapter();
                var diagnostico = diagnosticoAdapter.GetData().FirstOrDefault(d => d.Id_Consulta == idcons);

                if (diagnostico == null)
                {
                    mensagem_Do_Sistema.MensagemAtencao("Diagnóstico não encontrado.");
                    mensagem_Do_Sistema.MensagemAtencao("Essa consulta ainda não foi realizada ou está cancelada!");
                    return;
                }

                // Pegando o status da consulta
                string status = linha.Cells["Status"].Value.ToString();

                if (status == "Realizada" || status == "Avaliada")
                {
                    this.Hide();
                    // Abre o formulário de detalhes
                    VerDiagnosticoMedico detalhes = new VerDiagnosticoMedico(idConsulta);
                    detalhes.ShowDialog();

                    this.Show();
                }
            }
        }
    }
}
