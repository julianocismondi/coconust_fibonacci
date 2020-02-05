using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, aux, i, cantidad;

            string linea;

            Console.Write("INGRESE CUANTOS NUMEROS DE LA SERIE DE FIBONACCI DESEA VER: ");
            linea = Console.ReadLine();
             cantidad = int.Parse(linea);
             a = 0;
             b =  1;

             for (i = 0; i < cantidad; i++){
                 aux = a;
                 a = b;
                 b = aux + a;
                 Console.WriteLine(aux);

             }


        }
    }
}
