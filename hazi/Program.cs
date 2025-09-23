using System;

namespace hazi0916
{
    internal class Program
    {

        // param 1: string | bekeres uzenete
        // returns int | beirt szam
        static int ReadInt(string message)
        {
            Console.Write(message);
            int num;
            // checks input | ha nem lehet atvaltani intre => error message
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Hibás bemenet! Ez nem szám");
                Console.Write(message);
            }
            return num;
        }

        // param: string | bekeres uzenete
        // retuens string | beirt szoveg
        static string ReadStr(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        //param: string | bekeres uzenete
        //returns double | beirt nem egesz szam
        static double ReadDouble(string message)
        {
            Console.Write(message);
            double num;
            // checks input | ha nem valthato at doublere => error message
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Hibás bemenet! Ez nem szám");
                Console.Write(message);
            }
            return num;
        }

        // param: string | uzenet
        // addig ker be szamot, amig nem lesz pozitiv
        // returns int
        static int ReadPositiveInt(string message)
        {
            int num;
            do
            {
                num = ReadInt(message);
            } while (num < 1);
            return num;
        }

        static int Lnko(int a, int b)
        {
            int temp = a;
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            while (b % temp != 0)
            {
                temp--;
            }
            if (temp != 1)
            {
                while (a > 0)
                {
                    temp = a;
                    a = b % a;
                    b = temp;
                }
                return b;
            }
            return 0;
        }

        static void F1()
        {
            Console.WriteLine("Hello, World!");
        }
        static void F2()
        {
            string name = ReadStr("Név: ");
            Console.WriteLine($"Szia {name}");
        }
        static void F3()
        {
            int f3num = ReadInt("Szám: ");
            Console.WriteLine(f3num * 2);
        }
        static void F4()
        {
            int szam1 = ReadInt("1. szám: ");
            int szam2 = ReadInt("2. szám: ");
            Console.WriteLine(szam1 + szam2);
            Console.WriteLine(szam1 - szam2);
            Console.WriteLine(szam1 * szam2);
            Console.WriteLine(szam1 / szam2);
        }
        static void F5()
        {
            int szam1 = ReadInt("1. szám: ");
            int szam2 = ReadInt("2. szám: ");
            if (szam1 > szam2)
            {
                Console.WriteLine(szam1);
            }
            else if (szam2 > szam1)
            {
                Console.WriteLine(szam2);
            }
            else
            {
                Console.WriteLine(szam1);
            }
        }
        static void F6()
        {
            int szam1 = ReadInt("1. szám: ");
            int szam2 = ReadInt("2. szám: ");
            int szam3 = ReadInt("3. szám: ");
            if (szam1 < szam2 && szam1 < szam3)
            {
                Console.WriteLine($"{szam1} a legkisebb");
            }
            else if (szam2 < szam1 && szam2 < szam3)
            {
                Console.WriteLine($"{szam2} a legkisebb");
            }
            else
            {
                Console.WriteLine($"{szam3} a legkisebb");
            }
        }
        static void F7()
        {
            int a_oldal = ReadInt("a oldal: ");
            int b_oldal = ReadInt("b oldal: ");
            int c_oldal = ReadInt("c oldal: ");
            if (a_oldal + b_oldal > c_oldal || b_oldal + c_oldal > a_oldal || a_oldal + c_oldal > b_oldal)
            {
                Console.WriteLine("Szerkeszthető");
            }
            else
            {
                Console.WriteLine("Nem szerkeszthető");
            }
        }
        static void F8()
        {
            double szam1 = ReadDouble("1. szám: ");
            double szam2 = ReadDouble("2. szám: ");
            Console.WriteLine($"Számtani közép: {(szam1 + szam2) / 2}");
            Console.WriteLine($"Mértani közép: {Math.Sqrt(szam2 * szam1)}");
        }
        static void F9()
        {
            double a = ReadDouble("a: ");
            double b = ReadDouble("b: ");
            double c = ReadDouble("c: ");
            double d = b * b - 4 * a * c;
            if (d > 0 || d == 0)
            {
                Console.WriteLine("Van megoldása");
            }
            else
            {
                Console.WriteLine("Nincs megoldása");
            }
        }
        static void F10()
        {
            double a = ReadDouble("a: ");
            double b = ReadDouble("b: ");
            double c = ReadDouble("c: ");
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Nincs megoldás");
            }
            else if (d == 0)
            {
                double x1 = -b / (2 * a);
                Console.WriteLine($"1 megoldás\n{x1}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
                double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
                Console.WriteLine("2 megoldás");
                Console.WriteLine($"x1: {x1}");
                Console.WriteLine($"x2: {x2}");
            }
        }
        static void F11()
        {
            double befogo1 = ReadDouble("1. befogó");
            double befogo2 = ReadDouble("2. befogó");
            double atfogo = Math.Round(Math.Sqrt(befogo1 * befogo1 + befogo2 * befogo2), 2);
            Console.WriteLine($"Átfogó: {atfogo}");
        }
        static void F12()
        {
            double a = ReadDouble("'a' él: ");
            double b = ReadDouble("'b' él: ");
            double c = ReadDouble("'c' él: ");
            Console.WriteLine($"V: {a * b * c}");
            Console.WriteLine($"A: {2 * (a * b + b * c + a * c)}");
        }
        static void F13()
        {
            double r = ReadDouble("Kör átmérője: ") / 2;
            Console.WriteLine($"Kerület: {2 * r * Math.PI}");
            Console.WriteLine($"Terület: {r * r * Math.PI}");
        }
        static void F14()
        {
            double r = ReadDouble("Körcikk sugara: ");
            double a = ReadDouble("Középponti szög: ");
            Console.WriteLine($"Körcikk területe: {r * r * Math.PI * a / 360}");
            Console.WriteLine($"Körcikk ív hossza: {2 * r * Math.PI * a / 360}");
        }
        static void F15()
        {
            int num = ReadPositiveInt("Pozitív szám: ");
            for (int i = 0; i != num + 1; i++)
            {
                Console.Write(i + " ");
            }
        }
        static void F16()
        {
            int num = ReadPositiveInt("Pozitív szám: ");
            for (int i = 0; i != num + 1; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void F17()
        {
            int num = ReadPositiveInt("Pozitív szám: ");
            for (int i = 1; i < num + 1; i++)
            {
                if (num % i == 0) Console.WriteLine(i);
            }
        }
        static void F18()
        {
            int sum = 0;
            int num = ReadPositiveInt("Pozitív szám: ");
            for (int i = 1; i < num + 1; i++)
            {
                if (num % i == 0) sum += i;
            }
            Console.WriteLine(sum);
        }

        static void F19()
        {
            int num = ReadPositiveInt("Pozitív szám: ");
            int sum = 0;
            for (int i = 1; i < num + 1; i++)
            {
                if (num % i == 0) sum += i;
            }
            if (sum == num * 2)
            {
                Console.WriteLine("Tökéletes szám");
            }
            else
            {
                Console.WriteLine("Nem tökéletes szám");
            }
        }
        static void F20()
        {
            int num = ReadInt("Hatványalap: ");
            int power = ReadPositiveInt("Kitevő: ");
            int result = num;
            for (int i = 1; i < power; i++)
            {
                result *= num;
            }
            Console.WriteLine(result);
        }

        static void F21()
        {
            ReadPositiveInt("Pozitív szám: ");
        }
        static void F22()
        {
            int sum = 0;
            int num = ReadInt("Szám: ");
            while (num < 10)
            {
                if (num < 10) sum += num;
                num = ReadInt("Szám: ");
            }
            Console.WriteLine(sum);
        }
        static void F23()
        {
            int num = ReadInt("Szám: ");
            Console.Write($"{num} = ");
            while (num % 2 == 0)
            {
                num /= 2;
                Console.Write("2*");
            }
            Console.Write(num);
        }
        static void F24()
        {
            string str = "";
            do
            {
                str = ReadStr("Szöveg: ");
                if (str != "alma") Console.WriteLine("Hibás bemenet!");
            } while (str != "alma");
            Console.WriteLine("Az alma gyümölcs!");
        }

        static void F25()
        {
            int num = ReadInt("Szám: ");
            int times = 0;
            while (num >= 3)
            {
                num -= 3;
                times++;
            }
            Console.WriteLine($"{times}*3+{num}");
        }
        static bool F26(int num) // primszam-e
        {
            int osztokdb = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    osztokdb++;
                }
            }
            if (osztokdb == 2)
            {
                return true; // prim
            } else
            {
                return false; // nem prim
            }
        }
        static void F27()
        {
            int num = ReadInt("Szám: ");
            for (int i = 1; i < num ; i++)
            {
                if (F26(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void F28()
        {
            int num = ReadInt("Szám: ");
            int i = 1;
            while (!F26(num) && i <= num)
            {
                if (F26(i) && num % i == 0)
                {
                    Console.WriteLine(i);
                    num /= i;
                }
                else
                {
                    i++;
                }
            }
        }

        static void F29()
        {
            int num = ReadInt("Szám: ");
            int i = 1;
            while (!F26(num) && i <= num)
            {
                if (F26(i) && num % i == 0)
                {
                    Console.WriteLine($"{num} | {i}");
                    num /= i;
                } else
                {
                    i++;
                }
            }
            Console.WriteLine($"{num} | ");
        }
        static void F30()
        {
            int a = ReadInt("Elso szam: ");
            int b = ReadInt("Masodik szam: ");
            int lnko = Lnko(a, b);
            Console.WriteLine(lnko);
        }
        static void F31()
        {
            int a = ReadInt("Elso szam: ");
            int b = ReadInt("Masodik szam: ");
            int lnko = Lnko(a, b);
            Console.WriteLine((a * b) / lnko);

        }
        static void F32()
        {
            int num = ReadInt("Szám: ");
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }
        }
        static void F33()
        {
            int num = ReadInt("Szám: ");
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    
                }
                Console.WriteLine();
            }
        }
        static void F34()
        {
            for (int num1 = 10; num1 < 100; num1++)
            {
                for (int num2 = 10; num2 < 100; num2++)
                {
                    int flippednum1 = int.Parse($"{num1.ToString()[1]}{num1.ToString()[0]}");
                    int flippednum2 = int.Parse($"{num2.ToString()[1]}{num2.ToString()[0]}");
                    if (num1 * num2 == flippednum1 * flippednum2)
                    {
                        Console.WriteLine($"{num1}, {num2}");
                    }
                }
            }
        }

        static void F35()
        {
            int ascii = 97;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (ascii < 123)
                    {
                        Console.Write($"{Convert.ToChar(ascii)} {ascii}\t");
                        ascii++;    
                    }
                }
                Console.WriteLine("\t");
            }
        }

        static void F36()
        {
            int row = ReadInt("Sorok száma: ");
            int col = ReadInt("Oszlopok száma: ");
            bool x = true;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (x)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }
                    x = !x;
                }
                Console.WriteLine();
            }
        }

        static void F37()
        {
            int a = ReadInt("Sor: ");
            string stars = "*";
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void F38()
        {
            int a = ReadInt("Sor: ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 1; j <= a - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void F39()
        {
            int row = ReadInt("Sor: ");
            int col = ReadInt("Oszlop: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == 0 || i == row-1) 
                    {
                        Console.Write("*");
                    }
                    else if (j == 0 || j == col-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void F40()
        {
            int num = ReadInt("Szám: ");
            int sum = 0;
            for (int j = 1; j < num; j++)
            {
                for (int i = 1; i < j + 1; i++)
                {
                    if (j % i == 0) sum += i;
                }
                if (sum == j * 2)
                {
                    Console.WriteLine($"{j}");
                }
                sum = 0;
            }
            
        }
            static void Main(string[] args) 
        {
            F40();
        }
    }
}