using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal static class Player
    {
        public static void Play(Note[] notes)
        {
            Console.WriteLine("Melody starts ...");
            foreach (Note note in notes)
                Console.Beep(note.Frequency, note.DurationMsec);
            Console.WriteLine("Played!");
        }
    }
}
