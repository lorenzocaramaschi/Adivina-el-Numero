//Adivina el Numero Versión 1.0.0
using System;

//Entorno del Proyecto
namespace Adivina_el_numero
{
    //Clase Ppal
    internal class Program
    {
        //Función Principal
        static void Main(string[] args)
        {
            //Cambio el nombre que aparece en la consola
            Console.Title = "Adivina el Número";

            //Meto todo dentro de un ciclo para luego chequear si el usuario quiere volver a jugar
            while (true)
            {
                //Nos presentamos ante el usuario, a la vez que lo saludamos tras captar su nombre
                Presentacion();

                //Llamamos al objeto Random para usar luego sus métodos
                Random random = new Random();

                //Usamos el metodo Next para conseguir el número aleatorio entre 1 y 10
                int numeroCorrecto = random.Next(1, 11);

                //Inicializamos la adivinanza del usuario en 0, para que entre al ciclo
                int adivinanza = 0;

                //Entra al ciclo, ya que siempre al principio la adivinanza será 0, y en consecuencia, distinta al número correcto
                while (adivinanza != numeroCorrecto)
                {
                    //Ahora si agarramos el número que intente adivinar el usuario
                    string input = Console.ReadLine();

                    //Primero verificamos que ese número no sea una letra averiguando si no puede convertirse correctamente en entero
                    if (!int.TryParse(input, out adivinanza))
                    {
                        //Si la respuesta es true, pedimos que el usuario ingrese un número
                        ImprimirMensaje(ConsoleColor.Red, "Porfavor, ingresa un número... >:v");
                        //Y continuamos con el ciclo
                        continue;
                    }

                    //En caso de que el if sea false, parseamos el número elegido por el jugador
                    adivinanza = Int32.Parse(input);

                    //Una vez parseado, chequeamos si es el número correcto
                    if (adivinanza != numeroCorrecto)
                    {
                        //Al no ser el número correcto, imprimimos un mensaje de error
                        ImprimirMensaje(ConsoleColor.Red, "Fallaste, vuelve a intentarlo! :S");
                    }


                }

                // Si el número es correcto, se corta el ciclo y imprimimos un mensaje de éxito
                ImprimirMensaje(ConsoleColor.Green, "Felicidades, acertaste el número correcto! Era el " + numeroCorrecto + " :D");

                //Luego preguntamos si el usuario quiere jugar denuevo
                Console.WriteLine("Quieres volver a jugar? o.o\nPon [S o N] (S = SI / N = NO)");
                //Leemos la respuesta del usuario y la guardamos
                string respuesta = Console.ReadLine().ToUpper();

                //Si el usuario contesta S, continua el ciclo
                if (respuesta == "S")
                {
                    continue;
                }
                //Si el usuario contesta N, acaba el ciclo
                else if (respuesta == "N")
                {
                    return;
                }
                //Si el usuario contesta EASTEREGG, recibe un bucle infinito
                else if (respuesta == "EASTEREGG")
                {
                    Console.WriteLine(":O Descubriste el mensaje secreto. Te felicito. Ahora Estas condenado por siempre a ver emotes >:V");
                    int a = 0;
                    int b = 1;
                    while (a != b)
                    {
                        Console.WriteLine(":D\n:(\n:S\n:P\n:3\n:v\nPara cancelar presiona Control+C o simplemente cierra la ventana >:)");
                    }
                }
                //Contestando cualquier otra letra, el ciclo también termina, con un mensaje de consola antes
                else
                {
                    ImprimirMensaje(ConsoleColor.DarkYellow, "(O_o) Eso no estaba en las opciones, pero supongo que es un no...");
                    return;
                }


            }


        }

        static void ImprimirMensaje(ConsoleColor color, string mensaje)
        {

            Console.ForegroundColor = color;

            Console.WriteLine(mensaje);

            Console.ResetColor();
        }

        static void Presentacion()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            string autor = "Lorenzo Caramaschi";

            string version = "1.0.0";

            string nombreApp = "Adivina el Número";

            Console.WriteLine("{0}: Minijuego para adivinar un número en la consola. Versión {1}, por {2}.\nComo es tu nombre?", nombreApp, version, autor);

            Console.ResetColor();

            string nombre = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Hola " + nombre + ", bienvenido a Adivina el Número.\nVamos a jugar! Dime un número del 1 al 10!");

            Console.ResetColor();

        }

    }
}