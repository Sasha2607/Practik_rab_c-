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
    public partial class Form29 : Form
    {

        db DBC = new db();

        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        //    SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");
        //   SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Aleksandr\Documents\Visual Studio 2012\Projects\Practik\Practik\Database1.mdf"";Integrated Security=True;");
        public Form29()
        {
            InitializeComponent();
        }

        private void Form29_Load(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            data.z11 = null;
            data.z12 = null;
            data.R5 = null;
            data.R6 = null;

            data.R4 = null;
            data.z13id = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show(data.z13id);
         //   MessageBox.Show(data.R4);
        //    MessageBox.Show(textBox3.Text);
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

            List<string> cols = new List<string>();
            List<string> values = new List<string>();

            cols.Add("Id_coming");
            values.Add(data.z13id);

            cols.Add("Id_fuel");
            values.Add(data.R4);

            cols.Add("Amount");
            values.Add(textBox4.Text);

            cols.Add("Price");
            values.Add(textBox3.Text);

            cols.Add("Id_provider");
            values.Add(data.z35);


            if (DBC.InsertInto("Waybill", cols, values))
            {
                MessageBox.Show("Добавлено");

                this.Hide();
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
                MessageBox.Show("Ошибка");
            }


            /*
                  //  string t1 = textBox1.Text;
                   string t2 = textBox2.Text;
                    string t4 = textBox4.Text;
                string t3 = textBox3.Text;

                ////     if (t1 == "") t1 = null;
                //    if (t2 == "") t2 = null;
               // if (t3 == "") t3 = null;

                string sql = "";
                connect.Open();
                //  sql = "INSERT INTO Транспорт (Тип,Гос_номер,Масса,Id_Марка,Id_Наименование) VALUES (@Тип,@Гос_номер,@Масса,@Id_Марка,@Id_Наименование)";
                sql = "INSERT INTO Накладная (Id_Приход,Id_Наименование,Количество,Цена) VALUES (@Id_Приход,@Id_Наименование,@Количество,@Цена)";
                SqlCommand command = new SqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.Text;
                command.CommandText = sql;


                command.Parameters.AddWithValue("@Id_Приход", data.z13id);
                command.Parameters.AddWithValue("@Id_Наименование", data.R4);
                command.Parameters.AddWithValue("@Количество", t3);
                command.Parameters.AddWithValue("Цена", t4);
                //    command.Parameters.AddWithValue("@Id_Наименование", data.A3id);

                command.ExecuteNonQuery();

                MessageBox.Show("Добавлено");


              

                this.Hide();
                data.z11 = null;
                data.z12 = null;
                data.R5 = null;
                data.R6 = null;
                data.z13id = null;
                data.R4 = null;
                */



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form29_Activated(object sender, EventArgs e)
        {
            textBox1.Text = data.z11 + "    " + data.z12;
           textBox2.Text = data.R5 + "    " ;
     
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
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            data.z11 = null;
            data.z12 = null;
            data.R5 = null;
            data.R6 = null;
            data.z35 = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            data.toplivo = "1";
            Form22 Fo = new Form22();
            Fo.type = "toplivo";
            Fo.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form29_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            data.z11 = null;
            data.z12 = null;
            data.R5 = null;
            data.R6 = null;
            data.z35 = null;
        }
    }
}
