using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper.Entity
{
    [Serializable]
    public class Record
    {
        public Mode Difficulty { get; set; }
        public string Name { get; set; }
        public int Time { get; set;  }

        public Record(string name, int time, Mode difficulty)
        {
            this.Name = name;
            this.Time = time;
            this.Difficulty = difficulty;
        }
        public static Record DefaultEasy = new Record("Unknown", 999, Mode.Easy);
        public static Record DefaultMedium= new Record("Unknown", 999, Mode.Medium);
        public static Record DefaultProfessional = new Record("Unknown", 999, Mode.Professional);
        private static string getDifficultyString(Mode mode)
        {
            if (mode == Mode.Easy)
                return "Лёгкий";
            if (mode == Mode.Medium)
                return "Средний";
            if (mode == Mode.Professional)
                return "Профессиональный";
            return "Особый";
        }
        public override string ToString()
        {
            return String.Format("{0}: {1} ------ {2}c", getDifficultyString(Difficulty), Name, Time);
        }
    }
}
