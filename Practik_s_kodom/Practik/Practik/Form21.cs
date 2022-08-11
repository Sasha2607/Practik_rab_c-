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
    public partial class Form21 : Form
    {
        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        //  SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Aleksandr\Documents\Visual Studio 2012\Projects\Practik\Practik\Database1.mdf"";Integrated Security=True");
        public Form21()
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

            if (DBC.Update("City", "Name = '" + textBox2.Text + "'", "Id = '" + textBox1.Text + "'" ))
             
            {
                MessageBox.Show("Изменено");
                Hide();
                data.C1 = null;
                data.C2 = null;
            }
            else
            {
                MessageBox.Show("Неизвестная ошибка");
            }

    
          
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            textBox1.Text = data.C1;
            textBox2.Text = data.C2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            data.C1 = null;
            data.C2 = null;
        }

        private void Form21_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.C1 = null;
            data.C2 = null;
        }
    }
}
