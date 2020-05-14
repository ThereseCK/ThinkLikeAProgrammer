using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseTreeChapterTree();
            ExerciseFourAndFiveChapterTree();
            ExerciseSixChapterTree();
            ExerciseSevenChapterTree();
        }
        static void ExerciseTreeChapterTree()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (var number in numbers) Console.Write(number + ",");
            Console.WriteLine($"sortet = {IsSorted(numbers)}");
            numbers = new[] { 1, 2, 5, 4, 7, 2, 8, };
            foreach (var number in numbers) Console.Write(number + ": ");
            Console.WriteLine($"sortert = {IsSorted(numbers)}");
        }
        private static bool IsSorted(int[] numbers)
        {
            for (int i= 1; i< numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1]) return false;
            }
            return true;
        }

        //oppgave 3-4 og 3-5

       private static void ExerciseFourAndFiveChapterTree()
        {
            Console.WriteLine("Skriv en valgfri tekst i store bokstaver her----> ");
            string output = "";
            var letters = LettersAndCipher(out var ciphertext);

            output = Encrypt(letters, output, ciphertext);
            Console.WriteLine("teksten du skrev er blitt kryptert til: " + output);
            Console.WriteLine("Vil du konvertere tilbake ? Y = ja og N = nei !! ");
            Decrypt(output, ciphertext, letters);
        }

        private static string[] LettersAndCipher( out string[] ciphertext)
        {
            string[] letters =
            {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V",
                "W", "X", "Y", "Z", "Æ", "Ø", "Å",
            };

            ciphertext = new[]
            {
                 "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "Å", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Ø", "Æ",
                "Z", "X", "C", "V", "B", "N", "M",
            };
            return letters;
        }

        private static void Decrypt(string output, string[] ciphertext, string[] letters)
        {
            var curCiphers = output;
            var answer = Console.ReadLine()?.ToUpper();
            if(answer != "Y" && answer != "N")
            {
                return;
            }
            if (answer == "Y")
            {
                output = "";
                foreach (var check in curCiphers.Select(converted => converted.ToString()))
                {
                    for ( int i = 0; i < ciphertext.Length; i++)
                    {
                        if (check != ciphertext[i]) continue;

                        output += letters[i];
                    }
                }

            }
            Console.WriteLine("din text er Dekryptert : " + output);

        }
        private static string Encrypt(string[] letters, string output, string[] ciphertext)
        {
            var plaintext = Console.ReadLine()?.ToUpper();

            foreach( var letter in plaintext)
            {
                var check = letter.ToString();
                for (int j = 0; j < letters.Length; j++)
                {
                    if ( check == letters[j])
                    {
                        output += ciphertext[j];
                    }
                }
            }
            return output;
        }

        // oppgave 3-6
        private static void ExerciseSixChapterTree()
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ";
            var code = CreateCode(alphabet);
            Console.WriteLine(code);
        }

        private static string CreateCode(string alphabet)
        {
            var code = alphabet.ToCharArray();
            var random = new Random();
            for (int index1 = 0; index1 < alphabet.Length; index1++)
            {
                int randomIndex2;
                int avoidIndex2;
                do
                {
                    var randomChar1 = code[index1];
                    var avoidIndex1 = alphabet.IndexOf(randomChar1);
                    randomIndex2 = random.Next(0, alphabet.Length - 1);
                    if (randomIndex2 >= avoidIndex1) randomIndex2++;
                    var randomChar2 = code[randomIndex2];
                    avoidIndex2 = alphabet.IndexOf(randomChar2);
                } while (avoidIndex2 == index1);
                var tmp = code[index1];
                code[index1] = code[randomIndex2];
                code[randomIndex2] = tmp;
            }

            return new string(code);
        
        }
        private static void ExerciseSevenChapterTree()
        {
            int[] numbers = { 1, 10, 2, 10, 3, 10, 4, 10, 10 };
            int count = 1, tempCount;
            int frequent = numbers[0];
            int tempNR = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                tempNR = numbers[i];
                tempCount = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (tempNR == numbers[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    frequent = tempNR;
                    count = tempCount;
                }
            }
            Console.WriteLine("The most frequent number in this array is {0} has been repeated {1} times.", frequent, count);
            

        }
    }
   
}
