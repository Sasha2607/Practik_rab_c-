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
    public partial class Form16 : Form
    {
        db DBC = new db();


        SqlConnection connect = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SQLEXPRESS;Initial Catalog=Practik;Integrated Security=True");
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Практика\Practik\Practik\Database1.mdf;Integrated Security=True");
        //  SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Aleksandr\Documents\Visual Studio 2012\Projects\Practik\Practik\Database1.mdf"";Integrated Security=True");
        public Form16()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       

        private void Form16_Activated(object sender, EventArgs e)
        {
            table2();
        }

        void table2()
        {
       
            dataGridView1.DataSource = DBC.Select("SELECT Id,Name AS Наименование,Address AS Адрес,Phone_number AS 'Номер телефона' FROM Provider").DefaultView;

         //  dataGridView1.DataSource = DBC.Select("SELECT Id,  Last_name AS Фамилия,Name AS Имя,Middle_name AS Отчество,Age AS Возраст,Phone_number AS номер_телефона FROM Drivers").DefaultView;
              dataGridView1.Columns[0].Visible = false;
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            if (data.box == "Пользователь")
            {
                button6.Visible = false;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Hide();
            form17.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string type = "";

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
          
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Выберите строку");
            }
            else
            {

                DialogResult result = MessageBox.Show("Вы действительно хотите удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (DBC.Delete("Provider", "Id='" + textBox1.Text + "'")) MessageBox.Show("Удалено");
                    else MessageBox.Show("Произошла ошибка. Возможно, вы пытаетесь удалить запись, которая используется в другой таблице. Действие прервано.");

                }

                if (result == DialogResult.No)
                {

                }

            }


            textBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
  

                string t1 = textBox2.Text;
               // string sql = "";


                dataGridView1.DataSource = DBC.Select("SELECT Id,Name AS Наименование,Address AS Адрес,Phone_number AS 'Номер телефона' FROM Provider where Name like '%" + t1 + "%'").DefaultView;
            dataGridView1.Columns[0].Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            form18.Hide();
            form18.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
       
            
                string t1 = textBox3.Text;
              //  string sql = "";


                dataGridView1.DataSource = DBC.Select("SELECT Id,Name AS Наименование,Address AS Адрес,Phone_number AS 'Номер телефона' FROM Provider where Address like '%" + t1 + "%'").DefaultView;
                dataGridView1.Columns[0].Visible = false;
            }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
       

                string t1 = textBox4.Text;
                //string sql = "";


                dataGridView1.DataSource = DBC.Select("SELECT Id,Name AS Наименование,Address AS Адрес,Phone_number AS 'Номер телефона' FROM Provider where Phone_number like '%" + t1 + "%'").DefaultView;
                dataGridView1.Columns[0].Visible = false;
            }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (type)
            {
                case "name":
                    data.z1 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    data.z2id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    break;

                case "Postavka1":
                    data.Postavka1id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    data.Postavka1name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
            }

            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            data.B1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            data.B2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            data.B3 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            data.B4 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (data.post == "1")
            {
                this.Close();
                data.post = "";
            }

            if (data.Postavka1 == "1")
            {
                this.Close();
                data.Postavka1 = "";
            }
        }

    }
}
