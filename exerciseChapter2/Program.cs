using System;
using System.Runtime.CompilerServices;

namespace exerciseChapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseTreeChapterTwo();
            ExerciceTwoChapterTwo();
            ExerciseOneChapterTwo();
           
        }
        private static void ExerciseTreeChapterTwo()
        {
            var indexValues = new[] { 0, 1, 2, 3, 3, 2, 1, 0 };
            foreach (var i in indexValues) Row(i);

            //for (var i = 0; i < 4; i++) Row(i);
            //for (var i = 4 - 1; i >= 0; i--) Row(i);
        }
        private static void Row(int i)
        {
            Space(i);
            Hash(i + 1);
            Space(12 - i * 4);
            Hash(i + 1);
            NewLine();
        }

        private static void ExerciceTwoChapterTwo()
        {
            int space = 8;
            int[] hashtags = { 2, 4, 6, 8, 8, 6, 4, 2 };
            foreach (var hash in hashtags)
            {
                for (int p = 0; p < (space - hash) / 2; p++)
                {
                    Space();
                }
                for (int x = 0; x < hash; x++)
                {
                    Hash();
                }
                NewLine();
            }
        }
        private static void ExerciseOneChapterTwo()
        {
            int[] whatever = { 10, 8, 6, 4, 2 };
            for (int i = 0; i < whatever.Length; i++)
            {
                for (int x = 0; x < new[] { 1, 2, 3, 4, 5 }[i]; x++)
                {
                    Space();
                }
                for (int j = 0; j < whatever[i]; j++)
                {
                    Hash();
                }
                NewLine();
            }
        }
        private static void Hash(int count)
        {
            for (var i = 0; i < count; i++) Hash();
        }
        private static void Hash()
        {
            Console.Write("#");
        }
        private static void NewLine()
        {
            Console.WriteLine();
        }
        private static void Space(int count)
        {
            for (var i = 0; i < count; i++) Space();
        }
        private static void Space()
        {
            Console.Write(" ");
        }
    }
}
