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
    public partial class Form10 : Form
    {
        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");

        // SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        // SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");
        // SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Aleksandr\Documents\Visual Studio 2012\Projects\Practik\Practik\Database1.mdf"";Integrated Security=True");
        // SqlConnection connect = new SqlConnection("Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=""" + Environment.CurrentDirectory" + @"\Database1.mdf"";Integrated Security = True");

        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t2 = textBox2.Text;

            if (t2 == "") t2 = null;
            int z = 0;



            for (int i = 0; i < t2.Length; i++)
            {
                if (t2[i] == '-')
                {
                    z++;
                }
            }
            if (z == 1)
            {



                List<string> cols = new List<string>();
                List<string> values = new List<string>();

                cols.Add("Make_Model");
                values.Add(textBox2.Text);

                if (DBC.InsertInto("Make", cols, values))
                {
                    MessageBox.Show("Успех");
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Ошибка");
                }
            }

            else
            {
                MessageBox.Show("Введите Модель");
            }
              

            
        





           /* try

            {
            
                     string t2= textBox2.Text;
           
                     if (t2 == "") t2 = null;
                       int z = 0;



                       for (int i = 0; i < t2.Length; i++)
                       {
                           if (t2[i] == '-')
                           {
                               z++;
                           }
                       }
                       if (z == 1)
                       {
                           connect.Open();
                           string sql = "";
                           sql = "INSERT INTO Марки  (Марка_Модель) VALUES (@Марка_Модель)";
                           SqlCommand command = new SqlCommand();
                           command.Connection = connect;
                           command.CommandType = CommandType.Text;
                           command.CommandText = sql;
                           command.Parameters.AddWithValue("@Марка_Модель", t2);
                           command.ExecuteNonQuery();
                           MessageBox.Show("Добавлено");
                           Hide();
                       }
                       else
                       {
                           if (z== 0)
                           MessageBox.Show("Введите Модель");
                           else MessageBox.Show("Ошибка");
                       }
                       


            }
            catch         (SqlException dsa)
            {

               // MessageBox.Show("Ошибка");
                MessageBox.Show(dsa.ToString());
            }
            finally
            {

                connect.Close();
            }*/

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = null;
            this.Hide();
        }

        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBox2.Text = null;
        }
    }
}
