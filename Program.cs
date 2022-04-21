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

            


            do
            {
                if(jugador == 2){
                    jugador = 1;
                    PonerXoO(jugador, ingreso);//break; //Necesitamos los "breaks" para que el resto del codigo sea accesible
                } else if (jugador == 1){
                    jugador = 2;
                    PonerXoO(jugador, ingreso);//break; Pero en este caso no son necesario porque tenemos un "do" anidado

                }

                CreaTablero();


                //Verifica si hay un ganador
                #region
                char [] cadaSigno = {'X', 'O'};

                foreach (char signo in cadaSigno)
                {
                    if((tableroJuego[0,0] == signo) && (tableroJuego[0,1] == signo) && (tableroJuego[0,2] == signo)
                        || (tableroJuego[1,0] == signo) && (tableroJuego[1,1] == signo) && (tableroJuego[1,2] == signo)
                        || (tableroJuego[2,0] == signo) && (tableroJuego[2,1] == signo) && (tableroJuego[2,2] == signo)
                        || (tableroJuego[0,0] == signo) && (tableroJuego[1,0] == signo) && (tableroJuego[1,2] == signo)
                        || (tableroJuego[0,1] == signo) && (tableroJuego[1,1] == signo) && (tableroJuego[2,1] == signo)
                        || (tableroJuego[0,2] == signo) && (tableroJuego[1,2] == signo) && (tableroJuego[2,2] == signo)
                        || (tableroJuego[0,0] == signo) && (tableroJuego[1,1] == signo) && (tableroJuego[2,2] == signo)
                        || (tableroJuego[0,2] == signo) && (tableroJuego[1,1] == signo) && (tableroJuego[2,0] == signo))

                        {
                            if (signo == 'X')
                                Console.WriteLine("GG! Jugador 1 WINS!");
                            else 
                                Console.WriteLine("GG! Jugador 2 WINS!");

                        Console.WriteLine("Presione cualquier tecla para reiniciar el juego");
                        Console.Read();
                        ingreso = 0;
                        Resetear();
                        
                        break;
                            
                        }
                    else if(turnos == 10){
                        Console.WriteLine("\nEmpate!");
                        Console.WriteLine("Presione cualquier tecla para reiniciar el juego");
                        Console.Read();
                        Resetear();
                        break;

                    }
                        
                }
                            
                        
              
                #endregion

                //Codigo que verifica si el valor ingresado es correcto
                #region
                do
                {
                    Console.WriteLine("\nJugador {0}, elija su casilla...", jugador);
                    try
                    {
                        ingreso = Convert.ToInt32(Console.ReadLine());//(Leer de derecha a izq) Lo que el usuario escriba lo convierte en un "int" y lo almacena en 'ingreso'

                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Por favor, ingrese un number");
                    }
                
                    if((ingreso == 1) && (tableroJuego[0,0] == '1')){
                        ingresoCorrecto = true;
                    } else if ((ingreso == 2) && (tableroJuego[0,1] == '2')){
                        ingresoCorrecto = true;
                    } else if ((ingreso == 3) && (tableroJuego[0,2] == '3')){
                        ingresoCorrecto = true;
                    } else if ((ingreso == 4) && (tableroJuego[1,0] == '4')){
                        ingresoCorrecto = true;
                    } else if ((ingreso == 5) && (tableroJuego[1,1] == '5')){
                        ingresoCorrecto = true;
                    } else if ((ingreso == 6) && (tableroJuego[1,2] == '6')){
                        ingresoCorrecto = true;
                    } else if ((ingreso == 7) && (tableroJuego[2,0] == '7')){
                        ingresoCorrecto = true;
                    } else if ((ingreso == 8) && (tableroJuego[2,1] == '8')){
                        ingresoCorrecto = true;
                    } else if ((ingreso == 9) && (tableroJuego[2,2] == '9')){
                        ingresoCorrecto = true;
                    } else {
                        Console.WriteLine("\nIngreso incorrecto, elige otro numero");
                        ingresoCorrecto = false;
                    }
                    #endregion


                } while (!ingresoCorrecto);

            } while (true);

            
        }


        //Metodo para identificar el jugador
        public static void PonerXoO (int jugador, int ingreso)
        {
            char signo = ' ';

            if(jugador == 1){
                signo = 'O';
            } else if(jugador == 2){
                signo = 'X';
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

        //Array que contiene variables del juego inicial
        static char[,] tableroJuegoInicial = 
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}

        };


        //Declarar empate
        static int turnos = 0;

        //Metodo para crear el tablero
        public static void CreaTablero()
        {
            Console.Clear(); // Limpia la pantalla, asi cada vez que haya un cambio, reflejara el cambio y no toooodas las lineas
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}",tableroJuego[0,0], tableroJuego[0,1], tableroJuego[0,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}",tableroJuego[1,0], tableroJuego[1,1], tableroJuego[1,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}",tableroJuego[2,0], tableroJuego[2,1], tableroJuego[2,2]);
            Console.WriteLine("     |     |");
            turnos++;


        }

        public static void Resetear(){
            tableroJuego = tableroJuegoInicial;
            CreaTablero();
            turnos = 0;
        }
    }
}