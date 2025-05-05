using Avalia__.AureaMaxDataSetTableAdapters;
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
    public partial class FormularioAgendamentoConsulta: Form
    {
        private int IdUsuario;
      
        Mensagem_do_sistema mensagem_Do_Sistema = new Mensagem_do_sistema();
        
        private void atualizarBanco() 
        {
            tbInstituicaoTableAdapter tbInstituicaoTableAdapter = new tbInstituicaoTableAdapter();
            AureaMaxDataSet.tbInstituicaoDataTable tabelaInstituicao = tbInstituicaoTableAdapter.GetData();

            tbMedicoTableAdapter tbMedicoTableAdapter = new tbMedicoTableAdapter();
            AureaMaxDataSet.tbMedicoDataTable tbMedicos = tbMedicoTableAdapter.GetData();

            cbxMedico.DataSource = tbMedicos;
            cbxMedico.DisplayMember = "Nome";
            cbxMedico.ValueMember = "IdMedico";
        
            cbxAtendimento.DataSource = tabelaInstituicao;
            cbxAtendimento.DisplayMember = "NomeInstituicao";
            cbxAtendimento.ValueMember = "IdInstituicao";
        }
        
        private void novoDado() 
        {
            tbConsultaTableAdapter consulta = new tbConsultaTableAdapter();
            int Id_medico = Convert.ToInt32(cbxMedico.SelectedValue);
            int Id_instituicao = Convert.ToInt32(cbxAtendimento.SelectedValue);
            DateTime data = dtpData.Value;
            string motivo = txtConsultaMotivo.Text;
            string observacao = txtobservacao.Text;
            string statusconsulta = "Agendada";

           
            consulta.Insert(IdUsuario,Id_medico,data,motivo,statusconsulta,observacao);
            atualizarBanco();

        }
        private void carregaEspecialidade() 
        {
            using (var adapter = new tbMedicoTableAdapter())
            {
                var medicos = adapter.GetData();
                var especialidades = medicos
                    .Select(m => m.Especialidade)
                    .Distinct()
                    .ToList();

                cbxEspecialidade.DataSource = especialidades;
            }

            using (var adapter = new tbInstituicaoTableAdapter())
            {
                var instituicoes = adapter.GetData().ToList();

                cbxAtendimento.DisplayMember = "NomeInstituicao";
                cbxAtendimento.ValueMember = "IdInstituicao";
                cbxAtendimento.DataSource = instituicoes;
            }
        }



        public FormularioAgendamentoConsulta(int IdUsuario)
        {
            InitializeComponent();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelAgendar, btnSair, 25, Color.White);
            carregaEspecialidade();
            this.IdUsuario = IdUsuario;
       

        }

        private void FormularioAgendamentoConsulta_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void cbxEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {

            string especialidadeSelecionada = cbxEspecialidade.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(especialidadeSelecionada))
            {
                using (var adapter = new tbMedicoTableAdapter())
                {
                    var medicosFiltrados = adapter.GetData()
                        .Where(m => m.Especialidade == especialidadeSelecionada)
                        .Select(m => new
                        {
                            IdMedico = m.IdMedico,
                            NomeCompleto = m.Nome + " " + m.Sobrenome
                        })
                        .ToList();

                    cbxMedico.DisplayMember = "NomeCompleto";
                    cbxMedico.ValueMember = "IdMedico";
                    cbxMedico.DataSource = medicosFiltrados;
                }
            }
            else
            {
                cbxMedico.DataSource = null;
            }

            cbxAtendimento.DataSource = null; // limpa instituição se trocar a especialidade
        }

        private void cbxMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMedico.SelectedValue != null)
            {
                int idMedicoSelecionado = (int)cbxMedico.SelectedValue;

                using (var medicoAdapter = new tbMedicoTableAdapter())
                using (var instituicaoAdapter = new tbInstituicaoTableAdapter())
                {
                    var medico = medicoAdapter.GetData()
                        .FirstOrDefault(m => m.IdMedico == idMedicoSelecionado);

                    if (medico != null)
                    {
                        var instituicao = instituicaoAdapter.GetData()
                            .FirstOrDefault(i => i.IdInstituicao == medico.IdInstituicao);

                        if (instituicao != null)
                        {
                            cbxAtendimento.DataSource = new[] { instituicao };
                            cbxAtendimento.DisplayMember = "NomeInstituicao";
                            cbxAtendimento.ValueMember = "IdInstituicao";
                        }
                    }
                }
            }
            else
            {
                cbxAtendimento.DataSource = null;
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            
            DateTime diaAtual = DateTime.Today;
            if (dtpData.Value < diaAtual) 
            {
                mensagem_Do_Sistema.MensagemInformation("Selecione uma data valida!");
                return;
            }

            try
            {
                novoDado();
                MessageBox.Show("Consulta registrada com sucesso!");
                return;
            }
            catch (Exception) 
            {
                MessageBox.Show("Houve um erro com o cadastro da consulta!");
                return;
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
