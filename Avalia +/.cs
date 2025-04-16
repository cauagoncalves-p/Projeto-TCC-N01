using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace testee
{
    public partial class panelComentario : Form
    {
        public panelComentario()
        {
            InitializeComponent();
        }

        private void comentarioPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.Gray, 1.5f))
            {
                var bounds = comentarioPanel.ClientRectangle;  // Usando o nome correto do painel
                bounds.Width -= 1;
                bounds.Height -= 1;
                int radius = 10;

                using (System.Drawing.Drawing2D.GraphicsPath path = RoundedRect(bounds, radius))
                {
                    g.DrawPath(pen, path);
                }
            }
        }

        private System.Drawing.Drawing2D.GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            int diameter = radius * 2;
            Rectangle arc = new Rectangle(bounds.Location, new Size(diameter, diameter));

            // Arco superior esquerdo
            path.AddArc(arc, 180, 90);

            // Arco superior direito
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Arco inferior direito
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Arco inferior esquerdo
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
