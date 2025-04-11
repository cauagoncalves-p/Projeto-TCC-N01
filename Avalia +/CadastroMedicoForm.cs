using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalia__
{
    public partial class CadastroMedicoForm : Form
    {
        // Controles
        private TextBox txtNome;
        private TextBox txtCRM;
        private ComboBox cmbEspecialidade;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private CheckBox chkAtivo;
        private Button btnSalvar;
        private Button btnCancelar;

        public CadastroMedicoForm()
        {
            InitializeComponents();
            this.Text = "driconsulta - Cadastro de Médico";
            this.Size = new Size(600, 500);
            this.BackColor = Color.FromArgb(253, 246, 240);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void InitializeComponents()
        {
            // Título
            var lblTitulo = new Label();
            lblTitulo.Text = "Cadastro de Médico";
            lblTitulo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(139, 94, 60);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(20, 20);
            this.Controls.Add(lblTitulo);

            int yPos = 60;

            // Campo Nome
            AddLabel("Nome Completo:", 20, yPos);
            txtNome = AddTextBox(20, yPos + 25, 540);
            yPos += 55;

            // Campo CRM
            AddLabel("CRM:", 20, yPos);
            txtCRM = AddTextBox(20, yPos + 25, 200);
            yPos += 55;

            // Campo Especialidade
            AddLabel("Especialidade:", 20, yPos);
            cmbEspecialidade = new ComboBox();
            cmbEspecialidade.Location = new Point(20, yPos + 25);
            cmbEspecialidade.Size = new Size(300, 25);
            cmbEspecialidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidade.Items.AddRange(new object[] {
            "Ginecologia",
            "Obstetrícia",
            "Mastologia",
            "Clínica Geral",
            "Endocrinologia",
            "Cardiologia",
            "Dermatologia",
            "Outra"
        });
            this.Controls.Add(cmbEspecialidade);
            yPos += 55;

            // Campo Email
            AddLabel("E-mail:", 20, yPos);
            txtEmail = AddTextBox(20, yPos + 25, 540);
            yPos += 55;

            // Campo Telefone
            AddLabel("Telefone:", 20, yPos);
            txtTelefone = AddTextBox(20, yPos + 25, 200);
            txtTelefone.KeyPress += Telefone_KeyPress;
            yPos += 55;

            // Campo Senha
            AddLabel("Senha:", 20, yPos);
            txtSenha = AddTextBox(20, yPos + 25, 250);
            txtSenha.PasswordChar = '•';
            yPos += 55;

            // Campo Confirmar Senha
            AddLabel("Confirmar Senha:", 20, yPos);
            txtConfirmarSenha = AddTextBox(20, yPos + 25, 250);
            txtConfirmarSenha.PasswordChar = '•';
            yPos += 55;

            // Checkbox Ativo
            chkAtivo = new CheckBox();
            chkAtivo.Text = "Médico ativo no sistema";
            chkAtivo.Checked = true;
            chkAtivo.Location = new Point(20, yPos);
            chkAtivo.AutoSize = true;
            this.Controls.Add(chkAtivo);
            yPos += 40;

            // Botões
            btnSalvar = new Button();
            btnSalvar.Text = "Salvar Cadastro";
            btnSalvar.Size = new Size(180, 40);
            btnSalvar.Location = new Point(100, yPos);
            btnSalvar.BackColor = Color.FromArgb(216, 164, 143);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnSalvar.Click += BtnSalvar_Click;
            this.Controls.Add(btnSalvar);

            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Size = new Size(180, 40);
            btnCancelar.Location = new Point(300, yPos);
            btnCancelar.BackColor = Color.FromArgb(240, 240, 240);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10);
            btnCancelar.Click += (s, e) => this.Close();
            this.Controls.Add(btnCancelar);
        }

        private void AddLabel(string text, int x, int y)
        {
            var label = new Label();
            label.Text = text;
            label.Location = new Point(x, y);
            label.AutoSize = true;
            this.Controls.Add(label);
        }

        private TextBox AddTextBox(int x, int y, int width)
        {
            var textBox = new TextBox();
            textBox.Location = new Point(x, y);
            textBox.Size = new Size(width, 25);
            this.Controls.Add(textBox);
            return textBox;
        }

        private void Telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e formata automaticamente
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            var txt = (TextBox)sender;
            if (txt.Text.Length == 0 && e.KeyChar != '(')
            {
                txt.Text = "(";
                txt.SelectionStart = txt.Text.Length;
            }
            else if (txt.Text.Length == 3 && !txt.Text.Contains(")"))
            {
                txt.Text += ") ";
                txt.SelectionStart = txt.Text.Length;
            }
            else if (txt.Text.Length == 9 && txt.Text.IndexOf('-') == -1)
            {
                txt.Text += "-";
                txt.SelectionStart = txt.Text.Length;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Validações
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor, informe o nome completo do médico.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCRM.Text))
            {
                MessageBox.Show("Por favor, informe o CRM do médico.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCRM.Focus();
                return;
            }

            if (cmbEspecialidade.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione a especialidade do médico.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEspecialidade.Focus();
                return;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Por favor, informe um e-mail válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("A senha deve ter pelo menos 8 caracteres.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }

            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, digite novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarSenha.Focus();
                return;
            }

            // Aqui você implementaria a lógica de cadastro no banco de dados
            bool sucesso = CadastrarMedicoNoBanco();

            if (sucesso)
            {
                MessageBox.Show("Médico cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o médico. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private bool CadastrarMedicoNoBanco()
        {
            // Exemplo - implemente sua lógica real de cadastro
            try
            {
                // Simulação de cadastro
                var medico = new
                {
                    Nome = txtNome.Text,
                    CRM = txtCRM.Text,
                    Especialidade = cmbEspecialidade.SelectedItem.ToString(),
                    Email = txtEmail.Text,
                    Telefone = txtTelefone.Text,
                    Senha = txtSenha.Text, // Na prática, armazene um hash da senha
                    Ativo = chkAtivo.Checked
                };

                // Aqui você inseriria no banco de dados
                // database.Medicos.Add(medico);
                // database.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
