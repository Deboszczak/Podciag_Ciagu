using System;

namespace Podciag_Ciagu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Czy Twój ciąg jest podciągiem losowo generowanego ciągu?\nZa chwilę wygenerujemy losowy ciąg\nkliknij dowolny przycisk aby kontynuować \n");
            Console.ReadKey();
            Random random = new Random();
            int a = random.Next(50000, 100000);
            int[] tablica = new int[a];
            tablica[a - 1] = 0;
            for (int i = 0; i < a - 1; i++)
            {
                tablica[i] = random.Next(1, 10);
            }
            for (int i = 0; i < a - 1; i++)
            {
                Console.Write(tablica[i]);
            }

            Console.WriteLine("\n\nZadeklaruj długość ciągu:\n");
            int dlugosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Teraz wpisz swoje elementy ciągu (cyfry od 1 do 9) po każdym klikając enter\n");
            int[] szukana = new int[dlugosc];
            for (int i = 0; i < dlugosc; i++)
            {
                szukana[i] = int.Parse(Console.ReadLine());
            }
            int zero = 0;
            for (int i = 0; i < a; i++)
            {
                if (tablica[i] == szukana[zero])
                {
                    zero++;
                }
                else
                {
                    zero = 0;
                }
                if (zero == dlugosc)
                {
                    int odpowiedz = i + 2 - zero;
                    Console.WriteLine("\nTwój ciąg zaczyna się od liczby o indeksie " + odpowiedz);
                    Console.ReadKey();
                    break;
                }
                if (tablica[i] == 0)
                {
                    Console.WriteLine("\nPrzykro nam, ale Twój ciąg nie jest podciągiem tego ciągu");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("PS \nJak nie wierzysz to se sprawdź");
            Console.ReadKey();
        }
    }
}
