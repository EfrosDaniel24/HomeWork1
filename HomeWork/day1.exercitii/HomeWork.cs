using System;

class Program
{
    static void Main()
    {
        int numar;
        bool esteValabil;

        // Partea a)
        do
        {
            Console.Write("Introduceti un numar cu minim 3 cifre: ");
            string input = Console.ReadLine();
            esteValabil = int.TryParse(input, out numar);

            if (!esteValabil)
            {
                Console.WriteLine("Nu ati introdus un numar valid. Incercati din nou.");
            }
            else if (numar < 100)
            {
                Console.WriteLine("Numarul introdus nu are minim 3 cifre. Incercati din nou.");
                esteValabil = false;
            }
        }
        while (!esteValabil);

        // Partea b)
        int oglinda = CalculaOglinda(numar);
        Console.WriteLine($"Numarul introdus este: {numar}");
        Console.WriteLine($"Valoarea in oglinda a numarului este: {oglinda}");

        // Partea c)
        VerificaPatratPerfect(oglinda);
    }

    static int CalculaOglinda(int numar)
    {
        string numarString = numar.ToString();
        char[] caractere = numarString.ToCharArray();
        Array.Reverse(caractere);
        string oglindaString = new string(caractere);
        return int.Parse(oglindaString);
    }

    static void VerificaPatratPerfect(int numar)
    {
        if (numar < 0)
        {
            Console.WriteLine($"{numar} nu este un numar pozitiv, deci nu poate fi un patrat perfect.");
            return;
        }

        int radacina = (int)Math.Sqrt(numar);
        if (radacina * radacina == numar)
        {
            Console.WriteLine($"{numar} este un patrat perfect. Este {radacina} * {radacina}.");
        }
        else
        {
            Console.WriteLine($"{numar} nu este un patrat perfect.");
        }
    }
}

