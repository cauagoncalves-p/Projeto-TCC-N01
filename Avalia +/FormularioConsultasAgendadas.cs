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
    public partial class FormularioConsultasAgendadas: Form
    {
        private string codigoGerado;
        Mensagem_do_sistema mensagem_Do_Sistema = new Mensagem_do_sistema();
        public FormularioConsultasAgendadas()
        {
            InitializeComponent();
          
        }

        private void FormularioConsultasAgendadas_Paint(object sender, PaintEventArgs e)
        {
            ConfiguracaoTelas configuracaoTelas = new ConfiguracaoTelas();
            configuracaoTelas.FecharAba(this);
        }
    }
}
