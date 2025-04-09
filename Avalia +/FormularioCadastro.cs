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
