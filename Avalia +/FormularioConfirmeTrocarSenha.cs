using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Avalia__.RadiusButton;

namespace Avalia__
{
    public partial class FormularioConfirmeTrocarSenha : Form
    {
        private void MudarFonte()
        {
            lblAvalia.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblNovaSenha.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnConfirmar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblConfirmeNovaSenha.Font = new Font("Inter", 10, FontStyle.Bold);
            txtNovaSenha.Font = new Font("Segoe UI", 13, FontStyle.Regular);
            txtConfirmeSenha.Font = new Font("Segoe UI", 13, FontStyle.Regular);
        }

        private void AvaliarForcaSenha(string senha)
        {
            int forca = 0;

            // Tamanho
            if (senha.Length >= 10)
                forca++;

            // Contém letra
            if (Regex.IsMatch(senha, @"[a-zA-Z]"))
                forca++;

            // Contém número
            if (Regex.IsMatch(senha, @"\d"))
                forca++;

            // Contém caractere especial
            if (Regex.IsMatch(senha, @"[\W_]"))
                forca++;

            // Atualiza o label conforme a força
            switch (forca)
            {
                case 0:
                case 1:
                    lblError.Text = "Senha fraca";
                    lblError.ForeColor = Color.Red;
                    break;
                case 2:
                case 3:
                    lblError.Text = "Senha média";
                    lblError.ForeColor = Color.DarkOrange;
                    break;
                case 4:
                    lblError.Text = "Senha forte";
                    lblError.ForeColor = Color.Green;
                    break;
            }
        }

        public FormularioConfirmeTrocarSenha()
        {
            InitializeComponent();
            MudarFonte();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelConfirmeSenha, btnSair, 25);
            UIHelper.ArredondarBotao(btnConfirmar, 25);
            txtNovaSenha.TextChanged += (s, e) => AvaliarForcaSenha(txtNovaSenha.Text);
        }

        private void FormularioConfirmeTrocarSenha_Paint(object sender, PaintEventArgs e)
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
    }
}
