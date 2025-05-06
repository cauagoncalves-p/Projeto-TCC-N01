using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Avalia__.RadiusButton;

namespace Avalia__
{
    public partial class FormularioPaginaPaciente: Form
    {
        private int idUsuario;
        private string emailUsuario;

        
        public FormularioPaginaPaciente(int idUsuario, string emailUsuario)
        {
            InitializeComponent();
         
            this.idUsuario = idUsuario;
            this.emailUsuario = emailUsuario;

            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelbackground, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panel1, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panel2, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panelConsultas, btnSair, 25, ColorTranslator.FromHtml("#F0E4DC"));
            controlador.ConfigInicial(this, panelHeader, btnSair, 20, ColorTranslator.FromHtml("#c97c63"));
            UIHelper.ArredondarBotao(btnDetalhes, 25);
            UIHelper.ArredondarBotao(btnLembrar, 25);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            FormularioAgendamentoConsulta formularioAgendamento = new FormularioAgendamentoConsulta(idUsuario);
            formularioAgendamento.ShowDialog();

        }
       
        private void btnHistoricomedico_Click(object sender, EventArgs e)
        {
            FormularioConsultasAgendadas formularioConsultasAgendadas = new FormularioConsultasAgendadas(idUsuario);
            formularioConsultasAgendadas.ShowDialog();
        }

        private void btnCancelarConsulta_Click(object sender, EventArgs e)
        {
            FormCancelarConsulta formCancelarConsulta = new FormCancelarConsulta(idUsuario);
            formCancelarConsulta.ShowDialog();
        }

        private void FormularioPaginaPaciente_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }
    }
}
