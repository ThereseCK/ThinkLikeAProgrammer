using System;
using System.Runtime.CompilerServices;

namespace number9
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseNineChapterTwo();
        }
        private static void ExerciseNineChapterTwo()
        {
            Console.Write("Her kan du skrive hva du vil: ");
           string readingLine = Console.ReadLine() + " ";
            int total = 0;
            var CountingWords = 0;
            var CharsInCurrentWord = 0;
            var isInsideWord = false;
            string[] words = readingLine.Split(new[] { " "}, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach ( String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
           for ( var i = 0; i < readingLine.Length; i++)
            {
                var isSpace = readingLine[i] == ' ';
                if (!isInsideWord && !isSpace) CountingWords++;
                isInsideWord = !isSpace;
                if (readingLine.Contains("a") || readingLine.Contains("e") || readingLine.Contains("i") || readingLine.Contains("o") || readingLine.Contains("u"))
                {
                    total++;
                }
            }
            Console.WriteLine("Det er totalt " + CountingWords + " ord i det du skrev");
            Console.WriteLine("Totalt bruk av vokaler er : {0}", total);
           
            foreach (var character in readingLine){
                var isItSpace = character == ' ';
                if (isItSpace)
                {
                    Console.WriteLine("Det er " + CharsInCurrentWord + " bokstaver i det ene ordet" +
                        "");
                    CharsInCurrentWord = 0;
                }
                else
                {
                    if (CharsInCurrentWord == 0) CountingWords++;
                    CharsInCurrentWord++;
                }

            }
            
            Console.WriteLine("det lengste ordet er: " + word);

          
        }
   
    }
}
