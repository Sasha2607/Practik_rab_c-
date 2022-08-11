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
    public partial class Form30 : Form
    {

        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        //   SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");
        //   SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Aleksandr\Documents\Visual Studio 2012\Projects\Practik\Practik\Database1.mdf"";Integrated Security=True;");
        public Form30()
        {
            InitializeComponent();
        }

        private void Form30_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            data.prixod = "1";
            Form25 Fo = new Form25();
            Fo.type = "prixod";
            Fo.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            data.toplivo = "1";
            Form22 Fo = new Form22();
            Fo.type = "toplivo";
            Fo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            data.z14 = null;
            data.z15 = null;

            data.z11 = null;
            data.z12 = null;

            data.R5 = null;
            data.R6 = null;

            data.z13id = null;
            data.R4 = null;

            data.z35 = null;
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

            if (textBox5.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }


            if (DBC.Update("Waybill", "Id_coming='" + data.z13id + "', Id_fuel='" + data.R4 + "', Id_provider='" + data.z35 + "', Amount = '" + textBox5.Text + "', Price = '" + textBox3.Text + "'", "Id = '" + textBox4.Text + "'"))
              
            {
                MessageBox.Show("Изменено");
                Hide();
                data.z14 = null;
                data.z15 = null;

                data.z11 = null;
                data.z12 = null;

                data.R5 = null;
                data.R6 = null;

                data.z13id = null;
                data.R4 = null;

                data.z35 = null;


            }
            else
            {
                MessageBox.Show("Неизвестная ошибка");
            }

        
        }

        private void Form30_Activated(object sender, EventArgs e)
        {
            textBox1.Text = data.z11 + "    " + data.z12;
            textBox2.Text = data.R5  ;
            textBox3.Text = data.z14;
            textBox4.Text = data.z15;
            textBox5.Text = data.R6;


        }

        private void Form30_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.z14 = null;
            data.z15 = null;

            data.z11 = null;
            data.z12 = null;

            data.R5 = null;
            data.R6 = null;

            data.z13id = null;
            data.R4 = null;

            data.z35 = null;
        }
    }
}
