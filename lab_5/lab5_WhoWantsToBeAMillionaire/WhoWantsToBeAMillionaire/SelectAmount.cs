using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaire
{
    public partial class SelectAmount : Form
    {
        public int SelectedItem { get; set; }
        public SelectAmount()
        {
            InitializeComponent();
            InitializeListBox();
        }
        private void InitializeListBox()
        {
            listBox.Items.Add("3 000 000");
            listBox.Items.Add("1 500 000");
            listBox.Items.Add("800 000");
            listBox.Items.Add("400 000");
            listBox.Items.Add("200 000");
            listBox.Items.Add("100 000");
            listBox.Items.Add("50 000");
            listBox.Items.Add("25 000");
            listBox.Items.Add("15 000");
            listBox.Items.Add("10 000");
            listBox.Items.Add("5 000");
            listBox.Items.Add("3 000");
            listBox.Items.Add("2 000");
            listBox.Items.Add("1 000");
            listBox.Items.Add("500");
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                SelectedItem = listBox.SelectedIndex;
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите несгораемую сумму: ", "Выбор элемента");
            }
        }
    }



}
