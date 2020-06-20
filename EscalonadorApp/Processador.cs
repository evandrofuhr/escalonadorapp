using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EscalonadorApp
{
    public class Processador
    {
        public List<Processo> processos;
        public Tipo tipo;
        public int cpu;
        private int tempo;
        private int tempominimoCPU = 150;
        public bool suspender;
        private int tempoio;
        private bool io;

        public Processador()
        {
            tipo = Tipo.FIFO;
            cpu = 600;
            processos = new List<Processo>();
        }

        public int AdicionaProcesso(Processo processo)
        {
            var posicao = processos.Count + 1;
            processo.posicao = posicao;
            processos.Add(processo);
            return posicao;
        }

        public void Processa()
        {
            tempo = tempominimoCPU;
            suspender = false;
            Event.SendCPU(StatusCPU.Processando);

            while (!suspender)
            {
                AtualizaFila();

                if (tipo == Tipo.FIFO)
                    ProcessaFIFO();

                if (tipo == Tipo.RoundRobin)
                    ProcessaRR();
                if (processos.Where(w=>w.status != Status.Completo).Count() == 0)
                    CPU();
            }
            Event.SendCPU(StatusCPU.Inativo);
        }

        private void ProcessaFIFO()
        {
            var processo = processos.Where(w => w.status != Status.Completo && w.restante > 0).OrderBy(o => o.posicao).FirstOrDefault();
            if (processo != null)
            {

                if (processo.restante < processo.quantum)
                    tempo = processo.restante * cpu;
                else
                    tempo = processo.quantum * cpu;

                processo.status = Status.Executando;
                processo.atualiza = true;
                Event.SendProcesso();
                var restante = processo.restante;
                if (VerificaIO())
                {
                    processo.status = Status.ExecutandoIO;
                    processo.atualiza = true;
                    Event.SendProcesso();
                }
                CPU();

                if (processo.restante < processo.quantum)
                    processo.restante = 0;
                else
                    processo.restante -= processo.quantum;
                processo.atualiza = true;
                Event.SendProcesso();
                tempo = tempominimoCPU;
            }
        }

        private bool VerificaIO()
        {
            io = false;
            tempoio = 0;
            Random rd = new Random();
            var valor = rd.Next(1,11);

            if (valor == 6)
            {
                io = true;
                tempoio = rd.Next(0, tempo * 2);
            }
            return io;
        }

        private void CPU()
        {
            if ((!io) || ((io) && tempoio < tempo))
                tempoio = 0;

            var thr = new Thread(new ThreadStart(Tempo));
            thr.Start();

            foreach (var processo in processos.Where(w => w.status != Status.Completo && w.status != Status.NaoSubmetido).ToList())
                processo.percorridos++;
            thr.Join();

            io = false;
        }

        private void Tempo()
        {
            Thread.Sleep(tempo + tempoio);
        }

        private void AtualizaFila()
        {
            var aux = 0;
            foreach (var processo in processos.OrderBy(o => o.posicao).ToList())
            {
                aux++;
                if (aux != processo.posicao)
                {
                    processo.posicao = aux;
                    processo.atualiza = true;
                }
                if (processo.status != Status.Completo)
                {
                    processo.status = Status.Pronto;
                    processo.atualiza = true;
                }
            }
            Event.SendProcesso();
        }

        private void ProcessaRR()
        {
            var processo = processos.Where(w => w.status != Status.Completo && w.restante > 0).OrderBy(o => o.posicao).FirstOrDefault();
            if(processo != null)
            {
                if (processo.restante < processo.quantum)
                    tempo = processo.restante * cpu;
                else
                    tempo = processo.quantum * cpu;

                processo.status = Status.Executando;
                processo.atualiza = true;
                Event.SendProcesso();
                if (VerificaIO())
                {
                    processo.status = Status.ExecutandoIO;
                    processo.atualiza = true;
                    Event.SendProcesso();
                }
                CPU();
                processo.status = Status.Pronto;

                if (processo.restante < processo.quantum)
                    processo.restante = 0;
                else
                    processo.restante -= processo.quantum;

                processo.posicao = processos.OrderByDescending(o => o.posicao).FirstOrDefault().posicao + 1;
                processo.atualiza = true;
                Event.SendProcesso();
                tempo = tempominimoCPU;
            }
        }

        public void ReprocessarFila()
        {
            foreach (var processo in processos.OrderBy(o => o.posicao).ToList())
            {
                processo.status = Status.NaoSubmetido;
                processo.restante = processo.tamanho;
                processo.percorridos = 0;
                processo.atualiza = true;
            }
            Event.SendProcesso();
        }
    }

    public enum Tipo
    {
        FIFO = 0,
        RoundRobin = 1
    }

    public enum StatusCPU
    {
        Inativo = 0,
        Processando = 1
    }
}
