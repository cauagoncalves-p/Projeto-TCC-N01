using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Avalia__.RadiusButton;

namespace Avalia__
{
    public partial class FormularioCadCPF: Form
    {
        private void MudarFonte()
        {
            lblAvalia.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblVerifica.Font = new Font("Inter", 15, FontStyle.Bold);
            lblCPF.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblemail.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnContinuar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblLinkFazerLogin.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblVerificaCPF.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        public FormularioCadCPF()
        {
            InitializeComponent();
            MudarFonte();

            this.Paint += new PaintEventHandler(FormularioCadCPF_Load);
            this.Resize += (s, e) => this.Invalidate(); // Redesenha ao redimensionar

            RadiusButton arredondarBordas = new RadiusButton();
            arredondarBordas.ArredondarBordas(panelVerificaCPF, 25);
            panelVerificaCPF.BackColor = Color.White; // Cor do painel
        }
        
        private void FormularioCadCPF_Load(object sender, EventArgs e)
        {
            UIHelper.ArredondarBotao(btnContinuar, 25);
        }

        private void FormularioCadCPF_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            CorDeFundo.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void lblLinkFazerLogin_Click(object sender, EventArgs e)
        {
            FormularioLogin formularioLogin = new FormularioLogin();
            formularioLogin.ShowDialog();
        }
    }
}
