using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saper.Interfaces;

namespace Saper.Entity
{
    public class Cell : ICell
    {
        public bool IsOpen { get; set; }
        public bool IsBomb { get; set; }
        public bool IsFlag { get; set; }
        public int Number { get; set; }
        public Cell()
            :this(false, false, false, 0)
        {}
        public Cell(bool isOpen, bool isBomb, bool isFlag, int number)
        {
            this.IsOpen = isOpen;
            this.IsBomb = isBomb;
            this.IsFlag = isFlag;
            this.Number = number;
        }
    }
}
