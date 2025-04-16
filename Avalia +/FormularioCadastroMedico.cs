using Avalia__.AureaMaxDataSetTableAdapters;
using Avalia__.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Avalia__
{
    public partial class FormularioCadastroMedico : Form
    {
        Mensagem_do_sistema mensagem_Do_Sistema = new Mensagem_do_sistema();
        ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
        private void AtualizarBanco()
        {
            tbInstituicaoTableAdapter tbInstituicaoTableAdapter = new tbInstituicaoTableAdapter();
            AureaMaxDataSet.tbInstituicaoDataTable tabelaInstituicao = tbInstituicaoTableAdapter.GetData();

            cbxInstituicao.DataSource = tabelaInstituicao;
            cbxInstituicao.DisplayMember = "NomeInstituicao";         // Campo que aparece no ComboBox
            cbxInstituicao.ValueMember = "IdInstituicao";  // Campo que você usa pra salvar no banco
        }

        private void EnviarDado()
        {
            tbMedicoTableAdapter novosdados = new tbMedicoTableAdapter();

            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            string email = txtEmail.Text;
            string cpf = mktCPF.Text;
            string crm = txtCRM.Text;
            DateTime dataNascimento = dtpDataNascimento.Value;
            string telefone = new string(mktTelefone.Text.Where(char.IsDigit).ToArray());
            string sexo = "";

            if (rdbMasculino.Checked)
                sexo = "M";
            else if (rdbFeminino.Checked)
                sexo = "F";
            else if (rdbOutro.Checked)
                sexo = "O";

            int idInstituicao = Convert.ToInt32(cbxInstituicao.SelectedValue);

            string especialidade = "";
            switch (cbxEspecialidade.SelectedIndex)
            {
                case 0: especialidade = "Clínico Geral"; break;
                case 1: especialidade = "Pediatria"; break;
                case 2: especialidade = "Ginecologia"; break;
                case 3: especialidade = "Obstetrícia"; break;
                case 4: especialidade = "Urologia"; break;
                case 5: especialidade = "Dermatologia"; break;
                case 6: especialidade = "Cardiologia"; break;
                case 7: especialidade = "Endocrinologia"; break;
                case 8: especialidade = "Ortopedia"; break;
                case 9: especialidade = "Neurologia"; break;
                case 10: especialidade = "Psiquiatria"; break;
                case 11: especialidade = "Oftalmologia"; break;
                case 12: especialidade = "Otorrinolaringologia"; break;
                case 13: especialidade = "Reumatologia"; break;
                case 14: especialidade = "Gastroenterologia"; break;
                case 15: especialidade = "Nefrologia"; break;
                case 16: especialidade = "Oncologia"; break;
                case 17: especialidade = "Nutrologia"; break;
                case 18: especialidade = "Medicina do Trabalho"; break;
                case 19: especialidade = "Medicina da Família"; break;
                default:
                    MessageBox.Show("Selecione uma especialidade válida.");
                    break;
            }

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

            novosdados.Insert(nome,sobrenome,crm,sexo,especialidade,cidade,Estado,endereco,telefone,cpf,idInstituicao,email,senhaCriptografada);
            AtualizarBanco();

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
        private void EmailValido()
        {
            string email = txtEmail.Text.Trim();

            Regex regexEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!regexEmail.IsMatch(email))
            {
                mensagem_Do_Sistema.MensagemError("Digite um e-mail válido, como exemplo@dominio.com");
                lblError.Text = "Formato de e-mail inválido.";
                lblError.ForeColor = Color.Red;
                txtEmail.Focus();
                return;
            }
        }
        private void MudarFonte()
        {
            dtpDataNascimento.Font = new Font("Segoe UI", 12); // Aumenta a fonte → aumenta a altura
            mktTelefone.Font = new Font("Segoe UI", 12); // Aumenta a fonte → aumenta a altura
            cbxGenero.Font = new Font("Segoe UI", 12); // Aumenta a fonte → aumenta a altura
            cbxEstado.Font = new Font("Segoe UI", 14); // Aumenta a fonte → aumenta a altura
            cbxEspecialidade.Font = new Font("Segoe UI", 14); // Aumenta a fonte → aumenta a altura
            cbxInstituicao.Font = new Font("Segoe UI", 14); // Aumenta a fonte → aumenta a altura
            lblAvaliaCadastro.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblCompletecadastro.Font = new Font("Inter", 15, FontStyle.Bold);
            lblCPF.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            mktCPF.Font = new Font("Segoe UI", 12);
            txtNome.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            txtSobrenome.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            txtEndereco.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            txtCidade.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            txtEmail.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            txtSenha.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            txtconfirmeSenha.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            txtCRM.Font = new Font("Segoe UI", 14, FontStyle.Regular);

            Font fontePadrao = new Font("Inter", 13);

            foreach (Control ctrl in panelCadastro.Controls)
            {
                if (ctrl is Label)
                {
                    if (ctrl == lblCompletecadastro && ctrl == lblAvaliaCadastro)
                    {
                        continue;
                    }
                    ctrl.Font = fontePadrao;
                }
            }
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
                mensagem_Do_Sistema.MensagemInformation("O profissional precisa ter no mínimo 18 anos!");
                return false;
            }

            return true;
        }

        private bool CpfJaExiste(string cpf)
        {
            tbMedicoTableAdapter medicoTableAdapter= new tbMedicoTableAdapter();
            var usuarios = medicoTableAdapter.GetData()
                .Where(m => m.CPF == cpf)
                .ToList();

            return usuarios.Any();
        }

        private bool EmailJaExiste(string email)
        {
            tbMedicoTableAdapter medicoTableAdapter = new tbMedicoTableAdapter();
            var usuarios = medicoTableAdapter.GetData()
                .Where(m => m.Email == email)
                .ToList();

            return usuarios.Any();
        }

        public FormularioCadastroMedico()
        {
            InitializeComponent();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelCadastro, btnSair, 25, Color.White );
            txtSenha.TextChanged += (s, e) => AvaliarForcaSenha(txtSenha.Text);
            MudarFonte();
            AtualizarBanco();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }

        private void FormularioCadastroMedico_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void btnFinalizarCadastro_Click(object sender, EventArgs e)
        {
            //Verifica campos vazios 
            bool nomeVazio = string.IsNullOrEmpty(txtNome.Text);
            bool sobrenomeVazio = string.IsNullOrEmpty(txtSobrenome.Text);
            bool crm = string.IsNullOrEmpty(txtCRM.Text);
            bool cpfVazio = !mktCPF.MaskFull;
            bool telefoneVazio = !mktTelefone.MaskFull;
            bool enderecoVazio = string.IsNullOrEmpty(txtEndereco.Text);
            bool cidadeVazio = string.IsNullOrEmpty(txtCidade.Text);
            bool estadoNaoSelecionado = cbxEstado.SelectedIndex == -1;
            bool generoNaoSelecionado = !rdbMasculino.Checked && !rdbFeminino.Checked && !rdbOutro.Checked;
            bool generoComboNaoSelecionado = cbxGenero.SelectedIndex == -1;
            bool instituicao = cbxInstituicao.SelectedIndex == -1;
            bool especialidade = cbxEspecialidade.SelectedIndex == -1;
            bool senha = string.IsNullOrEmpty(txtSenha.Text);
            bool confirmeSenha = string.IsNullOrEmpty(txtconfirmeSenha.Text);

            if (nomeVazio || sobrenomeVazio || cpfVazio || telefoneVazio ||
                enderecoVazio || cidadeVazio ||
                generoNaoSelecionado || generoComboNaoSelecionado || estadoNaoSelecionado || senha || confirmeSenha || especialidade || instituicao)
            {
                mensagem_Do_Sistema.MensagemError("Preencha todos os campos obrigatórios.");

                return;
            }

            string cpf = mktCPF.Text;
            string email = txtEmail.Text.Trim();

            VerificaIdade();

            if (EmailJaExiste(email))
            {
                mensagem_Do_Sistema.MensagemError("Este e-mail já está em uso.");
                return;
            }

            if (CpfJaExiste(cpf))
            {
                mensagem_Do_Sistema.MensagemError("Este CPF já está cadastrado.");
                return;
            }

            // Verifica se o email informado é valido
            EmailValido();
            EnviarDado();
            mensagem_Do_Sistema.MensagemInformation("Cadastro realizado com sucesso!\nConfirme seu email na próxima tela!");
            FormularioCadCPF formularioCadCPF = new FormularioCadCPF();
            formularioCadCPF.ShowDialog();

        }

        private void cbxInstituicao_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxEspecialidade.Items == null) return;


        }

        private void txtCRM_TextChanged(object sender, EventArgs e)
        {
            // Evita loop
            txtCRM.TextChanged -= txtCRM_TextChanged;

            // Salva a posição do cursor antes de alterar
            int cursorPos = txtCRM.SelectionStart;

            // Remove qualquer caractere que não seja número ou letra
            string textoOriginal = txtCRM.Text;
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
            if (txtCRM.Text != crmFormatado)
            {
                int diff = crmFormatado.Length - textoOriginal.Length;

                txtCRM.Text = crmFormatado;

                // Reposiciona o cursor corretamente após inserção dos caracteres extras
                txtCRM.SelectionStart = Math.Max(0, Math.Min(crmFormatado.Length, cursorPos + diff));
            }

            // Reativa o evento
            txtCRM.TextChanged += txtCRM_TextChanged;
        }
    }
}
