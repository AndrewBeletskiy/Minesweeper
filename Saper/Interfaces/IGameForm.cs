using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper.Interfaces
{
    public interface IGameForm
    {
        // Об'єкт, що реалізовує інтерфейс IGameController описаний нижче
        IGameController gameControl { set; }
        // Метод, що створює початкове поле (пусті клітинки, змінює форму вікна і тд.)
        void CreateNewField(IMode mode);
        // Метод, що робить бомби видимими, флажки вірні та невірні - повинні бути зображені.
        void ShowBombs(ICell[,] cells);
        // Метод, що оновлює поле згідно з оновленним станом поля.
        void UpdateField(ICell[,] cells);
    }
}
