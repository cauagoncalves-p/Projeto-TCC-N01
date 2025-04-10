using Avalia__.AureaDataSetTableAdapters;
using Avalia__.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalia__
{
    public partial class FormularioCadastro : Form
    {
        private void AtualizarBanco() 
        {
            tbUsuarioTableAdapter tbUsuarioTableAdapter = new tbUsuarioTableAdapter();

            // Cria um DataTable e preenche com os dados do banco
            AureaDataSet.tbUsuarioDataTable tabelaUsuarios = tbUsuarioTableAdapter.GetData();

            // Agora você pode usar LINQ com os dados
            var usuarios = from linha in tabelaUsuarios select linha;


            // Exemplo: mostrar no console todos os nomes
            foreach (var usuario in usuarios)
            {
                Console.WriteLine(usuario);
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
            DateTime dataCadastro = DateTime.Now;
            novosdados.Insert(nome, sobrenome, dataNascimento, cpf, sexo, telefone, identidadeGenero, endereco, email, cidade, Estado, dataCadastro);
            AtualizarBanco();

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
                Mensagem_do_sistema mensagem_ = new Mensagem_do_sistema();
                mensagem_.MensagemInformation("Necessário ter 18 anos para se cadastrar!");
                return false;
            }

            return true;
        }
        private void MudarFonte() 
        {
            dtpDataNascimento.Font = new Font("Segoe UI", 12); // Aumenta a fonte → aumenta a altura
            mktTelefone.Font = new Font("Segoe UI", 12); // Aumenta a fonte → aumenta a altura
            cbxGenero.Font = new Font("Segoe UI", 12); // Aumenta a fonte → aumenta a altura
            cbxEstado.Font = new Font("Segoe UI", 14); // Aumenta a fonte → aumenta a altura
            lblAvaliaCadastro.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblCompletecadastro.Font = new Font("Inter", 15, FontStyle.Bold);
            lblCPF.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            mktCPF.Font = new Font("Segoe UI", 12);
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
        public FormularioCadastro()
        {
            InitializeComponent();
            MudarFonte();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelCadastro, btnSair, 25);
        }

        private void FormularioCadastro_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            CorDeFundo.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
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

            if (nomeVazio || sobrenomeVazio || cpfVazio || telefoneVazio ||
                enderecoVazio || cidadeVazio ||
                generoNaoSelecionado || generoComboNaoSelecionado || estadoNaoSelecionado)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Verifica a idade antes de continuar
            if (!VerificaIdade())
                return;

            EnviarDado();

            FormularioCadCPF formularioCadCPF = new FormularioCadCPF();
            formularioCadCPF.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja fechar a tela de cadastro?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
    }
}
