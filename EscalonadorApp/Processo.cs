using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalonadorApp
{
    public class Processo
    {
        private int FieldRestante;
        private Status FieldStatus;
        public int numero { get; set; }
        public int quantum { get; set; }
        public int tamanho { get; set; }
        public int restante {
            get
            {
                return FieldRestante;
            }
            set {
                if (value == 0)
                    status = Status.Completo;
                FieldRestante = value;
            }
        }
        public Status status
        {
            get
            {
                return FieldStatus;
            }
            set
            {
                switch (value)
                {
                    case Status.NaoSubmetido:
                        grupo = Grupo.Espera;
                        break;
                    case Status.Pronto:
                        grupo = Grupo.CPU;
                        break;
                    case Status.Executando:
                        grupo = Grupo.CPU;
                        break;
                    case Status.Espera:
                        grupo = Grupo.Espera;
                        break;
                    case Status.Completo:
                        grupo = Grupo.Completo;
                        break;
                    case Status.ExecutandoIO:
                        grupo = Grupo.CPU;
                        break;
                    default:
                        break;
                }
                FieldStatus = value;
            }
        }
        public Grupo grupo { get; set; }
        public int posicao { get; set; }
        public List<object> objetos { get; set; }
        public int percorridos { get; set; }
        public bool atualiza { get; set; }


        public Processo(int numero,int quantum,int tamanho)
        {
            status = Status.NaoSubmetido;
            this.numero = numero;
            this.quantum = quantum;
            this.tamanho = tamanho;
            restante = tamanho;
            objetos = new List<object>();
            percorridos = 0;
            atualiza = false;
        }
    }

    public enum Status
    {
        NaoSubmetido = 0,
        Pronto = 1,
        Executando = 2,
        Espera = 3,
        Completo = 4,
        ExecutandoIO = 5
    }

    public enum Grupo
    {
        CPU,
        Espera,
        Completo
    }
}
