using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avalia__.AureaMaxDataSetTableAdapters;
using static Avalia__.RadiusButton;

namespace Avalia__
{
    public partial class VerDiagnosticoMedico: Form
    {
        private string _idConsulta;

        public VerDiagnosticoMedico(string idConsulta) 
        {
            InitializeComponent();
           _idConsulta = idConsulta;
            CarregarDadosDiagnostico();
            RadiusButton controlador = new RadiusButton();
          
            controlador.ConfigInicial(this, panelPaciente, btnSair, 25, ColorTranslator.FromHtml("#f0e6dd"));
            controlador.ConfigInicial(this, panel7, btnSair, 25, ColorTranslator.FromHtml("#f0e6dd"));
          
            controlador.ConfigInicial(this, panelPrincipal, btnSair, 25, Color.White);
            UIHelper.ArredondarBotao(btnAvaliar, 20);

        }

        private void CarregarDadosDiagnostico()
        {
            using (var diagnosticoAdapter = new DiagnosticoMedicoTableAdapter())
            using (var consultaAdapter = new tbConsultaTableAdapter())
            using (var medicoAdapter = new tbMedicoTableAdapter())
            using (var usuarioAdapter = new tbUsuarioTableAdapter())
            {
                 int idCons = int.Parse(_idConsulta);
                // Busca os dados da consulta
                var consulta = consultaAdapter.GetData().FirstOrDefault(c => c.IdConsulta == idCons);
                if (consulta == null)
                {
                    MessageBox.Show("Consulta não encontrada.");
                    return;
                }

                // Busca o diagnóstico
                var diagnostico = diagnosticoAdapter.GetData().FirstOrDefault(d => d.Id_Consulta == idCons);
            
                // Busca médico
                var medico = medicoAdapter.GetData().FirstOrDefault(m => m.IdMedico == consulta.IdMedico);
                string nomeMedico = medico != null ? $"{medico.Nome} {medico.Sobrenome}" : "Desconhecido";

                // Busca paciente
                var paciente = usuarioAdapter.GetData().FirstOrDefault(u => u.Id_usuario == consulta.Id_usuario);
                string nomePaciente = paciente != null ? $"{paciente.Nome} {paciente.Sobrenome}" : "Desconhecido";
                string cpf = paciente != null ? paciente.CPF : "Não informado";
                string dataNascimento = paciente != null ? paciente.Data_Nascimento.ToString("dd/MM/yyyy") : "Não informado";
                
                // Preenche os campo
                txtTratamento.Text = diagnostico.tratamentoRecomendado;
                lblInfoPaciente.Text = nomePaciente;
                lblInfoCPF.Text = cpf;
                lblInfoDataNascimento.Text = dataNascimento;
                lblInfoDataConsulta.Text = consulta.DataConsulta.ToString("dd/MM/yyyy");
                txtObservacaoMedico.Text = diagnostico.diagnostico;
                lblRemedio.Text = diagnostico.Medicamento ;
                lblInfoDuracao.Text = diagnostico.duracao;
                lblInfoComoUsar.Text = diagnostico.instrucaoReceita;
                lblInfoFrequencia.Text = diagnostico.Frequencia;
                lblMedicoResponsavel.Text = $"Dro.(a) {nomeMedico}";
                lblCRMResponsavel.Text = $"CRM: {medico?.CRM ?? "Não informado"}";  
            }
        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioAvaliacao avaliacao = new FormularioAvaliacao(_idConsulta);
            avaliacao.ShowDialog();
            this.Show();
        }
    }
}
