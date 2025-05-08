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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalia__
{
    public partial class FormularioCadastro : Form
    {
        Mensagem_do_sistema mensagem_ = new Mensagem_do_sistema();
        ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
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
        private void EmailValido() 
        {
            string email = txtEmail.Text.Trim();

            Regex regexEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!regexEmail.IsMatch(email))
            {
                mensagem_.MensagemError("Digite um e-mail válido, como exemplo@dominio.com");
                lblError.Text = "Formato de e-mail inválido.";
                lblError.ForeColor = Color.Red;
                txtEmail.Focus();
                return;
            }
        }
        private void EnviarDado() 
        {
            tbUsuarioTableAdapter novosdados = new tbUsuarioTableAdapter();

            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            string email = txtEmail.Text;
            string cpf = mktCPF.Text;
            DateTime dataNascimento = dtpDataNascimento.Value;
            string telefone = new string(mktTelefone.Text.Where(char.IsDigit).ToArray());
            string sexo = "";

            if (rdbMasculino.Checked)
                sexo = "M";
            else if (rdbFeminino.Checked)
                sexo = "F";
            else if (rdbOutro.Checked)
                sexo = "O";

            string identidadeGenero = "";

            switch (cbxGenero.SelectedIndex)
            {
                case 0: identidadeGenero = "Cisgênero"; break;
                case 1: identidadeGenero = "Transgênero"; break;
                case 2: identidadeGenero = "Não-binário"; break;
                case 3: identidadeGenero = "Gênero fluido"; break;
                case 4: identidadeGenero = "Outro"; break;
                case 5: identidadeGenero = "Prefiro não dizer"; break;
                default: identidadeGenero = ""; break; // Caso nada esteja selecionado
            }

            string endereco = txtEndereco.Text;
            string cidade = txtCidade.Text;

            string Estado = "";

            switch (cbxEstado.SelectedIndex)
            {
                case 0: Estado = "AC"; break; // Acre
                case 1: Estado = "AL"; break; // Alagoas
                case 2: Estado = "AP"; break; // Amapá
                case 3: Estado = "AM"; break; // Amazonas
                case 4: Estado = "BA"; break; // Bahia
                case 5: Estado = "CE"; break; // Ceará
                case 6: Estado = "DF"; break; // Distrito Federal
                case 7: Estado = "ES"; break; // Espírito Santo
                case 8: Estado = "GO"; break; // Goiás
                case 9: Estado = "MA"; break; // Maranhão
                case 10: Estado = "MT"; break; // Mato Grosso
                case 11: Estado = "MS"; break; // Mato Grosso do Sul
                case 12: Estado = "MG"; break; // Minas Gerais
                case 13: Estado = "PA"; break; // Pará
                case 14: Estado = "PB"; break; // Paraíba
                case 15: Estado = "PR"; break; // Paraná
                case 16: Estado = "PE"; break; // Pernambuco
                case 17: Estado = "PI"; break; // Piauí
                case 18: Estado = "RJ"; break; // Rio de Janeiro
                case 19: Estado = "RN"; break; // Rio Grande do Norte
                case 20: Estado = "RS"; break; // Rio Grande do Sul
                case 21: Estado = "RO"; break; // Rondônia
                case 22: Estado = "RR"; break; // Roraima
                case 23: Estado = "SC"; break; // Santa Catarina
                case 24: Estado = "SP"; break; // São Paulo
                case 25: Estado = "SE"; break; // Sergipe
                case 26: Estado = "TO"; break; // Tocantins
                default: Estado = ""; break;  // Nenhum selecionado
            }

            string senhaCriptografada = configuracaoTelas.GerarHash(txtSenha.Text);

            DateTime dataCadastro = DateTime.Now;

            novosdados.Insert(nome, sobrenome, dataNascimento, cpf, sexo, telefone, identidadeGenero, endereco, email, cidade, Estado, dataCadastro, senhaCriptografada);
        }

        private bool VerificaIdade()
        {
            DateTime dataNascimento = dtpDataNascimento.Value;
            DateTime hoje = DateTime.Today;

            int idade = hoje.Year - dataNascimento.Year;
            if (dataNascimento > hoje.AddYears(-idade))
            {
                idade--;
            }

            if (idade < 18)
            {
                mensagem_.MensagemInformation("Necessário ter 18 anos para se cadastrar!");
                return false;
            }
            return true;
        }

        private void MudarFonte() 
        {
            dtpDataNascimento.Font = new Font("Arial", 12); // Aumenta a fonte → aumenta a altura
            mktTelefone.Font = new Font("Arial", 12); // Aumenta a fonte → aumenta a altura
            cbxGenero.Font = new Font("Arial", 12); // Aumenta a fonte → aumenta a altura
            cbxEstado.Font = new Font("Arial", 14); // Aumenta a fonte → aumenta a altura
            mktCPF.Font = new Font("Arial", 12);

        }

        private bool CpfJaExiste(string cpf)
        {
            tbUsuarioTableAdapter tbUsuarioTableAdapter = new tbUsuarioTableAdapter();
            var usuarios = tbUsuarioTableAdapter.GetData()
                .Where(u => u.CPF == cpf)
                .ToList();

            return usuarios.Any();
        }
        private bool EmailJaExiste(string email)
        {
            tbUsuarioTableAdapter tbUsuarioTableAdapter = new tbUsuarioTableAdapter();
            var usuarios = tbUsuarioTableAdapter.GetData()
                             .Where(u => u.Email == email)
                             .ToList();

            return usuarios.Any();
        }
        public FormularioCadastro()
        {
            InitializeComponent();
            txtSenha.TextChanged += (s, e) => AvaliarForcaSenha(txtSenha.Text);
            MudarFonte();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelCadastro, btnSair, 25, Color.White);
        }

        private void FormularioCadastro_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }
        private void btnFinalizarCadastro_Click(object sender, EventArgs e)
        {
            //Verifica campos vazios 
            bool nomeVazio = string.IsNullOrEmpty(txtNome.Text);
            bool sobrenomeVazio = string.IsNullOrEmpty(txtSobrenome.Text);
            bool cpfVazio = !mktCPF.MaskFull;
            bool telefoneVazio = !mktTelefone.MaskFull;
            bool enderecoVazio = string.IsNullOrEmpty(txtEndereco.Text);
            bool cidadeVazio = string.IsNullOrEmpty(txtCidade.Text);
            bool estadoNaoSelecionado = cbxEstado.SelectedIndex == -1;
            bool generoNaoSelecionado = !rdbMasculino.Checked && !rdbFeminino.Checked && !rdbOutro.Checked;
            bool generoComboNaoSelecionado = cbxGenero.SelectedIndex == -1;
            bool senha = string.IsNullOrEmpty(txtSenha.Text);
            bool confirmeSenha = string.IsNullOrEmpty(txtconfirmeSenha.Text);

            if (nomeVazio || sobrenomeVazio || cpfVazio || telefoneVazio ||
                enderecoVazio || cidadeVazio ||
                generoNaoSelecionado || generoComboNaoSelecionado || estadoNaoSelecionado || senha || confirmeSenha)
            {
                mensagem_.MensagemError("Preencha todos os campos obrigatórios.");
             
                return;
            }

            string cpf = mktCPF.Text;
            string email = txtEmail.Text.Trim();

            if (EmailJaExiste(email))
            {
                mensagem_.MensagemError("Este e-mail já está em uso.");
                return;
            }

            if (CpfJaExiste(cpf))
            {
                mensagem_.MensagemError("Este CPF já está cadastrado.");
                return;
            }

            // Verifica se o email informado é valido
            EmailValido();

            Regex regexSenhaForte = new Regex(@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[\W_]).{10,}$");

            if (!regexSenhaForte.IsMatch(txtSenha.Text))
            {
                mensagem_.MensagemError("A senha deve conter no mínimo 10 caracteres e incluir letras, números e caracteres especiais.");
                lblError.Text = "Ex: SenhaForte@2025";
                lblError.ForeColor = Color.Red;
                txtSenha.Focus();
                return;
            }

            if (txtSenha.Text == "SenhaForte@2025") 
            {
                mensagem_.MensagemError("Não use a senha de exemplo.");
                return;
            }

            if (txtSenha.Text != txtconfirmeSenha.Text) 
            {
                lblError.Text = "Senhas não são iguais";
                lblError.ForeColor = Color.Red;
                return;
            }

            // Verifica a idade antes de continuar
            if (!VerificaIdade())
                return;

            EnviarDado();

            mensagem_.MensagemInformation("Cadastro realizado com sucesso!\nConfirme seu email na próxima tela!");
            this.Hide();
            FormularioCadCPF formularioCadCPF = new FormularioCadCPF();
            formularioCadCPF.ShowDialog();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }

        private void panelCadastro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
