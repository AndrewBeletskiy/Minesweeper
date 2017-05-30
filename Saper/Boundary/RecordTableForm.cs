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
using Saper.Control;

namespace Saper.Boundary
{
    public partial class RecordTableForm : Form
    {
        RecordTable RecordTable;
        GameControl GameControl;
        public RecordTableForm(RecordTable table, GameControl gameControl)
        {
            InitializeComponent();
            RecordTable = table;
            GameControl = gameControl;
        }

        private void RecordTableForm_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }
        private void UpdateLabels()
        {
            labelEasy.Text = RecordTable.Records[0].ToString();
            labelMedium.Text = RecordTable.Records[1].ToString();
            labelProfessional.Text = RecordTable.Records[2].ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GameControl.ClearRecordTable();
            UpdateLabels();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
