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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void carBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carSellDataSet);

        }

        private void Cars_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carSellDataSet.Car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.carSellDataSet.Car);

        }

        private void availableCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            carBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            carBindingSource.MoveLast();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            carBindingSource.MoveNext();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            carBindingSource.RemoveCurrent();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.carBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.carSellDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cars2 car = new Cars2();
            car.ShowDialog();
        }
    }
}
