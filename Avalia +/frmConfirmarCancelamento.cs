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
    public partial class frmConfirmarCancelamento: Form
    {
        private string _data, _medico, _motivo, _status, _observacoes;

        public frmConfirmarCancelamento(string data, string medico, string motivo, string status, string observacoes)
        {
            InitializeComponent();

            _data = data;
            _medico = medico;
            _motivo = motivo;
            _status = status;
            _observacoes = observacoes;

            lblinfo.Text = $"Tem certeza que deseja cancelar a consulta com {medico} no dia {data}?";
        }
    }
}
