namespace Practica2_ManejoDeCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1

            Console.WriteLine("EJERCICIO 1: INVERTIR PALABRAS");

            Console.Write("Introduce una oración: ");
            string oracion = Console.ReadLine();

            string resultado = InvertirPalabras(oracion);

            Console.WriteLine("Resultado:");
            Console.WriteLine(resultado);


            // Ejercicio 3

            Console.WriteLine("\nEJERCICIO 3: CAMBIAR UNA LETRA");

            Console.Write("Introduce la letra a buscar: ");
            char letraBuscar = Convert.ToChar(Console.ReadLine());

            Console.Write("Introduce la letra nueva: ");
            char letraNueva = Convert.ToChar(Console.ReadLine());

            Console.Write("Introduce una oración: ");
            string texto = Console.ReadLine();

            string textoModificado = CambiarLetra(texto, letraBuscar, letraNueva);

            Console.WriteLine("Resultado:");
            Console.WriteLine(textoModificado);


            // Ejercicio 6

            Console.WriteLine("\nEJERCICIO 6: CREAR ACRÓNIMO");

            Console.Write("Introduce una frase: ");
            string frase = Console.ReadLine();

            string acronimo = CrearAcronimo(frase);

            Console.WriteLine("Acrónimo:");
            Console.WriteLine(acronimo);

            Console.ReadKey();
        }


        //  1

        static string InvertirPalabras(string texto)
        {
            string[] palabras = texto.Split(' ');
            string resultado = "";

            for (int i = palabras.Length - 1; i >= 0; i--)
            {
                resultado = resultado + palabras[i] + " ";
            }

            return resultado;
        }


        //  3

        static string CambiarLetra(string texto, char letraBuscar, char letraNueva)
        {
            string resultado = "";

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == letraBuscar)
                {
                    resultado = resultado + letraNueva;
                }
                else
                {
                    resultado = resultado + texto[i];
                }
            }

            return resultado;
        }


        //  6

        static string CrearAcronimo(string frase)
        {
            string[] palabras = frase.Split(' ');
            string acronimo = "";

            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length > 0)
                {
                    acronimo = acronimo + palabras[i][0];
                }
            }

            acronimo = acronimo.ToUpper();

            return acronimo;
        }
    }
}