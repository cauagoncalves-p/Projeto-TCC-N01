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
    public partial class FormInicial: Form
    {
        private void MudarCorBotao(Button botaoclicado)
        {
            // Resetar a cor de todos os botões dentro do painel
            foreach (Control botao in panelLogin.Controls)
            {
                if (botao is Button btn)
                {
                    if (btn == btnSair || btn == btnEntrar)
                        continue;

                    btn.BackColor = ColorTranslator.FromHtml("#fffaf0");
                }
            }

            // Aplicar a cor no botão clicado
            botaoclicado.BackColor = ColorTranslator.FromHtml("#d8a48f");

            // Resetar as labels antes de aplicar a cor na correta
            lblMedico.BackColor = ColorTranslator.FromHtml("#fffaf0");
            lblPaciente.BackColor = ColorTranslator.FromHtml("#fffaf0");
            lblMedico.ForeColor = ColorTranslator.FromHtml("#5a4a42");
            btnMedico.ForeColor = ColorTranslator.FromHtml("#5a4a42");
            lblPaciente.ForeColor = ColorTranslator.FromHtml("#5a4a42");
            btnPaciente.ForeColor = ColorTranslator.FromHtml("#5a4a42");

            // Aplicar a cor apenas na label correspondente
            if (botaoclicado == btnMedico)
            {
                lblMedico.BackColor = ColorTranslator.FromHtml("#d8a48f");
                lblMedico.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btnMedico.ForeColor = ColorTranslator.FromHtml("#ffffff");
            }
            else if (botaoclicado == btnPaciente)
            {
                lblPaciente.BackColor = ColorTranslator.FromHtml("#d8a48f");
                lblPaciente.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btnPaciente.ForeColor = ColorTranslator.FromHtml("#ffffff");
            }
        }


        private void MudarFonte()
        {
            lblAvalia.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblentrar.Font = new Font("Inter", 16, FontStyle.Bold); 
            btnMedico.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnPaciente.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnEntrar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblMedico.ForeColor = ColorTranslator.FromHtml("#5a4a42");
            lblPaciente.ForeColor = ColorTranslator.FromHtml("#5a4a42");
            btnMedico.ForeColor = ColorTranslator.FromHtml("#5a4a42");
            btnPaciente.ForeColor = ColorTranslator.FromHtml("#5a4a42");
            btnEntrar.BackColor = ColorTranslator.FromHtml("#d8a48f");
        }

        public FormInicial()
        {
            InitializeComponent();
            MudarFonte();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelLogin, btnSair, 25);
            UIHelper.ArredondarBotao(btnEntrar, 25);
        }

        private void FormInicial_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            CorDeFundo.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja fechar a tela de login?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            MudarCorBotao((Button)sender);
           
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            MudarCorBotao((Button)sender);
           
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!(btnPaciente.BackColor == ColorTranslator.FromHtml("#d8a48f")) && !(btnMedico.BackColor == ColorTranslator.FromHtml("#d8a48f"))) 
            {
                Mensagem_do_sistema mensagem_Do_Sistema = new Mensagem_do_sistema();
                mensagem_Do_Sistema.MensagemError("Selecione uma das opções acima!");
                return;
            }

            if (btnPaciente.BackColor == ColorTranslator.FromHtml("#d8a48f")) 
            {
                FormularioLogin formularioLogin = new FormularioLogin();
                formularioLogin.ShowDialog();
            }
            if (btnMedico.BackColor == ColorTranslator.FromHtml("#d8a48f"))
            {
                FormularioLoginMedico formularioLoginMedico = new FormularioLoginMedico();
                formularioLoginMedico.ShowDialog();
            }

        }
    }
}
