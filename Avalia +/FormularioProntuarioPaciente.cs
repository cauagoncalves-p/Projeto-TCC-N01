using Avalia__.AureaMaxDataSetTableAdapters;
using Avalia__.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Avalia__.AureaMaxDataSet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Avalia__
{
    public partial class FormularioProntuarioPaciente: Form
    {
        ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
        Mensagem_do_sistema mensagem = new Mensagem_do_sistema();
        private int _IdConsulta;
        private void CarregarDiagnosticoDaConsulta(int idConsulta)
        {
            try
            {
                using (var diagnosticoAdapter = new DiagnosticoMedicoTableAdapter())
                {
                    var diagnostico = diagnosticoAdapter.GetData()
                        .FirstOrDefault(d => d.Id_Consulta == idConsulta);

                    if (diagnostico != null)
                    {
                        // Preenche os campos com os dados do banco
                        txtMedicamento.Text = diagnostico.Medicamento;
                        txtDosagem.Text = diagnostico.Dosagem;
                        txtFrequencia.Text = diagnostico.Frequencia;
                        txtDuracao.Text = diagnostico.duracao;
                        txtInstrucaoReceita.Text = diagnostico.instrucaoReceita;
                        txtDiagnostico.Text = diagnostico.diagnostico;
                        txtTratamentoRecomendado.Text = diagnostico.tratamentoRecomendado;

                        // Verifica se a consulta já foi realizada
                        if (lblInfoStatus.Text == "Realizada")
                        {
                            // Desabilita todos os campos
                            txtMedicamento.Enabled = false;
                            txtDosagem.Enabled = false;
                            txtFrequencia.Enabled = false;
                            txtDuracao.Enabled = false;
                            txtInstrucaoReceita.Enabled = false;
                            txtDiagnostico.Enabled = false;
                            txtTratamentoRecomendado.Enabled = false;
                        }
                        else
                        {
                            // Caso ainda não realizada, mostra os placeholders
                            configuracaoTelas.ConfigurarPlaceholder(txtDiagnostico, "Descreva o diagnóstico do paciente...");
                            configuracaoTelas.ConfigurarPlaceholder(txtTratamentoRecomendado, "Adicione quaisquer observações relevantes...");
                            configuracaoTelas.ConfigurarPlaceholder(txtMedicamento, "Nome do medicamento");
                            configuracaoTelas.ConfigurarPlaceholder(txtDosagem, "Dosagem");
                            configuracaoTelas.ConfigurarPlaceholder(txtFrequencia, "Frequência");
                            configuracaoTelas.ConfigurarPlaceholder(txtDuracao, "Duração");
                            configuracaoTelas.ConfigurarPlaceholder(txtInstrucaoReceita, "Adicione instruções específicas sobre os medicamentos...");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o diagnóstico: " + ex.Message);
            }
        }


        public FormularioProntuarioPaciente(int IdConsulta, string paciente, string data, string status, string observacoes)
        {
            InitializeComponent();
            _IdConsulta = IdConsulta;
            _IdConsulta = IdConsulta;
            lblInfopaciente.Text = paciente;
            lblInfoObservacao.Text = observacoes;
            lblInfoStatus.Text = status;
            lblInfoHoraData.Text = data;

            CarregarDiagnosticoDaConsulta(_IdConsulta);

            configuracaoTelas.ConfigurarPlaceholder(txtDiagnostico, "Descreva o diagnóstico do paciente...");
            configuracaoTelas.ConfigurarPlaceholder(txtTratamentoRecomendado, "Adicione quaisquer observações relevantes...");
            configuracaoTelas.ConfigurarPlaceholder(txtMedicamento, "Nome do medicamento");
            configuracaoTelas.ConfigurarPlaceholder(txtDosagem, "Dosagem");
            configuracaoTelas.ConfigurarPlaceholder(txtFrequencia, "Frequência");
            configuracaoTelas.ConfigurarPlaceholder(txtDuracao, "Duração");
            configuracaoTelas.ConfigurarPlaceholder(txtInstrucaoReceita, "Adicione instruções específicas sobre os medicamentos...");
            // Aqui só carregamos os dados, os placeholders serão aplicados depois se necessário

            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, panel1, btnSair, 25, Color.White);
            controlador.ConfigInicial(this, panel2, btnSair, 25, ColorTranslator.FromHtml("#e8d5c4"));
        }

        private void btnFinalizar_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinalizarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                using (var consulta = new tbConsultaTableAdapter())
                using (var diagnosticoMedico = new DiagnosticoMedicoTableAdapter())
                {
                    if (txtDiagnostico.Text == "Descreva o diagnóstico do paciente..." || txtDosagem.Text == "Dosagem" ||
                        txtDuracao.Text == "Duração" || txtFrequencia.Text == "Frequência" ||
                         txtInstrucaoReceita.Text == "Adicione instruções específicas sobre os medicamentos..." || txtTratamentoRecomendado.Text == "Adicione quaisquer observações relevantes..." ||
                        txtMedicamento.Text == "Nome do medicamento")
                    {
                        mensagem.MensagemAtencao("Preencha todos os campos");
                        return;
                    }

                    int idConsulta = this._IdConsulta;
                    var adapter = new DiagnosticoMedicoTableAdapter();
                    var dados = adapter.GetData().FirstOrDefault(d => d.Id_Consulta == idConsulta);

                    if (dados != null && dados.diagnostico == txtDiagnostico.Text && dados.tratamentoRecomendado == txtTratamentoRecomendado.Text &&
                    dados.duracao == txtDuracao.Text && dados.instrucaoReceita == txtInstrucaoReceita.Text &&
                    dados.Dosagem == txtDosagem.Text && dados.Medicamento == txtMedicamento.Text && dados.Frequencia == txtFrequencia.Text)
                    {
                        mensagem.MensagemAtencao("Os dados fornecidos ja se encontram no banco\nClique em atualizar para mudar os dados!");
                        return;
                    }
                    else
                    {
                        string diagnostico = txtDiagnostico.Text;
                        string tratamento = txtTratamentoRecomendado.Text;
                        string remedio = txtMedicamento.Text;
                        string dosagem = txtDosagem.Text;
                        string duracao = txtDuracao.Text;
                        string frequencia = txtFrequencia.Text;
                        string instrucaoReceita = txtInstrucaoReceita.Text;

                        diagnosticoMedico.Insert(_IdConsulta, diagnostico, tratamento, remedio, dosagem, frequencia, duracao, instrucaoReceita);

                        consulta.AtualizarStatusConsulta("Realizada", _IdConsulta);

                        // Desabilita os campos após a consulta ser realizada
                        txtDiagnostico.Enabled = false;
                        txtTratamentoRecomendado.Enabled = false;
                        txtMedicamento.Enabled = false;
                        txtDosagem.Enabled = false;
                        txtFrequencia.Enabled = false;
                        txtDuracao.Enabled = false;
                        txtInstrucaoReceita.Enabled = false;

                        lblInfoStatus.Text = "Realizada";
                        mensagem.MensagemInformation("Diagnóstico enviado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                mensagem.MensagemError("Falha para enviar os dados: " + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtDiagnostico.Enabled == false)
            {
                DialogResult atualizar = MessageBox.Show("Quer mesmo atualizar esse status?", "ATENÇÂO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (atualizar == DialogResult.Yes)
                {
                    // Desabilita todos os campos
                    txtMedicamento.Enabled = true;
                    txtDosagem.Enabled = true;
                    txtFrequencia.Enabled = true;
                    txtDuracao.Enabled = true;
                    txtInstrucaoReceita.Enabled = true;
                    txtDiagnostico.Enabled = true;
                    txtTratamentoRecomendado.Enabled = true;
                    return;
                }
            }

            int idConsulta = this._IdConsulta; // Supondo que você tenha salvo isso ao abrir o formulário

            var adapter = new DiagnosticoMedicoTableAdapter();
            // Verifica se já existe diagnóstico
            var dados = adapter.GetData().FirstOrDefault(d => d.Id_Consulta == idConsulta);

            string dianostico = txtDiagnostico.Text;
            string tratamento = txtTratamentoRecomendado.Text;
            string remedio = txtMedicamento.Text;
            string dosagem = txtDosagem.Text;
            string duracao = txtDuracao.Text;
            string frequencia = txtFrequencia.Text;
            string instrucaoReceita = txtInstrucaoReceita.Text;

            if (txtDiagnostico.Text == "Descreva o diagnóstico do paciente..." || txtDosagem.Text == "Dosagem" ||
                        txtDuracao.Text == "Duração" || txtFrequencia.Text == "Frequência" ||
                         txtInstrucaoReceita.Text == "Adicione instruções específicas sobre os medicamentos..." || txtTratamentoRecomendado.Text == "Adicione quaisquer observações relevantes..." ||
                        txtMedicamento.Text == "Nome do medicamento")
            {
                mensagem.MensagemAtencao("Preencha todos os campos");
                return;
            }


            if (dados.diagnostico == txtDiagnostico.Text && dados.tratamentoRecomendado == txtTratamentoRecomendado.Text &&
            dados.duracao == txtDuracao.Text && dados.instrucaoReceita == txtInstrucaoReceita.Text &&
            dados.Dosagem == txtDosagem.Text && dados.Medicamento == txtMedicamento.Text && dados.Frequencia == txtFrequencia.Text)
            {
                mensagem.MensagemAtencao("Os dados ainda permancem os mesmo!\nTroque as informações ou clique em cancelar");
                return;
            }

            /*
             comando para atualziar os dados
            UPDATE DiagnosticoMedico
            SET 
                    diagnostico = @diagnostico,
                    tratamentoRecomendado = @tratamentoRecomendado,
                    Medicamento = @medicamento,
                    Dosagem = @dosagem,
                    Frequencia = @frequencia,
                    duracao = @duracao,
                    instrucaoReceita = @instrucaoReceita
            WHERE Id_diagnosticoMedico = @Id_diagnosticoMedico
            */

            if (dados != null)
            {
                // Se existir, atualiza
                adapter.AtualizarConsulta(dianostico,tratamento,remedio,dosagem,frequencia,duracao,instrucaoReceita,dados.Id_diagnosticoMedico);
                
                mensagem.MensagemInformation("Diagnóstico atualizado com sucesso!");

                // Desabilita os campos após a consulta ser realizada
                txtDiagnostico.Enabled = false;
                txtTratamentoRecomendado.Enabled = false;
                txtMedicamento.Enabled = false;
                txtDosagem.Enabled = false;
                txtFrequencia.Enabled = false;
                txtDuracao.Enabled = false;
                txtInstrucaoReceita.Enabled = false;
            }
            else
            {
                mensagem.MensagemError("Nenhum diagnóstico encontrado para esta consulta. Você precisa registrar primeiro.");
            }
        }

        private void FormularioProntuarioPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
