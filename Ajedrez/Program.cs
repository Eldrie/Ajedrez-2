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
<<<<<<< HEAD
            Console.SetWindowPosition(0, 0); // posicion del window en las coordenadas indicadas
            Console.WindowTop = 0; // Distancia entre la parte de arriba y el window generado
            Console.WindowHeight = 40; // Tamaño de la ventana
=======
            Console.SetWindowPosition(0, 0);
            Console.WindowTop = 0;
            Console.WindowHeight = 40;
>>>>>>> origin/master

            Tablero tablero = new Tablero();
            tablero.PintaTableroInicial();
            string statusError="";

            while (true)
            {
                Console.Clear();
                tablero.PintaTableroInicial();
                if (statusError.Length > 1)
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(statusError);
                    Console.BackgroundColor = ConsoleColor.Black;
                    statusError = "";
                    
                }
                Console.Write("Siguiente Movimiento (Coordenada origen)=> ");
                string COrigen = Console.ReadLine();
                if (!ValidarCoordenada(COrigen))
                {
                    statusError = "Tu coordenada origen no es valida";
                    continue;
                }
                
                Console.Write("Siguiente Movimiento (Coordenada destino)=> ");
                string CDestino = Console.ReadLine();

                if (!ValidarCoordenada(CDestino)) 
                {
                    statusError = "Tu coordenada destino no es valida";
                    continue;
                }

<<<<<<< HEAD
            Console.WriteLine("Siguiente Movimiento (Coordenada origen) =>");
            string COrigen = Console.ReadLine();
            Console.WriteLine("Siguiente Moviemiento (Coordenada destino)=>");
            string CDestino = Console.ReadLine();

            Console.Clear(); // Borra y deja el puntero hasta arriba
            tablero.PintaTablero();
=======
                tablero.SiguienteMovimiento(int.Parse(COrigen[0].ToString()), int.Parse(COrigen[2].ToString()),
                    int.Parse(CDestino[0].ToString()), int.Parse(CDestino[2].ToString()));


                Console.Clear();
                tablero.PintaTableroInicial();
            }
>>>>>>> origin/master

            Console.Read();
        }

        private static bool ValidarCoordenada(string Coordenada)
        {
            if (Coordenada.Length == 3)
            {
                char n1 = Coordenada[0];
                char n2 = Coordenada[2];

                if ((int.Parse(n1.ToString()) > 0) && (int.Parse(n1.ToString()) < 9) &&
                    (int.Parse(n2.ToString()) > 0) && (int.Parse(n2.ToString()) < 9))
                {
                    return true;
                }
            }



            return false;
        }

       
    }
}
