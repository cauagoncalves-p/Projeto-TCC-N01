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
        public FormularioAgendamentoConsulta(int IdUsuario)
        {
            InitializeComponent();
            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panelAgendar, btnSair, 25, Color.White);
            carregaEspecialidade();
            this.IdUsuario = IdUsuario;
            GerarBotoesHorarios();
        }

        private int IdUsuario;
        private DateTime horarioSelecionado;
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
        
        private void novoDado(DateTime horarios) 
        {
            tbConsultaTableAdapter consulta = new tbConsultaTableAdapter();
            int Id_medico = Convert.ToInt32(cbxMedico.SelectedValue);
            int Id_instituicao = Convert.ToInt32(cbxAtendimento.SelectedValue);
            DateTime data = dtpData.Value;
            string motivo = txtConsultaMotivo.Text;
            string observacao = txtobservacao.Text;
            string statusconsulta = "Agendada";
            TimeSpan horario = horarios.TimeOfDay;


            consulta.Insert(IdUsuario,Id_medico,data,motivo,statusconsulta,observacao,horario);
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
        private List<TimeSpan> ObterHorariosOcupados(DateTime dataConsulta)
        {
            List<TimeSpan> horariosOcupados = new List<TimeSpan>();

            using (var adapter = new tbConsultaTableAdapter())
            {
                // Obtém as consultas para a data especificada
                var consultas = adapter.GetData()
                    .Where(c => c.DataConsulta.Date == dataConsulta.Date)  // Filtra pela data da consulta
                    .Select(c => c.HorarioConsulta)  // Seleciona apenas os horários
                    .ToList();

                // Se for TimeSpan, adiciona diretamente
                foreach (var horario in consultas)
                {
                    horariosOcupados.Add(horario);  // Adiciona diretamente (é TimeSpan, então já podemos adicionar)
                }
            }

            return horariosOcupados;
        }

        private void GerarBotoesHorarios()
        {
            TimeSpan horaInicial = TimeSpan.FromHours(8);  // 08:00
            TimeSpan horaFinal = TimeSpan.FromHours(18);   // 18:00

            int margem = 10;
            int espacamentoHorizontal = 10;
            int espacamentoVertical = 10;
            int larguraBotao = 80;
            int alturaBotao = 30;

            // Margem superior para não sobrepor o título do GroupBox
            int posX = margem;
            int posY = gpxHorarios.Font.Height + 15; // Ajuste a altura do título + algum espaçamento

            int larguraMaxima = gpxHorarios.Width;

            // Obtém os horários ocupados para a data selecionada, agora como TimeSpan
            List<TimeSpan> horariosOcupados = ObterHorariosOcupados(dtpData.Value);

            while (horaInicial < horaFinal)
            {
                Button btnHorario = new Button();
                btnHorario.Text = horaInicial.ToString(@"hh\:mm");  // Exibe o horário no formato "HH:mm"
                btnHorario.Font = new Font("Arial Narrow", 10);
                btnHorario.Tag = horaInicial.ToString(@"hh\:mm");  // Guarda o horário no formato "HH:mm"
                btnHorario.Width = larguraBotao;
                btnHorario.Height = alturaBotao;

                // Se o horário estiver ocupado, desabilita o botão
                if (horariosOcupados.Contains(horaInicial))
                {
                    btnHorario.Enabled = false;
                    btnHorario.BackColor = Color.Gray; // Muda a cor para indicar que está indisponível
                }

                // Se passar da largura do GroupBox, vai para a próxima linha
                if (posX + larguraBotao + margem > larguraMaxima)
                {
                    posX = margem;
                    posY += alturaBotao + espacamentoVertical;
                }

                btnHorario.Left = posX;
                btnHorario.Top = posY;

                btnHorario.Click += BtnHorario_Click;

                gpxHorarios.Controls.Add(btnHorario);

                posX += larguraBotao + espacamentoHorizontal;
                horaInicial = horaInicial.Add(TimeSpan.FromMinutes(30));  // Incrementa de 30 em 30 minutos
            }
        }


        private void BtnHorario_Click(object sender, EventArgs e)
        {
            foreach (var btn in gpxHorarios.Controls.OfType<Button>())
            {
                btn.BackColor = SystemColors.Control;
            }
            // Captura o horário do botão clicado
            Button botaoClicado = (Button)sender;
            botaoClicado.BackColor = Color.Yellow;

            horarioSelecionado = Convert.ToDateTime(botaoClicado.Tag.ToString());
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
                mensagem_Do_Sistema.MensagemInformation("Selecione uma data válida!");
                return;
            }

            // Verifica se o horário foi selecionado
            if (horarioSelecionado == default(DateTime)) // Se o horário não foi selecionado
            {
                MessageBox.Show("Selecione um horário para a consulta!");
                return;
            }

            try
            {
                // Passa o horário selecionado para o método novoDado
                novoDado(horarioSelecionado);

                MessageBox.Show("Consulta registrada com sucesso!");
                ((FormularioPaginaPaciente)this.Owner)?.CarregarConsultas();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro com o cadastro da consulta!");
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
