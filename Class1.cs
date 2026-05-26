// Realice Una calculadora con las cuatro operaciones básicas: suma, resta, multiplicación y división.

using System;
namespace calculadora
{
    class program
    {
        static void Main(string[] args)
        {
            int funcion = 0;
            int num1 = 0;   
            int num2 = 0;
            string linea;
            Console.WriteLine("Indique una funcion a realizar: ");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");

            Console.Write("Indique la funcion: ");
            linea = Console.ReadLine();
            funcion = int.Parse(linea);

            Console.Write("Ingrese el numero 1 : ");
            linea=Console.ReadLine();    
            num1=int.Parse(linea);

            Console.Write("Ingrese el numero 2 : ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            if (funcion == 1)
            {
                suma=num1 + num2;
                Console.WriteLine("La suma es: " + suma);
            }
            else
            {
                if (funcion == 2)
                {
                    if (num1 > num2)
                    {
                        resta = num1 - num2;
                        Console.WriteLine("La resta es: " + resta);
                    }
                    else
                    {
                        resta = num2 - num1;
                        Console.WriteLine("La resta es: " + resta);
                    }
                }
                else
                {
                    if(funcion == 3)
                    {
                        multiplicacion= num1 * num2;
                        Console.WriteLine("El multiplo es: " + multiplo);
                    }

                    else
                    {
                        if (funcion == 4)
                        {
                            if (num1 > num2)
                            {
                                division = num1 / num2;
                                Console.WriteLine("La division es: " + division);
                            }
                            else
                            {
                                division = num2 / num1;
                                Console.WriteLine("La division es: " + division);
                            }
                        }
                    }
                }
            }

        }
    }
}
