using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalonadorApp
{
    public partial class FrmPrincipal : Form
    {
        private Thread thrTeste;
        delegate void SetTextCallback(string text);
        delegate void AtualizaCPUCallback(StatusCPU statusCPU);
        delegate void AtualizaTelaCallback();
        delegate void AtualizaProcessoCallback();

        private Processador processador;

        public FrmPrincipal()
        {
            InitializeComponent();
            processador = new Processador();
            processador.processos = new List<Processo>();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Event.NotifyProcesso += new Event.EventNotificationProcesso(AtualizaProcesso);
            Event.NotifyCPU += new Event.EventNotificationCPU(AtualizaCPU);

            thrTeste = new Thread(new ThreadStart(Processa));
            cbTipo.SelectedIndex = 0;
        }

        private void AtualizaCPU(StatusCPU statusCPU)
        {
            if (pnlCrcCPU.InvokeRequired)
            {
                AtualizaCPUCallback d = new AtualizaCPUCallback(AtualizaCPU);
                Invoke(d, new object[] { statusCPU });
            }
            else
            {
                pnlCrcCPU.CircleColor = statusCPU.Cor();
                btnLimpar.Enabled = (statusCPU == StatusCPU.Inativo);
                cbTipo.Enabled = (statusCPU == StatusCPU.Inativo);
                nudCPU.Enabled = (statusCPU == StatusCPU.Inativo);
                btnReprocessar.Enabled = (statusCPU == StatusCPU.Inativo);
            }
        }

        private void AtualizaProcesso()
        {
            if (this.InvokeRequired)
            {
                AtualizaProcessoCallback d = new AtualizaProcessoCallback(AtualizaProcesso);
                Invoke(d,null);
            }
            else
            {
                AtualizaTela();
            }
        }

        private void AtualizaTela()
        {

            if (this.InvokeRequired)
            {
                AtualizaTelaCallback d = new AtualizaTelaCallback(AtualizaTela);
                Invoke(d, null);
            }
            else
            {
                grpCPU.Text = RetornaNomeGrupo(Grupo.CPU);
                grpEspera.Text = RetornaNomeGrupo(Grupo.Espera);
                grpPronto.Text = RetornaNomeGrupo(Grupo.Completo);

                foreach (var grupo in processador.processos.GroupBy(g => g.grupo).ToList())
                {
                    var left = 0;
                    foreach (var processo in processador.processos.Where(w=> w.grupo == grupo.Key).OrderBy(o => o.posicao))
                    {

                        if (processo.atualiza)
                        {
                            foreach (var obj in processo.objetos)
                            {
                                if (obj is Panel)
                                {
                                    //painel principal
                                    if ((int)((Panel)obj).Tag == 0)
                                    {
                                        ((Panel)obj).Parent = RetornaParent(processo.grupo);
                                        ((Panel)obj).Left = 10 + (left * 70);
                                        ((Panel)obj).Top = 15;
                                        ((Panel)obj).BackColor = processo.status.Cor();
                                        ((Panel)obj).Visible = true;
                                    }

                                    if (obj is Progresso)
                                    {
                                        //progresso
                                        if ((int)((Progresso)obj).Tag == 5)
                                        {
                                            ((Progresso)obj).Valor = processo.tamanho - processo.restante;
                                        }
                                    }
                                }

                                if (obj is Label)
                                {
                                    //quantum
                                    if ((int)((Label)obj).Tag == 2)
                                    {
                                        ((Label)obj).Text = string.Format("{0}/{1}", processo.restante, processo.tamanho);
                                    }
                                    //descricao do status
                                    if ((int)((Label)obj).Tag == 3)
                                    {
                                        ((Label)obj).Text = processo.status.Descricao();
                                    }

                                    //percorridos
                                    if ((int)((Label)obj).Tag == 4)
                                    {
                                        ((Label)obj).Text = processo.percorridos.ToString();
                                    }
                                }
                            }
                        }
                        left++;
                        processo.atualiza = false;
                    }
                    ((GroupBox)RetornaParent(grupo.Key)).Text = string.Format("{0} - {1}", RetornaNomeGrupo(grupo.Key),left);
                }
            }
        }

        private void Processa()
        {
            processador.Processa();
        }

        private void btnAddProcesso_Click(object sender, EventArgs e)
        {
            var frm = new FrmDadosProcesso();
            frm.ShowDialog(this);
            if (frm.DialogResult == DialogResult.OK)
            {
                var processo = new Processo(processador.processos.Count + 1, frm.Quantum,frm.Tamanho);
                processo.posicao = processo.numero;
                processo.atualiza = true;
                CriaObjetosProcesso(processo);
                processador.processos.Add(processo);

                AtualizaTela();
            }
            frm.Dispose();            
        }

        private Control RetornaParent(Grupo grupo)
        {
            switch (grupo)
            {
                case Grupo.CPU:
                    return grpCPU;
                case Grupo.Espera:
                    return grpEspera;
                case Grupo.Completo:
                    return grpPronto;
                default:
                    return grpPronto;
            }
        }

        private string RetornaNomeGrupo(Grupo grupo)
        {
            switch (grupo)
            {
                case Grupo.CPU:
                    return "CPU";
                case Grupo.Espera:
                    return "Espera";
                case Grupo.Completo:
                    return "Completo";
                default:
                    return "";
            }
        }

        private void CriaObjetosProcesso(Processo processo)
        {
            var painel = new Panel();
            painel.Visible = false;

            processo.objetos.Clear();
            processo.objetos.Add(painel);

            painel.Parent = this;
            painel.Width = 65;
            painel.Height = 65;
            painel.BorderStyle = BorderStyle.FixedSingle;
            painel.Left = -100;
            painel.Top = -100;
            painel.Tag = 0;

            var labelNr = new Label();
            labelNr.Parent = painel;
            labelNr.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            labelNr.ForeColor = Color.White;
            labelNr.Left = 2;
            labelNr.Top = 2;
            labelNr.Text = string.Format("Nr.:{0}", processo.numero);
            labelNr.Tag = 1;

            processo.objetos.Add(labelNr);

            var prb = new Progresso();
            prb.Parent = painel;
            prb.Left = 1;
            prb.Width = painel.Width - 4;
            prb.Height = 15;
            prb.Top = 2 + labelNr.Height;
            prb.Maximo = processo.tamanho;
            prb.Valor = 0;
            prb.Tag = 5;
            processo.objetos.Add(prb);

            /*var labelRs = new Label();
            labelRs.Parent = painel;
            labelRs.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            labelRs.ForeColor = Color.White;
            labelRs.Left = 2;
            labelRs.Top = 2 + labelNr.Height;
            labelRs.Text = string.Format("{0}/{1}", processo.restante, processo.quantum);
            labelRs.Tag = 2;

            processo.objetos.Add(labelRs);*/

            var labelSt = new Label();
            labelSt.Parent = painel;
            labelSt.Font = new Font("Microsoft Sans Serif", 5, FontStyle.Regular);
            labelSt.ForeColor = Color.White;
            labelSt.Left = 2;
            labelSt.Top = painel.Height - 10;
            labelSt.Text = processo.status.Descricao();
            labelSt.Tag = 3;

            processo.objetos.Add(labelSt);

            /*var labelPr = new Label();
            labelPr.Parent = painel;
            labelPr.Font = new Font("Microsoft Sans Serif", 6, FontStyle.Regular);
            labelPr.ForeColor = Color.White;
            labelPr.Left = painel.Width - 10;
            labelPr.Top = painel.Height - 20;
            labelPr.Text = processo.percorridos.ToString();
            labelPr.Tag = 4;

            processo.objetos.Add(labelPr);*/
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (!thrTeste.IsAlive)
            {
                foreach (var processo in processador.processos)
                    if (processo.objetos.Count > 0)
                        ((Panel)processo.objetos.ElementAt(0)).Dispose();
                processador.processos.Clear();
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thrTeste.IsAlive)
            {
                processador.suspender = true;
                thrTeste.Abort();
            }
        }

        private void btnReprocessar_Click(object sender, EventArgs e)
        {
            processador.ReprocessarFila();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            processador.tipo = (Tipo)cbTipo.SelectedIndex;
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            if (thrTeste.IsAlive)
            {
                btnCPU.Text = "CPU (Parado)";
                processador.suspender = true;
                thrTeste.Abort();
                Event.SendCPU(StatusCPU.Inativo);
            }
            else
            {
                processador.cpu = (int)nudCPU.Value;
                thrTeste = new Thread(new ThreadStart(Processa));
                thrTeste.Start();
                btnCPU.Text = "CPU (Iniciado)";
            }
        }

        private void progresso1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
