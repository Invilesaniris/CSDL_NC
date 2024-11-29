using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("id", "ma id");
            dataGridView1.Columns.Add("name", "name");
            for (int i=0; i<5; ++i)
            {
                dataGridView1.Rows.Add(i, "d"+i);
            }

            dataGridView1.Rows[0].Cells[0].Value = 12121;

        }
    }
}
