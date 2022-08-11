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
    public partial class Form18 : Form
    {

        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        //  SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Aleksandr\Documents\Visual Studio 2012\Projects\Practik\Practik\Database1.mdf"";Integrated Security=True");
        public Form18()
        {
            InitializeComponent();
        }



        private void Form18_Load(object sender, EventArgs e)
        {
       

            textBox1.Text = data.B1;
          textBox2.Text = data.B2;
            textBox3.Text = data.B3;
           textBox4.Text = data.B4;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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

            if (DBC.Update("Provider", "Name='" + textBox2.Text + "', Address='" + textBox3.Text + "', Phone_number='" + textBox4.Text + "" +
               "'", "Id = '" + textBox1.Text + "'"))
            {
                MessageBox.Show("Изменено");
                Hide();
                data.B1 = null;
                data.B2 = null;
                data.B3 = null;
                data.B4 = null;
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;

            }
            else
            {
                MessageBox.Show("Неизвестная ошибка");
            }

         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            data.B1 = null;
            data.B2 = null;
            data.B3 = null;
            data.B4 = null;
        }

        private void Form18_Activated(object sender, EventArgs e)
        {
         
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form18_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.B1 = null;
            data.B2 = null;
            data.B3 = null;
            data.B4 = null;
        }
    }
}


