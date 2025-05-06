using Avalia__.AureaMaxDataSetTableAdapters;
using Avalia__.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
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
        Mensagem_do_sistema mensagem_Do_Sistema = new Mensagem_do_sistema();
        ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
        
       
        public FormularioLogin()
        {
            InitializeComponent();
            
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelLogin, btnSair, 25, Color.White);
            UIHelper.ArredondarBotao(btnEntrar, 25);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void lblLinkCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            FormularioCadastro formularioCadastro = new FormularioCadastro();
            formularioCadastro.ShowDialog();

            this.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }

        private void lblEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); 

            FormularioTrocarSenha formularioTrocarSenha = new FormularioTrocarSenha();
            formularioTrocarSenha.ShowDialog();

            this.Show(); 
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            tbUsuarioTableAdapter tbUsuarioTableAdapter = new tbUsuarioTableAdapter();
            string senhaDigitada = txtSenhaLogin.Text;
            string senhaCriptografada = configuracaoTelas.GerarHash(senhaDigitada);

            var usuario = tbUsuarioTableAdapter.GetData()
                .FirstOrDefault(u => u.Email == txtEmailLogin.Text && u.Senha == senhaCriptografada);

            if (usuario != null)
            {
                mensagem_Do_Sistema.MensagemInformation("Logado com sucesso");

                this.Hide(); 

                FormularioPaginaPaciente paciente = new FormularioPaginaPaciente(usuario.Id_usuario, usuario.Email);
                paciente.ShowDialog(); // Mostra a tela do paciente e espera ela ser fechada

                this.Show(); 
            }
            else
            {
                mensagem_Do_Sistema.MensagemError("E-mail ou Senha incorretos");
            }
        }

    }
}
