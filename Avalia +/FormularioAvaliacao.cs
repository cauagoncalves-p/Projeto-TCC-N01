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

namespace Avalia__
{

    public partial class FormularioAvaliacao: Form
    {
        private Image estrelaVazia;
        private Image estrelaPrenchida;

        private PictureBox[] estrelasAtendimento = new PictureBox[5];
        private PictureBox[] estrelasTempo = new PictureBox[5];
        private PictureBox[] estrelasConhecimento = new PictureBox[5];
        private PictureBox[] estrelasRespeito = new PictureBox[5];

        private string _idConsulta;
       
        public FormularioAvaliacao(string consulta)
        {
            InitializeComponent();
            ConfigurarEstrelas();

            _idConsulta = consulta;
            int Idconsulta = int.Parse (_idConsulta);

            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, comentarioPanel , btnSair, 25, Color.White);
        }

        private void ConfigurarEstrelas()
        {
            // Carrega as imagens (ajuste os caminhos se necessário)
            estrelaVazia = Image.FromFile("star-vazia.png");
            estrelaPrenchida = Image.FromFile("star_cheia.png");

            // Configura cada grupo de estrelas
            ConfigurarGrupo("Atendimento", estrelasAtendimento);
            ConfigurarGrupo("Tempo", estrelasTempo);
            ConfigurarGrupo("Conhecimento", estrelasConhecimento);
            ConfigurarGrupo("Respeito", estrelasRespeito);
        }

        private void ConfigurarGrupo(string prefixo, PictureBox[] grupo)
        {
            for (int i = 0; i < 5; i++)
            {
                // Encontra a PictureBox pelo nome (ex: "picAtendimento1")
                grupo[i] = Controls.Find($"pic{prefixo}{i + 1}", true)[0] as PictureBox;
                grupo[i].Tag = i; // Guarda a posição (0 a 4)
                grupo[i].Image = estrelaVazia; // Inicia vazia
                grupo[i].Click += Estrela_Click; // Associa o evento
            }
        }

        private void Estrela_Click(object sender, EventArgs e)
        {
            PictureBox estrelaClicada = (PictureBox)sender;
            int posicao = (int)estrelaClicada.Tag;

            // Extrai o prefixo do nome (ex: "Atendimento" de "picAtendimento1")
            string nome = estrelaClicada.Name;
            string prefixo = nome.Substring(3, nome.Length - 4); // Remove "pic" e o último número

            // Identifica o grupo correspondente
            PictureBox[] grupo;
            switch (prefixo)
            {
                case "Atendimento":
                    grupo = estrelasAtendimento;
                    break;
                case "Tempo":
                    grupo = estrelasTempo;
                    break;
                case "Conhecimento":
                    grupo = estrelasConhecimento;
                    break;
                case "Respeito":
                    grupo = estrelasRespeito;
                    break;
                default:
                    MessageBox.Show("Grupo de estrelas não reconhecido!");
                    return;
            }

            // Preenche as estrelas até a clicada
            for (int i = 0; i < 5; i++)
            {
                grupo[i].Image = (i <= posicao) ? estrelaPrenchida : estrelaVazia;
            }
        }

        private void FormularioAvaliacao_Paint(object sender, PaintEventArgs e)
        {
            //Cor de fundo da tela 
            ConfiguracaoTelas.PintarGradiente(this, e, "#f5e6d3", "#fdf6f0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void CarregarDadosAvaliar()
        {
            using (var diagnosticoAdapter = new DiagnosticoMedicoTableAdapter())
            using (var consultaAdapter = new tbConsultaTableAdapter())
            using (var medicoAdapter = new tbMedicoTableAdapter())
            using (var usuarioAdapter = new tbUsuarioTableAdapter())
            {
                // Busca os dados da consulta
                var consulta = consultaAdapter.GetData().FirstOrDefault(c => c.IdConsulta == );
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
                lblRemedio.Text = diagnostico.Medicamento;
                lblInfoDuracao.Text = diagnostico.duracao;
                lblInfoComoUsar.Text = diagnostico.instrucaoReceita;
                lblInfoFrequencia.Text = diagnostico.Frequencia;
                lblMedicoResponsavel.Text = $"Dro.(a) {nomeMedico}";
                lblCRMResponsavel.Text = $"CRM: {medico?.CRM ?? "Não informado"}";
            }
        }
    }
    
}
