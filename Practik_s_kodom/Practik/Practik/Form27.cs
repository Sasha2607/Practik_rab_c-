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
    public partial class Form27 : Form
    {


        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        //   SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");
        //   SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Aleksandr\Documents\Visual Studio 2012\Projects\Practik\Practik\Database1.mdf"";Integrated Security=True;");
        public Form27()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            data.z1 = null;
            data.z2 = null;
            data.z3 = null;
            dateTimePicker1.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data.post = "1";
            Form16 Fo = new Form16();
            Fo.type = "name";
            Fo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (DBC.Update("Receipt_fuel", "Date='" + dateTimePicker1.Text + "', Id_provider='" + data.z2id + "'", "Id = '" + textBox1.Text + "'"))
         
            {
                MessageBox.Show("Изменено");
                Hide();
                data.z1 = null;
                data.z2 = null;
                data.z3 = null;
           

            }
            else
            {
                MessageBox.Show("Неизвестная ошибка");
            }



          

          
        }

        private void Form27_Activated(object sender, EventArgs e)
        {
            textBox1.Text = data.z2;
      dateTimePicker1.Text = data.z3;
            textBox3.Text = data.z1;
            textBox2.Text = data.z3;

            if (textBox1.Text == "")
            {
                pictureBox1.Visible = true;
                dateTimePicker1.Visible = false;
                //textBox2 = (sender as TextBox).Text.Length > 0;
            }

        }

        private void Form27_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Text = null;
            dateTimePicker1.CustomFormat = "  ";



            if (textBox1.Text.Length < 0)
            {
                textBox2.Visible = true;
            }

            {

            }
          

              

        }

      

        private void dateTimePicker1_ValueChanged_2(object sender, EventArgs e)
        {
    
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            //  dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //  dateTimePicker1.CustomFormat = "dd MMMM yyyy г.";



            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                pictureBox1.Visible = false;
                dateTimePicker1.Visible = true;
            }
       
       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form27_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.z1 = null;
            data.z2 = null;
            data.z3 = null;
        }
    }
}
