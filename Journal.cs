using System;
using System.Collections.Generic;
using System.IO;

class Programa
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();

        bool estaEjecutando = true;
        while (estaEjecutando)
        {
            // Mostrar opciones del menú
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Escribir una nueva entrada");
            Console.WriteLine("2. Mostrar el diario");
            Console.WriteLine("3. Guardar el diario en un archivo");
            Console.WriteLine("4. Cargar el diario desde un archivo");
            Console.WriteLine("5. Salir");

            // Obtener la elección del usuario
            Console.Write("Ingrese su elección: ");
            int eleccion = Convert.ToInt32(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    diario.EscribirNuevaEntrada();
                    break;
                case 2:
                    diario.MostrarDiario();
                    break;
                case 3:
                    diario.GuardarDiario();
                    break;
                case 4:
                    diario.CargarDiario();
                    break;
                case 5:
                    estaEjecutando = false;
                    break;
                default:
                    Console.WriteLine("Elección no válida. Por favor, intente nuevamente.");
                    break;
            }
        }
    }
}

class Entrada
{
    public string Pregunta { get; set; }
    public string Respuesta { get; set; }
    public DateTime Fecha { get; set; }

    public Entrada(string pregunta, string respuesta, DateTime fecha)
    {
        Pregunta = pregunta;
        Respuesta = respuesta;
        Fecha = fecha;
    }
}

class Diario
{
    private List<Entrada> entradas;

    public Diario()
    {
        entradas = new List<Entrada>();
    }

    public void EscribirNuevaEntrada()
    {
        // Lista de preguntas
        List<string> preguntas = new List<string>
        {
            "¿Con quién interactuaste hoy y te pareció más interesante?",
            "¿Cuál fue la mejor parte de tu día?",
            "¿Cómo percibiste la mano de Dios en tu vida hoy?",
            "¿Cuál fue la emoción más intensa que sentiste hoy?",
            "Si pudieras hacer algo hoy, ¿qué sería?"
        };

        // Obtener una pregunta al azar
        Random aleatorio = new Random();
        int indice = aleatorio.Next(preguntas.Count);
        string pregunta = preguntas[indice];

        // Obtener la respuesta del usuario
        Console.WriteLine(pregunta);
        string respuesta = Console.ReadLine();

        // Crear una nueva entrada y agregarla al diario
        Entrada entrada = new Entrada(pregunta, respuesta, DateTime.Now);
        entradas.Add(entrada);

        Console.WriteLine("Entrada agregada exitosamente.");
    }

    public void MostrarDiario()
    {
        if (entradas.Count == 0)
        {
            Console.WriteLine("El diario está vacío.");
        }
        else
        {
            foreach (Entrada entrada in entradas)
            {
                Console.WriteLine($"{entrada.Fecha} - {entrada.Pregunta}: {entrada.Respuesta}");
            }
        }
    }

    public void GuardarDiario()
    {
        Console.Write("Ingrese el nombre del archivo para guardar el diario: ");
        string nombreArchivo = Console.ReadLine();

        try
        {
            using (StreamWriter escritor = new StreamWriter(nombreArchivo))
            {
                foreach (Entrada entrada in entradas)
                {
                    escritor.WriteLine($"{entrada.Fecha},{entrada.Pregunta},{entrada.Respuesta}");
                }
            }

            Console.WriteLine("Diario guardado exitosamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al guardar el diario: {ex.Message}");
        }
    }

    public void CargarDiario()
    {
        Console.Write("Ingrese el nombre del archivo para cargar el diario: ");
        string nombreArchivo = Console.ReadLine();

        try
        {
            using (StreamReader lector = new StreamReader(nombreArchivo))
            {
                entradas.Clear();

                string linea;
                while ((linea = lector.ReadLine()) != null)
                {
                    string[] partes = linea.Split(',');
                    if (partes.Length == 3)
                    {
                        string fechaStr = partes[0];
                        string pregunta = partes[1];
                        string respuesta = partes[2];

                        DateTime fecha = DateTime.Parse(fechaStr);
                        Entrada entrada = new Entrada(pregunta, respuesta, fecha);
                        entradas.Add(entrada);
                    }
                }
            }

            Console.WriteLine("Diario cargado exitosamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al cargar el diario: {ex.Message}");
        }
    }
}
