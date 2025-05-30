﻿using Avalia__.AureaMaxDataSetTableAdapters;
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
using static Avalia__.RadiusButton;

namespace Avalia__
{
    public partial class FormularioCadCPF: Form
    {
        Mensagem_do_sistema mensagem_ = new Mensagem_do_sistema();
        private string tipoUsuario = ""; 

        private void MudarFonte()
        {
            mktCPF.Font = new Font("Arial", 17, FontStyle.Regular);
        }

        public FormularioCadCPF()
        {
            InitializeComponent();
            MudarFonte();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelVerificaCPF, btnSair, 25, Color.White);
        }
        
        private void FormularioCadCPF_Load(object sender, EventArgs e)
        {
            UIHelper.ArredondarBotao(btnContinuar, 25);
        }

        private void FormularioCadCPF_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void lblLinkFazerLogin_Click(object sender, EventArgs e)
        {
            FormularioLogin formularioLogin = new FormularioLogin();
            formularioLogin.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {


            string cpfDigitado = mktCPF.Text;
            string emailDigitado = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(cpfDigitado) || string.IsNullOrWhiteSpace(emailDigitado))
            {
                mensagem_.MensagemError("Por favor, preencha o CPF e o e-mail.");
                return;
            }

            // Consulta no banco
            tbUsuarioTableAdapter tbUsuarioTableAdapter = new tbUsuarioTableAdapter();
            tbMedicoTableAdapter tbMedicoTableAdapter = new tbMedicoTableAdapter();
            var usuario = tbUsuarioTableAdapter.GetData().FirstOrDefault(u => u.CPF == cpfDigitado && u.Email == emailDigitado);
            var medico = tbMedicoTableAdapter.GetData().FirstOrDefault(m => m.CPF == cpfDigitado && m.Email == emailDigitado);

            if (usuario != null)
            {
                tipoUsuario = "paciente";
            }
            else if (medico != null)
            {
                tipoUsuario = "medico";
            }

            var resultado = usuario ?? (object)medico;

            if (resultado != null)
            {
                mensagem_.MensagemInformation("Usuário encontrado! Indo para a próxima tela...");

                FormularioDeEnvioCodigo envio = new FormularioDeEnvioCodigo(emailDigitado,tipoUsuario);
                this.Hide();
                envio.ShowDialog(); // Fecha ele depois e mostra outro, se quiser
                this.Close(); // Depois que envio for fechado 
            }
            else
            {
                mensagem_.MensagemAtencao("CPF ou E-mail não encontrado no sistema.");
            }
        }
    }
}
