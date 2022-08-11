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
    public partial class Form9 : Form
    {
        db DBC = new db();

       // SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        //  SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");
        //  SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Aleksandr\Documents\Visual Studio 2012\Projects\Practik\Practik\Database1.mdf"";Integrated Security=True");
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }

            if( DBC.Update("Drivers", "Last_name='"+textBox2.Text+ "', Name='" + textBox3.Text + "', Middle_name='" + textBox4.Text + "" +
                "',Age='" + DBC.DateFormat(dateTimePicker1.Text) + "',Phone_number='" + textBox6.Text + "'", "Id = '"+textBox1.Text+"'"))
            {
                MessageBox.Show("Изменено");
                Hide();

                data.D1 = null;
                data.D2 = null;
                data.D3 = null;
                data.D4 = null;
                data.D5 = null;
                data.D6 = null;
            
            }
            else
            {
                MessageBox.Show("Неизвестная ошибка");
            }

          
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            textBox1.Text = data.D1;
            textBox2.Text = data.D2;
            textBox3.Text = data.D3;
            textBox4.Text = data.D4;
            if (textBox1.Text == "")
            {
                dateTimePicker1.Text = data.D5;

            }
            else
            {
                dateTimePicker1.Text = DBC.Select("Select Age FROM Drivers where Id = '" + textBox1.Text + "'").Rows[0].ItemArray[0].ToString();
            }
            textBox6.Text = data.D6;   

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                pictureBox1.Visible = false;
                dateTimePicker1.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = null;
            data.D1 = null;
            data.D2 = null;
            data.D3 = null;
            data.D4 = null;
            data.D5 = null;
            data.D6 = null;
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            dateTimePicker1.Text = null;
            data.D1 = null;
            data.D2 = null;
            data.D3 = null;
            data.D4 = null;
            data.D5 = null;
            data.D6 = null;
        }
    }

}
   

     

