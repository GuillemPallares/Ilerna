using System;

namespace Calcular_Media_Modular
{
    class Program
    {
        public static double calcularNotaMedia(int[] array) 
        {
            double notaMedia = 0;

            //calculamos la nota media (suma de notas / numero de notas)

            for (int i = 0; i < array.Length; i++)
            {
                notaMedia = notaMedia + array[i];
            }

            notaMedia = notaMedia / array.Length;

            return notaMedia;
        }

        static void Main(string[] args)
        {
            int[] notas = new int[5];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Introduce la {0} nota", (i + 1));
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("La nota media del alumno es : {0}", calcularNotaMedia(notas));
        }
    }
}
