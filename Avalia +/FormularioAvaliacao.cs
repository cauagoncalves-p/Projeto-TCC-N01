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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
            {
                // Busca os dados da consulta
                var consulta = consultaAdapter.GetData().FirstOrDefault(c => c.IdConsulta == Idconsulta);
                if (consulta == null)
                {
                    MessageBox.Show("Consulta não encontrada.");
                    return;
                }

                // Busca médico
                var medico = medicoAdapter.GetData().FirstOrDefault(m => m.IdMedico == consulta.IdMedico);
                string nomeMedico = medico != null ? $"{medico.Nome} {medico.Sobrenome}" : "Desconhecido";
                string especialidade = medico != null ? $"{medico.Especialidade}" : "Não informado";
                string crm = medico != null ? $"{medico.CRM}" : "Não informado";

                // Preenche os campo
                lblNomeMedico.Text = $"Dr(a) {nomeMedico.ToUpper()}";
                lblEspecialidadeEcrm.Text = $"{especialidade} ° {crm}"; 
            }
        }

        private void btnEnviarAvaliacao_Click(object sender, EventArgs e)
        {
            // Exemplo de envio (você vai adaptar conforme sua tabela e DAL/Adapter)
            tbAvaliacaoTableAdapter avaliacaoAdapter = new tbAvaliacaoTableAdapter();
            string comentario = txtComentario.Text;
            try
            {
                avaliacaoAdapter.Insert(Idconsulta,comentario,notaAtendimento, notaTempo, notaConhecimento, notaRespeito);
                MessageBox.Show("Avaliação enviada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar avaliação: " + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }
    }
    
}
