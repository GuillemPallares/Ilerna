using System;

namespace Videotutoria_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[5];
            double notaMedia;

            for (int i = 0; i < notas.Length ; i++)
            {
                Console.WriteLine("Introduce la {0} nota", (i + 1));
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }

            notaMedia = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                notaMedia = notaMedia + notas[i];
            }

            notaMedia = notaMedia / notas.Length;

            Console.WriteLine("La nota media del alumno es : {0}", notaMedia);
        }
    }
}
