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

    public partial class Form20 : Form
    {
        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        // SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        //  SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");

        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                List<string> cols = new List<string>();
                List<string> values = new List<string>();

                cols.Add("Name");
                values.Add(textBox2.Text);

                if (DBC.InsertInto("City", cols, values))
                {
                    MessageBox.Show("Успех");
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Ошибка");
                }
            }



            /*  string t2 = textBox2.Text;


              if (t2 == "") t2 = null;
              ;
              string sql = "";
              connect.Open();
              sql = "INSERT INTO Город (Наименование) VALUES (@Наименование)";
              SqlCommand command = new SqlCommand();
              command.Connection = connect;
              command.CommandType = CommandType.Text;
              command.CommandText = sql;


              command.Parameters.AddWithValue("@Наименование", t2);
              command.ExecuteNonQuery();

              MessageBox.Show("Добавлено");


              //   Form6 form6 = new Form6();
              //   form6.Hide();
              //   form6.Show();

              this.Hide();
          }
          catch 
          {
              //MessageBox.Show("Заполните все поля");
              MessageBox.Show("Ошибка");
          }
          finally
          {

              connect.Close();
          }

          Select();
          */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            textBox2.Text = null;
        }

        private void Form20_Load(object sender, EventArgs e)
        {

        }

        private void Form20_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBox2.Text = null;
        }
    }
}
