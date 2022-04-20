using System;

namespace TikTakToe
{
     class Program
    {
        static void Main(string[] args)
        {
            int jugador = 2;
            int ingreso = 0;
            bool ingresoCorrecto = true;

            CreaTablero();


            do
            {
                if(jugador == 2){
                    jugador = 1;
                    PonerXoO(jugador, ingreso);//break; //Necesitamos los "breaks" para que el resto del codigo sea accesible
                }else if (jugador == 1){
                    jugador = 2;
                    PonerXoO(jugador, ingreso);//break; Pero en este caso no son necesario porque tenemos un "do" anidado

                }

                do
                {
                    Console.WriteLine("\nJugador {0}, elija su casilla...", jugador);
                    ingreso = Convert.ToInt32(Console.ReadLine());//(Leer de derecha a izq) Lo que el usuario escriba lo convierte en un "int" y lo almacena en 'ingreso'
                


                } while (!ingresoCorrecto);

            } while (true);

            
        }


        //Metodo para identificar el jugador
        public static void PonerXoO (int jugador, int ingreso)
        {
            char signo = ' ';

            if(jugador == 1){
                signo = 'X';
            } else if(jugador == 2){
                signo = 'O';
            }

            switch (ingreso)
                        {
                            case 1: tableroJuego[0, 0] = signo; break;
                            case 2: tableroJuego[0, 1] = signo; break;
                            case 3: tableroJuego[0, 2] = signo; break;
                            case 4: tableroJuego[1, 0] = signo; break;
                            case 5: tableroJuego[1, 1] = signo; break;
                            case 6: tableroJuego[1, 2] = signo; break;
                            case 7: tableroJuego[2, 0] = signo; break;
                            case 8: tableroJuego[2, 1] = signo; break;
                            case 9: tableroJuego[2, 2] = signo; break;                            
                        }
        }

        //Array que contiene variables del juego
        static char[,] tableroJuego = 
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}

        };

        //Metodo para crear el tablero
        public static void CreaTablero()
        {
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}",tableroJuego[0,0], tableroJuego[0,1], tableroJuego[0,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}",tableroJuego[1,0], tableroJuego[1,1], tableroJuego[1,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}",tableroJuego[2,0], tableroJuego[2,1], tableroJuego[2,2]);
            Console.WriteLine("     |     |");


        }
    }
}