using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalia__.Controles
{
    public class Mensagem_do_sistema
    {
        public void MensagemInformation(string mensagem)
        {
            MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensagemError(string mensagem)
        {
            MessageBox.Show(mensagem, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MensagemAtencao(string mensagem)
        {
            MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
