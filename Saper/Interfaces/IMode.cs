using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper.Interfaces
{
    public interface IMode
    {
        int Height { get; }
        int Width { get; }
        int Bombs { get; }
    }
}
