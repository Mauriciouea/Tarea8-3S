using System;
using System.Collections.Generic;

class Navegador
{
    private Stack<string> historial;

    public Navegador()
    {
        historial = new Stack<string>();
    }

    public void VisitarPagina(string url)
    {
        historial.Push(url);
        Console.WriteLine($"Visitando: {url}");
    }

    public void Retroceder()
    {
        if (historial.Count > 1)
        {
            historial.Pop();
            Console.WriteLine($"Regresando a: {historial.Peek()}");
        }
        else
        {
            Console.WriteLine("No hay páginas anteriores.");
        }
    }

    public void MostrarHistorial()
    {
        Console.WriteLine("\nHistorial de navegación:");
        foreach (var pagina in historial)
        {
            Console.WriteLine(pagina);
        }
    }
}

class Program
{
    static void Main()
    {
        Navegador navegador = new Navegador();

        navegador.VisitarPagina("google.com");
        navegador.VisitarPagina("openai.com");
        navegador.VisitarPagina("github.com");

        navegador.Retroceder();
        navegador.MostrarHistorial();
    }
}
