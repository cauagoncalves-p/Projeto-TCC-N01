using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Avalia__
{
    public partial class Form1 : Form
    {

        private void MudarFonte() 
        {
            lblAvalia.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblLogin.Font = new Font("Inter", 12, FontStyle.Bold);
            lblNome.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblSenha.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblEsqueceuSenha.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            btnEntrar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblLinkCriarConta.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblCriarConta.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        public Form1()
        {
            InitializeComponent();
            MudarFonte();
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.Resize += (s, e) => this.Invalidate(); // Redesenha ao redimensionar
   

            ArredondarBordas(panelLogin, 25); // Raio de 25px nos cantos
            panelLogin.BackColor = Color.White; // Cor do painel
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Cor inicial e final do gradiente (135°)
            Color corInicial = ColorTranslator.FromHtml("#f5e6d3");
            Color corFinal = ColorTranslator.FromHtml("#fdf6f0");

            // Ponto inicial: canto superior direito
            // Ponto final: canto inferior esquerdo
            Point pontoInicial = new Point(this.ClientRectangle.Right, this.ClientRectangle.Top);
            Point pontoFinal = new Point(this.ClientRectangle.Left, this.ClientRectangle.Bottom);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                pontoInicial,
                pontoFinal,
                corInicial,
                corFinal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }


        private void ArredondarBordas(Panel panel, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(panel.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(panel.Width - raio, panel.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, panel.Height - raio, raio, raio, 90, 90);
            path.CloseFigure();


            panel.Region = new Region(path);
        }

        private void lblEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
