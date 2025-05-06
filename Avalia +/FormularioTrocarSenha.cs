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
    public partial class FormularioTrocarSenha : Form
    {
        Mensagem_do_sistema mensagem_Do_Sistema = new Mensagem_do_sistema();

        public FormularioTrocarSenha()
        {
            InitializeComponent();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelTrocarSenha, btnSair, 25, Color.White);
        }

        private void FormularioTrocarSenha_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text)) 
            {
                mensagem_Do_Sistema.MensagemError("Preencha o campo de e-mail!");
            }
            string emaildigitado = txtEmail.Text;
            // Consulta no banco
            tbUsuarioTableAdapter tbUsuarioTableAdapter = new tbUsuarioTableAdapter(); 
            tbMedicoTableAdapter tbMedicoTableAdapter = new tbMedicoTableAdapter();
            var usuario = tbUsuarioTableAdapter.GetData().FirstOrDefault(u => u.Email == emaildigitado);
            var medico = tbMedicoTableAdapter.GetData().FirstOrDefault(m => m.Email == emaildigitado);

            var resultado = usuario ?? (object)medico;

            if (resultado != null)
            {
                mensagem_Do_Sistema.MensagemInformation("E-mail encontrado!...");

                this.Hide();
                // Abre a próxima tela, passando o e-mail se quiser
                FormularioEnvioDeEmailTrocarSenha envio = new FormularioEnvioDeEmailTrocarSenha(emaildigitado);
                envio.ShowDialog();
                this.Show();
            }
            else
            {
                mensagem_Do_Sistema.MensagemError("E-mail não enontrado");
                return;
            }
        }
    }
}
