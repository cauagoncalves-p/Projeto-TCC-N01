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
    public partial class FormularioAvaliar : Form
    {
        private int _idUsuario;
        private void ConfigurarDataGridView()
        {
            // Configuração básica
            dgvConsultasAvaliadas.AutoGenerateColumns = false;
            dgvConsultasAvaliadas.AllowUserToAddRows = false;
            dgvConsultasAvaliadas.AllowUserToDeleteRows = false;
            dgvConsultasAvaliadas.ReadOnly = true;
            dgvConsultasAvaliadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultasAvaliadas.MultiSelect = false;
            dgvConsultasAvaliadas.RowHeadersVisible = false;

            // Paleta de cores terrosa (baseada no seu design)
            Color fundoClaro = Color.FromArgb(253, 246, 240); // #fdf6f0 - marfim claro
            Color headerColor = Color.FromArgb(139, 94, 60);   // #8b5e3c - marrom escuro
            Color textoPadrao = Color.FromArgb(90, 74, 66);    // #5a4a42 - marrom médio
            Color borda = Color.FromArgb(210, 180, 140);       // #d2b48c - bege (para bordas)
            Color selColor = Color.FromArgb(216, 164, 143);    // #d8a48f - rosa terroso (seleção)

            // Aplicando as cores
            dgvConsultasAvaliadas.BackgroundColor = fundoClaro;
            dgvConsultasAvaliadas.GridColor = borda;
            dgvConsultasAvaliadas.BorderStyle = BorderStyle.None;
            
            // Cabeçalho das colunas
            dgvConsultasAvaliadas.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgvConsultasAvaliadas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvConsultasAvaliadas.ColumnHeadersHeight = 40;
            dgvConsultasAvaliadas.EnableHeadersVisualStyles = false;
            dgvConsultasAvaliadas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvConsultasAvaliadas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvConsultasAvaliadas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Linhas alternadas
            dgvConsultasAvaliadas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 240, 230);
            dgvConsultasAvaliadas.DefaultCellStyle.BackColor = fundoClaro;

            // Texto
            dgvConsultasAvaliadas.DefaultCellStyle.ForeColor = textoPadrao;
            dgvConsultasAvaliadas.AlternatingRowsDefaultCellStyle.ForeColor = textoPadrao;
            dgvConsultasAvaliadas.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvConsultasAvaliadas.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);

            // Seleção
            dgvConsultasAvaliadas.DefaultCellStyle.SelectionBackColor = selColor;

            // Bordas e linhas
            dgvConsultasAvaliadas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConsultasAvaliadas.GridColor = borda;
            dgvConsultasAvaliadas.RowTemplate.Height = 35;

            // Configuração de redimensionamento
            dgvConsultasAvaliadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultasAvaliadas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvConsultasAvaliadas.DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);

            // Configurar colunas (exemplo)
            if (dgvConsultasAvaliadas.Columns.Count == 0)
            {
                dgvConsultasAvaliadas.Columns.Add("colMedico", "Medico");
                dgvConsultasAvaliadas.Columns.Add("colHorario", "Horário");
                dgvConsultasAvaliadas.Columns.Add("colDiagnostico", "Diagnóstico");
                dgvConsultasAvaliadas.Columns.Add("colStatus", "Status");
                dgvConsultasAvaliadas.Columns.Add("colLocal", "Local");

              
            }
        }
        private void AjustarColunasDataGridView()
        {
            if (dgvConsultasAvaliadas.Columns.Count == 0) return;

            // Defina as larguras desejadas (sua configuração atual)
            var larguras = new Dictionary<string, int>
                {
                    { "Medico", 200 },      // 200px
                    { "Horario", 250 },    // 350px
                    { "Diagnóstico", 150}, // 100px
                    { "Status", 100}, // 100px
                    { "Local", 150} // 100px
                };

            // Calcula o total das larguras definidas
            int totalLarguras = larguras.Sum(x => x.Value);

            // Verifica se a soma ultrapassa a largura disponível
            if (totalLarguras > dgvConsultasAvaliadas.Width)
            {
                // Se ultrapassar, reduz proporcionalmente
                double fatorReducao = (double)dgvConsultasAvaliadas.Width / totalLarguras;
                foreach (var item in larguras.Keys.ToList())
                {
                    larguras[item] = (int)(larguras[item] * fatorReducao);
                }
            }
           

            // Aplica as larguras
            foreach (DataGridViewColumn coluna in dgvConsultasAvaliadas.Columns)
            {
                if (larguras.ContainsKey(coluna.Name))
                {
                    coluna.Width = larguras[coluna.Name];
                }
            }

            // Garante que a última coluna preencha qualquer espaço residual
            if (dgvConsultasAvaliadas.Columns.Count > 0)
            {
                dgvConsultasAvaliadas.Columns[dgvConsultasAvaliadas.Columns.Count - 1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        public FormularioAvaliar(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
           
            ConfigurarDataGridView();
            AjustarColunasDataGridView();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelConsultaAvaliadas, btnSair, 25, Color.White);
        }
    }
}
