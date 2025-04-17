﻿using Avalia__.AureaMaxDataSetTableAdapters;
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



        public FormularioAgendamentoConsulta()
        {
            InitializeComponent();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelAgendar, btnSair, 25, Color.White);
            carregaEspecialidade();
          
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
    }
}
