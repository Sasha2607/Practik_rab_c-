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
    public partial class Form23 : Form
    {
        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        
        public Form23()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> cols = new List<string>();
            List<string> values = new List<string>();

            cols.Add("Name");
            values.Add(textBox1.Text);

            if(DBC.InsertInto("Fuel", cols, values))
            {
                MessageBox.Show("Успех");

                this.Hide();
                textBox1.Text = null;
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            textBox1.Text = null;
        }

        private void Form23_Load(object sender, EventArgs e)
        {

        }

        private void Form23_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBox1.Text = null;
        }
    }
}
