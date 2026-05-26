// Validador de Contraseñas Seguras
//Crea una función que reciba una cadena de texto (una contraseña) y determine si es segura o no
//devolviendo un mensaje claro.
//Reglas a validar:
//Debe tener al menos 8 caracteres,
//incluir al menos una letra mayúscula, una minúscula, un número y un carácter especial (ej: !, @, #, $).

using System;
using System.Collections.Generic;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una contraseña:");
            string contraseña = Console.ReadLine() ?? "";

            // 1. Corrección de Longitud: Validamos si tiene menos de 8 caracteres
            if (contraseña.Length < 8)
            {
                Console.WriteLine("La contraseña debe tener al menos 8 caracteres.");
                return; // Detiene la ejecución si no cumple el tamaño mínimo
            }

            // Lista con la sintaxis moderna [] para almacenar los caracteres especiales obligatorios
            List<char> caracteresEspeciales = ['!', '@', '#', '$'];

            // Variables de control (Banderas)
            bool tieneLetra = false;
            bool tieneNumero = false;
            bool tieneEspecial = false;

            // 2. Ciclo For Correcto: Analiza carácter por carácter usando el índice [i]
            for (int i = 0; i < contraseña.Length; i++)
            {
                char caracterActual = contraseña[i];

                if (char.IsLetter(caracterActual))
                {
                    tieneLetra = true;
                }
                else if (char.IsDigit(caracterActual))
                {
                    tieneNumero = true;
                }
                else if (caracteresEspeciales.Contains(caracterActual))
                {
                    tieneEspecial = true;
                }
            }

            // 3. Veredicto Final: Se evalúa una sola vez fuera del ciclo
            if (tieneLetra && tieneNumero && tieneEspecial)
            {
                Console.WriteLine("La contraseña es segura.");
            }
            else
            {
                Console.WriteLine("La contraseña no es segura. Debe contener letras, números y al menos un símbolo (!, @, #, $).");
            }
        }
    }
}

//Codigo anterior:
using System;
namespace Prueba
{
    class program
    {
        static void Main(string[] args)
        {
            var contraseña = "";

            Console.WriteLine("Ingrese una contraseña:");
            contraseña = Console.ReadLine();

            if (contraseña.Length < 8 || contraseña.Length > 8)
            {
                Console.WriteLine("La contraseña debe tener al menos 8 caracteres");
            }

            for (int i = 0; i < contraseña.Length; i++)
            {
                if (contraseña == "Passw0r!" || contraseña == "Passw0r@" || contraseña == "Passw0r!" || contraseña == "Passw0r$") ;
                {
                    Console.WriteLine("La contraseña es segura");
                }


        else
                {
                    Console.WriteLine("La contraseña no es segura");
                }
            }
        }
    }
}

