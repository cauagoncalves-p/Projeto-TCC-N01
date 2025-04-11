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
        private void MudarCorBotao(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            // Reseta a cor de todos os botões (menos os que você quer ignorar)
            foreach (Control botao in this.Controls)
            {
                if (botao is Button btn)
                {
                    if (btn == btnSair || btn == btnEntrar)
                        continue;

                    btn.BackColor = SystemColors.Control; // ou a cor padrão: ColorTranslator.FromHtml("#F0F0F0")
                    btn.ForeColor = Color.Black;
                }
            }

            // Define a nova cor para o botão clicado (usando hexadecimal)
            botaoClicado.BackColor = ColorTranslator.FromHtml("#d8a48f"); // Dodger Blue
            botaoClicado.ForeColor = Color.White;
        }
        private void MudarFonte()
        {
            lblAvalia.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblentrar.Font = new Font("Inter", 16, FontStyle.Bold);  
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
    }
}
