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
using static Avalia__.RadiusButton;

namespace Avalia__
{
    public partial class frmConfirmarCancelamento: Form
    {
        private string _data, _medico, _motivo, _status, _observacoes, _local;
        Mensagem_do_sistema mensagem_Do_Sistema = new Mensagem_do_sistema();
        private void btnManterConsulta_Click(object sender, EventArgs e)
        {
            mensagem_Do_Sistema.MensagemInformation("Sua consulta continuara agendada!");
            this.Close();   
        }

        int _idConsulta;

        /*
         * UPDATE tbConsulta
            SET StatusConsulta = @status
            WHERE IdConsulta = @idConsulta
         AtualizarStatusConsulta
        */
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var consultaAdapter = new tbConsultaTableAdapter())
                {
                    consultaAdapter.AtualizarStatusConsulta("Cancelada", _idConsulta); 
                }

                MessageBox.Show("Consulta cancelada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cancelar consulta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmConfirmarCancelamento_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        public frmConfirmarCancelamento(int idConsulta,string data, string medico, string motivo, string status, string observacoes, string local)
        {
            InitializeComponent();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelCancelarConsulta, btnSair, 25, Color.White);
            UIHelper.ArredondarBotao(btnCancelar, 10);
            UIHelper.ArredondarBotao(btnManterConsulta, 10);

            _idConsulta = idConsulta;
            _data = data;
            _medico = medico;
            _motivo = motivo;
            _status = status;
            _observacoes = observacoes;
            _local = local;


            lblInfoMedico.Text = $"Dro.(a) {medico}";
            lblInfoLocal.Text = $"{local}";
            lblInfoHoraData.Text = $"{data}";
            string respostaObservacao = observacoes == "" ? "Sem observação" : observacoes;
            lblInfoObservacao.Text = $"{respostaObservacao}";

            cbxMotivo.SelectedIndex = 0;

        }
    }
}
