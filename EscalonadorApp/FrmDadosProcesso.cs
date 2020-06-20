using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalonadorApp
{
    public partial class FrmDadosProcesso : Form
    {
        public int Quantum { get; set; }
        public int Tamanho { get; set; }

        public FrmDadosProcesso()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Quantum = (int)nudQuantum.Value;
            Tamanho = (int)nudTamanho.Value;
            this.Close();
        }

        private void FrmDadosProcesso_Shown(object sender, EventArgs e)
        {
            nudQuantum.Focus();
            nudQuantum.Select(0, nudQuantum.Value.ToString().Length);
        }

        private void nudTamanho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirmar_Click(btnConfirmar, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void nudQuantum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudTamanho.Focus();
            }
        }
    }
}
