namespace ProblemePartial;

public class Program
{
    static void Main(string[] args)
    {
        //int[] array = { 1, 0, 4, 4, 4, 4, 0, 1, 1, 0, 1, 1, 0, 0, 0, 4, 2, 1, 1, 0, 1 };
        //Ex4Eg6(array);

        //Ex3Eg5();

        int[] ex1 = { 2, 3, 3, 4, 4, 4, 3 }; // putea [3, 3, 1]
        int[] ex2 = { 1, 1, 1, 1, 1, 1, 1 }; // puterea [7]
        int[] ex3 = { 1, 2, 3, 4, 5, 6, 6 }; // puterea [2, 1, 1, 1, 1, 1]
        int[] ex4 = { 2, 3, 2, 3, 2, 3 }; // puterea [3, 3]
        int[] ex5 = { 2, 3, 2, 3, 2, 3 }; // puterea [3, 3]
        Console.WriteLine(Ex1Eg6(ex1, ex5));
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
}
