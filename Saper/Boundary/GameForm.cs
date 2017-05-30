using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Saper.Control;
using Saper.Entity;
using Saper.Interfaces;

namespace Saper.Boundary
{
    public partial class GameForm : Form, IGameForm
    {
        public bool showed = false;
        public IGameController gameControl { get; set; }
        private Button[,] buttons;
        private IMode currentMode;
        private int CurrentTime
        {
            set
            {
                label1.Text = String.Format("{0}", value);
            }
        }
        public GameForm()
        {
            InitializeComponent();
            BackColor = GenerateSettings.OpenColor;
        }

        public void TimerTickHandler()
        {
            CurrentTime = gameControl.GetCurrentTime();
        }

        public void CreateNewField(IMode mode)
        {
            bombsLabel.Text = $"{mode.Bombs}";
            if (buttons != null && mode.Height == buttons.GetLength(0) && mode.Width == buttons.GetLength(1))
            {
                ButtonsToDefault();
                return;
            }
            else
            {
                ClearField();
            }

            Size buttonSize = GenerateSettings.ButtonSize;
            
            buttons = new Button[mode.Height, mode.Width];
            for (var i = 0; i < mode.Height; i++)
            {
                for (var j = 0; j < mode.Width; j++)
                {
                    buttons[i, j] = CreateCellButton(i,j);
                }
            }
            AddButtons(buttons);
            this.Width = mode.Width * (buttonSize.Width + GenerateSettings.deltaWidth) + GenerateSettings.leftMargin + GenerateSettings.rightMargin;
            this.Height = mode.Height * (buttonSize.Height + GenerateSettings.deltaHeight) + GenerateSettings.topMargin + GenerateSettings.bottomMargin;
            currentMode = mode;
            bombsLabel.Left = Width - GenerateSettings.BombsLabelLeftMargin;
            bombPicture.Left = Width - GenerateSettings.BombsPictureLeftMargin;
        }
        
        private void ButtonsToDefault()
        {   
            for (var i = 0; i < buttons.GetLength(0); i++)
            {
                for (var j = 0; j < buttons.GetLength(1); j++)
                {
                    ButtonToDefault(i, j);
                }
            }
                
        }


        private Button CreateCellButton(int i, int j)
        {
            var result = new Button();
            result.Font = new Font("Arial", 8.0f);
            result.FlatStyle = FlatStyle.Popup;
            result.BackColor = GenerateSettings.CloseColor;
            result.Size = GenerateSettings.ButtonSize;
            result.Top = i * GenerateSettings.ButtonHeight + GenerateSettings.topMargin;
            result.Left = j * GenerateSettings.ButtonWidth + GenerateSettings.leftMargin;
            result.MouseUp += CellClicked;
            return result;
        }

        private void CellClicked(object sender, EventArgs e)
        {
            MouseEventArgs ev = e as MouseEventArgs;
            Button button = sender as Button;
            Point position = findPosition(button);
            int row = position.Y;
            int column = position.X;
            gameControl.CellAction(row, column, ev.Button);
        }
        private Point findPosition(Button button)
        {
            for (var i = 0; i < buttons.GetLength(0); i++)
            {
                for (var j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j] == button)
                        return new Point(j,i);
                }
            }
            return new Point(0, 0);
        }

        private void AddButtons(Button[,] buttons)
        {
            foreach (Button button in buttons)
            {
                button.Name = "Cell";
                Controls.Add(button);
            }
        }

        public void UpdateField(ICell[,] currentCells)
        {
            for (var i = 0; i < currentCells.GetLength(0); i++)
            {
                for (var j = 0; j < currentCells.GetLength(1); j++)
                {
                    var cell = currentCells[i, j];
                    if (cell.IsOpen && !cell.IsBomb)
                    {
                        SetOpenButton(i, j, cell);
                    }
                    else if (cell.IsFlag)
                    {
                        SetFlagButton(i, j);
                    }
                    else if (cell.IsBomb && cell.IsOpen)
                    {
                        SetBombButton(i, j);
                    }
                    else if (cell.IsFlag && cell.IsBomb)
                    {
                        SetBombAcceptButton(i, j);
                    }
                    else
                    {
                        SetCloseButton(i, j);
                    }
                }
            }
            int bombs = currentMode.Bombs;
            foreach (var cell in currentCells)
            {
                if (cell.IsFlag && !cell.IsOpen)
                    bombs--;
                    
            }
            bombsLabel.Text = $"{bombs}";   
        }

        private void ButtonToDefault(int i, int j)
        {
            buttons[i, j].Text = "";
            buttons[i, j].ForeColor = GenerateSettings.CloseColor;
            buttons[i, j].BackColor = GenerateSettings.CloseColor;
            buttons[i, j].BackgroundImage = null;
        }

        private void SetCloseButton(int i, int j)
        {
            buttons[i, j].BackColor = GenerateSettings.CloseColor;
            buttons[i, j].BackgroundImage = null;
        }

        private void SetBombAcceptButton(int i, int j)
        {
            buttons[i, j].BackColor = GenerateSettings.BombAcceptColor;
            buttons[i, j].BackgroundImage = GenerateSettings.acceptedImage;

        }

        private void SetBombButton(int i, int j)
        {
            //buttons[i, j].BackColor = GenerateSettings.BombColor;
            buttons[i, j].BackgroundImage = GenerateSettings.bombImage;
        }

        private void SetFlagButton(int i, int j)
        {
            //buttons[i, j].BackColor = GenerateSettings.FlagColor;
            buttons[i, j].BackgroundImage = GenerateSettings.flagImage;
        }

        private void SetOpenButton(int i, int j, ICell cell)
        {
            if (cell.Number > 0)
                buttons[i, j].Text = cell.Number.ToString();
            buttons[i, j].BackColor = GenerateSettings.OpenColor;
            buttons[i, j].ForeColor = GenerateSettings.OpenForeColor;
        }

        public void ShowBombs(ICell[,] currentCells)
        {
            for (var i = 0; i < currentCells.GetLength(0); i++)
            {
                for (var j = 0; j < currentCells.GetLength(1); j++)
                {
                    if (currentCells[i,j].IsBomb)
                    {
                        if (currentCells[i, j].IsFlag)
                        {
                            SetBombAcceptButton(i, j);
                            //buttons[i, j].BackColor = GenerateSettings.BombAcceptColor;
                        }
                        else
                        {
                            SetBombButton(i, j);
                            //buttons[i, j].BackColor = GenerateSettings.BombColor;
                        }

                    }
                }
            }
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimerTickHandler();
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void NewGame()
        {
            gameControl.NewGame();
        }
        private void ClearField()
        {
            ClearKey("Cell");
        }
        private void ClearKey(string key)
        {
            while (Controls.ContainsKey(key))
                Controls.RemoveByKey(key);
        }

        private void таблицаРекордовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameControl.ShowRecordTable();
        }

        private void выбратьУровеньСложностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameControl.ChangeMode();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                NewGame();
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameControl.About();
        }
    }
    public static class GenerateSettings
    {
        public static int BombsLabelLeftMargin = 60;
        public static int BombsPictureLeftMargin = BombsLabelLeftMargin + 20;
        public static int topMargin = 54;
        public static int leftMargin = 5;
        public static int rightMargin = 20;
        public static int bottomMargin = 42;
        public static int deltaWidth = 0;
        public static int deltaHeight = 0;
        public static int ButtonHeight = 20;
        public static int ButtonWidth = 20;
        private static Size buttonSize;
        public static Size ButtonSize
        {
            get
            {
                if (buttonSize.Height == 0 || buttonSize.Width == 0)
                {
                    buttonSize = new Size(ButtonWidth, ButtonHeight);
                }
                return buttonSize;
            }
        }
        public static Color CloseColor = Color.SkyBlue;
        public static Color FlagColor = Color.Orange;
        public static Color BombColor = Color.Red;
        public static Color OpenColor = Color.White;
        public static Color OpenForeColor = Color.Black;
        public static Color BombAcceptColor = Color.Yellow;
        public static Bitmap acceptedImage = new Bitmap("Images//acceptedBomb.bmp");
        public static Bitmap bombImage = new Bitmap("Images//bomb.bmp");
        public static Bitmap flagImage = new Bitmap("Images//flag.bmp");
    }
}
