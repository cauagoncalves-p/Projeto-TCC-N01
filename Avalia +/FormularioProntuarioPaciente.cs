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

                        // Desabilita campos se a consulta já foi realizada
                        if (lblInfoStatus.Text == "Realizada")
                        {
                            txtMedicamento.Enabled = false;
                            txtDosagem.Enabled = false;
                            txtFrequencia.Enabled = false;
                            txtDuracao.Enabled = false;
                            txtInstrucaoReceita.Enabled = false;
                            txtDiagnostico.Enabled = false;
                            txtTratamentoRecomendado.Enabled = false;
                        }
                    }

                    // Aplica placeholders apenas se os campos estiverem vazios
                    configuracaoTelas.ConfigurarPlaceholder(txtDiagnostico, "Descreva o diagnóstico do paciente...");
                    configuracaoTelas.ConfigurarPlaceholder(txtTratamentoRecomendado, "Adicione quaisquer observações relevantes...");
                    configuracaoTelas.ConfigurarPlaceholder(txtMedicamento, "Nome do medicamento");
                    configuracaoTelas.ConfigurarPlaceholder(txtDosagem, "Dosagem");
                    configuracaoTelas.ConfigurarPlaceholder(txtFrequencia, "Frequência");
                    configuracaoTelas.ConfigurarPlaceholder(txtDuracao, "Duração");
                    configuracaoTelas.ConfigurarPlaceholder(txtInstrucaoReceita, "Adicione instruções específicas sobre os medicamentos...");
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
            lblInfopaciente.Text = paciente;
            lblInfoObservacao.Text = observacoes;
            lblInfoStatus.Text = status;
            lblInfoHoraData.Text = data;

            CarregarDiagnosticoDaConsulta(_IdConsulta);

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
                    // Captura e normaliza os textos com Trim()
                    string diagnostico = txtDiagnostico.Text.Trim();
                    string tratamento = txtTratamentoRecomendado.Text.Trim();

                    // Validação dos campos obrigatórios
                    if (diagnostico == "Descreva o diagnóstico do paciente..." || string.IsNullOrWhiteSpace(diagnostico) ||
                        tratamento == "Adicione quaisquer observações relevantes..." || string.IsNullOrWhiteSpace(tratamento))
                    {
                        MessageBox.Show("Preencha os campos obrigatórios: Diagnóstico e Tratamento Recomendado.");
                        return;
                    }

                    // Campos opcionais com operador ternário e Trim()
                    string remedio = txtMedicamento.Text.Trim() == "Nome do medicamento" ? "Não informado" : txtMedicamento.Text.Trim();
                    string dosagem = txtDosagem.Text.Trim() == "Dosagem" ? "Não informado" : txtDosagem.Text.Trim();
                    string duracao = txtDuracao.Text.Trim() == "Duração" ? "Não informado" : txtDuracao.Text.Trim();
                    string frequencia = txtFrequencia.Text.Trim() == "Frequência" ? "Não informado" : txtFrequencia.Text.Trim();
                    string instrucaoReceita = txtInstrucaoReceita.Text.Trim() == "Adicione instruções específicas sobre os medicamentos..." ? "Não informado" : txtInstrucaoReceita.Text.Trim();

                    int idConsulta = this._IdConsulta;
                    var dados = diagnosticoMedico.GetData().FirstOrDefault(d => d.Id_Consulta == idConsulta);

                    // Verifica se os dados já existem no banco
                    if (dados != null &&
                        dados.diagnostico == diagnostico &&
                        dados.tratamentoRecomendado == tratamento &&
                        dados.duracao == duracao &&
                        dados.instrucaoReceita == instrucaoReceita &&
                        dados.Dosagem == dosagem &&
                        dados.Medicamento == remedio &&
                        dados.Frequencia == frequencia)
                    {
                        mensagem.MensagemAtencao("Os dados fornecidos já se encontram no banco.\nClique em atualizar para mudar os dados!");
                        return;
                    }

                    // Insere no banco
                    diagnosticoMedico.Insert(idConsulta, diagnostico, tratamento, remedio, dosagem, frequencia, duracao, instrucaoReceita);

                    // Atualiza o status da consulta
                    consulta.AtualizarStatusConsulta("Realizada", idConsulta);

                    // Desativa os campos após finalizar
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
            catch (Exception ex)
            {
                mensagem.MensagemError("Falha ao enviar os dados: " + ex.Message);
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

            // Captura e normaliza os textos com Trim()
            string diagnostico = txtDiagnostico.Text.Trim();
            string tratamento = txtTratamentoRecomendado.Text.Trim();

            // Validação dos campos obrigatórios
            if (diagnostico == "Descreva o diagnóstico do paciente..." || string.IsNullOrWhiteSpace(diagnostico) ||
                tratamento == "Adicione quaisquer observações relevantes..." || string.IsNullOrWhiteSpace(tratamento))
            {
                MessageBox.Show("Preencha os campos obrigatórios: Diagnóstico e Tratamento Recomendado.");
                return;
            }

            // Campos opcionais com operador ternário e Trim()
            string remedio = txtMedicamento.Text.Trim() == "Nome do medicamento" ? "Não informado" : txtMedicamento.Text.Trim();
            string dosagem = txtDosagem.Text.Trim() == "Dosagem" ? "Não informado" : txtDosagem.Text.Trim();
            string duracao = txtDuracao.Text.Trim() == "Duração" ? "Não informado" : txtDuracao.Text.Trim();
            string frequencia = txtFrequencia.Text.Trim() == "Frequência" ? "Não informado" : txtFrequencia.Text.Trim();
            string instrucaoReceita = txtInstrucaoReceita.Text.Trim() == "Adicione instruções específicas sobre os medicamentos..." ? "Não informado" : txtInstrucaoReceita.Text.Trim();

            if (txtDiagnostico.Text == "Descreva o diagnóstico do paciente..." || txtTratamentoRecomendado.Text == "Adicione quaisquer observações relevantes...")
                  
            {
                mensagem.MensagemAtencao("Preencha o diagnóstico e a observação");
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
                adapter.AtualizarConsulta(diagnostico,tratamento,remedio,dosagem,frequencia,duracao,instrucaoReceita,dados.Id_diagnosticoMedico);
                
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

   

        private void button1_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }
    }
}
