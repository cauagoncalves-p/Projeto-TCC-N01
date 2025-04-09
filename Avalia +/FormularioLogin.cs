using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Avalia__.RadiusButton;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Avalia__
{
    public partial class FormularioLogin : Form
    {

        private void MudarFonte() 
        {
            lblAvalia.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblLogin.Font = new Font("Inter", 15, FontStyle.Bold);
            lblEmail.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblSenha.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblEsqueceuSenha.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            btnEntrar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblLinkCriarConta.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblCriarConta.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }
       
        public FormularioLogin()
        {
            InitializeComponent();
            MudarFonte();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelLogin, btnSair, 25);
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            CorDeFundo.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void FormularioLogin_Load(object sender, EventArgs e)
        {
            UIHelper.ArredondarBotao(btnEntrar, 25);
        }

        private void lblLinkCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormularioCadastro formularioCadastro = new FormularioCadastro();
            formularioCadastro.ShowDialog();
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
