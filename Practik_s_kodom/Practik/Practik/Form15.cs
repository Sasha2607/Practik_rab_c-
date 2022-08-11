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
    public partial class Form15 : Form
    {

        db DBC = new db();
        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        //  SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""" + Environment.CurrentDirectory + @"\Database1.db"";Integrated Security=True;");
        //   SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Aleksandr\Documents\Visual Studio 2012\Projects\Practik\Practik\Database1.mdf"";Integrated Security=True;");
        public Form15()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
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
            if (textBox5.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Ошибка");
                return;
            }

            

                if (DBC.Update("Transport", "Type='" + comboBox1.Text + "', Gos_nomer='" + textBox3.Text + "', carrying_capacity='" + textBox4.Text + "" +
               "',Id_marka='" + data.A2id + "'", "Id = '" + textBox1.Text + "'"))
            {

                MessageBox.Show("Изменено");
                Hide();
                data.E1 = null;
                data.E2 = null;
                data.E3 = null;
                data.E4 = null;
                data.E5 = null;
                data.A2 = null;

            }
        
            else
            {
                MessageBox.Show("Неизвестная ошибка");
            }


 /*   connect.Open();
                string sql = "";
               // sql = "UPDATE Транспорт SET Тип= @Тип, Гос_номер= @Гос_номер,Масса= @Масса,Id_марка = @Id_марка,Id_Наименование = @Id_Наименование where Id_транспорт = @Id_транспорт"; 
                sql = "UPDATE Транспорт SET Тип= @Тип, Гос_номер= @Гос_номер,Грузоподъемность= @Грузоподъемность,Id_марка = @Id_марка where Id_транспорт = @Id_транспорт"; 
                SqlCommand command = new SqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.Text;
                command.CommandText = sql;

                command.Parameters.AddWithValue("@Id_транспорт", textBox1.Text);
                command.Parameters.AddWithValue("@Тип", comboBox1.Text);
                command.Parameters.AddWithValue("@Гос_номер", textBox3.Text);
                command.Parameters.AddWithValue("@Грузоподъемность", textBox4.Text);
                command.Parameters.AddWithValue("@Id_Марка", data.A2id);
              //  command.Parameters.AddWithValue("@Id_Наименование", data.A3id);

                command.ExecuteNonQuery();

           
                MessageBox.Show("Изменено");


                Hide();
                data.E1 = null;
                data.E2 = null;
                data.E3 = null;
                data.E4 = null;
                data.A2 = null;
                */


          
        }

        private void Form15_Load(object sender, EventArgs e)
        {

         
               
            
        }

        private void Form15_Activated(object sender, EventArgs e)
        {
            textBox1.Text = data.E1;
            comboBox1.Text = data.E3;
            textBox3.Text = data.E4;
            textBox4.Text = data.E5;
            textBox5.Text = data.E2;

      //      textBox6.Text = data.A3;
             
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            data.avto = "1";
            Form5 Fo = new Form5();
            Fo.type = "marka";
            Fo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data.avto = "1";
            Form5 Form5 = new Form5();
            Form5.type = "name";
            Form5.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            data.E1 = null;
            data.E2 = null;
            data.E3 = null;
            data.E4 = null;
            data.E5 = null;
            data.A2 = null;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form15_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.E1 = null;
            data.E2 = null;
            data.E3 = null;
            data.E4 = null;
            data.E5 = null;
            data.A2 = null;
        }
    }
}
