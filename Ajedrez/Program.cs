using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowPosition(0, 0); // posicion del window en las coordenadas indicadas
            Console.WindowTop = 0; // Distancia entre la parte de arriba y el window generado
            Console.WindowHeight = 40; // Tamaño de la ventana

            Tablero tablero = new Tablero();
            tablero.PintaTablero();

            Console.WriteLine("Siguiente Movimiento (Coordenada origen) =>");
            string COrigen = Console.ReadLine();
            Console.WriteLine("Siguiente Moviemiento (Coordenada destino)=>");
            string CDestino = Console.ReadLine();

            Console.Clear(); // Borra y deja el puntero hasta arriba
            tablero.PintaTablero();

            Console.Read();
        }
    }
}
