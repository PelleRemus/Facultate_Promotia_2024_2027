namespace ProblemePartial;

public class Program
{
    static void Main(string[] args)
    {
        //int[] array = { 1, 0, 4, 4, 4, 4, 0, 1, 1, 0, 1, 1, 0, 0, 0, 4, 2, 1, 1, 0, 1 };
        //Ex4Eg6(array);

        //Ex3Eg5();

        /*int[] ex1 = { 2, 3, 3, 4, 4, 4, 3 }; // putea [3, 3, 1]
        int[] ex2 = { 1, 1, 1, 1, 1, 1, 1 }; // puterea [7]
        int[] ex3 = { 1, 2, 3, 4, 5, 6, 6 }; // puterea [2, 1, 1, 1, 1, 1]
        int[] ex4 = { 2, 3, 2, 3, 2, 3 }; // puterea [3, 3]
        int[] ex5 = { 2, 3, 2, 3, 2, 3 }; // puterea [3, 3]
        Console.WriteLine(Ex1Eg6(ex1, ex5));*/

        // Console.WriteLine("5000! = " + Ex4Eg2(5000));

        //Console.WriteLine("E = ∑i^i ,i∈[1,255] = " + Ex4Eg1());

        int[,] matrix =
        {
            { 1, 2, 0, 4, 5 },
            { 6, 0, 0, 9, 0 },
            { 1, 0, 0, 0, 5 },
            { 6, 0, 0, 9, 0 },
            { 1, 2, 0, 4, 5 },
        };
        Ex2Eg19(matrix, 5, 5);
    }

    /* IV. 6. Să se construiască un algoritm care pentru un vector dat efectuează repetitiv următoarea transformare:
        De la dreapta la stânga, fiecare 2 valori diferite de 0, adiacente, de valori identice se combină ȋntr-un element cu valoare dublă
        Ex:
        1,0,4,4,4,4,0,1,1,0,1,1,0,0,0,4,2,1,1,0,1 ->
        1,0,8,8,0,2,0,2,0,0,0,8,0,1
        1,0,16,0,2,0,2,0,0,0,8,0,1

        Ex:
        1,1,1,1,2,1,1,1,1,1,1,1,1
        2,2,4,2,2,2
        4,4,2,4
        8,2,4
        (Un pic cam simpla pentru problemele din acest capitol)
    */
    static void Ex4Eg6(int[] array)
    {
        bool hasCombined = true;
        while (hasCombined)
        {
            hasCombined = false;
            List<int> list = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i > 0 && array[i] != 0 && array[i] == array[i - 1])
                {
                    i--;
                    hasCombined = true;
                    int current = array[i] * 2;
                    while (i > 0 && current == array[i - 1])
                    {
                        current *= 2;
                        i--;
                    }
                    list.Add(current);
                }
                else if (i >= 0)
                {
                    list.Add(array[i]);
                }
            }

            list.Reverse();
            array = list.ToArray();
        }
    }

    // IV. 2. Afisati toate cifrele lui 5000!
    static BigInt Ex4Eg2(int number) // Factorial
    {
        if (number == 0 || number == 1)
            return new BigInt(1);
        return Ex4Eg2(number - 1) * new BigInt(number);
    }

    /* IV. 1. Scrieți un program C# care afișează toate cifrele expresiei (E) unde
                E = ∑i^i ,i∈[1,255]
    */
    static BigInt Ex4Eg1()
    {
        BigInt result = new BigInt(new byte[1000000000], 1000000000);
        for (int i = 1; i <= 2; i++)
        {
            result = result + (new BigInt(i) ^ i);
        }
        return result;
    }

    // III. 5. Transformarea unui numar (din scriere araba) in scriere romana, eventual cu extensie
    static void Ex3Eg5()
    {
        char[] letters = { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
        int[] equivalents = { 1000, 500, 100, 50, 10, 5, 1 };

        int number = 2948; // MMCM XLVIII
        string result = "";

        for (int i = 0; i < letters.Length; i++)
        {
            while (number >= equivalents[i])
            {
                result = result + letters[i];
                number = number - equivalents[i];
            }

            // pentru 1000 si 500, vrem valoarea 100 (pentru indicii 0 si 1, vrem indicele 2)
            int index = i + (i + 1) % 2 + 1;
            if (index < letters.Length)
            {
                int difference = equivalents[i] - equivalents[index];
                if (number >= difference)
                {
                    result = result + letters[index] + letters[i];
                    number = number - difference;
                }
            }
        }
        Console.WriteLine(result);
    }

    /* II. 19. Sa se determine cel mai mare "platou" din matrice
        Platou = o regiune din matrice cu aceeasi valoare care se intersecteaza adiacent (in sus, jos, stanga dreapta)
        Ex:
        1 2 0 4 5
        6 0 0 9 0
        1 0 0 0 5
        6 0 0 9 0
        1 2 0 4 5
        Afisare: platou de dimensiune 9 cu valoarea 0

    */
    static void Ex2Eg19(int[,] matrix, int n, int m)
    {
        bool[,] visited = new bool[n, m];
        int max = 0, maxValue = 0;

        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                int current = Platou(matrix, visited, matrix[i, j], i, j, n, m);
                if (current > max)
                {
                    max = current;
                    maxValue = matrix[i, j];
                }
                else if (current == max && matrix[i, j] > maxValue)
                {
                    maxValue = matrix[i, j];
                }
            }

        Console.WriteLine($"Platoul maxim este de dimensiune {max} cu valoarea {maxValue}");
    }

    static int Platou(int[,] matrix, bool[,] visited, int value, int i, int j, int n, int m)
    {
        if (i < 0 || i >= n || j < 0 || j >= m || matrix[i, j] != value || visited[i, j])
            return 0;

        visited[i, j] = true;
        return 1 + Platou(matrix, visited, value, i - 1, j, n, m)
            + Platou(matrix, visited, value, i, j + 1, n, m)
            + Platou(matrix, visited, value, i + 1, j, n, m)
            + Platou(matrix, visited, value, i, j - 1, n, m);
    }

    /* I. 6. Definim puterea unui vector ca fiind numărul maxim de valori identice urmate de următorul maxim de valori identice ș.a.m.d.
        Ex1: 2,3,3,4,4,4,3 va avea puterea (3,3,1) deoarece există 3 de 4, 3 de 3 și un 2.
        Ex2: 1,1,1,1,1,1,1 va avea puterea (7) deoarece există 7 de 1
        Ex3: 1,2,3,4,5,6,6 va avea puterea (2,1,1,1,1,1)
        Ex4: 1,2,3,1,2,3,1,2,3 va avea puterea (3,3,3)

        [2A]Construiți o funcție care primește argument un vector și returnează vectorul reprezentând puterea acestuia.

        [2B]Construiți o funcție care primește argument 2 vectori (v și u) și returnează -1 dacă puterea lui u este mai mică decât v,
            1 ȋn caz contrar și 0 dacă cei doi vectori au puteri egale. Un vector are putere mai mare față de alt vector
            dacă valoarea cea mai semnificativă este mai mare decât valoarea corespunzătoare din vectorul al doi-lea.
        ȋn exemplele anterioare vectorul de la Ex2 are puterea cea mai mare (7), după care Ex4 (3,3,3), Ex1 (3,3,1) și ultimul Ex3 (2,1,...).
    */
    // A)
    static int[] ArrayPower(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        int[] frequency = new int[max + 1];
        for (int i = 0; i < array.Length; i++)
        {
            frequency[array[i]]++;
        }

        // Voi faceti cu bubble sort
        Array.Sort(frequency);
        int[] result = frequency.Reverse().Where(number => number != 0).ToArray();

        for (int i = 0; i < result.Length; i++)
            Console.Write(result[i] + " ");
        Console.WriteLine();

        return result;
    }

    // B)
    static int Ex1Eg6(int[] v, int[] u)
    {
        int[] vPower = ArrayPower(v);
        int[] uPower = ArrayPower(u);

        int n = Math.Min(vPower.Length, uPower.Length);
        for (int i = 0; i < n; i++)
        {
            if (uPower[i] < vPower[i])
                return -1;
            if (uPower[i] > vPower[i])
                return 1;
        }

        if (vPower.Length == uPower.Length)
            return 0;
        if (uPower.Length < vPower.Length)
            return -1;
        return 1;
    }

    /* I. 2. Se consideră fişierul data.in ce conţine cel mult un milion de numere naturale separate prin spatii, 
        fiecare număr având cel mult nouă cifre.
        a) Scrieţi un program C/C++ care citeşte toate numerele din fişierul BAC.TXT şi determină,
        folosind un algoritm eficient din punct de vedere timpului de executare,
        cele mai mari două numere de trei cifre care nu se află în fişier. Cele două numere vor fi afişate pe ecran
        în ordine descrescătoare, cu un spaţiu între ele. Dacă nu pot fi determinate două astfel de
        numere, programul va afişa pe ecran valoarea 0.
        Exemplu: dacă fişierul data.in conţine numerele:
        12 2345 123 67 989 6 999 123 67 989 999
        atunci programul va afişa
        998 997
    */
    static void Ex1Eg2(string filePath)
    {
        string text = File.ReadAllText(filePath);
        string[] strings = text.Split(' ');
        int[] numbers = new int[strings.Length];

        for (int i = 0; i < strings.Length; i++)
        {
            numbers[i] = int.Parse(strings[i]);
        }

        // Vector de frecventa / aparitii
        int[] frecventa = new int[1000];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 1000)
                frecventa[numbers[i]]++;
        }

        int a = 0, b = 0;
        for (int i = 999; i >= 100; i--)
        {
            if (frecventa[i] == 0)
            {
                if (a == 0)
                    a = frecventa[i];
                else
                {
                    b = frecventa[i];
                    break;
                }
            }
        }

        if (b == 0)
            Console.WriteLine("nu eista");
        else
            Console.WriteLine(a + " " + b);
    }
}
