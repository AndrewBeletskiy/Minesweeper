using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saper.Interfaces;
namespace Saper.Entity
{
    [Serializable]
    public class Mode : IMode
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Bombs { get; set; }

        public Mode(int height, int width, int bombs)
        {
            Height = height;
            Width = width;
            Bombs = bombs;
        }

        public static Mode Easy = new Mode(9, 9, 10);
        public static Mode Medium = new Mode(16, 16, 40);
        public static Mode Professional = new Mode(16, 30, 99);

        public Mode() : this(9, 9, 10) { }

        public override bool Equals(object obj)
        {
            
            Mode other = obj as Mode;
            if (other == null)
                return false;
            return other.Height == Height && other.Width == Width && other.Bombs == Bombs;
        }
        public static bool operator == (Mode a, Mode b)
        {
            return a.Height == b.Height && a.Width == b.Width && a.Bombs == b.Bombs;
        }
        public static bool operator !=(Mode a, Mode b)
        {
            return a.Height != b.Height || a.Width != b.Width || a.Bombs != b.Bombs;
        }
    }
}
