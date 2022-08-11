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
    public partial class Form7 : Form
    {
        db DBC = new db();

        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");

        public int c;
        public Form7()
        {
            InitializeComponent();
     
        }
        
        public Form7(Form6 form)
        {
            InitializeComponent();

        }
           

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     //       MessageBox.Show(dateTimePicker1.Text);
        //    return;

            List<string> cols = new List<string>();
            List<string> values = new List<string>();

            cols.Add("Last_name");
            values.Add(textBox2.Text);

            cols.Add("Name");
            values.Add(textBox3.Text);

            cols.Add("Middle_name");
            values.Add(textBox4.Text);

            cols.Add("Age");
            //   values.Add(textBox5.Text);
            values.Add(DBC.DateFormat(dateTimePicker1.Text));

            cols.Add("Phone_number");
            values.Add(textBox6.Text);


            if (DBC.InsertInto("Drivers", cols, values))
            {
                MessageBox.Show("Успех");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }


          
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
          
        }

        private void Form7_Load(object sender, EventArgs e)
        {

            dateTimePicker1.CustomFormat = "  ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
           // textBox5.Text = null;
            textBox6.Text = null;
            dateTimePicker1.Text = null;


            this.Close();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
    }
}
