using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper.Interfaces
{
    public interface IGameController
    {
        // через цей метод, об'єкт класу GameForm буде взнавати який час показувати як час гри
        int GetCurrentTime();
        // Цей метод повинен виконуватись коли користувач натискає на поле, правою або лівою кнопкою миші.
        void CellAction(int row, int column, MouseButtons button);
        // Цей метод повинен запускатися, коли користувач хоче розпочати нову гру
        void NewGame();
        // Цей метод повинен запускатися, коли користувач хоче побачити таблицю рекордів
        void ShowRecordTable();
        // Цей метод повинен запускатися, коли користувач бажає змінити поточний режим гри
        void ChangeMode();
        // Цей метод повинен визиватися, коли користувач бажаэ побачити вікно "Про программу"
        void About();
    }
}
