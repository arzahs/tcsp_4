using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tspp_lab4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
          
                //-цикл по комірках рядка таблиці-
                for (int i = 0; i < DataGridView1.Rows.Count; i++)
                {
                    //-перевірка заповнення комірки значенням-
                    if (DataGridView1.Rows[i].Cells[4].Value != DBNull.Value)
                       
                        sum += Convert.ToDouble(DataGridView1.Rows[i].Cells[4].Value);
                }
            
            label2.Text = sum.ToString();
        }
    }
}
