using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Saper.Entity;

namespace Saper.Boundary
{
    public partial class ChooseModeForm : Form
    {
        public int Width
        {
            get;set;
        }

        public int Height
        {
            get; private set;
        }

        public int Bombs
        {
            get; private set;
        }

        public ChooseModeForm(Mode mode)
        {
            InitializeComponent();
            if (mode == Mode.Easy)
            {
                radioButtonEasy.Checked = true;
            }
            else if (mode == Mode.Medium)
            {
                radioButtonMedium.Checked = true;
            }
            else if (mode == Mode.Professional)
            {
                radioButtonProfessional.Checked = true;
            }
            else
            {
                radioButtonSpecial.Checked = true;
            }

            numWidth.Value = mode.Width;
            Width = mode.Width;
            Height = mode.Height;
            Bombs = mode.Bombs;
            numHeight.Value = mode.Height;
            numBombs.Value = mode.Bombs;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numHeight.Value < 9)
            {
                MessageBox.Show("Слишком маленькое поле", "Высота должна быть не меньше 9");
                numHeight.Value = 9;
            }
            else if (numHeight.Value > 30)
            {
                MessageBox.Show("Слишком большое поле", "Высота должна быть не больше 30");
                numHeight.Value = 30;
            }
            Height = (int)numHeight.Value;
            radioButtonSpecial.Checked = true;

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numWidth.Value < 9)
            {
                MessageBox.Show("Слишком маленькое поле", "Ширина должна быть не меньше 9");
                numWidth.Value = 9;
            }
            else if (numWidth.Value > 30)
            {
                MessageBox.Show("Слишком большое поле", "Ширина должна быть не больше 30");
                numWidth.Value = 30;
            }
            
            Width = (int)numWidth.Value;
            radioButtonSpecial.Checked = true;

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numWidth.Value < 1)
            {
                MessageBox.Show("Слишком легко", "Мины должны присутствовать");
                numBombs.Value = (Height * Width) / 10;
            }
            else if (numBombs.Value >= Height * Width - 8)
            {
                MessageBox.Show("Слишком много мин", String.Format("Количество мин должно быть меньше {0}", Height * Width-8));
                numBombs.Value = (Height * Width - 9 > 0) ? Height * Width - 9 : 1;
            }
            Bombs = (int)numBombs.Value;
            radioButtonSpecial.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonEasy.Checked)
            {
                CurrentMode = Mode.Easy;
            }
            else if (radioButtonMedium.Checked) 
            {
                CurrentMode = Mode.Medium;
            }
            else if (radioButtonProfessional.Checked)
            {
                CurrentMode = Mode.Professional;
            } 
            try { 
                if (Check())
                    Close();
            } catch (ModeException ex)
            {
                MessageBox.Show(ex.Header, ex.Message);
            }
        }
        private bool Check()
        {
            return true;
        }
        private Mode CurrentMode
        {
            get
            {
                return new Mode((int)numHeight.Value, (int)numWidth.Value, (int)numBombs.Value);
            }
            set
            {
                numWidth.Value = Width = value.Width;
                numHeight.Value = Height = value.Height;
                numBombs.Value = Bombs = value.Bombs;                
            }
        }
    }
    class ModeException : Exception
    {
        public string Header { get; set; }
        public ModeException(string header, string message)
            :base(message)
        {
            Header = header;
        }
    }
}