using Avalia__.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Avalia__
{
    public partial class FormularioEnvioDeEmailTrocarSenha : Form
    {
        private string emailUsuario;
        private string codigoGerado;
        Mensagem_do_sistema mensagem_Do_Sistema = new Mensagem_do_sistema();

        public FormularioEnvioDeEmailTrocarSenha(string email)
        {
            InitializeComponent();
            emailUsuario = email; // recebe e guarda o e-mail do usuário
            lblEmailInformado.Text = email;

            // Ex: já gera e envia o código automaticamente ao abrir a tela
            codigoGerado = GerarCodigoConfirmacao();
            EnviarEmail(emailUsuario, codigoGerado);


            txt1.KeyUp += TextBox_KeyUp;
            txt2.KeyUp += TextBox_KeyUp;
            txt3.KeyUp += TextBox_KeyUp;
            txt4.KeyUp += TextBox_KeyUp;
            txt5.KeyUp += TextBox_KeyUp;
            txt6.KeyUp += TextBox_KeyUp;
            MudarFonte();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelConfirmeEmail, btnSair, 25);
        }

        private void LimparCamposCodigo()
        {
            txt1.Clear(); txt2.Clear(); txt3.Clear();
            txt4.Clear(); txt5.Clear(); txt6.Clear();
            txt1.Focus();
        }

        private string GerarCodigoConfirmacao()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString(); // Exemplo: 675849
        }

        private bool EnviarEmail(string destino, string codigo)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("cauagoncalves2190@gmail.com");
                mail.To.Add(destino);
                mail.Subject = "Código de Confirmação";
                mail.Body = $"Seu código de verificação é: {codigo}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("cauagoncalves2190@gmail.com", "nduu tkmc ayoe joes");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar o e-mail: " + ex.Message);
                return false;
            }
        }
        private void MudarFonte()
        {
            lblAvalia.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblDescritivo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblDescritivo1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblEmailInformado.Font = new Font("Segoe UI", 10, FontStyle.Bold);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja fechar essa tela?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var currentTextBox = (System.Windows.Forms.TextBox)sender;

            // Só avança se tiver um caractere digitado
            if (currentTextBox.Text.Length == 1)
            {
                this.SelectNextControl(currentTextBox, true, true, true, true);
            }

            // Trata o Backspace (volta para o anterior se estiver vazio)
            if (e.KeyCode == Keys.Back && currentTextBox.Text.Length == 0)
            {
                this.SelectNextControl(currentTextBox, false, true, true, true);
            }
        }

        private void linkLblReenviarCodigo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimparCamposCodigo();
            codigoGerado = GerarCodigoConfirmacao();

            if (EnviarEmail(emailUsuario, codigoGerado))
            {
                mensagem_Do_Sistema.MensagemInformation("Código reenviado com sucesso!");
            }
            else
            {
                mensagem_Do_Sistema.MensagemError("Falha ao reenviar o código.");
            }
        }

        private void FormularioEnvioDeEmailTrocarSenha_KeyUp(object sender, KeyEventArgs e)
        {
            var currentTextBox = (System.Windows.Forms.TextBox)sender;

            // Só avança se tiver um caractere digitado
            if (currentTextBox.Text.Length == 1)
            {
                this.SelectNextControl(currentTextBox, true, true, true, true);
            }

            // Trata o Backspace (volta para o anterior se estiver vazio)
            if (e.KeyCode == Keys.Back && currentTextBox.Text.Length == 0)
            {
                this.SelectNextControl(currentTextBox, false, true, true, true);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            // Junta os textos dos 6 campos
            string codigoDigitado = txt1.Text + txt2.Text + txt3.Text + txt4.Text + txt5.Text + txt6.Text;

            // Verifica se todos os campos estão preenchidos
            if (codigoDigitado.Length != 6)
            {
                mensagem_Do_Sistema.MensagemAtencao("Por favor, preencha todos os 6 dígitos do código.");
                return;
            }

            // Compara com o código que foi enviado por e-mail
            if (codigoDigitado == codigoGerado)
            {
                mensagem_Do_Sistema.MensagemInformation("✅ Código confirmado com sucesso!");
                FormularioConfirmeTrocarSenha formularioLogin = new FormularioConfirmeTrocarSenha(emailUsuario);
                formularioLogin.ShowDialog();
            }
            else
            {
                mensagem_Do_Sistema.MensagemError("Código incorreto. Verifique e tente novamente.");
            }
        }
    }
}

