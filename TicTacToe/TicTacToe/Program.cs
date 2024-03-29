﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        // Crear arreglo bidimensional
        static int[,] tablero = new int[3, 3]; // 3 filas 3 columnas
        // crear un arreglo parasimbolos del tablero
        static char[] simbolo = { ' ', 'O', 'X' };

        static void Main(string[] args)
        {
            bool terminado = false;
            // Dibuja el tablero
            DibujarTablero();
            Console.WriteLine("Jugador 1 = O\nJugador 2 = X");

            do
            {
                //turno jugador 1
                PreguntarPosicion(1); //Envia valor 1 a la funcion

                //Dibujar la casilla despues de preguntar la posicion
                DibujarTablero();

                //Comprueba el tablero si ha ganado
                terminado = ComprobarGanador();

                if (terminado == true)
                {
                    Console.WriteLine("El Jugador 1 Ha Ganado");
                }
                else //Comprueba si hay empate
                {
                    terminado = ComprobarEmpate();
                    if (terminado == true)
                    {
                        Console.WriteLine("Es Empate!");
                    }
                    // si jugador 1 no gano, empato, da turno a jugador 2
                    else
                    {
                        // Turno del jugador 2
                        PreguntarPosicion(2);
                        //Dibuja de Jugador 2 despues de preguntar
                        DibujarTablero();
                        //Comprobar si Jugador 2 gano
                        terminado = ComprobarGanador();

                        if(terminado == true)
                        {
                            Console.WriteLine("El Jugador 2 Ha Gando!");
                        }
                    }
                    
                }
                //Repetir hasta encontrar 3 iguales en linea
            } while (terminado == false); // mientras la varibale sea igual a false, se repite el ciclo

        } // Cierre de MAIN
        static void DibujarTablero()
        {
            // Variables de conteo
            int fila = 0;
            int columna = 0;

            Console.WriteLine(); // Margen del tablero
            Console.WriteLine("-------------"); // dibuja la linea horizontal
            for(fila = 0; fila < 3; fila ++)
            {
                Console.Write("|"); //Dibuja la primera linea vertical
                for(columna = 0; columna <3; columna++)
                {
                    // Asigna un: Espacio, O, X, segun corresponda
                    Console.Write(" {0} |", simbolo[tablero[fila,columna]]); // Dibuja las demas lineas verticales
                }
                Console.WriteLine();
                Console.WriteLine("-------------"); // lineas horizontales
            }
        }
        
        // Pregunta donde poner la ficha
        static void PreguntarPosicion(int jugador) // 1 = Jugador 1 ; 2 Jugador 2
        {
            int fila, columna;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Turno del Jugador: {0}", jugador);
                // Pedir el numero de Fila
                do
                {
                    Console.Write("Selecciona la fila (1 a la 3 ): ");
                    fila = Convert.ToInt32(Console.ReadLine());

                } while ((fila < 1) || (fila > 3)); // se ejecuta mientras fila sea menor a 1 o mayor a 3

                //Pedir numero de columna
                do
                {
                    Console.Write("Selecciona la columna (1 a la 3 ): ");
                    columna = Convert.ToInt32(Console.ReadLine());

                } while ((fila < 1) || (fila > 3));

                if (tablero[fila - 1, columna - 1] != 0)
                    Console.WriteLine("Casilla Ocupada!");

            } while (tablero[fila - 1, columna - 1] != 0);

            // Si todo es correcto, se le asigna al jugador correspondiente
            tablero[fila - 1, columna - 1] = jugador;
        }

        // Devolver True si hay 3 en linea
        static bool ComprobarGanador()
        {
            int fila = 0;
            int columna = 0;
            bool ticTacToe = false;

            // Si las filas son iguales y no estan vacias
            for (fila = 0; fila < 3; fila++)
            {
                if(   (tablero[fila,0] == tablero[fila,1])
                    &&(tablero[fila,0] == tablero[fila,2])
                    &&(tablero[fila,0]!= 0              ))

                {
                    ticTacToe = true;
                }
            }

            // Si alguna columna todas las casillas son iguales  y no estan vacias

            for (columna =0; columna < 3; columna ++)
            {
                if(    (tablero[columna, 0] == tablero[1,columna])
                    && (tablero[columna, 0] == tablero[2,columna])
                    && (tablero[columna, 0] != 0                ))
                {
                    ticTacToe = true;
                }
            }

            // Si en alguna diagonal todas las casillas son iguales y no estan vacias

            if (       (tablero[0 , 0] == tablero[1, 1])
                    && (tablero[0 , 0] == tablero[2, 2])
                    && (tablero[0 , 0] != 0           ))
            {
                ticTacToe = true;
            }

            if (       (tablero[0, 2] == tablero[1, 1])
                    && (tablero[0, 2] == tablero[2, 2])
                    && (tablero[0, 2] != 0           ))
            {
                ticTacToe = true;
            }

            return ticTacToe;
        }

        //Devuelve true si hay empate
        static bool ComprobarEmpate()
        {
            bool hayEspacio = false;
            int fila = 0;
            int columna = 0;

            for(fila =0; fila < 3; fila++)
            {
                for(columna = 0; columna <3; columna++)
                {
                    if(tablero[fila,columna]==0)
                    {
                        hayEspacio = true; // Si hay casillas vacias se puede seguir jugando
                    }
                }
            }

            return !hayEspacio; //si regresa un true que indica que hay espacio, entonces retorna negacion para que empate no cumpla
        }
    }
}
