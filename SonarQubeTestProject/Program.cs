using System;

namespace SonarQubeTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Error 1: Variable no utilizada
            int unusedVar = 10;

            // Error 2: Nombre de variable poco claro
            int n = 5;

            // Error 3: Usar un método sin validación
            Console.WriteLine(DivideNumbers(10, 0));

            // Error 4: Llamada a un método vacío
            PrintMessage(null);

            // Error 5: Usar un tipo de variable inadecuado
            string result = 123.ToString();

            Console.ReadLine();
        }

        // Error 6: Método con lógica de división por 0
        static int DivideNumbers(int a, int b)
        {
            return a / b;  // Error: División por cero
        }

        // Error 7: Método innecesario o sin propósito
        static void PrintMessage(string message)
        {
            // Este método no hace nada y es innecesario
            // Error: Se debe eliminar el método vacío o usarlo correctamente
            if (message != null)
            {
                Console.WriteLine(message);
            }
        }
    }
}
