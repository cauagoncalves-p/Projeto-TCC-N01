using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Avalia__
{
    public partial class FormularioProntuarioPaciente: Form
    {
        ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();  
        public FormularioProntuarioPaciente(string paciente, string data, string status, string observacoes)
        {
            InitializeComponent();

            lblInfopaciente.Text = paciente;
            lblInfoObservacao.Text = observacoes;
            lblInfoStatus.Text = status;
            lblInfoHoraData.Text = data;
            configuracaoTelas.ConfigurarPlaceholder(txtDiagnostico, "Descreva o diagnóstico do paciente...");
            configuracaoTelas.ConfigurarPlaceholder(txtObservação, "Adicione quaisquer observações relevantes...");
            configuracaoTelas.ConfigurarPlaceholder(txtMedicamento, "Nome do medicamento");
            configuracaoTelas.ConfigurarPlaceholder(txtDosagem, "Dosagem");
            configuracaoTelas.ConfigurarPlaceholder(txtFrequencia, "Frequência");
            configuracaoTelas.ConfigurarPlaceholder(txtDuracao, "Duração");
            configuracaoTelas.ConfigurarPlaceholder(txtInstrucaoReceita, "Adicione instruções específicas sobre os medicamentos...");



            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panel1, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panel2, btnSair, 25, ColorTranslator.FromHtml("#e8d5c4"));
        }

        private void btnFinalizar_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
