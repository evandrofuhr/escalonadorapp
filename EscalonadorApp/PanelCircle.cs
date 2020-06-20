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
    public partial class PanelCircle : Panel
    {

        private Color circleColor;

        public Color CircleColor {
            get  {
                if (circleColor == null)
                    return BackColor;
                else
                    return circleColor;
            }
            set
            {
                circleColor = value;
                Refresh();
            }
        }

        public PanelCircle()
        {
            InitializeComponent();
        }

        public PanelCircle(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //g.DrawEllipse(Pens.Black, 0, 0, this.Width - 1, this.Height - 1);
            SolidBrush sb = new SolidBrush(CircleColor);
            g.FillEllipse(sb, 0, 0, Width-1, Height-1);
        }

        protected override void OnResize(EventArgs eventargs)
        {
            this.Width = this.Height;
            base.OnResize(eventargs);
        }
    }
}
