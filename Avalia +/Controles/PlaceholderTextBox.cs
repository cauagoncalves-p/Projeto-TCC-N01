using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalia__.Controles
{
    public class PlaceholderTextBox : TextBox
    {
        private string _placeholderText;
        private Color _placeholderColor = Color.Gray;
        private Color _normalColor = SystemColors.WindowText;
        private bool _isPlaceholderActive = false;

        public string PlaceholderText
        {
            get { return _placeholderText; }
            set
            {
                _placeholderText = value;
                if (!this.Focused && string.IsNullOrEmpty(this.Text))
                {
                    ShowPlaceholder();
                }
            }
        }

        public PlaceholderTextBox()
        {
            // Configura os eventos
            this.Enter += PlaceholderTextBox_Enter;
            this.Leave += PlaceholderTextBox_Leave;
            this.TextChanged += PlaceholderTextBox_TextChanged;
        }

        private void ShowPlaceholder()
        {
            if (!string.IsNullOrEmpty(_placeholderText))
            {
                base.Text = _placeholderText;
                this.ForeColor = _placeholderColor;
                _isPlaceholderActive = true;
            }
        }

        private void HidePlaceholder()
        {
            if (_isPlaceholderActive)
            {
                base.Text = "";
                this.ForeColor = _normalColor;
                _isPlaceholderActive = false;
            }
        }

        private void PlaceholderTextBox_Enter(object sender, EventArgs e)
        {
            if (_isPlaceholderActive)
            {
                HidePlaceholder();
            }
        }

        private void PlaceholderTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                ShowPlaceholder();
            }
        }

        private void PlaceholderTextBox_TextChanged(object sender, EventArgs e)
        {
            // Impede que o usuário modifique o texto do placeholder manualmente
            if (_isPlaceholderActive && this.Text != _placeholderText)
            {
                HidePlaceholder();
            }
        }

        public override string Text
        {
            get => _isPlaceholderActive ? string.Empty : base.Text;
            set
            {
                if (string.IsNullOrEmpty(value) && !this.Focused)
                {
                    ShowPlaceholder();
                }
                else
                {
                    base.Text = value;
                    this.ForeColor = _normalColor;
                    _isPlaceholderActive = false;
                }
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (string.IsNullOrEmpty(this.Text))
            {
                ShowPlaceholder();
            }
        }
    }
}
