using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalonadorApp
{
    public static class Ajuda
    {
        public static string Descricao(this Status status)
        {
            switch (status)
            {
                case Status.NaoSubmetido:
                    return "Não submentido";
                case Status.Pronto:
                    return "Pronto";
                case Status.Executando:
                    return "Executando";
                case Status.Espera:
                    return "Espera";
                case Status.Completo:
                    return "Completo";
                case Status.ExecutandoIO:
                    return "Executando IO";
                default:
                    return "";
            }
        }

        public static Color Cor(this Status status)
        {
            switch (status)
            {
                case Status.NaoSubmetido:
                    return Color.Gray;
                case Status.Pronto:
                    return Color.Green;
                case Status.Executando:
                    return Color.YellowGreen;
                case Status.Espera:
                    return Color.Coral;
                case Status.Completo:
                    return Color.Blue;
                case Status.ExecutandoIO:
                    return Color.LightCoral;
                default:
                    return Color.White;
            }
        }

        public static Color Cor(this StatusCPU statusCPU)
        {
            switch (statusCPU)
            {
                case StatusCPU.Inativo:
                    return Color.Red;
                case StatusCPU.Processando:
                    return Color.Green;
                default:
                    return Color.White;
            }
        }
    }

}
