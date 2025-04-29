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
    public partial class FormularioProntuarioPaciente: Form
    {
        public FormularioProntuarioPaciente(string paciente, string data, string status, string observacoes)
        {
            InitializeComponent();

            lblInfopaciente.Text = paciente;
            lblInfoObservacao.Text = observacoes;
            lblInfoStatus.Text = status;
            lblInfoHoraData.Text = data;

            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panel1, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panel2, btnSair, 25, ColorTranslator.FromHtml("#e8d5c4"));
        }

        private void btnFinalizar_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }
    }
}
