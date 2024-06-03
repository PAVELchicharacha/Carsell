using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carsell
{
    public partial class Cars2 : Form
    {
        public Cars2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void carBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carSellDataSet);

        }

        private void Cars2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carSellDataSet.Car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.carSellDataSet.Car);
            button1.Enabled = false;

        }

        private void carBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//sort
        {
            DataGridViewColumn column = null;
            switch (listbox1.SelectedIndex)
            {
                case 0:
                    column = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    column = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    column = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    column = dataGridViewTextBoxColumn5;
                    break;
                case 4:
                    column = dataGridViewTextBoxColumn6;
                    break;

                    if (radioButton2.Checked)
                        carDataGridView.Sort(column, System.ComponentModel.ListSortDirection.Ascending);
                    else
                        carDataGridView.Sort(column, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carBindingSource.Filter = "model='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < carDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < carDataGridView.RowCount - 1; j++)
                {
                    carDataGridView[i, j].Style.BackColor = Color.White;
                    carDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < carDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < carDataGridView.RowCount - 1; j++)
                {
                    if (carDataGridView[i, j].Value.ToString().Contains(textBox1.Text))
                    {
                        carDataGridView[i, j].Style.BackColor = Color.Blue;
                        carDataGridView[i, j].Style.ForeColor = Color.White;
                    }
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
