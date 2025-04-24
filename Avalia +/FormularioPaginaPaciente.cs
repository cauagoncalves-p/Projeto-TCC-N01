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
    public partial class FormularioPaginaPaciente: Form
    {
        private int idUsuario;
        private string emailUsuario;

        private void mudarFonte() 
        {
            lblAvalia.Font = new Font("Ariel", 16, FontStyle.Bold);
            lblTitulo.Font = new Font("Ariel", 14, FontStyle.Bold);
            lblSubTitulo.Font = new Font("Ariel", 12, FontStyle.Regular);
            //lblAgendarBtn.Font = new Font("Ariel", 10, FontStyle.Regular);
            //lblAvaliabtn.Font = new Font("Ariel", 10, FontStyle.Regular);
            //lblcancelabtn.Font = new Font("Ariel", 10, FontStyle.Regular);
            //lblhistoricobtn.Font = new Font("Ariel", 10, FontStyle.Regular);
        }
        public FormularioPaginaPaciente(int idUsuario, string emailUsuario)
        {
            InitializeComponent();
            mudarFonte();
            this.idUsuario = idUsuario;
            this.emailUsuario = emailUsuario;

            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelbackground, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panelConsultas, btnSair, 25, ColorTranslator.FromHtml("#F0E4DC"));
            controlador.ConfigInicial(this, panelHeader, btnSair, 20, ColorTranslator.FromHtml("#c97c63"));

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            FormularioAgendamentoConsulta formularioAgendamento = new FormularioAgendamentoConsulta(idUsuario,emailUsuario);
            formularioAgendamento.ShowDialog();

        }

        private void btnAvaliarconsulta_Click(object sender, EventArgs e)
        {
            
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

        
    }
}
