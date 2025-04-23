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

        private int idUsuario;
        private string emailUsuario;


        public FormularioAvaliacao(int idUsuario, string emailUsuario)
        {
            InitializeComponent();
            ConfigurarEstrelas();
            this.emailUsuario = emailUsuario;
            this.idUsuario = idUsuario;

            RadiusButton controlador = new RadiusButton();
            controlador.ConfigInicial(this, comentarioPanel , btnSair, 25, Color.White);

            tbAvaliacaoTableAdapter avaliacao = new tbAvaliacaoTableAdapter();

            //AureaMaxDataSet.tbMedicoDataTable medico = new tbMedicoTableAdapter.GetData();
            //AureaMaxDataSet.tbInstituicaoDataTable tabelaInstituicao = tbInstituicaoTableAdapter.GetData();

            //cbxInstituicao.DataSource = tabelaInstituicao;
            //cbxInstituicao.DisplayMember = "NomeInstituicao";         // Campo que aparece no ComboBox
            //cbxInstituicao.ValueMember = "IdInstituicao";  // Campo que você usa pra salvar no banco
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

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
    
}
