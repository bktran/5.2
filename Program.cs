namespace _5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            string s = "Hello World";
            string s2 = " Fly me to the moon ";
            Console.WriteLine(LastWordLength(s));
            Console.WriteLine(LastWordLength(s2));

            //2
            PrintNaturalNumsAsc(10);
            Console.WriteLine();
            PrintNaturalNumsAsc(15);
            Console.WriteLine();

            //3
            PrintNaturalNumsDesc(20);
            Console.WriteLine();
            PrintNaturalNumsDesc(10);
            Console.WriteLine();


            //4
            Console.WriteLine(IsPalindrome("RADAR"));
            Console.WriteLine(IsPalindrome("RADARR"));
            
        }
        //1
        public static int LastWordLength(string s)
        {
            string[] arr = s.Trim().Split(' ');
            string lastWord = arr[arr.Length - 1];
            return lastWord.Length;
        }

        //2
        public static void PrintNaturalNumsAsc(int n)
        {
            if (n > 0)
            {
                PrintNaturalNumsAsc(n - 1);
                Console.Write($"{n} ");
            }
        }

        //3
        public static void PrintNaturalNumsDesc(int n)
        {
            if (n > 0)
            {
                Console.Write($"{n} ");
                PrintNaturalNumsDesc(n - 1);
            }
        }

        //4
        public static bool IsPalindrome(string word)
        {
            string newWord = word.Trim().ToLower();
            if (newWord.Length <= 1)
            {
                return true;
            }

            if (newWord[0] != newWord[newWord.Length - 1])
            {
                return false;
            }
            string shortenedWord = newWord.Substring(1, newWord.Length - 2);
            return IsPalindrome(shortenedWord);
            
        }

    }
}
