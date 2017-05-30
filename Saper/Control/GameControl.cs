using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Saper.Additional;
using Saper.Entity;
using Saper.Boundary;
using Saper.Interfaces;


namespace Saper.Control
{
    public class GameControl : IGameController
    {
        public IGameForm GameForm { get; private set; }
        public GameState GameState { get; private set; }
        public RecordTable RecordTable { get; private set; }
        public GameControl()
        {

            GameState = new GameState();
            RecordTable = new RecordTable();
            GameState.StateChange += StateChangeHandler;
            RecordTable.ReadFromFile();
            CreateForm();
        }
        public void CreateForm()
        {
            GameForm = new GameForm();
            GameForm.gameControl = this;
            GameForm.CreateNewField(GameState.Mode);
        }
        public void CellAction(int cellRow, int cellColumn, MouseButtons clickedMouseButton)
        {
            switch (clickedMouseButton)
            {

                case MouseButtons.Right:
                    GameState.ChangeFlag(cellRow, cellColumn);
                    break;
                case MouseButtons.Left:
                    GameState.OpenCells(cellRow, cellColumn);
                    break;
            }
        }

        public void GameFinished()
        {
            switch (GameState.State)
            {
                case GameStateEnum.Win:
                    GameWin();
                    break;
                case GameStateEnum.Lose:
                    GameLose();
                    break;
                default:
                    throw new Exception("There is bug, because game is not finished");
            }
        }

        public void GameWin()
        {
            int time = GameState.CurrentGameTime;
            Mode mode = GameState.Mode;
            MessageBox.Show("Победа!", "Вы победили", MessageBoxButtons.OK);
            if (RecordTable.IsNewRecord(time, mode))
            {
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                string name = (string.IsNullOrEmpty(loginForm.Name))
                                ? "User" : loginForm.Name;
                RecordTable.AddNewRecord(new Record(name, time, mode));
                RecordTable.WriteIntoFile();
            }
        }

        public void GameLose()
        {
            GameForm.ShowBombs(GameState.Cells);
            MessageBox.Show("Поражение!", "Вы проиграли", MessageBoxButtons.OK);
        }

        public int GetCurrentTime()
        {
            return GameState.CurrentGameTime;
        }

        public void ShowRecordTable()
        {
            RecordTableForm recordTableForm = new RecordTableForm(RecordTable, this);
            recordTableForm.ShowDialog();
        }

        public void StateChangeHandler()
        {
            GameForm.UpdateField(GameState.Cells);
            switch (GameState.State)
            {
                case GameStateEnum.Win:
                case GameStateEnum.Lose:
                    GameFinished();
                    break;
            }
        }
        public void ChangeMode()
        {
            var chooseModeForm = new ChooseModeForm(GameState.Mode);
            chooseModeForm.ShowDialog();
            Mode newMode = new Mode(chooseModeForm.Height, chooseModeForm.Width, chooseModeForm.Bombs);
            GameState.ChangeMode(newMode);
            GameForm.CreateNewField(newMode);
        }
        public void NewGame()
        {
            GameState.Initialize();
            GameForm.CreateNewField(GameState.Mode);
        }
        public void About()
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();

        }
        public void ClearRecordTable()
        {
            RecordTable.ToDefault();
        }
    }
}
