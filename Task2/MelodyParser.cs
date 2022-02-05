using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal static class MelodyParser
    {
        public static Note[] ParseMelody(string melody)
        {
            Note[] notes = new Note[melody.Length];
            for (int i = 0; i < melody.Length; i++)
            {
                char element = melody[i];
                if (element == ' ')
                {
                    notes[i] = new Note(37, 1, true);
                    continue;
                }
               
                Note note = Convert.ToInt32(melody[i].ToString()) switch
                {
                    0 => Note.Do(2, 500),
                    1 => Note.Re(2, 500),
                    2 => Note.Mi(2, 500),
                    3 => Note.Fa(2, 500),
                    4 => Note.Sol(2, 500),
                    5 => Note.La(2, 500),
                    6 => Note.Si(2, 500),
                    7 => Note.Do(2, 500),
                    8 => Note.Re(2, 500),
                    9 => Note.Mi(2, 500),
                    _ => new Note(37, 1, true)
                };
                notes[i] = note;
            }
            return notes;
        }
    }
}
