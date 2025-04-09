using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Avalia__
{
    public partial class FormularioDeEnvioCodigo : Form
    {
        private void MudarFonte()
        {
            lblAvalia.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblDescritivo.Font = new Font("Segoe UI", 10, FontStyle.Bold); 
            lblDescritivo1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblEmailInformado.Font = new Font("Segoe UI", 10, FontStyle.Bold);
          
        }

        public FormularioDeEnvioCodigo()
        {
            InitializeComponent();

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
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja fechar essa tela?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
