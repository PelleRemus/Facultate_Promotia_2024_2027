using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemePartial
{
    public static class RezorvarePartial
    {
        // R1. 1.
        public static void R1Ex1(string path)
        {
            var powers = new Dictionary<int, int>();
            int a = 1;
            powers[a] = 0;
            while (1_000_000_000F / 13 > a)
            {
                a = a * 13;
                powers[a] = 0;
            }

            string allText = File.ReadAllText(path);
            allText = allText.Replace(Environment.NewLine, " ");
            string[] split = allText.Split(' ');

            for (int i = 0; i < split.Length; i++)
            {
                int number = int.Parse(split[i]);
                if (powers.ContainsKey(number))
                {
                    powers[number]++;
                }
            }

            foreach (int key in powers.Keys)
            {
                while (powers[key] > 0)
                {
                    Console.Write(key + " ");
                    powers[key]--;
                }
            }
        }

        // R1. 2.
        public static bool R1Ex2(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int k = 0; k < Math.Min(n, m) / 2; k++)
            {
                int suma = 0;
                for (int i = k; i < n - k - 1; i++)
                    suma += matrix[k, i];
                for (int i = k; i < n - k - 1; i++)
                    suma += matrix[i, n - k - 1];
                for (int i = k; i < n - k - 1; i++)
                    suma += matrix[n - k - 1, n - i - 1];
                for (int i = k; i < n - k - 1; i++)
                    suma += matrix[n - i - 1, k];

                if (suma != 13)
                    return false;
            }

            return true;
        }

        // R2. 1.
        public static void R2Ex1(string path)
        {
            var fibonacci = new Dictionary<int, int>();
            int a = 0, b = 1;
            fibonacci[a] = 0;
            fibonacci[b] = 0;
            while (a + b < 1_000_000_000)
            {
                b = b + a;
                a = b - a;
                fibonacci[b] = 0;
            }

            string allText = File.ReadAllText(path);
            allText = allText.Replace(Environment.NewLine, " ");
            string[] split = allText.Split(' ');

            for (int i = 0; i < split.Length; i++)
            {
                int number = int.Parse(split[i]);
                if (fibonacci.ContainsKey(number))
                {
                    fibonacci[number]++;
                }
            }

            foreach (int key in fibonacci.Keys)
            {
                while (fibonacci[key] > 0)
                {
                    Console.Write(key + " ");
                    fibonacci[key]--;
                }
            }
        }

        // R1/2. 4.
        public static int R1_2Ex4(string path)
        {
            string allText = File.ReadAllText(path);
            allText = allText.Replace(Environment.NewLine, ",");
            string[] split = allText.Split(',');

            List<Spectacol> spectacole = new List<Spectacol>();
            for (int i = 0; i < split.Length; i++)
            {
                spectacole.Add(new Spectacol(split[i]));
            }
            spectacole.Sort();
            // Daca nu am avea IComparable, ar trebui facut asa:
            //spectacole.Sort((a, b) => a.End - b.End);

            int scene = 0;
            while (spectacole.Count > 0)
            {
                scene++;
                Spectacol current = spectacole[0];
                spectacole.RemoveAt(0);

                for (int i = 0; i < spectacole.Count; i++)
                {
                    if (spectacole[i].Start >= current.End)
                    {
                        current = spectacole[i];
                        spectacole.RemoveAt(i);
                        i--;
                    }
                }
            }

            return scene;
        }
    }
}
