using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int test1 = Convert.ToInt32('8');
            //int test2 = Convert.ToInt32('8'.ToString()); 
            //Console.WriteLine(test1);
            //Console.WriteLine(test2);

            string melody = "987 876 765 654 543 432 111 8";
            Note[] notes = MelodyParser.ParseMelody(melody);
            Player.Play(notes);
        }
    }
}
