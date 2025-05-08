using Avalia__.AureaMaxDataSetTableAdapters;
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
    public partial class FormularioPaginaPaciente: Form
    {
        private int idUsuario;
        private string emailUsuario;

        public void CarregarConsultas()
        {
            using (var consultas = new tbConsultaTableAdapter())
            using (var medicos = new tbMedicoTableAdapter())
            {
                try
                {
                    var consultasDoUsuario = consultas.GetData()
                                                      .Where(c => c.Id_usuario == idUsuario &&
                                                                  c.StatusConsulta != "Cancelada" &&
                                                                  c.StatusConsulta != "Realizada" &&
                                                                  c.StatusConsulta != "Avaliada" &&
                                                                  c.StatusConsulta != "Urgente")
                                                      .OrderBy(c => c.DataConsulta)
                                                      .ToList();

                    var medicosLista = medicos.GetData();

                    // Consulta 1
                    if (consultasDoUsuario.Count > 0)
                    {
                        var consulta1 = consultasDoUsuario[0];
                        var medico1 = medicosLista.FirstOrDefault(m => m.IdMedico == consulta1.IdMedico);

                        lblDataConsulta1.Text = consulta1.DataConsulta.ToString("dd/MM/yyyy");
                        lblMedico.Text = medico1 != null ? $"{medico1.Nome} - {medico1.Especialidade}" : "Médico não encontrado";
                    }
                    else
                    {
                        lblDataConsulta1.Text = "Consulta não encontrada";
                        lblMedico.Text = "Não disponível";
                    }

                    // Consulta 2
                    if (consultasDoUsuario.Count > 1)
                    {
                        var consulta2 = consultasDoUsuario[1];
                        var medico2 = medicosLista.FirstOrDefault(m => m.IdMedico == consulta2.IdMedico);

                        lblDataConsulta2.Text = consulta2.DataConsulta.ToString("dd/MM/yyyy");
                        lblMedico1.Text = medico2 != null ? $"{medico2.Nome} - {medico2.Especialidade}" : "Médico não encontrado";
                    }
                    else
                    {
                        lblDataConsulta2.Text = "Consulta não encontrada";
                        lblMedico1.Text = "Não disponível";
                    }
                }
                catch (Exception)
                {
                    lblDataConsulta1.Text = "Erro ao carregar";
                    lblMedico.Text = "Erro ao carregar";
                    lblDataConsulta2.Text = "Erro ao carregar";
                    lblMedico1.Text = "Erro ao carregar";
                }
            }
        }

        public FormularioPaginaPaciente(int idUsuario, string emailUsuario)
        {
            InitializeComponent();
         
            this.idUsuario = idUsuario;
            this.emailUsuario = emailUsuario;
            CarregarConsultas();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelbackground, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panel1, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panel2, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panelConsultas, btnSair, 25, ColorTranslator.FromHtml("#F0E4DC"));
            controlador.ConfigInicial(this, panelHeader, btnSair, 20, ColorTranslator.FromHtml("#c97c63"));

            UIHelper.ArredondarBotao(btnLembrar, 10);
            UIHelper.ArredondarBotao(btnLembrar2, 10);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this); // Fecha apenas a aba atual
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconde o formulário atual

            FormularioAgendamentoConsulta formularioAgendamento = new FormularioAgendamentoConsulta(idUsuario);
            formularioAgendamento.Owner = this; // Define o dono
            formularioAgendamento.ShowDialog(); // Espera o usuário fechar

            this.Show(); // Só será executado depois que o agendamento for fechado

        }

        private void btnHistoricomedico_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormularioConsultasAgendadas formularioConsultasAgendadas = new FormularioConsultasAgendadas(idUsuario);
            formularioConsultasAgendadas.ShowDialog();

            this.Show();
        }

        private void btnCancelarConsulta_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormCancelarConsulta formCancelarConsulta = new FormCancelarConsulta(idUsuario);
            formCancelarConsulta.ShowDialog();

            this.Show();
        }
        private void FormularioPaginaPaciente_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void btnAvaliarconsulta_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormularioConsultasAvaliadas avaliadas = new FormularioConsultasAvaliadas(idUsuario);
            avaliadas.ShowDialog();

            this.Show();
        }

        private void lblLinkConsulta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormularioConsultasAgendadas formularioConsultasAgendadas = new FormularioConsultasAgendadas(idUsuario);
            formularioConsultasAgendadas.ShowDialog();
            this.Show();
        }
    }
}
