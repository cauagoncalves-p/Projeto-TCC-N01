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
        private void MudarFonte()
        {
            lblAvalia.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblDescritivo.Font = new Font("Inter", 11, FontStyle.Bold);
            lblEmail.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnProximo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTrocarSenha.Font = new Font("Inter", 15, FontStyle.Bold);
            txtEmail.Font = new Font("Segoe UI", 13, FontStyle.Regular);

        }

        public FormularioTrocarSenha()
        { 
            InitializeComponent();
            MudarFonte();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelTrocarSenha, btnSair, 25);
        }

        private void FormularioTrocarSenha_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja fechar a tela de login?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                this.Close();
            }
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

                // Abre a próxima tela, passando o e-mail se quiser
                FormularioEnvioDeEmailTrocarSenha envio = new FormularioEnvioDeEmailTrocarSenha(emaildigitado);
                envio.ShowDialog();
            }
            else
            {
                mensagem_Do_Sistema.MensagemError("E-mail não enontrado");
                return;
            }
        }
    }
}
