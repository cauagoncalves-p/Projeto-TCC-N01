using Avalia__.AureaMaxDataSetTableAdapters;
using Avalia__.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Avalia__.RadiusButton;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Avalia__
{
    public partial class FormularioConfirmeTrocarSenha : Form
    {
        Mensagem_do_sistema mensagem_Do_Sistema = new Mensagem_do_sistema();
        ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
        private bool VerificarSenhaAntiga(string novaSenha)
        {
            string novaSenhaCriptografada = configuracaoTelas.GerarHash(novaSenha);

            if (!string.IsNullOrEmpty(emailUsuario))
            {
                var usuario = new tbUsuarioTableAdapter().GetData()
                                 .FirstOrDefault(u => u.Email == emailUsuario);
                return usuario != null && usuario.Senha == novaSenhaCriptografada;
            }
            else if (!string.IsNullOrEmpty(emailMedico))
            {
                var medico = new tbMedicoTableAdapter().GetData()
                                .FirstOrDefault(m => m.Email == emailMedico);
                return medico != null && medico.Senha == novaSenhaCriptografada;
            }

            return false;
        }

        private string emailUsuario;
        private string emailMedico;
        private void MudarFonte()
        {
            lblAvalia.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblNovaSenha.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnConfirmar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblConfirmeNovaSenha.Font = new Font("Inter", 10, FontStyle.Bold);
            txtNovaSenha.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            txtConfirmeSenha.Font = new Font("Segoe UI", 14, FontStyle.Bold);
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

        public FormularioConfirmeTrocarSenha(string email, string emailM)
        {
            InitializeComponent();
            MudarFonte();
            emailUsuario = email;
            emailMedico = emailM;

            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelConfirmeSenha, btnSair, 25, Color.White);
            UIHelper.ArredondarBotao(btnConfirmar, 25);
            txtNovaSenha.TextChanged += (s, e) => AvaliarForcaSenha(txtNovaSenha.Text);
        }

        private void FormularioConfirmeTrocarSenha_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }
       
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNovaSenha.Text) || string.IsNullOrEmpty(txtConfirmeSenha.Text)) 
            {
                mensagem_Do_Sistema.MensagemError("Preencha todos os campos!");
                return;
            }

            if (txtConfirmeSenha.Text != txtNovaSenha.Text) 
            {
                mensagem_Do_Sistema.MensagemError("As senhas não são iguais\nTente denovo!");
                return;
            }

            string novaSenha = txtNovaSenha.Text.Trim();

            // Validação da nova senha (ex: pelo Regex que fizemos antes)
            Regex regexSenhaForte = new Regex(@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[\W_]).{10,}$");
            if (!regexSenhaForte.IsMatch(novaSenha))
            {
                MessageBox.Show("A nova senha deve ter no mínimo 10 caracteres e conter letras, números e caracteres especiais.");
                return;
            }

            string senha = txtNovaSenha.Text;

            // Verifica se a nova senha é igual à atual
            if (VerificarSenhaAntiga(senha))
            {
                MessageBox.Show("A nova senha deve ser diferente da senha atual.");
                return;
            }

            // Criptografa a nova senha
            string novaSenhaCriptografada = configuracaoTelas.GerarHash(senha);

            // Atualiza a senha no banco dependendo do tipo de usuário
            if (!string.IsNullOrEmpty(emailUsuario))
            {
                //tbUsuarioTableAdapter usuarioAdapter = new tbUsuarioTableAdapter();
                //usuarioAdapter.AtualizarSenhaPorEmail(novaSenhaCriptografada, emailUsuario);
            }
            else if (!string.IsNullOrEmpty(emailMedico))
            {
                //tbMedicoTableAdapter medicoAdapter = new tbMedicoTableAdapter();
                //medicoAdapter.AtualizarSenhaPorEmail(novaSenhaCriptografada, emailMedico);
            }

            MessageBox.Show("Senha atualizada com sucesso!");
            this.Close(); // Fecha a tela após atualizar, se desejar
        }
    }
}
