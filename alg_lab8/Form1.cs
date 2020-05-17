using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alg_lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int[,] Random_matrix(DataGridView dataGrid)
        {
            Random rnd = new Random();
            int mtrxSize = rnd.Next(2, 5);
            dataGrid.RowCount = mtrxSize;
            dataGrid.ColumnCount = mtrxSize;
            int[,] matrix = new int[mtrxSize, mtrxSize];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(50);
                    dataGrid.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            return matrix;
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 1)
            {
                int[,] matrix = Random_matrix(dataGridView1);
                bool brk = false;
                int flag = 0;
                int col = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (brk == true) { break; }
                    if (flag < matrix.GetLength(1)) { flag = 0; }
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if ((matrix[j, i] % 2) == 0)
                        {
                            if (flag < matrix.GetLength(1))
                            {
                                flag += 1;
                            }
                            if (flag == matrix.GetLength(1))
                            {
                                col = i + 1;
                                brk = true;
                                break;
                            }
                        }
                        else
                        {
                            flag = 0;
                        }
                    }
                }
                if (flag == matrix.GetLength(1))
                {
                    col_exists.Visible = true;
                    column.Visible = true;
                    col_exists.Text = "column exists";
                    column.Text = col.ToString() + " " + "column";
                }
                else
                {
                    col_exists.Text = "column doesn't exist";
                    column.Text = "";
                }
            }
            else
            {
                dataGridView1.Rows.Clear();
                column.Visible = false;
                col_exists.Text = "matrix has been cleared,\n press again ";
            }
        }
    }
}
