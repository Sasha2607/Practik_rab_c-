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
    public partial class Form36 : Form
    {

        db DBC = new db();


        public Form36()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            data.clientID = null;
            data.client1 = null;
            data.client2 = null;
            data.client3 = null;
            data.client4 = null;

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }

                if (textBox2.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (DBC.Update("Client", "Last_name='" + textBox2.Text + "', Name='" + textBox3.Text + "',Middle_name='" + textBox4.Text + "', Phone_number='" + textBox6.Text + "'", "Id = '" + textBox1.Text + "'"))

            {
                MessageBox.Show("Изменено");
                Hide();
                data.clientID = null;
                data.client1 = null;
                data.client2 = null;
                data.client3 = null;
                data.client4 = null;


            }
            else
            {
                MessageBox.Show("Неизвестная ошибка");
            }

        }

        private void Form36_Activated(object sender, EventArgs e)
        {
            textBox1.Text = data.clientID;
            textBox2.Text = data.client1;
            textBox3.Text = data.client2;
            textBox4.Text = data.client3;
            textBox6.Text = data.client4;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
