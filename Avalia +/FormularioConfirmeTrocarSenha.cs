using Avalia__.AureaDataSetTableAdapters;
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
        private string GerarHash(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
        private bool VerificarSenhaAntiga(string novaSenha, string email)
        {
            string novaSenhaCriptografada = GerarHash(novaSenha); // usa o mesmo método que usou no cadastro

            tbUsuarioTableAdapter tbUsuarioTableAdapter = new tbUsuarioTableAdapter();
            var usuario = tbUsuarioTableAdapter.GetData()
                .FirstOrDefault(u => u.Email == email);

            if (usuario != null)
            {
                return usuario.Senha == novaSenhaCriptografada;
            }

            return false;
        }

        private string emailUsuario;
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

        public FormularioConfirmeTrocarSenha(string email)
        {
            InitializeComponent();
            MudarFonte();
            emailUsuario = email;

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

            if (VerificarSenhaAntiga(senha, emailUsuario))
            {
                MessageBox.Show("A nova senha deve ser diferente da senha atual.");
                return;
            }
            string novaSenhaCriptografada = GerarHash(novaSenha);

            // Atualiza a senha no banco
            tbUsuarioTableAdapter tbUsuarioTableAdapter = new tbUsuarioTableAdapter();
            tbUsuarioTableAdapter.AtualizarSenhaPorEmail(novaSenhaCriptografada, emailUsuario);

            mensagem_Do_Sistema.MensagemInformation("Senha atualizada com sucesso! Você já pode fazer login.");
            this.Close();
        }
    }
}
