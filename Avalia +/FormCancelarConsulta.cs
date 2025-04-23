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
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelCancelarConsulta, btnSair, 25, Color.White);

        }

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
            if (dgvConsultas.Columns.Count == 0) return;

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
            if (totalLarguras > dgvConsultas.Width)
            {
                // Se ultrapassar, reduz proporcionalmente
                double fatorReducao = (double)dgvConsultas.Width / totalLarguras;
                foreach (var item in larguras.Keys.ToList())
                {
                    larguras[item] = (int)(larguras[item] * fatorReducao);
                }
            }
            else if (totalLarguras < dgvConsultas.Width)
            {
                // Se sobrar espaço, distribui para a coluna Observações
                larguras["Observações"] += dgvConsultas.Width - totalLarguras;
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

        private void FormCancelarConsulta_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }
    }
}
