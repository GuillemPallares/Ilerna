using System;

namespace Actividad_de_Desarrollo_1_UF1
{
    class Program
    {
        static void Main(string[] args)
        {
            int filasA, filasB, columnasA, columnasB;

            //Utilizaremos esta variable para el control de loops while.
            int l = 0;

            int[,] matrizA, matrizB;

            Console.Title = "Actividad_de_Desarrollo_1_UF1";

            Console.Clear();

        #region 1. Se deberá pedir el número de filas y de columnas que deberá tener la primera matriz.

            Console.WriteLine("Primera Matriz");
            
            Console.WriteLine("Introduzca el número de FILAS deseado:"); 

            //Reseteamos la variable de control para iniciar el loop.
            l = 0;

            do
            {
                if(l > 0){
                    Console.WriteLine("*El valor de FILAS ha de ser un Número ENTERO POSITIVO"); 
                    //Creamos un número máximo de intentos para evitar bucles infinitos.
                    if (l > 5){
                        Console.WriteLine("Número de intentos superado"); 

                        Environment.Exit(0);
                    }
                }
                try {
                    filasA = Convert.ToInt32(Console.ReadLine());
                } 
                catch {
                    filasA = 0;
                }
                l++;
                
            } while (filasA <= 0);

            Console.WriteLine("Introduzca el número de COLUMNAS deseado:");

            //Reseteamos la variable de control para iniciar el loop.
            l = 0;

            do
            {
                if(l > 0){
                    Console.WriteLine("*El valor de COLUMNAS ha de ser un Número ENTERO POSITIVO"); 
                    //Creamos un número máximo de intentos para evitar bucles infinitos.
                    if (l > 5){
                        Console.WriteLine("Número de intentos superado"); 

                        Environment.Exit(0);
                    }
                }
                try {
                    columnasA = Convert.ToInt32(Console.ReadLine());
                } 
                catch {
                    columnasA = 0;
                }
                l++;
                
            } while (columnasA <= 0);


        #endregion

        #region 2. Se deberá pedir el número de filas y de columnas que deberá tener la segunda matriz.

            Console.WriteLine("\nSegunda Matriz");

            Console.WriteLine("Introduzca el número de FILAS deseado:"); 

            //Reseteamos la variable de control para iniciar el loop.
            l = 0;

            do
            {
                if(l > 0){
                    Console.WriteLine("*El valor de FILAS ha de ser un Número ENTERO POSITIVO"); 
                    //Creamos un número máximo de intentos para evitar bucles infinitos.
                    if (l > 5){
                        Console.WriteLine("Número de intentos superado"); 

                        Environment.Exit(0);
                    }
                }
                try {
                    filasB = Convert.ToInt32(Console.ReadLine());
                } 
                catch {
                    filasB = 0;
                }
                l++;
                
            } while (filasB <= 0);

            Console.WriteLine("Introduzca el número de COLUMNAS deseado:");

            //Reseteamos la variable de control para iniciar el loop.
            l = 0;

            do
            {
                if(l > 0){
                    Console.WriteLine("*El valor de COLUMNAS ha de ser un Número ENTERO POSITIVO"); 
                    //Creamos un número máximo de intentos para evitar bucles infinitos.
                    if (l > 5){
                        Console.WriteLine("Número de intentos superado"); 

                        Environment.Exit(0);
                    }
                }
                try {
                    columnasB = Convert.ToInt32(Console.ReadLine());
                } 
                catch {
                    columnasB = 0;
                }
                l++;
                
            } while (columnasB <= 0);

        #endregion

        #region 3. El usuario introducirá los elementos de la primera matriz.

            matrizA = new int[filasA, columnasA];


            // Al hablar de filas y utlizar el valor filas no empezamos en cero y utilizamos <= para mayor comprensibilidad
            for (int i = 1; i <= filasA; i++)
            {
                for (int j = 1; j <= columnasA; j++)
                {
                    Console.Clear();
                    Console.WriteLine("\nPrimera Matriz [{0}, {1}]", filasA, columnasA);

                    for (int ii = 0; ii < filasA; ii++)
                    {
                    Console.Write("|");
                        for (int jj = 0; jj < columnasA; jj++)
                        {
                            if (ii + 1 == i && jj + 1 == j)
                            {
                                Console.Write(" {0,2} ", "a");
                            }else {
                                Console.Write(" {0,2} ", matrizA [ii,jj]);
                            }
                        }
                    Console.WriteLine("|");
                    }

                    Console.WriteLine("Introduzca el VALOR Correspondiente a la posicion a({0},{1})", i,j);
                    matrizA[i-1,j-1] = Convert.ToInt32(Console.ReadLine());
                }
            }

        #endregion

        #region 4. El usuario introducirá los elementos de la segunda matriz.

            matrizB = new int[filasB, columnasB];


            // Al hablar de filas y utlizar el valor filas no empezamos en cero y utilizamos <= para mayor comprensibilidad
            for (int i = 1; i <= filasB; i++)
            {
                for (int j = 1; j <= columnasB; j++)
                {
                    Console.Clear();
                    Console.WriteLine("\nSegunda Matriz [{0}, {1}]", filasB, columnasB);
                    
                    for (int ii = 0; ii < filasB; ii++)
                        {
                        Console.Write("|");
                            for (int jj = 0; jj < columnasB; jj++)
                            {
                                if (ii + 1 == i && jj + 1 == j)
                                {
                                    Console.Write(" {0,2} ", "a");
                                }else {
                                    Console.Write(" {0,2} ", matrizB [ii,jj]);
                                }
                            }
                        Console.WriteLine("|");
                        }
                    Console.WriteLine("Introduzca el VALOR Correspondiente a la posicion a({0},{1})", i,j);
                    matrizB[i-1,j-1] = Convert.ToInt32(Console.ReadLine());
                    
                }
            }
        #endregion

            Console.Clear();

        #region 5. Se mostrará por pantalla el contenido de la primera matriz.

            Console.WriteLine("Primera Matriz [{0}, {1}]\n", filasA, columnasA);

            for (int i = 0; i < filasA; i++)
            {
            Console.Write("|");
                for (int j = 0; j < columnasA; j++)
                {
                    Console.Write(" {0,2} ", matrizA [i,j]);
                }
            Console.WriteLine("|");
            }
        #endregion

        #region 6. Se mostrará por pantalla el contenido de la segunda matriz

            Console.WriteLine("\nSegunda Matriz [{0}, {1}]\n", filasB, columnasB);

                for (int i = 0; i < filasB; i++)
                {
                Console.Write("|");
                    for (int j = 0; j < columnasB; j++)
                    {
                        Console.Write(" {0,2} ", matrizB [i,j]);
                    }
                Console.WriteLine("|");
                }
            Console.WriteLine("\n");
        #endregion

        #region 7. El programa deberá comprobar si las matrices se pueden comparar o no con la siguiente salida por pantalla.
            
            // Comprobación de si se pueden comparar.
            /* Para saber si se pueden compara las matrices han de tener mismo número de filas y columnas */
            if (filasA == filasB && columnasA == columnasB)
            {
                Console.WriteLine("Las matrices pueden ser comparadas");
                
                // Comprobación de si son iguales.
                /* Comprobamos los valores uno a uno con un for loop anidado en otro for loop y le obligamos 
                   a parar el proceso una vez encontramos una desigualdad.*/              
                for (int i = 0; i < filasA; i++)
                {
                    for (int j = 0; j < columnasA; j++)
                    {
                        if (matrizA[i,j] == matrizB[i,j])
                        {

                        }else {
                            Console.WriteLine("Las matrices no son iguales");
                            return;
                            
                        }
                    }
                }
                Console.WriteLine("Las matrices son iguales"); 

            } else {
                Console.WriteLine("Las matrices no pueden ser comparadas");
            }

        #endregion

        }
    }
}
