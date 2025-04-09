namespace ProblemePartial
{
    public class BigInt
    {
        public byte[] digits;
        public int n = 0;

        public BigInt(int baseNumber)
        {
            // Calculam numarul de cifre (in n)
            int temporary = baseNumber;
            while (temporary > 0)
            {
                n++;
                temporary = temporary / 10;
            }

            // Initialiam vectorul de cifre
            digits = new byte[n];
            // Punem toate cifrele in vectorul de cifre
            for (int i = 0; i < n; i++)
            {
                digits[i] = (byte)(baseNumber % 10);
                baseNumber = baseNumber / 10;
            }
            // Pentru ca am inceput cu ultima cifra, trebuie inversate
            digits = digits.Reverse().ToArray();
        }
        public BigInt(byte[] digits, int n)
        {
            this.digits = new byte[n];
            for (int i = 0; i < n; i++)
            {
                this.digits[i] = digits[i];
            }
            this.n = n;
        }

        public static BigInt operator +(BigInt a, BigInt b)
        {
            // Determinam numarul maxim de cifre pentru adunare
            if (b.n > a.n)
            {
                BigInt temporary = a;
                a = b;
                b = temporary;
            }
            int n = a.n + 1;

            // Initializam vectorul de cifre. La inceput, avem cifrele lui a
            byte[] c = new byte[n];
            for (int i = 0; i < a.n; i++)
            {
                c[i + 1] = a.digits[i];
            }

            // Facem suma cifra cu cifra, incepand cu ultima, folosind cifrele lui b.
            // Deocamdata nu conteaza daca ajungem cu "cifre" mai mari decat 9
            for (int i = 0; i < b.n; i++)
            {
                c[n - i - 1] += b.digits[b.n - i - 1];
            }

            BigInt result = new BigInt(c, n);
            result.ConvertToDigits();
            return result;
        }

        public static BigInt operator *(BigInt a, BigInt b)
        {
            // Determinam numarul maxim de cifre pentru adunare
            int n = a.n + b.n;

            // Initializam vectorul de cifre.
            if (b.n > a.n)
            {
                BigInt temporary = a;
                a = b;
                b = temporary;
            }

            BigInt c = new BigInt(new byte[n], n);

            // Facem mai multe produse pe cifre astfel:
            // Ultima cifra a celui mai scurt numar se inmulteste cu toate cifrele
            // celui mai lung numar, si la fel pentru toate cifrele celui scurt
            // Dupa care, vom face suma acestora
            for (int i = b.n - 1; i >= 0; i--)
            {
                byte[] digits = new byte[a.n + b.n - i - 1];
                for (int j = 0; j < a.n; j++)
                {
                    digits[j] = a.digits[j];
                }

                BigInt temporary = new BigInt(digits, a.n + b.n - i - 1);
                for (int j = a.n - 1; j >= 0; j--)
                {
                    temporary.digits[j] = (byte)(temporary.digits[j] * b.digits[i]);
                }
                c = c + temporary;
            }

            c.RemoveLeadingZeros();
            return c;
        }

        public static BigInt operator ^(BigInt number, int power)
        {
            byte[] digits = new byte[1000000000];
            digits[999999999] = 1;

            BigInt result = new BigInt(digits, 1000000000);
            for (int i = 0; i < power; i++)
            {
                result = result * number;
            }
            result.RemoveLeadingZeros();
            return result;
        }

        public void ConvertToDigits()
        {
            for (int i = n - 1; i > 0; i--)
            {
                if (digits[i] > 9)
                {
                    digits[i - 1] = (byte)(digits[i - 1] + digits[i] / 10);
                    digits[i] = (byte)(digits[i] % 10);
                }
            }
        }

        public void RemoveLeadingZeros()
        {
            int count = 0;
            while (digits[count] == 0)
            {
                count++;
            }

            if (count == 0)
                return;

            n = n - count;
            byte[] newDigits = new byte[n];
            for (int i = 0; i < n; i++)
            {
                newDigits[i] = digits[count + i];
            }

            digits = newDigits;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result = $"{result}{digits[i]}";
            }
            return result;
        }
    }
}
