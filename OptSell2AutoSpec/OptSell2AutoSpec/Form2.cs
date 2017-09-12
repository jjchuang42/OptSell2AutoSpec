using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            DataGridViewRow[] rows = new DataGridViewRow[5];

            for (int i = 0; i < rows.Count(); i++)
            {
                DataGridViewButtonCell but = new DataGridViewButtonCell();
                but.Value = "取消";
                int comm = 9900 + i * 50;
                int callPos = 1 + i;
                int putPos = 1 + i;
                int callDeal = 50 + i * 10;
                int putDeal = 100 - i * 10;
                int priThru = 3;
                int stopLossBase = 10;
                int stopLossTurn = 3;
                int stopLossOut = 9;

                rows[i] = new DataGridViewRow();
                rows[i].CreateCells(this.ezDataGridView1, comm, callPos, putPos, callDeal, putDeal, 
                    stopLossBase, stopLossTurn, stopLossOut, priThru, but.Value);
            }

            this.ezDataGridView1.Rows.AddRange(rows);
        }
    }
}
