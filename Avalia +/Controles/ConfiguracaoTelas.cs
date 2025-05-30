﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalia__
{
    public class ConfiguracaoTelas
    {/// <summary>
     /// Pinta o fundo do formulário com um gradiente de 135 graus.
     /// </summary>
        public static void PintarGradiente(Form form, PaintEventArgs e, string corHexInicial, string corHexFinal)
        {
            Color corInicial = ColorTranslator.FromHtml(corHexInicial);
            Color corFinal = ColorTranslator.FromHtml(corHexFinal);

            Point pontoInicial = new Point(form.ClientRectangle.Right, form.ClientRectangle.Top); // Canto superior direito
            Point pontoFinal = new Point(form.ClientRectangle.Left, form.ClientRectangle.Bottom); // Canto inferior esquerdo

            using (LinearGradientBrush brush = new LinearGradientBrush(
                pontoInicial,
                pontoFinal,
                corInicial,
                corFinal))
            {
                e.Graphics.FillRectangle(brush, form.ClientRectangle);
            }
        }

        public void FecharAba(Form form)
        {
            DialogResult sair = MessageBox.Show("Deseja fechar essa tela?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                form.Close();
            }
        }

        public string GerarHash(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
    
        public void ConfigurarPlaceholder(TextBox campo, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                campo.Text = placeholder;
                campo.ForeColor = Color.Gray;
            }

            campo.GotFocus += (s, e) =>
            {
                if (campo.Text == placeholder)
                {
                    campo.Text = "";
                    campo.ForeColor = Color.Black;
                }
            };

            campo.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(campo.Text))
                {
                    campo.Text = placeholder;
                    campo.ForeColor = Color.Gray;
                }
            };
        }

    }
}

