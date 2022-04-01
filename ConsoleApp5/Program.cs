using System;



namespace AnonynFunc
{
    delegate bool Delegate(int num);
    class Program

    {

        static bool IsEven(int num)
        {
            if (num % 2 == 0)
                return true;
            return false;
        }




        static bool IsNotEven(int num)
        {
            if (num % 2 == 0)
                return false;
            return true;
        }
        static bool Has3(int num)
        {
            string str = num.ToString();
            foreach (char c in str)
            {
                if (c == '3')
                    return true;
            }
            return false;
        }

        static bool HasSameNumberSequance(int num)
        {
            string str = num.ToString();
            if (str.Length == 1)
                return true;
            else
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i] == str[i + 1])
                        return true;
                }
            return false;
        }

        static int[] GetFiltered(int[] arr, Delegate d)
        {
            List<int> list = new List<int>();
            foreach (int i in arr)
            {
                if (d(i))
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }




        static void Print(int[] arr)
        {
            foreach (int i in arr)
                Console.WriteLine($"{i}, ");
        }


        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 5, 6, 11, 12, 13, 14, 22, 23, 33, 44, 55 };
            int[] evenArray = GetFiltered(array, (num) => num %2 ==0);
            int[] notEvenArray = GetFiltered(array, (num) => num % 2 != 0);
            int[] has3Array = GetFiltered(array, (num) =>
            {
                string str = num.ToString();
                foreach (char s in str)
                {
                    if (s == '3')
                        return true;
                }
                return false;
            });
            int[] has3Array2 = GetFiltered(array, (num) => num.ToString().Contains ("3"));

            int[] hasSameNumberArray = GetFiltered(array, (num) =>
            {
                string str = num.ToString();
                if (str.Length == 1)
                    return true;
                else
                    for (int i = 0; i < str.Length - 1; i++)
                    {
                        if (str[i] == str[i + 1])
                            return true;
                    }
                return false;
            });
            //
            System.Console.WriteLine("Original array items:");
            Print(array);
            System.Console.WriteLine("\n********************");
            System.Console.WriteLine("Even array items:");
            Print(evenArray);
            System.Console.WriteLine("\n********************");
            System.Console.WriteLine("Not even array items:");
            Print(notEvenArray);
            System.Console.WriteLine("\n********************");
            System.Console.WriteLine("Has 3 array items:");
            Print(has3Array);
            System.Console.WriteLine("\n********************");
            System.Console.WriteLine("Has same number array items:");
            Print(hasSameNumberArray);
            System.Console.WriteLine("\n********************");
        }

    }

}

