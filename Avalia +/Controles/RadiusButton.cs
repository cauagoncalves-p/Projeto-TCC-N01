using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalia__
{
    public class RadiusButton
    {
        public static class UIHelper
        {
            public static void ArredondarBotao(Button botao, int raio)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, raio, raio, 180, 90);
                path.AddArc(botao.Width - raio, 0, raio, raio, 270, 90);
                path.AddArc(botao.Width - raio, botao.Height - raio, raio, raio, 0, 90);
                path.AddArc(0, botao.Height - raio, raio, raio, 90, 90);
                path.CloseAllFigures();

                botao.Region = new Region(path);
            }
        }

        public void ArredondarBordas(Panel panel, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(panel.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(panel.Width - raio, panel.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, panel.Height - raio, raio, raio, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }
    }
}

