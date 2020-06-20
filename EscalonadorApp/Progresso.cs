using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalonadorApp
{
    public partial class Progresso : Panel
    {

        private int maximo;
        private int valor;
        public int Maximo
        {
            get
            {
                return maximo;
            }
            set
            {
                maximo = value;
            }
        }
        public int Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }

        public Progresso()
        {
            InitializeComponent();
        }

        public Progresso(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rct = new Rectangle(1, 1, Width, Height-1);
            SolidBrush sb = new SolidBrush(Color.Gray);
            e.Graphics.FillRectangle(sb, rct);

            if ((maximo > 0) && (valor > 0))
            {
                var percentual = ((decimal)valor / (decimal)maximo);

                var Largura = (int)decimal.Round((Width * percentual),0);
                Rectangle rctprc = new Rectangle(1, 1, Largura, Height - 1);
                sb.Color = Color.Green;
                e.Graphics.FillRectangle(sb,rctprc);
            }

            sb.Color = Color.White;
            e.Graphics.DrawString(
                string.Format("{0}/{1}", valor, maximo),
                new Font("Arial", 6, FontStyle.Regular),
                sb, 1, 2);
        }

    }
}
