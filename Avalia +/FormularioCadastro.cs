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
        public FormularioCadastro()
        {
            InitializeComponent();

            this.Paint += new PaintEventHandler(FormularioCadastro_Paint);
            this.Resize += (s, e) => this.Invalidate(); // Redesenha ao redimensionar

            RadiusButton arredondarBordas = new RadiusButton();
            arredondarBordas.ArredondarBordas(panelCadastro, 25);
            panelCadastro.BackColor = Color.White; // Cor do painel
        }

        private void FormularioCadastro_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            CorDeFundo.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormularioCadastro_Load(object sender, EventArgs e)
        {
           dtpDataNascimento.Font = new Font("Segoe UI", 12); // Aumenta a fonte → aumenta a altura
           mktTelefone.Font = new Font("Segoe UI", 12); // Aumenta a fonte → aumenta a altura
           cbxGenero.Font = new Font("Segoe UI", 12); // Aumenta a fonte → aumenta a altura
           cbxEstado.Font = new Font("Segoe UI", 14); // Aumenta a fonte → aumenta a altura
           lblAvalia.Font = new Font("Segoe UI", 16, FontStyle.Bold); 
           lblCompletecadastro.Font = new Font("Inter", 15, FontStyle.Bold);
           Font fontePadrao = new Font("Inter", 13);

            foreach (Control ctrl in panelCadastro.Controls)
            {
                if (ctrl is Label)
                {
                    if (ctrl == lblCompletecadastro && ctrl == lblAvalia)
                        {
                            continue;
                        }
                    ctrl.Font = fontePadrao;
                }
            }




        }

       
    }
}
