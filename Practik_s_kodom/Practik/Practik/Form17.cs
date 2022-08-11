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
    public partial class Form17 : Form
    {


        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        // SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");
        //  SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Aleksandr\Documents\Visual Studio 2012\Projects\Practik\Practik\Database1.mdf"";Integrated Security=True");
        public Form17()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            List<string> cols = new List<string>();
            List<string> values = new List<string>();

      

            cols.Add("Name");
            values.Add(textBox1.Text);

            cols.Add("Address");
            values.Add(textBox2.Text);

            cols.Add("Phone_number");
             values.Add(textBox3.Text);
          


            if (DBC.InsertInto("Provider", cols, values))
            {
                MessageBox.Show("Успех");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }

              



          
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }

        private void Form17_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
    }
}
