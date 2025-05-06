using Avalia__.AureaMaxDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalia__
{
    public partial class FormularioAvaliacao: Form
    {
        private int notaAtendimento = 0;
        private int notaTempo = 0;
        private int notaConhecimento = 0;
        private int notaRespeito = 0;

        private Image estrelaVazia;
        private Image estrelaPrenchida;

        private PictureBox[] estrelasAtendimento = new PictureBox[5];
        private PictureBox[] estrelasTempo = new PictureBox[5];
        private PictureBox[] estrelasConhecimento = new PictureBox[5];
        private PictureBox[] estrelasRespeito = new PictureBox[5];

        private string _idConsulta;
        private int Idconsulta;
       
        public FormularioAvaliacao(string consulta)
        {
            InitializeComponent();
            ConfigurarEstrelas();

            _idConsulta = consulta;
            Idconsulta = int.Parse (_idConsulta);

            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, comentarioPanel , btnSair, 25, Color.White);
            CarregarDadosAvaliar();
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
            int posicao = (int)estrelaClicada.Tag; // posição vai de 0 a 4 (então nota é posicao + 1)

            string nome = estrelaClicada.Name;
            string prefixo = nome.Substring(3, nome.Length - 4); // ex: "Atendimento"

            PictureBox[] grupo;
            int nota = posicao + 1; // converte posição para nota de 1 a 5

            switch (prefixo)
            {
                case "Atendimento":
                    grupo = estrelasAtendimento;
                    notaAtendimento = nota;
                    break;
                case "Tempo":
                    grupo = estrelasTempo;
                    notaTempo = nota;
                    break;
                case "Conhecimento":
                    grupo = estrelasConhecimento;
                    notaConhecimento = nota;
                    break;
                case "Respeito":
                    grupo = estrelasRespeito;
                    notaRespeito = nota;
                    break;
                default:
                    MessageBox.Show("Grupo de estrelas não reconhecido!");
                    return;
            }

            // Atualiza as imagens das estrelas
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


        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }

        private void CarregarDadosAvaliar()
        {
            using (var diagnosticoAdapter = new DiagnosticoMedicoTableAdapter())
            using (var consultaAdapter = new tbConsultaTableAdapter())
            using (var medicoAdapter = new tbMedicoTableAdapter())
            using (var usuarioAdapter = new tbUsuarioTableAdapter())
            using (var avaliacaoAdapter = new tbAvaliacaoTableAdapter()) // novo
            {
                var consulta = consultaAdapter.GetData().FirstOrDefault(c => c.IdConsulta == Idconsulta);
                if (consulta == null)
                {
                    MessageBox.Show("Consulta não encontrada.");
                    return;
                }

                var medico = medicoAdapter.GetData().FirstOrDefault(m => m.IdMedico == consulta.IdMedico);
                string nomeMedico = medico != null ? $"{medico.Nome} {medico.Sobrenome}" : "Desconhecido";
                string especialidade = medico != null ? $"{medico.Especialidade}" : "Não informado";
                string crm = medico != null ? $"{medico.CRM}" : "Não informado";

                lblNomeMedico.Text = $"Dr(a) {nomeMedico.ToUpper()}";
                lblEspecialidadeEcrm.Text = $"{especialidade} ° {crm}";

                // Verifica se já existe uma avaliação para esta consulta
                var avaliacao = avaliacaoAdapter.GetData().FirstOrDefault(a => a.IdConsulta == Idconsulta);
                if (avaliacao != null)
                {
                    // Se já houver avaliação, preenche os dados e desabilita o botão de envio
                    notaAtendimento = avaliacao.Atendimento_comunicacao;
                    notaTempo = avaliacao.Tempo_de_espera;
                    notaConhecimento = avaliacao.Conhecimento_tecnico;
                    notaRespeito = avaliacao.Respeito_empatia;
                    txtComentario.Text = avaliacao.Comentario;

                    // Atualiza as estrelas
                    AtualizarEstrelas(estrelasAtendimento, notaAtendimento);
                    AtualizarEstrelas(estrelasTempo, notaTempo);
                    AtualizarEstrelas(estrelasConhecimento, notaConhecimento);
                    AtualizarEstrelas(estrelasRespeito, notaRespeito);

                    // Desabilita o botão de enviar
                    btnEnviarAvaliacao.Enabled = false;

                    // Desabilita as estrelas e o campo de comentário
                    DesabilitarEstrelas(estrelasAtendimento);
                    DesabilitarEstrelas(estrelasTempo);
                    DesabilitarEstrelas(estrelasConhecimento);
                    DesabilitarEstrelas(estrelasRespeito);
                    txtComentario.Enabled = false;
                }
                else
                {
                    // Se não houver avaliação, habilita o botão de envio
                    btnEnviarAvaliacao.Enabled = true;
                }
            }
        }

        private void DesabilitarEstrelas(PictureBox[] grupo)
        {
            foreach (var pic in grupo)
            {
                pic.Enabled = false; 
            }
        }

        private void AtualizarEstrelas(PictureBox[] grupo, int nota)
        {
            for (int i = 0; i < 5; i++)
            {
                grupo[i].Image = (i < nota) ? estrelaPrenchida : estrelaVazia;
            }
        }

        private void btnEnviarAvaliacao_Click(object sender, EventArgs e)
        {
            using (var avaliacaoAdapter = new tbAvaliacaoTableAdapter())
            {
                try
                {
                    // Verifica se já existe uma avaliação para essa consulta
                    var avaliacaoExistente = avaliacaoAdapter.GetData().FirstOrDefault(a => a.IdConsulta == Idconsulta);

                    // Se a avaliação já existe, fazemos o UPDATE
                    if (avaliacaoExistente != null)
                    {
                        // Atualiza os valores da avaliação existente
                        avaliacaoExistente.Atendimento_comunicacao = notaAtendimento;
                        avaliacaoExistente.Tempo_de_espera = notaTempo;
                        avaliacaoExistente.Conhecimento_tecnico = notaConhecimento;
                        avaliacaoExistente.Respeito_empatia = notaRespeito;
                        avaliacaoExistente.Comentario = txtComentario.Text;

                        // Atualiza no banco de dados
                        avaliacaoAdapter.Update(avaliacaoExistente);
                        MessageBox.Show("Avaliação atualizada com sucesso!");
                    }
                    else
                    {
                        // Caso não exista avaliação, faz o INSERT (caso nunca tenha avaliado)
                        avaliacaoAdapter.Insert(Idconsulta, notaAtendimento, notaTempo, notaConhecimento, notaRespeito, txtComentario.Text);
                        MessageBox.Show("Avaliação enviada com sucesso!");
                    }

                    // Desabilita o botão de envio após a avaliação
                    btnEnviarAvaliacao.Enabled = false;

                    // Desabilita as estrelas e o campo de comentário
                    DesabilitarEstrelas(estrelasAtendimento);
                    DesabilitarEstrelas(estrelasTempo);
                    DesabilitarEstrelas(estrelasConhecimento);
                    DesabilitarEstrelas(estrelasRespeito);
                    txtComentario.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar avaliação: " + ex.Message);
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            using (var avaliacaoAdapter = new tbAvaliacaoTableAdapter())
            {
                // Recupera a avaliação do banco
                var avaliacao = avaliacaoAdapter.GetData().FirstOrDefault(a => a.IdConsulta == Idconsulta);
                if (avaliacao != null)
                {
                    // Recarrega as informações da avaliação
                    notaAtendimento = avaliacao.Atendimento_comunicacao;
                    notaTempo = avaliacao.Tempo_de_espera;
                    notaConhecimento = avaliacao.Conhecimento_tecnico;
                    notaRespeito = avaliacao.Respeito_empatia;
                    txtComentario.Text = avaliacao.Comentario;

                    // Atualiza visualmente as estrelas
                    AtualizarEstrelas(estrelasAtendimento, notaAtendimento);
                    AtualizarEstrelas(estrelasTempo, notaTempo);
                    AtualizarEstrelas(estrelasConhecimento, notaConhecimento);
                    AtualizarEstrelas(estrelasRespeito, notaRespeito);

                    // Habilita o botão de enviar novamente
                    btnEnviarAvaliacao.Enabled = true;

                    // Habilita as estrelas e o campo de comentário
                    HabilitarEstrelas(estrelasAtendimento);
                    HabilitarEstrelas(estrelasTempo);
                    HabilitarEstrelas(estrelasConhecimento);
                    HabilitarEstrelas(estrelasRespeito);
                    txtComentario.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Avaliação não encontrada para esta consulta.");
                }
            }
        }

        private void HabilitarEstrelas(PictureBox[] grupo)
        {
            foreach (var pic in grupo)
            {
                pic.Enabled = true; 
            }
        }

        private void btnCancelarAvaliacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
