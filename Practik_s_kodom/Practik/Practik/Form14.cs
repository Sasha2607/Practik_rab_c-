using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Practik
{
    public partial class Form14 : Form
    {

        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        // SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");
        //  SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Aleksandr\Documents\Visual Studio 2012\Projects\Practik\Practik\Database1.mdf"";Integrated Security=True;");
        public Form14()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       


                
                string t1 = comboBox1.Text;
                string t2 = textBox3.Text;
                string t3 = textBox4.Text;
                   string t4 = textBox5.Text;

                if (t1 == "") t1 = null;
                if (t2 == "") t2 = null;
                if (t3 == "") t3 = null;
                if (t4 == "") t4 = null;


            List<string> cols = new List<string>();
            List<string> values = new List<string>();

            cols.Add("Type");
            values.Add(comboBox1.Text);


            cols.Add("Gos_nomer");
            values.Add(textBox3.Text);

            cols.Add("carrying_capacity");
            values.Add(textBox4.Text);


            cols.Add("Id_marka");
            values.Add(data.A2id);

            if (DBC.InsertInto("Transport", cols, values))
            {
                MessageBox.Show("Успех");
                this.Hide();
            }

            else
            {
              //  Exception ;
                 //   MessageBox.Show(dsa.ToString());
                    MessageBox.Show("Ошибка");
            }




         
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            data.avto = "1";
            Form5 Fo = new Form5();
            Fo.type = "marka";
            Fo.ShowDialog();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            comboBox1.Text = null;
            textBox5.Text = null;
          //  textBox6.Text = null;
        //    data.A3 = null;
            data.A2 = null;
            data.A2id = null;
        }

        private void Form14_Activated(object sender, EventArgs e)
        {
            textBox5.Text = data.A2;
        //    textBox6.Text = data.A3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data.avto = "1";
            Form5 Form5 = new Form5();
            Form5.type = "name";
            Form5.ShowDialog();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            comboBox1.Text = null;

        }

        private void Form14_FormClosed(object sender, FormClosedEventArgs e)
        {
            comboBox1.Text = null;
        }
    }
}
