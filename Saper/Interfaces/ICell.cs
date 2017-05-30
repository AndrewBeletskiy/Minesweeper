using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper.Interfaces
{
    public interface ICell
    {
        bool IsBomb { get; }
        bool IsFlag { get; }
        bool IsOpen { get; }
        int Number { get; }
    }
}
