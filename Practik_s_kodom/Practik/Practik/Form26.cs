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
    public partial class Form26 : Form
    {
        db DBC = new db();

        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        //  SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");
        // SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Aleksandr\Documents\Visual Studio 2012\Projects\Practik\Practik\Database1.mdf"";Integrated Security=True;");
        public Form26()
        {
            InitializeComponent();
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            //textBox1.Text = null;
            dateTimePicker1.Text = null;
            textBox2.Text = null;

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if (textBox1.Text == "")
            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            List<string> cols = new List<string>();
            List<string> values = new List<string>();



            cols.Add("Date");
            // values.Add(dateTimePicker1.Text);
            values.Add(DBC.DateFormat(dateTimePicker1.Text));

            cols.Add("Id_provider");
            values.Add(data.z2id);





            if (DBC.InsertInto("Receipt_fuel", cols, values))
            {
                MessageBox.Show("Успех");
                this.Hide();
                data.z1 = null;
            }
            else
            {
                MessageBox.Show("Ошибка");
            }



        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data.post = "1";
            Form16 Fo = new Form16();
            Fo.type = "name";
            Fo.ShowDialog();

        }

        private void Form26_Activated(object sender, EventArgs e)
        {
            textBox2.Text = data.z1;
        }

        private void Form26_Load(object sender, EventArgs e)
        {
            data.z1 = null;
            textBox2.Text = null;
           dateTimePicker1.CustomFormat = "  ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // dateTimePicker1.Format = DateTimePickerFormat.Custom;
            // dateTimePicker1.CustomFormat = "dd MMMM yyyy г.";
            //     ActiveControl = null;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
     
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void Form26_FormClosed(object sender, FormClosedEventArgs e)
        {
            dateTimePicker1.Text = null;
            textBox2.Text = null;
        }
    }
}
