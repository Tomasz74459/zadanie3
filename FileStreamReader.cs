using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string sciezkaDoPliku = "TestowyDokument.txt";

        try
        {
            // Otwarcie istniejącego pliku za pomocą FileStream
            using (FileStream stream = new FileStream(sciezkaDoPliku, FileMode.Open, FileAccess.Read))
            {
                // Utworzenie obiektu StreamReader dla odczytu tekstu z pliku
                using (StreamReader reader = new StreamReader(stream))
                {
                    // Odczytaj zawartość pliku w pętli, dopóki nie osiągniesz końca pliku
                    while (!reader.EndOfStream)
                    {
                        string linia = reader.ReadLine(); // Odczytaj jedną linię tekstu z pliku
                        Console.WriteLine(linia); // Wyświetl odczytaną linię na konsoli
                    }
                }
            }
        }
        catch (IOException ex)
        {
            // Obsługa wyjątków związanych z operacjami wejścia/wyjścia (np. błąd dostępu do pliku)
            Console.WriteLine("Wystąpił błąd wejścia/wyjścia: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Obsługa innych wyjątków
            Console.WriteLine("Wystąpił nieoczekiwany błąd: " + ex.Message);
        }
    }
}