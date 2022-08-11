using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practik
{
    public partial class Form35 : Form
    {

        db DBC = new db();
        public Form35()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox6.Text = null;

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> cols = new List<string>();
            List<string> values = new List<string>();

            cols.Add("Last_name");
            values.Add(textBox2.Text);

            cols.Add("Name");
            values.Add(textBox3.Text);

            cols.Add("Middle_name");
            values.Add(textBox4.Text);

            cols.Add("Phone_number");
            values.Add(textBox6.Text);


            if (DBC.InsertInto("Client", cols, values))
            {
                MessageBox.Show("Успех");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
