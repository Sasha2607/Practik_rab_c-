using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Practik
{
    public partial class Form24 : Form
    {
        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
      
        public Form24()
        {
            InitializeComponent();
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

            if (DBC.Update("Fuel", "Name='" + textBox2.Text + "'", "Id = '" + textBox1.Text + "'"))
            {
                MessageBox.Show("Изменено");

                data.R1 = null;
                data.R2 = null;
                data.R3 = null;

                Hide();

            }
            else
            {
                MessageBox.Show("Неизвестная ошибка");
            }

          
        }

        private void Form24_Load(object sender, EventArgs e)
        {
            textBox1.Text = data.R1;
            textBox2.Text = data.R2;
          //  textBox3.Text = data.R3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            data.R1 = null;
            data.R2 = null;
        //    data.R3 = null;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form24_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.R1 = null;
            data.R2 = null;
        }
    }
}
