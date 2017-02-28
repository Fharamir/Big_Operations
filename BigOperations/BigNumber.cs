using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigOperations
{
    class BigNumber
    {
        protected List<byte> Number;
        public Boolean Negative;

        // CONSTRUCTORS

        public BigNumber(string inputFromString)
        {
            Number = new List<byte>();

            if (inputFromString.Length == 0)
            {
                Number.Add(0);
                Negative = false;
            }
            else
            {
                if (inputFromString[0] == '-')
                {
                    inputFromString = inputFromString.Substring(1);
                    Negative = true;
                }
                else
                    Negative = false;

                foreach (char rf in inputFromString)
                    if (!System.Char.IsNumber(rf))
                        throw new InvalidCastException();

                char[] rev = inputFromString.ToArray();
                Array.Reverse(rev);

                foreach (char C in rev)
                {
                    byte b = Convert.ToByte(C);
                    b -= 48;
                    Number.Add(b);
                }

                CleanZeros();
            }
        }

        public BigNumber(List<byte> inputFromByteList, Boolean Negativenumber)
        {
            Number = inputFromByteList;
            Negative = Negativenumber;
            CleanZeros();
        }

        public BigNumber(int inputFromInt32)
        {
            if (inputFromInt32 < 0)
            {
                inputFromInt32 = -inputFromInt32;
                Negative = true;
            }
            else
                Negative = false;

            char[] t = inputFromInt32.ToString().ToArray();
            Array.Reverse(t);
            Number = new List<byte>();

            foreach (char C in t)
            {
                byte b = Convert.ToByte(C);
                b -= 48;
                Number.Add(b);
            }

            CleanZeros();

        }

        public BigNumber(long inputFromInt64)
        {
            if (inputFromInt64 < 0)
            {
                inputFromInt64 = -inputFromInt64;
                Negative = true;
            }
            else
                Negative = false;

            char[] t = inputFromInt64.ToString().ToArray();
            Array.Reverse(t);
            Number = new List<byte>();

            foreach (char C in t)
            {
                byte b = Convert.ToByte(C);
                b -= 48;
                Number.Add(b);
            }

            CleanZeros();
        }

        // END CONSTRUCTORS

        // OVERRIDES

        public override string ToString()
        {
            byte[] numerob;

            numerob = Number.ToArray();
            Array.Reverse(numerob);

            string numero;

            if (Negative) numero = "-";
            else numero = "";

            foreach (byte B in numerob)
                numero += Convert.ToByte(B);

            return numero;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is BigNumber))
                return false;
            else
                return (this == ((BigNumber)obj));
        }

        // END OVERRIDES

        // OPERATORS

        public static BigNumber operator  +(BigNumber A, BigNumber B)
        {
            if (A.Negative && !B.Negative)
            {
                BigNumber C = -A;
                return (B - C);
            }
            if (B.Negative && !A.Negative)
            {
                BigNumber C = -B;
                return (A - C);
            }
            
            List<byte> Result = new List<byte>();
            byte riporto = 0;

            if (A.Number.Count() >= B.Number.Count())
            {
                int a = -1;
                for (int x = 0; x < B.Number.Count(); x += 1)
                {
                    byte sum = (byte)(A.Number[x] + B.Number[x] + riporto);

                    if (sum > 9)
                    {
                        sum -= 10;
                        riporto = 1;
                    }
                    else
                        riporto = 0;

                    Result.Add(sum);
                    a = x + 1;
                }

                while (a < A.Number.Count())
                {
                    if (riporto == 1)
                    {
                        A.Number[a] += 1;
                        if (A.Number[a] > 9)
                        {
                            A.Number[a] -= 10;
                            riporto = 1;
                        }
                        else
                            riporto = 0;

                        Result.Add(A.Number[a]);
                    }
                    else
                        Result.Add(A.Number[a]);
                    a++;
                }
            }
            else
            {
                int a = -1;
                for (int x = 0; x < A.Number.Count(); x += 1)
                {
                    byte sum = (byte)(A.Number[x] + B.Number[x] + riporto);

                    if (sum > 9)
                    {
                        sum -= 10;
                        riporto = 1;
                    }
                    else
                        riporto = 0;

                    Result.Add(sum);
                    a = x + 1;
                }

                while (a < B.Number.Count())
                {
                    if (riporto == 1)
                    {
                        B.Number[a] += 1;
                        if (B.Number[a] > 9)
                        {
                            B.Number[a] -= 10;
                            riporto = 1;
                        }
                        else
                            riporto = 0;

                        Result.Add(B.Number[a]);
                    }
                    else
                        Result.Add(B.Number[a]);

                    a++;
                }
            }

            Result.Add(riporto);
            BigNumber SS = new BigNumber(Result, (A.Negative && B.Negative));
            return SS;
        }

        public static BigNumber operator  *(BigNumber A, BigNumber B)
        {
            //Controlli pre-prodotto
            if ((A == 0) || (B == 0))
                return new BigNumber("");
            //fine controlli

            BigNumber T = new BigNumber("");

            List<byte>[] Res = new List<byte>[B.Number.Count()];
            int count = 0;
            byte riporto = 0;

            foreach (byte Bbyte in B.Number)
            {
                riporto = 0;
                Res[count] = new List<byte>();
                for (int x = 0; x < count; x++) Res[count].Add(0);

                foreach (byte Abyte in A.Number)
                {
                    byte N = (byte)((Abyte * Bbyte) + riporto);
                    byte n = 0;
                    if (N > 9)
                    {
                        riporto = (byte)(N / 10);
                        n = (byte)(N - (riporto * 10));
                    }
                    else
                    {
                        riporto = 0;
                        n = N;
                    }

                    Res[count].Add(n);
                }

                if (riporto > 0)
                    Res[count].Add(riporto);

                count++;
            }

            foreach (List<byte> LB in Res)
                T = T + new BigNumber(LB, false);

            if (A.Negative ^ B.Negative) T.Negative = true;
            return T;
        }

        public static BigNumber operator  -(BigNumber A, BigNumber B)
        {
            if (A.Negative && !B.Negative)
            {
                BigNumber C = -A;
                return -(B + C);
            }
            if (B.Negative && !A.Negative)
            {
                BigNumber C = -B;
                return (A + C);
            }
            if (B.Negative && A.Negative)
            {
                BigNumber C = -A;
                B = C;
                A = -B;
            }

            List<byte> LB = new List<byte>();
            Boolean negative = false;

            if (A < B)
            {
                negative = true;
                BigNumber C = B;
                B = A;
                A = C;
            }

            byte riporto = 0;

            for (int x = 0; x < B.Number.Count(); x++)
            {
                byte n = 0;
                if (B.Number[x] > (A.Number[x] - riporto))
                {
                    n = (byte)((10 + A.Number[x]) - B.Number[x] - riporto);
                    riporto = 1;
                }
                else
                {
                    n = (byte)(A.Number[x] - B.Number[x] - riporto);
                    riporto = 0;
                }

                LB.Add(n);
            }

            int y = B.Number.Count();

            while (y < A.Number.Count())
            {
                byte n = 0;
                if ((A.Number[y] - riporto) < 0)
                {
                    n = (byte)((10 + A.Number[y]) - riporto);
                    riporto = 1;
                }
                else
                {
                    n = (byte)(A.Number[y] - riporto);
                    riporto = 0;
                }

                LB.Add(n);
                y++;
            }
            BigNumber BN = new BigNumber(LB, false);

            if (negative)
                BN.Negative = true;

            CleanZeros(BN);
            return BN;
        }
        public static BigNumber operator  -(BigNumber A)
        {
            if (A.Negative) A.Negative = false;
            else A.Negative = true;

            return A;
        }

        public static BigNumber operator  /(BigNumber A, BigNumber B)
        {
            //Controlli pre-divisione
            if ((A == 0) || (B == 0)) return new BigNumber("");
            if (B == 1) return A;
            if (B == -1) return -A;
            //fine controlli

            BigNumber C, D;
            C = A;
            D = B;
            C.Negative = false;
            D.Negative = false;            
            BigNumber Total = Quantevolte(C, D);

            if (A.Negative ^ B.Negative) Total.Negative = true;
            return Total;
        }

        public static BigNumber operator ++(BigNumber A)
        {
            Incr(A);
            return A;
        }

        public static BigNumber operator --(BigNumber A)
        {
            Decr(A);
            return A;
        }

        public static bool      operator ==(BigNumber A, BigNumber B)
        {
            if (A.Number.Count() != B.Number.Count()) return false;
            if (A.Negative != B.Negative) return false;

            Boolean res = true;
            int x = 0;
            int stop = A.Number.Count();

            while ((res) && (x < stop))
            {
                if (A.Number[x] != B.Number[x])
                    res = false;
                x++;
            }

            return res;
        }

        public static bool      operator !=(BigNumber A, BigNumber B)
        {
            return !(A == B);
        }

        public static bool      operator  <(BigNumber A, BigNumber B)
        {
            return Is_Bigger(B, A);
        }

        public static bool      operator  >(BigNumber A, BigNumber B)
        {
            return Is_Bigger(A, B);
        }

        public static bool      operator <=(BigNumber A, BigNumber B)
        {
            if (A == B) return true;
            return Is_Bigger(B, A);
        }

        public static bool      operator >=(BigNumber A, BigNumber B)
        {
            if (A == B) return true;
            return Is_Bigger(A, B);
        }


        public static BigNumber operator  +(BigNumber A, int B)
        {
            return (A + new BigNumber(B.ToString()));
        }
        public static BigNumber operator  +(int A, BigNumber B)
        {
            return (B + new BigNumber(A.ToString()));
        }

        public static BigNumber operator  *(BigNumber A, int B)
        {
            return (A * new BigNumber(B.ToString()));
        }
        public static BigNumber operator  *(int A, BigNumber B)
        {
            return (B * new BigNumber(A.ToString()));
        }

        public static BigNumber operator  -(BigNumber A, int B)
        {
            return (A - new BigNumber(B.ToString()));
        }
        public static BigNumber operator  -(int A, BigNumber B)
        {
            return (new BigNumber(A.ToString()) - B);
        }

        public static BigNumber operator  /(BigNumber A, int B)
        {
            return (A / new BigNumber(B.ToString()));
        }
        public static BigNumber operator  /(int A, BigNumber B)
        {
            return (new BigNumber(A.ToString()) / B);
        }

        public static bool      operator ==(BigNumber A, int B)
        {
            return (A == new BigNumber(B.ToString()));
        }
        public static bool      operator ==(int A, BigNumber B)
        {
            return (B == new BigNumber(A.ToString()));
        }

        public static bool      operator !=(BigNumber A, int B)
        {
            return (A != new BigNumber(B.ToString()));
        }
        public static bool      operator !=(int A, BigNumber B)
        {
            return (B != new BigNumber(A.ToString()));
        }

        public static bool      operator  <(BigNumber A, int B)
        {
            return Is_Bigger(new BigNumber(B.ToString()), A);
        }
        public static bool      operator  <(int A, BigNumber B)
        {
            return Is_Bigger(B, new BigNumber(A.ToString()));
        }

        public static bool      operator  >(BigNumber A, int B)
        {
            return Is_Bigger(A, new BigNumber(B.ToString()));
        }
        public static bool      operator  >(int A, BigNumber B)
        {
            return Is_Bigger(new BigNumber(A.ToString()), B);
        }

        public static bool      operator <=(BigNumber A, int B)
        {
            if (A == B) return true;
            return Is_Bigger(new BigNumber(B.ToString()), A);
        }
        public static bool      operator <=(int A, BigNumber B)
        {
            if (A == B) return true;
            return Is_Bigger(B, new BigNumber(A.ToString()));
        }

        public static bool      operator >=(BigNumber A, int B)
        {
            if (A == B) return true;
            return Is_Bigger(A, new BigNumber(B.ToString()));
        }
        public static bool      operator >=(int A, BigNumber B)
        {
            if (A == B) return true;
            return Is_Bigger(new BigNumber(A.ToString()), B);
        }

        // END OPERATORS

        // OPERATORS SUPPORT METHODS

        private static BigNumber Quantevolte(BigNumber A, BigNumber B)
        {
            BigNumber counter = new BigNumber("0");

            int Acount = A.Number.Count();
            int Bcount = B.Number.Count();

            //Costante di riduzione dei cicli
            BigNumber moltiplicatore = new BigNumber("10");
            int riduttore = 0;

            while (riduttore < (Acount - Bcount - 2))
            {
                riduttore++;
                moltiplicatore *= 10;
            }
            riduttore++;
            
            BigNumber R;
            BigNumber NB = B;
            BigNumber conta = new BigNumber("0");

            while (NB.Number.Count() < (Acount - riduttore))
            {
                NB *= moltiplicatore;
                conta++;
            }

            bool is_zero = (conta == 0);
            if (!is_zero)
            {
                int y = Convert.ToInt32(conta.ToString());
                conta = new BigNumber("1");
                for (int x = 0; x < y; x++)
                    conta *= moltiplicatore;
            }

            R = A;
            while (!(R = (R - NB)).Negative)
                counter++;

            R = A - (NB * counter);
            if (!is_zero)
                counter *= conta;

            BigNumber S = R;

            while (B.Number.Count() < R.Number.Count())
            {
                S = Quantevolte(R, B);
                counter += S;
                R = A - (counter * B);
            }

            //ultime cifre
            while (!(R = (R - B)).Negative)
                counter++;

            return counter;
        }

        public static void Decr(BigNumber A)
        {
            if (A == 0)
            {
                A.Number[0] = 1;
                A.Negative = true;
                return;
            }
            if (A.Negative)
            {
                Incr(-A);
                A.Negative = true;
                return;
            }

            var e = A.Number.GetEnumerator();
            Boolean stop = false;
            List<byte> L = new List<byte>();
            while (!stop)
            {
                stop = true;
                if (e.MoveNext())
                {
                    byte b = e.Current;
                    if (b == 0)
                    {
                        stop = false;
                        b = 9;
                    }
                    else
                        b -= 1;

                    L.Add(b);
                }
            }

            while (e.MoveNext())
                L.Add(e.Current);

            A.Number = L;
            CleanZeros(A);
        }

        public static void Incr(BigNumber A)
        {
            if (A == -1)
            {
                A.Number[0] = 0;
                A.Negative = false;
                return;
            }
            if (A.Negative)
            {
                Decr(-A);
                A.Negative = true;
                return;
            }

            Boolean stop = false;
            List<byte> L = new List<byte>();
            int x = 0;
            while (!stop)
            {
                byte n = 0;
                if ((A.Number[x] + 1) > 9)
                    n = 0;
                else
                {
                    n = (byte)(A.Number[x] + 1);
                    stop = true;
                }

                L.Add(n);
                x++;

                if ((A.Number.Count() == x) && (!stop))
                {
                    L.Add(1);
                    stop = true;
                }                
            }

            while (x < A.Number.Count())
            {
                L.Add(A.Number[x]);
                x++;
            }

            A.Number = L;

            return;
        }

        private void CleanZeros()
        {
            Boolean stop = false;

            while (!stop)
            {
                stop = true;
                if (Number.Count() > 0)
                    if (Number.Last() == 0)
                    {
                        Number.RemoveAt(Number.Count - 1);
                        stop = false;
                    }
            }

            if (Number.Count() == 0) Number.Add(0);
        }

        private static void CleanZeros(BigNumber B)
        {
            Boolean stop = false;

            while (!stop)
            {
                stop = true;
                if (B.Number.Count() > 0)
                    if (B.Number.Last() == 0)
                    {
                        B.Number.RemoveAt(B.Number.Count - 1);
                        stop = false;
                    }
            }

            if (B.Number.Count() == 0) B.Number.Add(0);
        }

        // END OPERATORS SUPPORT METHODS

        // OTHER

        public static string SuperDivision(BigNumber A, BigNumber B)
        {
            const int max_decimal = 100;

            BigNumber C, D;
            C = A;
            D = B;
            C.Negative = false;
            D.Negative = false;
            BigNumber Resto = Quantevolte(C, D);
            if (A.Negative ^ B.Negative) Resto.Negative = true;

            string r = Resto.ToString() + ".";
            Resto.Negative = false;
            C -= (Resto * D);

            int x = 0;
            Boolean Stop = false;
            while ((x < max_decimal) && (!Stop))
            {
                if (C == 0) Stop = true;
                else
                {
                    C = C * 10;
                    Resto = Quantevolte(C, D);

                    if (Resto.Number.Count() > 1) Stop = true;
                    else
                    {
                        r += Resto.ToString();
                        C -= (Resto * D);
                        x++;
                    }
                }
            }

            return r;
        }

        public static Boolean Is_Bigger(BigNumber A, BigNumber B)
        {
            if (A.Number.Count() > B.Number.Count()) return true;
            if (A.Number.Count() < B.Number.Count()) return false;

            Boolean exit = false;
            int index = A.Number.Count() - 1;
            
            while (!exit)
            {
                if (A.Number[index] > B.Number[index]) return true;
                if (A.Number[index] < B.Number[index]) return false;

                index--;

                if (index == -1)
                    exit = true;
            }

            return false;
        }
    }
}
