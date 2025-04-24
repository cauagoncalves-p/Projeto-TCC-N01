using Avalia__.AureaMaxDataSetTableAdapters;
using Avalia__.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Avalia__.RadiusButton;

namespace Avalia__
{
    public partial class FormularioLoginMedico : Form
    {
        Mensagem_do_sistema mensagem_Do_Sistema = new Mensagem_do_sistema();
        ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();

        private void MudarFonte()
        {
            lblAvalia.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblLogin.Font = new Font("Inter", 15, FontStyle.Bold);
            lblcrm.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblSenha.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblEsqueceuSenha.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            btnEntrar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblLinkCriarConta.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblCriarConta.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            txtCRMLogin.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtSenhaLogin.Font = new Font("Segoe UI", 14, FontStyle.Bold);
        }

        public FormularioLoginMedico()
        {
            InitializeComponent();
            MudarFonte();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelLogin, btnSair, 25, Color.White);
            UIHelper.ArredondarBotao(btnEntrar, 25);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }

        private void FormularioLoginMedico_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            tbMedicoTableAdapter tbMedicoTableAdapter = new tbMedicoTableAdapter();
            string senhaDigitada = txtSenhaLogin.Text;
            string senhaCriptografada = configuracaoTelas.GerarHash(senhaDigitada);

            var usuario = tbMedicoTableAdapter.GetData()
                .FirstOrDefault(u => u.CRM == txtCRMLogin.Text && u.Senha == senhaCriptografada);

            if (usuario != null)
            {
                mensagem_Do_Sistema.MensagemInformation("Logado com sucesso");
            }
            else
            {
                mensagem_Do_Sistema.MensagemError("E-mail ou Senha incorretos");
            }
        }

        private void lblEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormularioTrocarSenha formularioTrocarSenha = new FormularioTrocarSenha();
            formularioTrocarSenha.ShowDialog();
        }

        private void txtCRMLogin_TextChanged(object sender, EventArgs e)
        {
            // Evita loop
            txtCRMLogin.TextChanged -= txtCRMLogin_TextChanged;

            // Salva a posição do cursor antes de alterar
            int cursorPos = txtCRMLogin.SelectionStart;

            // Remove qualquer caractere que não seja número ou letra
            string textoOriginal = txtCRMLogin.Text;
            string textoLimpo = new string(textoOriginal.Where(char.IsLetterOrDigit).ToArray());

            string crmFormatado = textoLimpo;

            if (textoLimpo.Length > 3 && textoLimpo.Length <= 9)
            {
                crmFormatado = textoLimpo.Insert(3, "-");
            }
            else if (textoLimpo.Length > 9)
            {
                crmFormatado = textoLimpo.Insert(3, "-").Insert(10, "/");
            }

            // Só atualiza o texto se mudou
            if (txtCRMLogin.Text != crmFormatado)
            {
                int diff = crmFormatado.Length - textoOriginal.Length;

                txtCRMLogin.Text = crmFormatado;

                // Reposiciona o cursor corretamente após inserção dos caracteres extras
                txtCRMLogin.SelectionStart = Math.Max(0, Math.Min(crmFormatado.Length, cursorPos + diff));
            }

            // Reativa o evento
            txtCRMLogin.TextChanged += txtCRMLogin_TextChanged;
        }

        private void lblLinkCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormularioCadastroMedico formularioCadastroMedico = new FormularioCadastroMedico();
            formularioCadastroMedico.ShowDialog();  
        }
    }
}
