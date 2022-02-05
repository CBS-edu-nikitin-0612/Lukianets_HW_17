using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Note
    {
        public int _frequency, _durationMsec;
        private bool _isPause;

        public Note(int freq, int durationMsec, bool isPause)
        {
            _frequency = freq;
            _durationMsec = durationMsec;
            _isPause = isPause;
        }

        public int Frequency => _frequency;
        public int DurationMsec => _durationMsec;

        // Fabric methods to create Note (freguency depending on octave number [1, 2, 3]).
        public static Note Do(int octaveNumber, int duration)
        {
            int freq = octaveNumber switch
            {
                1 => 196,
                2 => 220,
                3 => 233,
                _ => 0
            };
            return new Note(freq, duration, false);
        }
        public static Note Re(int octaveNumber, int duration)
        {
            int freq = octaveNumber switch
            {
                1 => 247,
                2 => 262,
                3 => 277,
                _ => 0
            };
            return new Note(freq, duration, false);
        }
        public static Note Mi(int octaveNumber, int duration)
        {
            int freq = octaveNumber switch
            {
                1 => 294,
                2 => 311,
                3 => 330,
                _ => 0
            };
            return new Note(freq, duration, false);
        }
        public static Note Fa(int octaveNumber, int duration)
        {
            int freq = octaveNumber switch
            {
                1 => 349,
                2 => 370,
                3 => 392,
                _ => 0
            };
            return new Note(freq, duration, false);
        }
        public static Note Sol(int octaveNumber, int duration)
        {
            int freq = octaveNumber switch
            {
                1 => 415,
                2 => 430,
                3 => 452,
                _ => 0
            };
            return new Note(freq, duration, false);
        }
        public static Note La(int octaveNumber, int duration)
        {
            int freq = octaveNumber switch
            {
                1 => 460,
                2 => 479,
                3 => 490,
                _ => 0
            };
            return new Note(freq, duration, false);
        }
        public static Note Si(int octaveNumber, int duration)
        {
            int freq = octaveNumber switch
            {
                1 => 500,
                2 => 511,
                3 => 525,
                _ => 0
            };
            return new Note(freq, duration, false);
        }
    }
}
