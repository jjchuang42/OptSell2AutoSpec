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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataGridViewRow[] rows = new DataGridViewRow[20];

            for (int i = 0; i < rows.Count(); i++)
            {
                DataGridViewButtonCell but = new DataGridViewButtonCell();
                but.Value = 10200 - i * 50;
                int deal = 0 + i * 50;
                int call_price = 660 - i * 32;
                int put_price = 3 + i * 34;
                rows[i] = new DataGridViewRow();
                rows[i].CreateCells(this.ezDataGridView1, deal, call_price, but.Value, put_price, deal);
            }

            this.ezDataGridView1.Rows.AddRange(rows);
        }
    }
}
